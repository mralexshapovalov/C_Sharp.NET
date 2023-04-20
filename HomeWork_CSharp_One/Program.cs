//#define Task
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
                    int numberMultipleFive  = number % 5;

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
            Console.WriteLine($"{percent} % от числа {value} = {result}") ;
        }

        static void TaskThree()
        {
            Console.WriteLine("Введите c кдавиатуры 4 цифры");
            int value,value1,value2,value3;

            value  = Convert.ToInt32(Console.ReadLine());
            value1 = Convert.ToInt32(Console.ReadLine());
            value2 = Convert.ToInt32(Console.ReadLine());
            value3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Число: {value}{value1}{value2}{value3}");



        }
        static void TaskFour()
        {


            while(true)
            {
            
                int selectAction=0;

                Console.Write("Введите показания температуры: ");
                int valueTemperature = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("1)Перевести температуру из Фаренгейта в Цельсий\n" +
                                   "2)Перевести температуры из Цельсий в Фаренгейт");





                switch(selectAction=Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:


                        double С=(5/9*(Convert.ToInt32(valueTemperature)-32));
                        

                        Console.WriteLine(С);
                        break;

                        case 2:
                        double F = 9 / 5 *132 + 32;
                        
                        Console.WriteLine(F);


                        break;

                    default:
                        Console.WriteLine("Ошибка");
                        break;

                }


            }

           






        }
        static void TaskFive()
        {

        }

        static void TaskSix()
        {

        }

        static void TaskSeven()
        {

        }






        static void Main(string[] args)
        {
            // TaskOne();

            //TaskTwo();

            TaskFour();
        }
    }
}
