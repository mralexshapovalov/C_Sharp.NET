//#define Task
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
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
            double[,] B = new double[3, 4];

            double minValue = 0, maxValue = 0, sumElement = 0, remainderDivision = 0, compositionElement = 1;

            Console.WriteLine("Заполните массив :");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());

                if (A[i] < A[(int)minValue])
                {
                    minValue = i;
                }

                if (A[i] > A[(int)maxValue])
                {
                    maxValue = i;
                }

                if (A[i] % 2 == 0)
                {
                    remainderDivision += A[i];
                }

                sumElement += A[i];
                compositionElement *= A[i];
            }

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + "\t");
            }

            Console.WriteLine();
            Console.WriteLine($"Минимальное значение : {A[(int)minValue]} ячейка A[{minValue}]");
            Console.WriteLine($"Минимальное значение : {A[(int)maxValue]} ячейка A[{maxValue}]");
            Console.WriteLine($"Сумма элементов в массиве : {sumElement}");
            Console.WriteLine($"Произведение элементов: {compositionElement}");
            Console.WriteLine($"Сумма четных элементов массива :{remainderDivision}");

            sumElement = 0;
            compositionElement = 1;
            remainderDivision = 0;

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = random.NextDouble() * 100;


                    sumElement += B[i, j];
                    compositionElement *= B[i, j];


                    if (j % 3 != 0)
                    {
                        remainderDivision += B[i, j];
                    }
                }
            }

            Console.WriteLine();

            minValue = B[0, 0];
            maxValue = B[0, 0];
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {

                    if (minValue > B[i, j])
                    {
                        minValue = B[i, j];
                    }

                    if (B[i, j] > maxValue)
                    {
                        maxValue = B[i, j];
                    }
                    Console.Write(Math.Round(B[i, j], 2) + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine($"Минимальное значение : {Math.Round(minValue, 2)}");
            Console.WriteLine($"Максимальный элемент : {Math.Round(maxValue, 2)}");
            Console.WriteLine($"Сумма элементов в массиве : {Math.Round(sumElement, 2)}");
            Console.WriteLine($"Произведение элементов: ,{Math.Round(compositionElement, 2)}");
            Console.WriteLine($"Сумма четных элементов массива :{remainderDivision}");


        }
        static void TaskTwo()
        {
            Random random = new Random();

            int sum = 0, indexMin = 0, indexMax = 0;
         
            int[,] array = new int[5, 5];
           
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-101, 101);
                }
            }

            Console.WriteLine("Дан двухмерный массив,заполненый случайными числами в диапазаоне от -100 до 100");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int minValue = array[0, 0];
            int maxValue = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(minValue > array[i,j] )
                    {
                        minValue = array[i, j];
                    }
                    if (array[i, j] > maxValue)
                    {
                        maxValue = array[i, j];
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Минимальное значение  " + minValue);
            Console.WriteLine("Максимальное значение " + maxValue);

            // переводим массив в одномерный

            Console.WriteLine("\nМассив переведен в одномерный:");

            List<int> arrayDimensional = new List<int>();
    
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    arrayDimensional.Add(array[i, j]);
         
                }
            }

            // ищем индексы макс и мин

            for (int i = 0; i < array.Length; i++)
            {
                if (minValue == arrayDimensional[i])
                {
                    indexMin = i;
                    break;
                }

                if (maxValue == arrayDimensional[i])
                {
                    indexMax = i;
                    break;
                }
            }

            if (indexMin < indexMax) // переменным не присвоено значение???
            {
                for (int j = indexMin; j <= indexMax; j++)
                {
                    sum += arrayDimensional[j];
                   
                }
            }

            else
            {

                for (int j = indexMax; j <= indexMin; j++)
                {
                    sum += arrayDimensional[j];
                  
                }


            }


            Console.WriteLine("min = {0}, max= {1}, sum= {2} ", minValue, maxValue, sum);
        }
        static void TaskThree()
        {
            string CodeEncode(string text, int k)
            {
                const string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

                //добавляем в алфавит маленькие буквы
                var fullAlfabet = alfabet + alfabet.ToLower();
                var letterQty = fullAlfabet.Length;
                var retVal = "";

                for (int i = 0; i < text.Length; i++)
                {
                    var c = text[i];
                    var index = fullAlfabet.IndexOf(c);

                    if (index < 0)
                    {
                        //если символ не найден, то добавляем его в неизменном виде
                        retVal += c.ToString();
                    }
                    else
                    {
                        var codeIndex = (letterQty + index + k) % letterQty;
                        retVal += fullAlfabet[codeIndex];
                    }
                }

                return retVal;
            }

            //шифрование текста
            string Encrypt(string plainMessage, int key) => CodeEncode(plainMessage, key);

            //дешифрование текста
            string Decrypt(string encryptedMessage, int key) => CodeEncode(encryptedMessage, -key);


            Console.Write("Введите текст: ");
            var message = Console.ReadLine();
            Console.Write("Введите ключ: ");
            var secretKey = Convert.ToInt32(Console.ReadLine());
            var encryptedText = Encrypt(message, secretKey);
            Console.WriteLine("Зашифрованное сообщение: {0}", encryptedText);
            Console.WriteLine("Расшифрованное сообщение: {0}", Decrypt(encryptedText, secretKey));
            Console.ReadLine();
        }
        static void TaskFour()
        {
            Random random = new Random();
         
            int[,] arrayOne = new int[5, 5];
            int[,] arrayTwo = new int[5, 5];
            int[,] arrayThree = new int[5, 5];
           

            for (int i = 0; i < arrayOne.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOne.GetLength(1); j++)
                {
                    arrayOne[i, j] = random.Next(1,20);
                }
            }

            for (int i = 0; i < arrayTwo.GetLength(0); i++)
            {
                for (int j = 0; j < arrayTwo.GetLength(1); j++)
                {
                    arrayTwo[i, j] = random.Next(1, 20);
                }
            }

            Console.WriteLine("Вывод массива:" +
                             "\n1:");
            for (int i = 0; i < arrayOne.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOne.GetLength(1); j++)
                {
                    Console.Write(arrayOne[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n2:");
            for (int i = 0; i < arrayTwo.GetLength(0); i++)
            {
                for (int j = 0; j < arrayTwo.GetLength(1); j++)
                {
                    Console.Write(arrayTwo[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Умножение первого массива на 2\n");
            for (int i = 0; i < arrayOne.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOne.GetLength(1); j++)
                {
                    Console.Write((arrayOne[i, j] * 2) + "\t");
                }
                Console.WriteLine();
            }

    
            Console.WriteLine("\nСумма первого и второго массивов:");
            for (int i = 0; i < arrayOne.GetLength(0); i++)
            {
                for (int j = 0; j < arrayOne.GetLength(1); j++)
                {
                    Console.Write((arrayOne[i, j] + arrayTwo[i, j]) + "\t");

                }
                Console.WriteLine();
            }

            Console.WriteLine("Вывролнение произведение двух массивов:");
            for (int i = 0; i < arrayThree.GetLength(0); i++)
            {
                for (int j = 0; j < arrayThree.GetLength(1); j++)
                {
                    for (int k = 0; k < arrayThree.GetLength(2); k++)
                    {
                        arrayThree[i, j] += arrayOne[i, k] * arrayTwo[k, j];
                    }
                }
            }

            for (int i = 0; i < arrayThree.GetLength(0); i++)
            {
                for (int j = 0; j < arrayThree.GetLength(1); j++)
                {
                    Console.Write(arrayThree[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
        static void TaskFive()
        {

        }
        static void TaskSix()
        {
            string str = "today is a good day for walking. i will try to walk near the sea.";

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(str[0].ToString().ToUpper());

            for (int i = 1; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]) && char.IsWhiteSpace(str[i - 1]) && ".!?".IndexOf(str[i - 2]) != -1)
                {
                    stringBuilder.Append(str[i].ToString().ToUpper());
                }
                else
                {
                    stringBuilder.Append(str[i]);
                }
            }
            Console.WriteLine(stringBuilder.ToString());
        }
        static void TaskSeven()
        {

        }
        static void Main(string[] args)
        {
            TaskTwo();
        }
    }
}
