// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления. 

Console.WriteLine("Введите первое число");
string? numberString1 = Console.ReadLine()!;
int number1 = int.Parse(numberString1);

Console.WriteLine("Введите второе число");
string? numberString2 = Console.ReadLine()!;
int number2 = int.Parse(numberString2);

int result = number2%number1;



if (number2%number1==0)

{
    Console.WriteLine("кратно");
}

else 
{
    Console.WriteLine("не кратно, остаток " + result );
}

// мое творение.
