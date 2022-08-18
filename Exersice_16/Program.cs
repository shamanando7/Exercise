// // Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N

// long ProizFrom1toN(long n)
// {

//     long result = 1;

//     for (long i = 1; i <= n; i++)
//         result *= i;                                                // тоже самое result = result * i

//     return result;
// }

// Console.WriteLine("Введите ваше число");                            // Вводим число
// long number = long.Parse(Console.ReadLine()!);                        // С помощью Console.ReadLine считываем число, с помощью TryParse мы это число парсим. 

// if (number <= 0)

//     return;

// long result = ProizFrom1toN(number);                                 // В этой строке происходит вызов функции

// Console.WriteLine();
// Console.WriteLine(result);



// мое творение, все работает. 













long Factorial(long num)
{
    var result = 1L;

    for (long i = 1; i <= num; i++)
    {
        result *= i;
    }

    return result;
}

Console.WriteLine("Программа, которая принимает на вход число N и выдаёт произведение чисел от 1 до N");

for (; ; )
{
    Console.WriteLine("Введите ваше число: ");
    Console.WriteLine("Для выхода введите Y ");

    var inputString = Console.ReadLine()!;

    if (inputString.Equals("Y"));
        break;

    if (long.TryParse(inputString, out var number))
    {
        if (number < 0)
        {    Console.WriteLine("Число не должно быть отрицательным");
            continue;
        }
        var result = Factorial(number);

        Console.WriteLine(result);

    }
    else
    {
        Console.WriteLine("Введено не число или слишком большое число!");
    }
}