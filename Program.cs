using System;
using System.Collections.Generic;
//using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Linq;

namespace LinqIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func and action types
            Func<int, int> Square = x => x * x;
            Console.WriteLine(Square(3));

            Func<int, int, int> add = (x, y) => x + y;
            Console.WriteLine(Square(add(3, 5)));

            Action<int> write= x=>Console.WriteLine(x);
            write(Square(add(3, 5)));


            //array of employees
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee {Id=1, Name="Scott"},
                new Employee {Id=2, Name="Chris"}
            };

            //list of employees
            IEnumerable<Employee> sales = new List<Employee>()
            {
                new Employee {Id=3, Name="Alex"}
            };

            //creating a linq query to select developers with a name of length 5
            var query = from developer in developers
                        where developer.Name.Length == 5
                        orderby developer.Name descending
                        select developer;

            foreach(var employee in query)
            {
                Console.WriteLine(employee.Name);
            }

            //lambda expression for returning employee name with lenght of 5
            foreach(var employee in developers.Where(e=>e.Name.Length==5)
                .OrderBy(e => e.Name))
            {
                Console.WriteLine(employee.Name);
            }

            /**foreach (var person in sales)
            {
                Console.WriteLine(person.Name);
            }**/

            //counts the number of employees in sales....count method extension in mylinq class
            Console.WriteLine(developers.Count());

            //loops through employee array using interface method and returns name
            IEnumerator<Employee> enumerator = developers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Name);
            }

            //write lambda expression where code shows employee names that start with an S
            foreach(var employee in developers.Where(e => e.Name.StartsWith("S")
            ))
            {
                Console.WriteLine(employee.Name);
            }

            public sheep(string sound)
            {
                sound="maaaah";
                return sound;
            }

        }

        private static bool NameStartsWithS(Employee employee)
        {
            return employee.Name.StartsWith("S");
        }
    }
}
