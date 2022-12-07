
using System;
namespace OopsBasicProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("For Understanding Basic Inheritance");
            Console.WriteLine("Click Below options :" + "\n" + "1.Singleinheritance"+"\n"+"2.MultipleInheritance");
            while (true) 
            {
                int option =Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        EmployeeInheritance2 e1 = new EmployeeInheritance2("Mahesh", 5009, "Wistron Private Limited");
                        e1.Check();
                        break;
                    case 2:
                        Animals a1 = new Animals();
                        a1.standing();
                        MaleDog m1 = new MaleDog();
                        m1.Dogstanding();
                        FemaleDog e2 = new FemaleDog("Red","SSSS",5);
                        e2.Waiting();
                        break;
                }
            }
            
        }
    }
}