//#define TEST
//#define ARRAYS
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

            
           // int _id = null;
            int? value = null;


            int? _nullable = null;


            Nullable<double> _nullabled = null;


            _nullable = _nullable ?? 0;


           // int a = 10L;
            double d = 10f;
            Console.WriteLine(10L.GetType());

#endif



#if ARRAYS

            double[] doubles = new double[15];

            Random random = new Random();

            for (int i = 0; i < doubles.Length; i++)

            {
                doubles[i] = random.NextDouble();
            }

            for (int i = 0; i < doubles.Length; i++)
            {
                Console.Write(doubles[i] + "\t");
            }


            int a = 0;
            int b = 0;

            Console.WriteLine("Введите параметр A-");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите параметр Б-");
            b = Convert.ToInt32(Console.ReadLine());


            int[] ints = new int[15];

            Random random=new Random();



            for (int i = 0; i < ints.Length; i++)

            {
                ints[i] = random.Next(a,b);
            }

            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write(ints[i] + "\t");
            }


            int[] arr = {0,1,0,0,10,13,20,30,10};

            Random random = new Random();

            //for (int i = 0; i < arr.Length; i++)

            //{
            //    arr[i] = random.Next(1,100);
            //}

            for (int i = 0; i < arr.Length; i++)

            {
                Console.Write(arr[i] + "\t");
            }



            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i + 1 < arr.Length)

                    if (arr[i] % 10 == 0 && (arr[i + 1] % 10 == 0))

                    {
                        count++;
                    }



                
            }

            Console.Write("Колличество пар "+count + "\t");

#endif

            int[] arr = {0,1,0,0,10,13,20,30,10};

            Random random = new Random();

            //for (int i = 0; i < arr.Length; i++)

            //{
            //    arr[i] = random.Next(1,100);
            //}

            for (int i = 0; i < arr.Length; i++)

            {
                Console.Write(arr[i] + "\t");
            }


            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i + 1 < arr.Length)

                    if (arr[i] % 10 == 0 && (arr[i + 1] % 10 == 0))

                    {
                        count++;
                    }



                
            }

            Console.Write("Колличество пар "+count + "\t");

        }
    }
}
