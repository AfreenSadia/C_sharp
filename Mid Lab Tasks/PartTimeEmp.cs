using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePracticeMid
{
    internal class PartTimeEmp : Employees
    {
        private int commision;

        private int Commision
        {
            get { return commision; }
            set { commision = value; }
        }

        internal PartTimeEmp(byte id, string name, int salary, JoiningDate joiningDate, string position,int commision) : base(id,name,salary,joiningDate,position)
        {
            this.commision = commision;
        }

        internal virtual void GrossIncome()
        {
            Console.WriteLine("Total: {0}",this.Salary + this.commision);
        }
        internal virtual void NetTax()
        {
            Console.WriteLine("Net Tax: {0} ", this.Salary * 0.5 + this.Salary);
        }

        internal override void ShowInfo()
        {
            Console.WriteLine("Full Time Employee Information: ");
            base.ShowInfo();
            this.GrossIncome();
            this.NetTax();
        }
    }
}
