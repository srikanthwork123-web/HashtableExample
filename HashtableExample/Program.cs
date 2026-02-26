using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             4) Hash table:-
            ===================
1) It will arrange data in the form of key and value format
2) It will maintain the data in DictionaryEntry interface
3) It will arrange data based on key and value format.
4) It will arrange data in descending order
            */
            Hashtable ht = new Hashtable();

            ht.Add(1, "Na");
            ht.Add(9, "r");
//Here 9 is the keyname .key name should be unique .you can't add duplicate key .if you add duplicate key it will throw compiletime error.
            // ht.Add(9, "s");
            ht.Add("collegename", "JNTU");
            ht.Add(3, "Z");
            ht.Add(5, "h");
            ht.Add(15, "L");
            foreach (DictionaryEntry d in ht)//DictionaryEntry maintain the key value format of data.
            {
                Console.WriteLine("the key is {0} and values is {1},-{2}", d.Key, d.Value,"Testing");
            }
            
            //foreach (var d in ht)   //var is not handle the key value format of Data.
            //{
            //    Console.WriteLine("the key is {0} and values is {1},-{2}", d.Key, d.Value, "Testing");
            //}
            Console.ReadLine();
        }
    }
}
