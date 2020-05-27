using System;
using System.IO;
using System.Collections.Generic;

namespace Yuliya
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Исходный порядок:");
            StreamReader line = new StreamReader("C:\\Yuliya\\Lab_7_4_text.txt");
            Stack<int> stack = new Stack<int>();
            while (!line.EndOfStream)
            {
                int number = Convert.ToInt32(line.ReadLine());
                stack.Push(number);
                Console.Write(number+" ");
            }
            StreamWriter write = new StreamWriter("C:\\Yuliya\\Lab_7_4_write.txt", false);
            Console.WriteLine("\nОбратный порядок:");
            foreach( var i in stack)
            {
                write.WriteLine(i);
                Console.Write(i+" ");
            }
            write.Close();
        }
    }
}