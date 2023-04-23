//#define Task
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http.Headers;


#if Task
Задание 1
Пользователь вводит с клавиатуры число в диапазоне от 1 до 100. Если число кратно 3 (делится на 3 без
остатка) нужно вывести слово Fizz. Если число кратно 5
нужно вывести слово Buzz. Если число кратно 3 и 5 нужно
вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно
вывести само число.

Задание 2
Если пользователь ввел значение не в диапазоне от 1
до 100 требуется вывести сообщение об ошибке.
Пользователь вводит с клавиатуры два числа. Первое
число — это значение, второе число процент, который
необходимо посчитать. Например, мыввели с клавиатуры
90 и 10. Требуется вывести на экран 10 процентов от 90.
Результат: 9.

Задание 3
Пользователь вводит с клавиатуры четыре цифры.
Необходимо создать число, содержащее эти цифры. Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно
сформировать число 1578.

Задание 4
Пользователь вводит шестизначное число. После чего
пользователь вводит номера разрядов для обмена цифр.
Например, если пользователь ввёл один и шесть — это
значит, что надо обменять местами первую и шестую
цифры.Число 723895 должно превратиться в 523897. 
Если пользователь ввел не шестизначное число требуется вывести сообщение об ошибке.

Задание 5
Пользователь вводит с клавиатуры дату. Приложение должно отобразить название сезона и дня недели.
Например, если введено 22.12.2021, приложение должно
отобразить Winter Wednesday.

Задание 6
Пользователь вводит с клавиатуры показания температуры. В зависимости от выбора пользователя программа переводит температуру из Фаренгейта в Цельсий
или наоборот.

Задание 7
Пользователь вводит с клавиатуры два числа. Нужно
показать все четные числа в указанном диапазоне. Если
границы диапазона указаны неправильно требуется произвести нормализацию границ. Например, пользователь
ввел 20 и 11, требуется нормализация, после которой
начало диапазона станет равно 11, а конец 20.

#endif
namespace HomeWork_CSharp_One
{
    class Program
    {
        static void TaskOne()
        {
            bool isRemember = true;

            while (isRemember)
            {
                Console.Write("Введите число с клавиатуры в диапазоне от 0 до 100 : ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number >= 1 && number <= 100)
                {
                    int numberMultipleThree = number % 3;
                    int numberMultipleFive = number % 5;

                    if (numberMultipleThree == 0 && numberMultipleFive == 0)
                    {
                        Console.WriteLine("Fizz Bizz");
                    }

                    else if (numberMultipleThree == 0)
                    {
                        Console.WriteLine("Fizz");
                    }

                    else if (numberMultipleFive == 0)
                    {
                        Console.WriteLine("Bizz");
                    }

                    if (numberMultipleThree != 0 && numberMultipleFive != 0)
                    {
                        Console.Write($"Число не кратное 3 и 5 - {number}");//По заданию не понял какое нужно выести число
                    }
                }
                else
                    Console.WriteLine("Ошибка!Данное число не в диапазоне.Повторите снова");
            }
        }

        static void TaskTwo()
        {
            Console.Write("Введите число: ");
            float value = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите процент числа: ");
            float percent = Convert.ToSingle(Console.ReadLine());

            float result = (Convert.ToSingle(value / 100)) * percent;
            Console.WriteLine($"{percent} % от числа {value} = {result}");
        }

        static void TaskThree()
        {
            Console.WriteLine("Введите c кдавиатуры 4 цифры");
            int value, value1, value2, value3;

            value = Convert.ToInt32(Console.ReadLine());
            value1 = Convert.ToInt32(Console.ReadLine());
            value2 = Convert.ToInt32(Console.ReadLine());
            value3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Число: {value}{value1}{value2}{value3}");
        }

        static void TaskFour()
        {
            while (true)
            {
                Console.Write("Введите 6-ти значное число : ");

                int number = int.Parse(Console.ReadLine());//Parse преборазует строку к числу 32-битовое число со знаком

                int firstNumber = 0, 
                    counter = 0,
                    lastNumber = number % 100/10,
                    temp = number;
              
                while (temp != 0)
                {
                    firstNumber = temp % 10;
                    temp = temp / 10;
                    counter++;
                }
               
                if (counter >7)
                {
                    Console.WriteLine($"Ошибка!Вы ввели число {number} .Оно превышает больше 6-ти знанчений.Введите число снова");
                }
                else

                    counter--;
                    number -= firstNumber * (int)Math.Pow(10, counter) + lastNumber;
                    number += lastNumber * (int)Math.Pow(10, counter) + firstNumber;
                    Console.WriteLine(number.ToString());

            }
        }

        static void TaskFive()
        {
            bool isDay = true;

            while (isDay)
            {
                Console.Write("Введите дату через пробел :");
                string line = Console.ReadLine();

                string[] lineArray = line.Split('.').Where(x => x != "").ToArray();
                //Split предназначен для разделения строки
                //Where использование последовательность значений

                int day = int.Parse(lineArray[0]), month = int.Parse(lineArray[1]), year = int.Parse(lineArray[2]);

                if (day == 0 || day >= 32)
                {
                    Console.WriteLine("Ошибка!Неверно указана дата.Повторите снова");
                }
                else
                {
                    if (month == 1 || month == 2 || month == 12)
                    {
                        Console.Write("Winter ");
                    }

                    if (month == 3 || month == 4 || month == 5)
                    {
                        Console.Write("Spring ");
                    }

                    if (month == 6 || month == 7 || month == 8)
                    {
                        Console.Write("Summer ");
                    }

                    if (month == 9 || month == 10 || month == 11)
                    {
                        Console.Write("Autumn ");
                    }

                    if (month == 0 || month >= 13)
                    {
                        Console.WriteLine("Ошибка!Неверно указан месяц.Повторите снова");
                    }

                    var startDay = new DateTime(year, month, day);
                    Console.WriteLine($"{startDay.DayOfWeek}");
                }
            }
        }

        static void TaskSix()
        {
            int selectAction, valueTemperature;
            float celsius, farenheint;

            while (true)
            {
                Console.Write("Введите показания температуры: ");
                valueTemperature = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("1)Перевести температуру из Фаренгейта в Цельсий\number" +
                                  "2)Перевести температуры из Цельсий в Фаренгейт");

                switch (selectAction = Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        celsius = 0.5556f * (valueTemperature - 32);
                        Console.WriteLine($"Из Фаренгейта в Цельсий - {Math.Round(celsius, 2)}C\number");
                        break;

                    case 2:
                        farenheint = 1.8f * valueTemperature + 32;
                        Console.WriteLine($"Из Цельсий в Фаренгейт - {farenheint}F\number");
                        break;

                    default:
                        Console.WriteLine("Ошибка!Повторите снова");
                        break;
                }
            }
        }

        static void TaskSeven()
        {
            int valueOne, valueTwo, minValue = 0, maxValue = 0;

            Console.WriteLine("Введите диапазон значений:");

            valueOne = Convert.ToInt32(Console.ReadLine());
            valueTwo = Convert.ToInt32(Console.ReadLine());

            if (valueOne < valueTwo)
            {
                minValue = valueOne;
                maxValue = valueTwo;
            }

            if (valueOne > valueTwo)
            {
                minValue = valueTwo;
                maxValue = valueOne;
            }

            Console.Write($"Все четные числа в диапазоне от {minValue} до {maxValue} : ");

            while (minValue <= maxValue)
            {
                int numberMultipleThree = minValue % 2;

                if (numberMultipleThree == 0)
                {
                    Console.Write(minValue + "\t");
                }

                minValue++;
            }
        }

        static void Main(string[] args)
        {
 
            while (true)
            {
                Console.Write(
                   "1)Задание 1\n" +
                   "2)Задание 2\n" +
                   "3)Задание 3\n" +
                   "4)Задание 4\n" +
                   "5)Задание 5\n" +
                   "6)Задание 6\n" +
                   "7)Задание 7\n" +
                   "Введите число :");

                switch (value = Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        TaskOne();
                        break;
                    case 2:
                        TaskTwo();
                        break;
                    case 3:
                        TaskThree();
                        break;
                    case 4:
                        TaskFour();
                        break;
                    case 5:
                        TaskFive();
                        break;
                    case 6:
                        TaskSix();
                        break;
                    case 7:
                        TaskSeven();
                        break;
                    default:
                        Console.WriteLine("Ошибка!Неверно указн номер.Повторите снова");
                        break;
                }

               
            }
        }
    }
}
