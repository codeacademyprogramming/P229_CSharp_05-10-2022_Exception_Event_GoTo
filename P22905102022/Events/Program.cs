using Events.Models;
using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Grade = 50;
            student1.Notify += () => 
            {
                if (student1.Grade < 60)
                {
                    Console.WriteLine("Herbiye hazirlas");
                }
                else
                {
                    Console.WriteLine("Canim Qutardi");
                }
            };
            student1.Notify += Test;
            student1.Notify -= Test;

            //student1.Sowmessage();

            Student student2 = new Student();
            student2.Grade = 40;
            student2.Notify += () => 
            {
                if (student2.Grade < 60)
                {
                    Console.WriteLine("Ovladliqdan Cixmaga hazirlas");
                }
                else
                {
                    Console.WriteLine("Is Axtarmaga Basla");
                }
            };
            //student2.Sowmessage();
        }

        static void Test()
        {

        }
    }
}
