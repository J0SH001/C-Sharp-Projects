using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Joes = new List<Employee>();

            List<Employee> Employees = new List<Employee>();
            
            Employee one = new Employee();
            one.FirstName = "Joe";
            one.LastName = "Smith";
            one.Id = 1;
            Employees.Add(one);

            Employee two = new Employee();
            two.FirstName = "Emily";
            two.LastName = "Smith";
            two.Id = 2;
            Employees.Add(two);

            Employee three = new Employee();
            three.FirstName = "John";
            three.LastName = "Smith";
            three.Id = 3;
            Employees.Add(three);

            Employee four = new Employee();
            four.FirstName = "Edward";
            four.LastName = "Smith";
            four.Id = 3;
            Employees.Add(four);

            Employee five = new Employee();
            five.FirstName = "Becky";
            five.LastName = "Smith";
            five.Id = 4;
            Employees.Add(five);

            Employee six = new Employee();
            six.FirstName = "Renaldo";
            six.LastName = "Smith";
            six.Id = 5;
            Employees.Add(six);

            Employee seven = new Employee();
            seven.FirstName = "Echbert";
            seven.LastName = "Smith";
            seven.Id = 6;
            Employees.Add(seven);

            Employee eight = new Employee();
            eight.FirstName = "Joe";
            eight.LastName = "Johnson";
            eight.Id = 7;
            Employees.Add(eight);

            Employee nine = new Employee();
            nine.FirstName = "Joey";
            nine.LastName = "Smith";
            nine.Id = 8;
            Employees.Add(nine);

            Employee ten = new Employee();
            ten.FirstName = "Francis";
            ten.LastName = "Smith";
            ten.Id = 9;
            Employees.Add(ten);

            foreach (Employee employee in Employees)
            {
                if (employee.FirstName == "Joe")
                {
                    Joes.Add(employee);
                }
            }

            foreach (Employee employee in Joes)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            List<Employee> Joes2 = Employees.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee employee in Joes2)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            List<Employee> GreaterThanFive = Employees.Where(x => x.Id > 5).ToList();

            foreach (Employee employee in GreaterThanFive)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            Console.ReadLine();
        }
    }
}
