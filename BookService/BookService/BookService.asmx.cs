using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BookObject;

namespace BookService
{
    /// <summary>
    /// Summary description for BookService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BookService : System.Web.Services.WebService
    {
        public static List<Book> listBooks = new List<Book>();
        
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public Boolean themSach(long id, string title ,string author, double price, string puclicsher)
        {
            Book book = new Book(id, title, author, price, puclicsher);
            if (checkID(book.id))
            {
                newBook(book);
                return true;
            }
            else
            {
                return false;
            }
        }
        void newBook(Book book)
        {
            listBooks.Add(book);
        }

        public Boolean checkID(long id)
        {
           for(int i = 0; i < listBooks.Count(); i++)
            {
                if(listBooks[i].id == id)
                {
                    return false;
                }
            }
            return true;
        }

        [WebMethod]
        public List<Book> dsSach()
        {
            return listBooks;
        }

        [WebMethod]
        public Book timKiemTheoId(long id)
        {
            for(int i=0;i< listBooks.Count; i++)
            {
                if(listBooks[i].id == id)
                {
                    return listBooks[i];
                }
            }
            return null; 
        }
        [WebMethod]
        public List<Book> timKiemTheoAuThor(string author)
        {
            List<Book> dsSachCungAuthor = new List<Book>();
            for (int i = 0; i < listBooks.Count; i++)
            {
                if (listBooks[i].author == author)
                {
                    dsSachCungAuthor.Add(listBooks[i]);
                }
            }
            return dsSachCungAuthor;
        }

        [WebMethod]
        public List<Book> timKiemTheoPublicsher(string publicsher)
        {
            List<Book> dsSachCungPublicsher = new List<Book>();
            for (int i = 0; i < listBooks.Count; i++)
            {
                if (listBooks[i].publicsher == publicsher)
                {
                    dsSachCungPublicsher.Add(listBooks[i]);
                }
            }
            return dsSachCungPublicsher;
        }
    }
}
