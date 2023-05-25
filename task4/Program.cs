// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
if(firstNumber>secondNumber)
    if(firstNumber>thirdNumber)
        Console.WriteLine("max = "+firstNumber);
    else
        Console.WriteLine("max = "+thirdNumber);
else
    if(secondNumber>thirdNumber)
        Console.WriteLine("max = "+secondNumber);
    else
        Console.WriteLine("max = "+thirdNumber);