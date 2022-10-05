using ClassWork.Exceptions;
using ClassWork.Services;
using System;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            try
            {
                library.FindAllBooksByPageCountRange(10, 30);
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
