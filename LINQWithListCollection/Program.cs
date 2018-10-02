using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQWithListCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //populate a list of strings
            var items = new List<string>(); //dynamic size, can be increased during run time
            //its an improved array

            //var item1= new List<double>();
            //var item2 = new List<int>();

            items.Add("aQua");//adding each items to the end of list
            items.Add("RusT");
            items.Add("yElLow");
            items.Add("rEd");

            //display initial list
            Console.WriteLine("Item contains: ");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();//output end of line

            //convert those uppercase, select those starting with 'R' and sort

            var startWithR =
                from value in items
                let uppercaseString = value.ToUpper()
                where uppercaseString.StartsWith("R")
                orderby uppercaseString
                select uppercaseString;

            //display query results
            Console.WriteLine("results of query startWithRr: ");
            foreach (var item in startWithR)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();//output end of line

            items.Add("rUby");
            items.Add("SaFfRon");

            //display Initial lsit
            Console.WriteLine("Item contains: ");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //display updated query results
            Console.WriteLine("results of query startwithR: ");
            foreach (var item in startWithR)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
