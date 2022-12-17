using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTryYourself
{
    internal class ITExecutive : FullTime
    {
        private float commision;

        private float Commision
        {
            get { return commision; }
            set { commision = value; }
        }
        internal override string Id
        {
            set { base.Id = value + "-IT"; }
        }
        internal ITExecutive(string name, int salary, DateTime Dateofbirth,float bonus,float commision) : base (name,salary,Dateofbirth,bonus)
        {
            this.commision = commision;
        }

        internal override void GrossIncome()
        {
            //base.GrossIncome();
            Console.WriteLine("Gross Income: {0}", (this.Salary + this.Bonus + this.commision) - (this.Bonus - Salary * 0.1 / 100) + (this.Bonus * 0.02 / 100) + (this.commision * 0.05 / 100));
        }
        internal override void NetTax()
        {
            //base.NetTax();
            Console.WriteLine("Net Tax: {0} ", (this.Salary * 0.1) / 100 + (this.Bonus * 0.02) / 100 + (this.commision * 0.05) / 100);
        }

        internal override void ShowInfo() //
        {
            Console.WriteLine("\n*****Full Time Employee,IT Executive's Information: *****\n");
            base.ShowInfo();
            //this.GrossIncome();
            //this.NetTax();
        }
    }
}
