using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace katehw4
{
    public class Item
    {
        public int ItemId;
        public int Price;
        public string Origin;
        public string Name;
        public string Date;
        public string Description;
        public Item(int itemId, int price, string origin, string name, string date, string description)
        {
            this.ItemId = itemId;
            this.Price = price;
            this.Origin = origin;
            this.Name = name;
            this.Date = date;
            this.Description = description;
        }
    }
    public class Grocery : Item
    {
        public string valid;
        public int quantity;
        public string measure;
        public Grocery(int itemId, string name, int price, string origin, int quantity, string measure, string date, string valid, string description) : base(itemId, price, origin, name, date, description)
        {
            this.valid = valid;
            this.quantity = quantity;
            this.measure = measure;
        }
    }
    public class Book : Item
    {
        public int pages;
        public string publisher;
        public List<string> authors;
        public Book(int itemId, string name, int pages, string publisher, List<string> authors, int price, string origin, string date, string description) : base(itemId, price, origin, name, date, description)
        {
            this.pages = pages;
            this.publisher = publisher;
            this.authors = authors;
        }
    }
}
