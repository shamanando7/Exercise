﻿// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] CreateArray()                                   // фунция создающая массив
{

    int[] array = new int[8];

    var random = new Random();

    for (int i = 0; i < 8; i++)
        array[i] = random.Next(0, 2);
    return array;
}

var array = CreateArray();                           // выводим функцию на экран

for (int i = 0; i < 8; i++)
    Console.Write(array[i]);



