
using System;
namespace OopsBasicProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("For Understanding Basic Inheritance");
            Console.WriteLine("Click Below options :" + "\n" + "1.Singleinheritance");
            while (true) 
            {
                int option =Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        EmployeeInheritance2 e1 = new EmployeeInheritance2("Mahesh", 5009, "Wistron Private Limited");
                        e1.Check();
                        break;
                }
            }
            
        }
    }
}