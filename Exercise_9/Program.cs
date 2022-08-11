// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом второго.

Console.WriteLine("Пожалуйста, введите первое целое число и нажмите Enter");
string? numberString1 = Console.ReadLine()!;
int number1 = int.Parse(numberString1);

Console.WriteLine("Пожалуйста, введите первое целое число и нажмите Enter");
string? numberString2 = Console.ReadLine()!;
int number2 = int.Parse(numberString2);

int result1 = number1 * number1;
int result2 = number2 * number2;

if (result1 == number2||result2 == number1)
{
   Console.WriteLine("да");
}

else
{
    Console.WriteLine("нет");
}
 