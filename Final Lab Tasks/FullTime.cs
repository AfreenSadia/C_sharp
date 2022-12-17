using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTryYourself
{ 

    internal class FullTime : Employee
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
        internal override string Id
        {
            set { base.Id = value + "-FT"; }
        }

        internal FullTime (string name, int salary, DateTime Dateofbirth,float bonus) : base (name,salary,Dateofbirth)
        {
          this.Bonus = bonus;
        }

       internal virtual void GrossIncome()
        {
            Console.WriteLine("Total income: {0}",( this.Salary + this.bonus)-((this.Salary * 0.1) / 100 + (this.bonus * 0.02) / 100));
        }
        internal virtual void NetTax()
        {
            Console.WriteLine ("Net Tax: {0} ",(this.Salary * 0.1 / 100) + (this.bonus * 0.02 / 100) );
        }
        internal override void ShowInfo()
        {   
            base.ShowInfo();
            this.GrossIncome();
            this.NetTax();
         
        }

    }
}
