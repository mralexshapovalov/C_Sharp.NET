#define TEST
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if (TEST)
            object name;
            name=Console.ReadLine();
            Console.WriteLine("Привет,"+name);

#endif          

        }
    }
}
