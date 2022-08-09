// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.WriteLine("Пожалуйста, введите первое целое число и нажмите Enter");

string? numberString1 = Console.ReadLine()!;

int number1 = int.Parse(numberString1);

Console.WriteLine("Пожалуйста, введите второе целое число и нажмите Enter");

string? numberString2 = Console.ReadLine()!;

int number2 = int.Parse(numberString2);

if (number1 == number2 / number1)

{
   Console.WriteLine("да");
}

else
{
    Console.WriteLine("нет");
}
 
