﻿using System;
using System.Dynamic;
using System.Globalization;
using static System.Console;
/// <summary>
/// Соколова Диана БПИ 202
/// Написать метод, находящий трехзначное десятичное число s, все цифры которого одинаковы и которое представляет собой сумму первых членов натурального ряда,
/// то есть s = 1+2+3+4+… 
////Вывести полученное число, количество членов ряда и условное изображение соответствующей суммы, в которой указаны первые три и последние три члена,
///а средние члены обозначены многоточием. Например, если последний член равен 25, то вывести: 1 + 2 + 3 +…+23 + 24 + 25.

/// </summary>
namespace A
{
    
    class Program
    {
        static void GetAns()
        {
            int sum = 0;
            for (int i = 0; sum < 1000; i++)
            {
                sum += i;
                if (sum < 100) continue;
                else if (sum % 10 == sum / 100 && sum % 10 == sum % 100 / 10)
                {
                    WriteLine(sum + " = 1 + 2 + 3 + ... +" + (i - 2) + " + " + (i - 1) + " + " + i);
                }
            }
        }
        static void Main(string[] args)
        {
            GetAns();
        }
    }
}
