//#define TEST
//#define ARRAYS
//#define STRING
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NN
{
    class MyClass
    {
        MyClass_1 myClass =new MyClass_1();
        int x_1 = MyClass_1.x;
        int y_1 = MyClass_1.y;
    }

    class MyClass_1
    {
        public static int x= 0;
        public const int y = 0;
    }
}

namespace C_Sharp
{

   

    internal class Program
    {

        struct MyStruct
        {

        }

        enum MyEnum
        {
            red=10,blue=4500, green=41
        }


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

#if string
            string str_1 = "fskskf";
            string str_2 = "sdsddss";

            int lenght_1 = str_1.Length;
            int lenght_2 = str_2.Length;


            string str = " ";

            string[] str_mass;
            str_mass = str_1.Split(' ');

            string temp = str_mass[0];

            str_mass[0] = str_mass[str_mass.Length - 1];

            str_mass[str_mass.Length - 1] = temp;

            StringBuilder sb = new StringBuilder(lenght_1);

            for (int i = 0; i < lenght_1; i++)

            {
                sb.Append(str_1[i]);
                if (i < lenght_2)
                {
                    sb.Append(str_2[i]);

                }
            }

            Console.WriteLine(sb.ToString()); 
#endif


            string str = Console.ReadLine();



            int my_color = 45;
            MyEnum myEnum=(MyEnum)Enum.Parse(typeof(MyEnum),str);

            switch(myEnum)
            {
                case MyEnum.red:

                    Console.Write("Красный");
                    break;

                case MyEnum.blue:

                    Console.Write("Синий");
                    break;

                case MyEnum.green:

                    Console.Write("Зеленный");
                    break;


            }
     



        }
    }
}
