using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePracticeMid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employees E1 = new Employees(001,"XYZ",50000,new JoiningDate(12,10,22),"Manager");
            FullTimeEmp F1 = new FullTimeEmp(005, "Ahamed", 1000, new JoiningDate(12, 10, 17),"Superviser",500);
            PartTimeEmp P1 = new PartTimeEmp(008, "Sadia", 2000, new JoiningDate(5, 07, 12),"Sub-manager",300);
            Employees EF1 = new FullTimeEmp(005,"abc",2500, new JoiningDate(20,05,22),"Manager",500);
            Employees EP1 = new PartTimeEmp(005, "abc", 2500, new JoiningDate(20, 05, 22), "Manager", 500);

            E1.ShowInfo();
            F1.ShowInfo();
            P1.ShowInfo();
           
           

        }
    }
}
