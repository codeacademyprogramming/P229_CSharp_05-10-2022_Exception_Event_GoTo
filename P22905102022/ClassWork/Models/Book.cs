using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.Models
{
    class Book
    {
        static int _no;
        public readonly string Code;
        public string Name;
        public string AuthorName;
        public int PageCount;

        static Book()
        {
            _no = 0;
        }

        public Book(string name, string authorName, int pageCount)
        {
            _no++;
            Code = $"{name.Substring(0, 2).ToUpper()}{_no}";
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
        }
    }
}
