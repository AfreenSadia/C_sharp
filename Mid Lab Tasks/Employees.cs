using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePracticeMid
{
    struct JoiningDate
    {
        private byte date;//initialize
        private byte month;
        private int year;

        public JoiningDate(byte date, byte month, int year)//constructor
        {
            this.date = date;
            this.month = month;
            this.year = year;
        }

        public void PrintJoiningDate()//method
        {
            Console.WriteLine("Joining date : {0}-{1}-{2}", this.date, this.month,this.year);
           
        }
    }
    
    internal class Employees
    {
        private byte id;
        private string name;
        private int salary;
        private JoiningDate joiningDate;
        private string position;

        internal byte Id
        {
            get { return id; }
            set { this.id = value;}
        }

        internal string Name
        {
            get { return name;}
            set { this.name = value;}
        }

        internal int Salary
        {
            get { return salary;}
            set { this.salary = value;}
        }

        internal JoiningDate Joiningdate
        {
            get { return joiningDate; }
            set
            {
                this.joiningDate = value;
            }
        }

        internal string Position
        {
            get { return position; }
            set { this.position = value; }
        }
        internal Employees () { }
        internal Employees (byte id, string name, int salary, JoiningDate joiningDate, string position)
        {
            this.Id= id;
            this.Name= name;
            this.Salary= salary;
            this.Joiningdate= joiningDate;
            this.Position= position;
        }

        internal virtual void ShowInfo()
        {
            Console.WriteLine("Employee ID: {0}", this.Id);
            Console.WriteLine("Employee Name: {0}", this.Name);
            Console.WriteLine("Employee Salary: {0}", this.Salary);
            this.joiningDate.PrintJoiningDate();
            Console.WriteLine("Position : {0}",this.Position);
        }


        
    }

    
}
