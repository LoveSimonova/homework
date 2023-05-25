// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = 2;
while (number2<=number)
{
    Console.Write(number2+" ");
    number2+=2;
}
