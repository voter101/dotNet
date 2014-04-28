using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BinaryTreeNode<int> drzewo = new BinaryTreeNode<int>(15);
            drzewo.insert(9);
            drzewo.insert(20);
            drzewo.insert(4);
            drzewo.insert(12);
            drzewo.insert(17);
            drzewo.insert(24);
            drzewo.insert(1);
            drzewo.insert(5);

            foreach (int nazwa in drzewo)
            {
                Console.WriteLine(nazwa);
            }
                

            Console.ReadKey();
        }
        

    }
}
