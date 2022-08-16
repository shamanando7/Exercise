// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)

Console.WriteLine("Введите номер четверти");
string? numberstring = Console.ReadLine();
int number = int.Parse(numberstring!);

if (number > 4 || number < 1)
{
    Console.WriteLine("Неправильно введены данные");
    return;
}
else if (number == 1) Console.WriteLine("X от 0 до бесконечности и Y от 0 до бесконечности");
else if (number == 2) Console.WriteLine("X от 0 до минус бесконечности и Y от 0 до бесконечности");
else if (number == 3) Console.WriteLine("X от 0 до минус бесконечности и Y от 0 до минус бесконечности");
else if (number == 4) Console.WriteLine("X от 0 до бесконечности и Y от 0 до минус бесконечности");