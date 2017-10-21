using SF_29_2016.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF_29_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new A();
            var ime = new A();
            ime.SetIme("Goran");
            Console.WriteLine("Pozdrav ja se zovem" + ime.GetIme());
            Console.ReadLine();
            


        }
    }
}
