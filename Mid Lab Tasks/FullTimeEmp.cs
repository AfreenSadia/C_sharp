using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePracticeMid
{
    
    internal class FullTimeEmp : Employees
    {
         private float bonus;

        internal float Bonus
        {
            get { return bonus; }
            set
            {
                this.bonus = value;
            }
           
        }

        internal FullTimeEmp (byte id, string name, int salary, JoiningDate joiningDate, string position,float bonus) : base (id,name,salary,joiningDate,position)
        {
          this.Bonus = bonus;
        }

       internal virtual void GrossIncome()
        {
            Console.WriteLine("Total income: {0}", this.Salary * 12 + bonus + 2);
        }
        internal virtual void NetTax()
        {
            Console.WriteLine ("Net Tax: {0} ", this.Salary * 0.20 + this.Salary);
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
