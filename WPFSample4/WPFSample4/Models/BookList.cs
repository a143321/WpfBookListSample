using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSample4.Models
{
    public class BookList
    {
        /// <summary>
        /// 書籍リストクラス
        /// </summary>
        private List<Book> books;

        public BookList()
        {
            this.books = new List<Book>();
        }

        public BookList(List<Book> someList)
        {
            this.books = new List<Book>(someList);
        }

        public List<Book> GetList()
        {
            return new List<Book>(books);
        }


        public List<Book> Add(Book someBook)
        {
            books.Add(someBook);

            return new List<Book>(books);
        }

        public List<Book> Del(Book someBook)
        {
            foreach(var book in books)
            {
                if(book.ID == someBook.ID)
                {
                    books.Remove(book);
                    break;
                }

            }
            return new List<Book>(books);
        }

        public void DelAll()
        {
            books.Clear();
        }
    }
}
