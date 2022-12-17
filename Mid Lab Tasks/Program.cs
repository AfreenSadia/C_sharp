using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLabTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(1,"abc",new ManufactureDate(12,04,22),new ExpairyDate(05,07,25),4500.0f,23);
            //p1.SetId(1);
            //p1.SetName("HP");
            //p1.SetManufactureDate(new ManufactureDate(12, 02, 22));
            //p1.SetExpairyDate(new ExpairyDate(22, 10, 25));
            //p1.SetPrice(2500);
            //p1.SetQuantity(52);
            p1.ShowInfo();
        }
    }
}
