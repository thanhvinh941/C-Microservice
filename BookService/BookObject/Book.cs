using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookObject
{
    public class Book
    {
        public long id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public double price { get; set; }
        public string publicsher { get; set; }

        public Book(long id, string title, string author, double price, string publicsher)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.price = price;
            this.publicsher = publicsher;
        }

        public Book() { }

        public override string ToString()
        {
            return id+"\t"+title+"\t"+author+"\t"+price+"\t"+publicsher;
        }
    }
}
