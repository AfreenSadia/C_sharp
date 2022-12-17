using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTryYourself
{
    internal class Manager : FullTime
    {
        private float kpi;

        internal float Kpi
        {
            get { return kpi; }
            set { kpi = value; }
        }
        internal override string Id
        {
            set { base.Id =  value + "-M"; }
        }
        internal Manager (string name, int salary, DateTime Dateofbirth,float bonus, float kpi) : base (name,salary,Dateofbirth,bonus)
        {
            this.kpi = kpi;
        }

        internal override void GrossIncome()
        {
            //base.GrossIncome();
            Console.WriteLine("Gross income: {0}", (this.Salary + this.Bonus + this.kpi)- (this.Bonus - Salary * 0.1 /100 ) + (this.Bonus * 0.02 / 100) + (this.kpi * 0.03 / 100));
        }
        internal override void NetTax()
        {
            //base.NetTax();
            Console.WriteLine("Net Tax: {0} ", (this.Salary * 0.1) /100 + (this.Bonus * 0.02) / 100 + (this.kpi * 0.03)/ 100);
        }

        internal override void ShowInfo() //
        {
            Console.WriteLine("\n****Full Time Employee,Manager's Information: ****\n");
            base.ShowInfo();
            //this.GrossIncome();
            //this.NetTax();
        }
    }
}
