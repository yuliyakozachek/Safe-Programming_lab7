using System;
using System.IO;

namespace Yuliya
{
    class Program
    {
        static void Main()
        {
            string line;
            int op = 0, cl = 0;
            StreamReader tmp = new StreamReader("C:\\Yuliya\\Lab_7_1_text.txt");
            line = Convert.ToString(tmp.ReadToEnd());
            Console.WriteLine("Содержимое файла:");
            Console.WriteLine(line);
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '(')
                {
                    op++;
                }
                else if (line[i] == ')')
                {
                    cl++;
                } 
            }
            if (op == cl)
            {
                Console.WriteLine("Количество открытых и закрытых скобок одинаково");
            }
            else
            {
                Console.WriteLine("Количество открытых и закрытых скобок разное");
            }
        }
    }
}


    
