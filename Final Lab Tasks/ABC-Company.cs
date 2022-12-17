using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTryYourself
{
    internal static class ABC_Company
    {
        private static Employee[] employeeList = new Employee[5000];
        private static int count = 0;


        internal static void FirstView()
        {
            //int option=1;
            Console.WriteLine("*****WELCOME TO ABC COMPANY*****");
            Console.WriteLine("1.Add Employee");
            Console.WriteLine("2.Remove Employee");
            Console.WriteLine("3.Search Employee");
            Console.WriteLine("4.Show all Employee");
            Console.WriteLine("5.Exit");
            Console.WriteLine("Write down any option: ");
            string option = Console.ReadLine();
            int op1 = Int32.Parse(option);
           

            int r;

            switch (op1)//manager,it executive, part time
            {

                case 1:
                    Console.WriteLine("*****Choose employee type*****");
                    Console.WriteLine("1.Full time");
                    Console.WriteLine("2.Part Time");
                    Console.WriteLine("Enter your choice: ");
                    string opt3 = Console.ReadLine();
                    int op2 = Int32.Parse(opt3);
                    switch (op2)
                    {
                        case 1:
                            Console.WriteLine("1.Manager");
                            Console.WriteLine("2.IT Executive");
                            string opt4 = Console.ReadLine();
                            int op5 = Int32.Parse(opt4);

                            switch(op5)
                            {
                                case 1:
                                    Console.WriteLine("Enter name: ");
                                    string name = Console.ReadLine();
                                    Console.WriteLine("Enter salary: ");
                                    int salary = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter birth year: ");
                                    int year = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter birth month: ");
                                    int month = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter birth date: ");
                                    int date = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter bonus: ");
                                    float bonus = float.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter kpi: ");
                                    float kpi = float.Parse(Console.ReadLine());
                                    ABC_Company.AddEmployee(new Manager(name, salary, new DateTime(year, month, date), bonus, kpi));
                                    break;


                                case 2:
                                    Console.WriteLine("Enter name: ");
                                    string name1 = Console.ReadLine();
                                    Console.WriteLine("Enter salary: ");
                                    int salary1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter birth year: ");
                                    int year1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter birth month: ");
                                    int month1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter birth date: ");
                                    int date1 = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter bonus: ");
                                    float bonus1 = float.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter commision: ");
                                    float commision = float.Parse(Console.ReadLine());
                                    ABC_Company.AddEmployee(new ITExecutive(name1, salary1, new DateTime(year1, month1, date1), bonus1, commision));
                                    break;

                            }
                            break;


                        case 2:
                            Console.WriteLine("Enter name: ");
                            string name3 = Console.ReadLine();
                            Console.WriteLine("Enter salary: ");
                            int salary3 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter birth year: ");
                            int year3= Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter birth month: ");
                            int month3 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter birth date: ");
                            int date3 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter commision: ");
                            float commision3 = float.Parse(Console.ReadLine());
                            ABC_Company.AddEmployee(new PartTime(name3, salary3, new DateTime(year3, month3, date3),commision3));
                            break;
                    }
                    
                    
                    break;
                case 2:
                    ABC_Company.DeleteEmployee(Console.ReadLine());
                    break;
                case 3:
                    ABC_Company.Search(Console.ReadLine(), out r);
                    break;
                case 4:
                    ABC_Company.ShowAll();
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;

            }

            }
       internal static void AddEmployee(Employee p)
        {
            //int q = 1;
            employeeList[count] = p;
            count++;
            Console.WriteLine("1.Back");
            Console.WriteLine("2.Exit");
            string  q = Console.ReadLine();
            int q1 = Int32.Parse(q);
            switch(q1)
            {
                case 1:
                    ABC_Company.FirstView();
                    break;
                case 2:
                    System.Environment.Exit(0);
                    break;

            }
               

        }

        internal static void ShowAll()
        {
            int index = 0;
            while (index < count)
            {
                if (employeeList[index] != null)
                    employeeList[index].ShowInfo();
                index++;
            }
            Console.WriteLine("1.Back");
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

            }
        }

        internal static bool Search(string key,out int info)
        {
            
            bool found = false;
            int index = 0;
            while (index < count)
            {
                if (key.Equals(employeeList[index].Id))
                {
                    found = true;
                    info = index;
                    Console.WriteLine("\n**********'Employee Information Found'**********\n");
                    employeeList[index].ShowInfo();
                    return found;
                }
                index++;
            }

            if (!found)
                Console.WriteLine("\n*******'Employee Information Not Found'*******\n");
            info = -1;
            return found;

            ABC_Company.FirstView();

            /* Console.WriteLine("1.Back");
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

        internal static void DeleteEmployee(string key)
        {
            int indexNumber;
            bool decision = Search(key, out indexNumber);
            if (decision)
            {
                employeeList[indexNumber] = null;
                Console.WriteLine("\n*******'Delete Complete'*******\n");
                //ShowAll();
            }
            if(!decision)
            {
                Console.WriteLine("User not found");
            }
            Console.WriteLine("1.Back");
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

            }
        }

        /*internal static void Exit(bool p)
        {
            if(!p)
            {
                Console.WriteLine("\n****DO YOU WANT TO EXIT?****\n");
            }
            if(p)
            {
                Console.WriteLine("\n****EXIT****\n");
            }
        }*/
    }
}