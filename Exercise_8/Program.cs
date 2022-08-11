// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число");
string? numberString1 = Console.ReadLine()!;
int number1 = int.Parse(numberString1);

int x = 7;
int y = 23;

if (number1%x==0 && number1%y==0) 

{
    Console.WriteLine("да");
}

else 
{
    Console.WriteLine("нет");
}


// мое творение. 