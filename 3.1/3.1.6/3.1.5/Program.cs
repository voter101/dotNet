using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Xml.Serialization;
namespace _3._1._5
{
    class Program
    {
        static void Main(string[] args){



            Samochod ford = new Samochod();
            ford.pojemnoscSilnika = 1800;
            ford.marka = "ford";
            ford.rejestracja = "kahirWPZ";

            TcpClient client = new TcpClient("127.0.0.1", 1024);




            StreamWriter wr = new StreamWriter(client.GetStream());
            XmlSerializer serializer = new XmlSerializer(typeof(Samochod));
            serializer.Serialize(wr, ford);
            wr.Flush();
            wr.Close();
            client.Close();
            

            
        }
    }
}
