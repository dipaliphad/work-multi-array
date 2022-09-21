using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_multi_array
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] n2 = new string[4];
            string[] names = { "jay", "darshan", "dipu", "rupu" };
            string[] n1 = new string[4];
            Console.WriteLine("Original array");
            names[2] = "ishu";
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("sorted array");
            Array.Sort(names);
            //Array.Reverse(names);
            //Array.Clear(names, 1,2);
            // Array.Copy(names,n1, names.Length);
            int index = Array.IndexOf(names, 2);
            names[index] = "ishu";
            Console.WriteLine($"index of dipu is {index}");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
