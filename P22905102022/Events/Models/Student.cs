using System;
using System.Collections.Generic;
using System.Text;

namespace Events.Models
{
    class Student
    {
        public event Action Notify 
        { 
            add 
            {
                value.Invoke();
                Console.WriteLine(value.Method.Name);
            } 
            remove 
            {
                value.Invoke();
                Console.WriteLine($"{value.Method.Name} {value.Method.IsStatic}");
            } 
        }
        public double Grade;

        //public void Sowmessage()
        //{
        //    Notify.Invoke();
        //    //if (Grade < 60)
        //    //{
        //    //    Console.WriteLine("Kesildiniz");
        //    //}
        //    //else
        //    //{
        //    //    Console.WriteLine("Kecdiniz");
        //    //}
        //}
    }
}
