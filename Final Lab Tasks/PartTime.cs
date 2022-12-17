using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTryYourself
{
    internal class PartTime : Employee
    {
        private float commision;

        private float Commision
        {
            get { return commision; }
            set { commision = value; }
        }
        internal override string Id
        {
            set { base.Id = value + "-PT"; }
        }
        internal PartTime(string name, int salary, DateTime Dateofbirth, float commision ) : base(name, salary, Dateofbirth)
        {
            this.commision = commision;
        }

        internal void GrossIncome()
        {
            Console.WriteLine("Total: {0}", (this.Salary + this.commision) - ((this.Salary * 0.15) /100));
        }
        internal void NetTax()
        {
            Console.WriteLine("Net Tax: {0} ", (this.Salary* 0.15 / 100));
        }

        internal override void ShowInfo()
        {
            Console.WriteLine("\n*****Part Time Employee's Information: *****\n");
            base.ShowInfo();
            this.GrossIncome();
            this.NetTax();
        }
    }
}
