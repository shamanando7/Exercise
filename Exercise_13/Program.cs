// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите число");
string? numberString = Console.ReadLine();
int x = int.Parse(numberString);
int index = 1;


while (x >=index)
{
  var result = Math.Pow(index, 2);
  index++;
  Console.WriteLine(result + " ");
  Console.WriteLine(" ");
}

if (x < 1)
  Console.WriteLine("Введены неверные значения");









