using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Level1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //способ с коллекциями
            //string[] arr1 = { "Alex", "Dima", "Kate", "Galina", "Ivan" };
            //string[] arr2 = { "Dima", "Ivan", "Kate" };
            //string[] arr3 = arr1.Except<string>(arr2).ToArray<string>();
            //foreach (var i in arr3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.ReadKey();


            //способ без коллекций
            string[] arr4 = { "Alex", "Dima", "Kate", "Galina", "Ivan" };
            string[] arr5 = { "Dima", "Ivan", "Kate" };
            foreach (var f in arr5)
            {
                string[] arr6 = arr4.Where(x => x != f).ToArray();
                arr4 = arr6;
            }
            foreach (var t in arr4)
                Console.WriteLine(t);


            Console.ReadKey();
        }
    }
}
