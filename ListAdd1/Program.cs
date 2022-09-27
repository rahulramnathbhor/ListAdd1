using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProductList
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Rahul");
            list.Add("Akshay");
            list.Add("Siddhesh");
            list.Remove("Siddhesh");
            foreach (var l in list)
            {
                Console.WriteLine(l);
            }
            //string[] names = new string[1];
            // list.Insert(1, "Siddhesh");
            //list.CopyTo(names);
            //foreach (var l in list)
            //{
            //    Console.WriteLine(l);
            //}
            list.Reverse();
            list.Add("Dnyaneshwar");
            list.RemoveAt(1);
            list.IndexOf("Siddhesh");
            {
                Console.WriteLine();
            }




        }

        }


}
