using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lstnamaMhs = new List<string>();
            lstnamaMhs.Add("erick");
            lstnamaMhs.Add("wely");
            lstnamaMhs.Add("rully");

            string namaMhs = lstnamaMhs[1];

            Console.WriteLine(namaMhs);
            Console.WriteLine();

            foreach (string nama in lstnamaMhs)
            {
                Console.WriteLine(nama);
            }
            Console.ReadKey();
        }
    }
}
