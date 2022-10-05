using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace katehw4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        List<Book> books = new List<Book>();
        List<Grocery> grocery = new List<Grocery>();
        List<Item> items = new List<Item>();
        DataTable ItemTable = new DataTable();
        DataTable GroceryTable = new DataTable();
        DataTable BookTable = new DataTable();


        private void Form1_Load(object sender, EventArgs e)
        {

            ItemTable.Columns.Add("Type of item", typeof(int));
            ItemTable.Columns.Add("Name", typeof(string));
            ItemTable.Columns.Add("Price", typeof(string));
            ItemTable.Columns.Add("Country", typeof(string));
            ItemTable.Columns.Add("Date of package", typeof(string));
            ItemTable.Columns.Add("Description", typeof(string));

            


            grocery.Add(new Grocery(1, "Kavun", 180, "Ukraine", 5, "Kilograms", "22.10.2022", "27.10.2022", "Hersonskiy Kavun"));
           

            GroceryTable.Columns.Add("ItemID", typeof(int));
            GroceryTable.Columns.Add("Name of grocery", typeof(string));
            GroceryTable.Columns.Add("Price", typeof(int));
            GroceryTable.Columns.Add("Country of origin", typeof(string));
            GroceryTable.Columns.Add("Quantity", typeof(int));
            GroceryTable.Columns.Add("Measure", typeof(string));
            GroceryTable.Columns.Add("Date of package", typeof(string));
            GroceryTable.Columns.Add("Valid", typeof(string));
            GroceryTable.Columns.Add("Description", typeof(string));




            for (int  i= 0; i < grocery.Count; i++)
            {
                GroceryTable.Rows.Add(grocery[i].ItemId, grocery[i].Name, grocery[i].Price, grocery[i].Origin, grocery[i].quantity, grocery[i].measure, grocery[i].Date, grocery[i].valid, grocery[i].Description);
            }
            dataGridView2.DataSource = GroceryTable;

            for(int i= 0; i < grocery.Count; i++)
            {
                ItemTable.Rows.Add(grocery[i].ItemId, grocery[i].Name, grocery[i].Price, grocery[i].Origin, grocery[i].Date, grocery[i].Description);
            }
            dataGridView1.DataSource = ItemTable;

           
            List<string> autorlist1 = new List<string>();
            autorlist1.Add("Dunkan Maclaud");
            autorlist1.Add("Robert Parkinson");

            books.Add(new Book(2, "Fly of pigs", 542, "PigyMania", autorlist1, 320, "America", "22.04.1921", "Pink pig"));

            BookTable.Columns.Add("ItemID", typeof(int));
            BookTable.Columns.Add("Title", typeof(string));
            BookTable.Columns.Add("Number of pages", typeof(int));
            BookTable.Columns.Add("Publisher", typeof(string));
            BookTable.Columns.Add("Autors", typeof(string));
            BookTable.Columns.Add("Price", typeof(int));
            BookTable.Columns.Add("Country of original", typeof(string));
            BookTable.Columns.Add("Date", typeof(string));
            BookTable.Columns.Add("Description", typeof(string));

            for(int i = 0; i < books.Count; i++)
            {
                string authors = " ";
                for (int j = 0; j < books[i].authors.Count; j++)
                {
                    authors += books[i].authors[j] + " , ";
                }
                BookTable.Rows.Add(books[i].ItemId, books[i].Name, books[i].pages, books[i].publisher, authors, books[i].Price, books[i].Origin, books[i].Date, books[i].Description);
            }
            dataGridView3.DataSource = BookTable;

            for (int i = 0; i < books.Count; i++)
            {
                ItemTable.Rows.Add(books[i].ItemId, books[i].Name, books[i].Price, books[i].Origin, books[i].Date, books[i].Description);
            }
            dataGridView1.DataSource = ItemTable;

        }



        private void GroceryADD_Click(object sender, EventArgs e)
        {
            Grocery grocery = new Grocery(1, "Kavun", 150, "Ukraine", 4, "Kilograms", "16.10.2022", "20.10.2022", "Hersonskiy Kavun");
            GroceryTable.Rows.Add(grocery.ItemId, grocery.Name, grocery.Price, grocery.Origin, grocery.quantity, grocery.measure, grocery.Date, grocery.valid, grocery.Description);
            ItemTable.Rows.Add(grocery.ItemId, grocery.Name, grocery.Price, grocery.Origin, grocery.Date, grocery.Description);
        }

        private void BookADD_Click(object sender, EventArgs e)
        {
            List<string> autorlist = new List<string>();
            autorlist.Add("Taras Shevchenko");

            Book books = new Book(2, "I am Blue", 140, "63AD", autorlist, 350, "Tadjikistan", "25.03.2015", "Good Book");

            string autors = "";
            for (int j = 0; j < books.authors.Count; j++)
            {
                autors += books.authors[j];    
            }

            BookTable.Rows.Add(books.ItemId, books.Name, books.pages, books.publisher, autors, books.Price, books.Origin, books.Date, books.Description);
            ItemTable.Rows.Add(books.ItemId, books.Name, books.Price, books.Origin, books.Date, books.Description);
        }

        private void DeleteGrocery_Click(object sender, EventArgs e)
        {
            int limit = dataGridView2.Rows.Count - 2;
            if (limit < 0) MessageBox.Show("Error");
            else dataGridView2.Rows.RemoveAt(limit);
        }

        private void DeleteBook_Click(object sender, EventArgs e)
        {
            int limit = dataGridView3.Rows.Count - 2;
            if (limit < 0) MessageBox.Show("Error");
            else dataGridView3.Rows.RemoveAt(limit);
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            int limit = dataGridView1.Rows.Count - 2;
            if (limit < 0) MessageBox.Show("Error");
            else dataGridView1.Rows.RemoveAt(limit);
        }

    }
}
