using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Welcome To HashTable Program-----");

            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);//creating object and Key and value datatype is string and size is 5
            // Adding values in hashtable.
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "To");
            hash.Add("5", "be");
           
            // hash.Remove("0");
            hash.Display();

            // getting the specific value from hashtable.
            string hash4 = hash.Get("4");
            Console.WriteLine("4th index value:" + hash4);
            Console.Read();
        }
    }
}
