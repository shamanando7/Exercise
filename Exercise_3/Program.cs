// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> "-2, -1, 0, 1, 2"

Console.WriteLine("Введите число и нажмите Enter"); // тут читается число

string numberString = Console.ReadLine()!;
int number = int.Parse(numberString);

if (number < 0)
    number *= (-1); // сначала умножаем, потом присваиваем, тоже самое что и number = number * (-1), т.е мы number умножаем на -1 и потом сохраняем number

// Console.WriteLine(number);

int i = number * (-1); 

while (i<=number) {
    Console.WriteLine(i++);
}


 









//int i = number *(-1);

//while (i<=number)
//{
  //  Console.WriteLine(i);
   // i+= 1;
//}






                            