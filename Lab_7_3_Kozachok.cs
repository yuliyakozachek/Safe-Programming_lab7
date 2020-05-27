using System;
using System.IO;
using System.Collections.Generic;

namespace Yuliya
{
    class People
    {
        public string Name
        {
            set;
            get;
        }
        public string Surname
        {
            set;
            get;
        }        
        public int Age
        {
            set;
            get;
        }
        public int Ves
        {
            set;
            get;
        }
        public People(string name, string surname, int let, int ves)
        {
            Name=name;
            Surname=surname;
            Age=let;
            Ves=ves;
        }
        public void Show()
        {
            Console.WriteLine("Имя - "+Name);
            Console.WriteLine("Фамилия - "+Surname);
            Console.WriteLine("Возраст - "+Age);
            Console.WriteLine("Вес - "+Ves);
        }
    }
    class Comparer : IComparer<People>
        {
            public int Compare(People person1, People person2)
            {
                if (person1.Age > person2.Age)
                {
                    return 1;
                }
                else if (person1.Age < person2.Age)           
                {
                    return -1;
                }
                else
                 {
                    return 0;
                 }   
            }
        }
    class Program
    {
        static void Main()
        {
            List<People> people = new List<People>();
            string text;
            StreamReader read = new StreamReader("C:\\Yuliya\\Lab_7_2_text.txt");
            while ((text = read.ReadLine()) != null)
            {
                string[] split = text.Split(' ');
                string name = split[0];
                string surname = split[1];
                int age = Convert.ToInt32(split[2]);
                int ves = Convert.ToInt32(split[3]);

                people.Add(new People(name, surname, age, ves));
            }
            Console.WriteLine("Список людей:");
            foreach (People i in people)
            {
                    i.Show();
            }
            people.Sort(new Comparer());
            Console.WriteLine("\nОтсортированный список людей");
            foreach (People i in people)
            {
                
                i.Show();
            }
        }
    }
}


    
