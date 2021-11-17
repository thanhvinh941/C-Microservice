using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookObject;
using BookService;
namespace BookCilent
{
    public partial class Form1 : Form
    {
        public static List<Book> ds = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            BookCilent.ServiceReference1.BookServiceSoapClient qlSach = new ServiceReference1.BookServiceSoapClient();
            long id = long.Parse(textBoxID.Text);
            string title = textBoxTitle.Text;
            string author = textBoxAuthor.Text;
            double price = double.Parse(textBoxPrice.Text);
            string publicsher = textBoxPublicsher.Text;

            Boolean b = qlSach.themSach(id, title, author, price, publicsher);

            if (b){
                Book book = new Book(id, title, author, price, publicsher);
                ds.Add(book);
                listBoxBook.Items.Add(book.ToString());
                textBoxID.Text = ""; textBoxTitle.Text = ""; textBoxPrice.Text = "";
                textBoxAuthor.Text = ""; textBoxPublicsher.Text = "";
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                textBoxID.Text = "";
                MessageBox.Show("ID trùng");
            }
        }

        private void buttonID_Click(object sender, EventArgs e)
        {
            BookCilent.ServiceReference1.BookServiceSoapClient qlSach = new ServiceReference1.BookServiceSoapClient();
            long id = qlSach.timKiemTheoId(long.Parse(textBoxID.Text)).id;
            string title = qlSach.timKiemTheoId(long.Parse(textBoxID.Text)).title;
            string author = qlSach.timKiemTheoId(long.Parse(textBoxID.Text)).author;
            double price = qlSach.timKiemTheoId(long.Parse(textBoxID.Text)).price;
            string publicsher = qlSach.timKiemTheoId(long.Parse(textBoxID.Text)).publicsher;

            Book b = new Book(id, title, author, price, publicsher);
            listBoxBook.Items.Add(b.ToString());
        }

        private void buttonLoadDS_Click(object sender, EventArgs e)
        {
            ds.Clear();
            listBoxBook.Items.Clear();
            BookCilent.ServiceReference1.BookServiceSoapClient qlSach = new ServiceReference1.BookServiceSoapClient();
            for(int i = 0; i < qlSach.dsSach().Length; i++)
            {
                long id = qlSach.dsSach()[i].id;
                string title = qlSach.dsSach()[i].title;
                string author = qlSach.dsSach()[i].author;
                double price = qlSach.dsSach()[i].price;
                string publicsher = qlSach.dsSach()[i].publicsher;
                Book b = new Book(id, title, author, price, publicsher);
                ds.Add(b);
                listBoxBook.Items.Add(b);
            }
        }

        private void listBoxBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            String listSelect = listBoxBook.SelectedItem.ToString();

            string[] arrListStr = listSelect.Split('\t');
            textBoxID.Text = arrListStr[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
    
}
