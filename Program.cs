using System;

namespace NestedTuplesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nested Tuples!");
            /*
             * 1.int    : employee number
             * 2.string : first name
             * 3.string : last name
             * 4.string : address
             * 5.string : city
             * 6.string : job title
             * 7.string : nationality
             * 8.tuple  : last 5 salaries
            */

            /*Create*/
            var employeeInfo = new Tuple<int, string, string, string, string, string, string, Tuple<decimal, decimal, decimal, decimal, decimal>>
                (105, "James", "Franco", "123 Bird Street", "Miami", "Programmer", "American", Tuple.Create(2000m, 3000m, 4000m, 5000m, 5000m));

            /*Display*/
            Console.WriteLine("Item 1 : " + employeeInfo.Item1);
            Console.WriteLine("Item 2 : " + employeeInfo.Item2);
            Console.WriteLine("Item 3 : " + employeeInfo.Item3);
            Console.WriteLine("Item 4 : " + employeeInfo.Item4);
            Console.WriteLine("Item 5 : " + employeeInfo.Item5);
            Console.WriteLine("Item 6 : " + employeeInfo.Item6);
            Console.WriteLine("Item 7 : " + employeeInfo.Item7);

            Console.WriteLine("Item 8-1 : " + employeeInfo.Rest.Item1);
            Console.WriteLine("Item 8-2 : " + employeeInfo.Rest.Item2);
            Console.WriteLine("Item 8-3 : " + employeeInfo.Rest.Item3);
            Console.WriteLine("Item 8-4 : " + employeeInfo.Rest.Item4);

        }
    }
}
