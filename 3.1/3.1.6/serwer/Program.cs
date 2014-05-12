using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Xml.Serialization;

namespace serwer
{
    class Program
    {
        static void Main(string[] args)
        {
            // test polega na uruchomieniu poza visual stdio z bin/debug/serwer.exe (skompilownej oczywiscie) i odpali sie serwer
            // ktory bedzie czekal na klienta ktory przesle obiekt, w miedzy czasie odpalamy 3.1.5/bin/debug/3.1.5.exe  i serwer powienien wyswietlic obiekt
            // ktory wysle klient
            TcpListener server = new TcpListener(IPAddress.Parse("127.0.0.1"), 1024);
            TcpClient internalClient = new TcpClient();

            server.Start();
            internalClient = server.AcceptTcpClient();

            StreamReader reader = new StreamReader(internalClient.GetStream());

            XmlSerializer serializer = new XmlSerializer(typeof(Samochod));
            Samochod samochod = (Samochod)serializer.Deserialize(reader);
            StreamWriter writer = new StreamWriter("obiekt.xml");
            serializer.Serialize(writer, samochod);


            Console.WriteLine(samochod.ToString());

            Console.WriteLine("Lipton");
            Console.ReadKey();

        }
    }
}
