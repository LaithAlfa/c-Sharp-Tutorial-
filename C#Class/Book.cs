using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Class
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string aTitile, string aAuthor, int aPage)
        {
                title = aTitile;
                author = aAuthor;
                pages = aPage;

        }
    }

}