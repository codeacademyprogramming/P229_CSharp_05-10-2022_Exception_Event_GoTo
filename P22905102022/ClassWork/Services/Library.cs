using ClassWork.Exceptions;
using ClassWork.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.Services
{
    class Library
    {
        public List<Book> Books;

        public Library()
        {
            Books = new List<Book>();
        }

        public List<Book> FindAllBooksByName(string str) => Books.FindAll(b => b.Name.ToLower().Contains(str.ToLower()));
        //{
        //    //List<Book> findngBooks = Books.FindAll(b => b.Name.ToLower().Contains(str.ToLower()));
        //    //return findngBooks;

        //     
        //}

        public void RemoveAllBookByName(string str)
        {
            Books.RemoveAll(b => b.Name.ToLower().Contains(str.ToLower()));
        }

        public List<Book> SearchBooks(string str)
        {
            return Books.FindAll(b => b.Name.ToLower().Contains(str.ToLower()) || 
            b.AuthorName.ToLower().Contains(str.ToLower()) || 
            b.PageCount.ToString().ToLower().Contains(str.ToLower()));
        }

        public List<Book> FindAllBooksByPageCountRange(int min, int max)
        {
            List<Book> findingBooks = Books.FindAll(b => b.PageCount >= min && b.PageCount <= max);


            if (findingBooks.Count <= 0)
            {
                //NullReferenceException nullReferenceException = new NullReferenceException("Axtaris deyerlerinde Uygun List Tapilmadi");
                //throw nullReferenceException;

                //CustomException customException = new CustomException("Axtaris deyerlerinde Uygun List Tapilmadi");
                //Console.WriteLine(customException.Message);
                throw new CustomException("Axtaris deyerlerinde Uygun List Tapilmadi");
            }

            return findingBooks;
        }

        public void RemoveByNo(string str)
        {
            Book book = Books.Find(b => b.Code == str.ToUpper());

            if (book == null)
            {
                Books.Remove(book);
            }
        }
    }
}
