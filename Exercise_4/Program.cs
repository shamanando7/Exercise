// Программа которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите трехзначное число");
string numberString = Console.ReadLine()!;
int number1 = int.Parse(numberString);

int number2 = number1 - ((number1 / 10) * 10); // либо короче записать int number2 = number1 %10;

Console.WriteLine(number2);