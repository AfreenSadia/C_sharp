using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTryYourself
{
    
    internal abstract class Employee
    {
        private static int serialNo = 0;
        private string id;
        private string name;
        private int salary;
        private DateTime Dateofbirth;

        internal virtual string Id
        {
            get { return this.id; }
            set { this.id = "E-" + value; }
        }

        internal string Name
        {
            get;
            set;
        }

        internal int Salary
        {
            get; set;
        }

        internal DateTime DateOfBirth
        {
            get { return Dateofbirth; }
            set
            {
                this.Dateofbirth = value;
            }
        }

        internal Employee (string name, int salary, DateTime Dateofbirth)
        {
            this.Id = (++serialNo).ToString();
            this.Name= name;
            this.Salary= salary;
            this.DateOfBirth= Dateofbirth;
        }

        internal virtual void ShowInfo()
        {
            Console.WriteLine("Employee ID: {0}", this.Id);
            Console.WriteLine("Employee Name: {0}", this.Name);
            Console.WriteLine("Employee Salary: {0}", this.Salary);
            Console.WriteLine("Date of birth: {0:D}", this.DateOfBirth);
            /*Console.WriteLine("1.Back");
            Console.WriteLine("2.Exit");
            string q = Console.ReadLine();
            int q1 = Int32.Parse(q);
            switch (q1)
            {
                case 1:
                    ABC_Company.FirstView();
                    break;
                case 2:
                    System.Environment.Exit(0);
                    break;

            }*/
        }


        
    }

    
}
