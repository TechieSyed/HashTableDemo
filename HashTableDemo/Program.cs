using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
namespace HashTableDemo
{
    class Employee { }
    class Department : IComparable
    {
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var EmployeesInDepartments = new Hashtable();

            var csdept = new ArrayList();
            csdept.Add(new Employee());
            csdept.Add(new Employee());
            csdept.Add(new Employee());

            var ecdept = new ArrayList();
            ecdept.Add(new Employee());
            ecdept.Add(new Employee());
            ecdept.Add(new Employee());

            //EmployeesInDepartments.Add("CS101", csdept);
            //EmployeesInDepartments.Add("EC102", ecdept);
            EmployeesInDepartments.Add(new Department(), csdept);
            EmployeesInDepartments.Add(new Department(), ecdept);

            Department d = new Department();
            if (EmployeesInDepartments.ContainsKey(d))
            {
                ArrayList lst = EmployeesInDepartments[d] as ArrayList;
            }

            var employees = new Hashtable();
            employees.Add(101, "Jojo");
            employees.Add(102, "Sam");
            employees.Add(103, "Sarah");
            employees.Add(104, "Sarah");
            //employees.Add(103, "Jenny");

            Console.WriteLine("Total items : " + employees.Count);

            foreach(object k in employees.Keys)
            {
                Console.WriteLine(employees[k]);
            }
            
           var ispresent =employees.ContainsKey(101);
            Console.WriteLine("Key found : " + ispresent);

            employees.Remove(101);
            Console.WriteLine("Total items after removal : " + employees.Count);


            Console.ReadKey();
        }
    }
}
