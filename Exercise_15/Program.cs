// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А

// 7 -> 28 
// 4 -> 10
// 8 -> 36


int SumFrom1ToA(int a) {                         // здесь функция объявляется
    int result = 0;
    
    for (var i = 0; i <= a; i++)                 // for (инициализатор(счетчик цикла); условие; итератор (шаг) {тело (выполняемые операторы)}
         result += i;                            // while(условие)
                                                 // {оператор (операторы)}
    return result;                               // тут возвращается готовый result
}                                           


var number = int.Parse (Console.ReadLine()!);     // у нас есть число и сумма чисел до него, считываем (защита от дурака)
if (number <= 0)
    return;                                      

var result = SumFrom1ToA(number);                 // функция вызывается здесь

Console.WriteLine(result);



// class Programm                                       // пример задачи для демонстрации работы цикла
// {
//     static void Main(string[]args)
//     {
//         for (int i = 0; i <= 10; i++)
//         Console.WriteLine(i);
//     }}
    



