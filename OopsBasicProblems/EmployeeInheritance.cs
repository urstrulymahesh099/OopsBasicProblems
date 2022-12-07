using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OopsBasicProblems
{
    public class EmployeeInheritance
    {
        public string companyName;
    }
    public class EmployeeInheritance2 : EmployeeInheritance
    {
        public string name;
        public int empID;
        public EmployeeInheritance2(string name, int empID, string companyName)
        {
            this.name = name;
            this.empID = empID;
            this.companyName = companyName;
        }
        public void Check()
        {
            Console.WriteLine("Employee name " + name);
            Console.WriteLine("Employee id " + empID);
            Console.WriteLine("Employee companyName  " + companyName);


        }

    }
}