﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number%2==0)
    Console.WriteLine("Да (четное)");
else
    Console.WriteLine("Нет (нечетное)");
