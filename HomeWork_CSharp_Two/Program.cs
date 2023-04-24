//#define Task
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if Task
Задание 1
Объявить одномерный(5 элементов) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B. Заполнить одномерный массив
А числами, введенными с клавиатуры пользователем, а
двумерный массив В случайными числами с помощью
циклов. Вывести на экран значения массивов: массива
А в одну строку, массива В — в виде матрицы. Найти в
данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее
произведение всех элементов, сумму четных элементов
массива А, сумму нечетных столбцов массива В.

Задание 2
Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100.
Определить сумму элементов массива, расположенных
между минимальным и максимальным элементами.

Задание 3
Пользователь вводит строку с клавиатуры. Необходимо зашифровать данную строку используя шифр Цезаря.
Из Википедии:
Шифр Цезаря — это вид шифра подстановки, в котором каждый символ в открытом тексте заменяется
символом, находящимся на некотором постоянном числе
позиций левее или правее него в алфавите. Например,
в шифре со сдвигом вправо на 3, A была бы заменена на
D, B станет E, и так далее.
Подробнее тут: https://en.wikipedia.org/wiki/Caesar_
cipher.
Кроме механизма шифровки, реализуйте механизм
расшифрования.

Задание 4
Создайте приложение, которое производит операции
над матрицами:
■ Умножение матрицы на число;
■ Сложение матриц;
■ Произведение матриц.

Задание 5
Пользователь с клавиатуры вводит в строку арифметическое выражение.Приложение должно посчитать
его результат.Необходимо поддерживать только две
операции: + и –.

Задание 6
Пользователь с клавиатуры вводит некоторый текст.
Приложение должно изменять регистр первой буквы
каждого предложения на букву в верхнем регистре.

Например, если пользователь ввёл: «today is a good
day for walking.i will try to walk near the sea».
Результат работы приложения: «Today is a good day
for walking.I will try to walk near the sea».

Задание 7
Создайте приложение, проверяющее текст на недопустимые слова.Если недопустимое слово найдено, оно
должно быть заменено на набор символов*. По итогам
работы приложения необходимо показать статистику
действий.
Например, если и у нас есть такой текст:
To be, or not to be, that is the question,
Or to take arms against a sea of troubles,
And by opposing end them? To die: to sleep;
No more; and by a sleep to say we end
Devoutly to be wish'd. To die, to sleep
Недопустимое слово: die.
Результат работы:
To be, or not to be, that is the question,

Or to take arms against a sea of troubles,
And by opposing end them? To ***: to sleep;
No more; and by a sleep to say we end
Devoutly to be wish'd. To ***, to sleep.
Статистика: 2 замены слова die.  
#endif

namespace HomeWork_CSharp_Two
{
    class Program
    {
        static void TaskOne()
        {
            Random random = new Random();

            int[] A = new int[5];

            int[,] B = new int[3, 4];

            int  minValue = 0;
            int maxValue = 0;

            int sum = 0;


            for (int i=0; i<A.Length; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < A.Length; i++)
            {
                minValue = A[0];

               

                Console.Write(A[i]+"\t");

                sum+= A[i];

             


            }
            Console.WriteLine();


            for (int i = 0; i < A.Length; i++)
            {
               

                if (A[i] < A[minValue])
                {
                    minValue = i;
                    

                }
                if(A[i] > A[maxValue])
                {
                    maxValue = i;


                }


            }

            Console.WriteLine("Минимальное значение " + A[minValue]);
            Console.WriteLine("Максимальное значени " + A[maxValue]);
            //Console.WriteLine(sum);
            Console.WriteLine();
            for (int i=0;i<B.GetLength(0);i++)
            {
                for(int j=0;j<B.GetLength(1);j++)
                {
                   B[i, j] = random.Next(0, 100);

                }
                
            }

           
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                   
                    Console.Write(B[i, j]+"\t");
                    sum += B[i,j];

                }
               
                Console.WriteLine();
            }

            Console.WriteLine(sum);
            minValue = B[0,0];

            for (int i = 0; i < B.GetLength(0); i++)
            
                for (int j = 0; j < B.GetLength(1); j++)
                

                    //Console.Write(B[i, j] + "\t");
                    //sum += B[i, j];


                    //if (B[i,j] < minValue)
                    

                    //    minValue = B[i, j];

                    if (B[i,j] > maxValue)


                      maxValue = B[i, j];
                   

                
                
            
            Console.WriteLine("Минимальное значение " + minValue);
            Console.WriteLine("Максимальное значени " + maxValue);
            Console.WriteLine();
        }

        void TaskTwo()
        {

        }

        void TaskThree()
        {

        }

        void TaskFour()
        {

        }

        void TaskFive()
        {

        }

        void TaskSix()
        {

        }

        void TaskSeven()
        {

        }





        static void Main(string[] args)
        {
            TaskOne();
        }
    }
}
