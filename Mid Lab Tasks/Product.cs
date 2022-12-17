using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLabTask1
{
    struct ManufactureDate
    {
        private byte date;
        private byte month;
        private byte year;

        public ManufactureDate(byte date, byte month, byte year)
        {
            this.date = date;
            this.month = month;
            this.year = year;
        }

        public void PrintManufactureDate()
        {
            /*Console.WriteLine("Date : {0}", this.date);
            Console.WriteLine("Month : {0}", this.month);
            Console.WriteLine("Year : {0}", this.year);*/
            Console.WriteLine("Manufacture Date: {0}-{1}-{2}", this.date, this.month, this.year);
                
         }
    }

    struct ExpairyDate
    {
        private byte date;
        private byte month;
        private byte year;

        public ExpairyDate(byte date, byte month, byte year)
        {
            this.date = date;
            this.month = month;
            this.year = year;
        }

        public void PrintExpairyDate()
        {
            /*Console.WriteLine("Date : {0}", this.date);
            Console.WriteLine("Month : {0}", this.month);
            Console.WriteLine("Year : {0}", this.year);*/
            Console.WriteLine("Expairy Date: {0}-{1}-{2}", this.date, this.month, this.year);
        }
    }
    internal class Product
    {
        private byte id;
        private string name;
        private ManufactureDate manufactureDate;
        private ExpairyDate expairyDate;
        private float price;
        private int quantity;


        public byte GetId()
        {
            return this.id;
        }

        public void SetId(byte id)
        {
            this.id = id;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public ManufactureDate GetManufactureDate()
        {
            return this.manufactureDate;
        }

        public void SetManufactureDate(ManufactureDate manufactureDate)
        {
            this.manufactureDate = manufactureDate;
        }

        public ExpairyDate GetExpairyDate()
        {
            return this.expairyDate;
        }
        public void SetExpairyDate(ExpairyDate expairyDate)
        {
            this.expairyDate = expairyDate;
        }

        public float GetPrice()
        {
            return this.price;
        }

        public void SetPrice(float price)
        {
            this.price = price;
        }
        public int GetQuantity()
        {
            return this.quantity;
        }
        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        public Product() { }

        public Product(byte id, string name, ManufactureDate manufactureDate, ExpairyDate expairyDate, float price, int quantity)
        {
            this.SetId(id);
            this.SetName(name);
            this.SetManufactureDate(manufactureDate);
            this.SetExpairyDate(expairyDate);
            this.SetPrice(price);
            this.SetQuantity(quantity);

        }

        public void ShowInfo()
        {
            Console.WriteLine("Products Info");
            Console.WriteLine("Product Id : {0}", this.GetId());
            Console.WriteLine("Product Name: {0}", this.GetName());
            this.GetManufactureDate().PrintManufactureDate();
            this.GetExpairyDate().PrintExpairyDate();
            Console.WriteLine("Product price: {0}", this.GetPrice());
            Console.WriteLine("Product Quantity: {0}", this.GetQuantity());
        }

    }
    }
