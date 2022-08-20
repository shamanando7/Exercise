// Задайте массив из 12 элементов, заполненный случайными числами из промежутка (-9, 9).
// Найдите сумму отрицательных и пложительных элементов массива.

// Например, в массиве (3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6) 
// сумма положительных чисел равна 29, сумма отрицательных чисел равно - 20.
// В данной задаче будет лучше записать все не в одну функцию, а в несколько. 
// Какая-то функция создает массив, следующая функция считает сумму положительных чисел, другая отрицательных.


// Данная функция создает массив
int[] createArray()                              //массив целых чисел                 
{
    var random = new Random();

    var result = new int[12];            // жестко задано 12 элементов

    for (long i = 0; i < result.Length; i++)     // бежим по массиву в цикле с нулевого элемента по Length
    {
        result[i] = random.Next(-9, 10);  // каждый элемент массива нужно будет проинициализировать
    }

    return result;
}

// Далее пишем функции которые будут считать сумму положительных и отрицательных элементов  
int sumPositiveNumbers(int[] array) {            // принимает в себя массив
    var result = 0;

    for (long i = 0; i < array.Length; i++)      // бежим по элементам массива
    {
        if (array[i] > 0)                        // Проверяем что если текущий элемент положительный
            result += array[i];
    }

    return result;
}
int sumNegativeNumbers(int[] array)
{
    var result = 0;

    for (long i = 0; i < array.Length; i++)      // бежим по элементам массива
    {
        if (array[i] < 0)                        // Проверяем что если текущий элемент отрицательный
            result += array[i];
    }
 
    return result;
}


// Формат вывода в консоль
void printArray(int[] array) {                   // принимает в себя массив
     Console.Write("[");                         // как избавиться от запятой в конце? нужен if
     
    for (var i = 0; i < array.Length; i++) {     
        Console.Write(array[i]);

         if (i != array.Length - 1)                  //  проверяем что у нас не последний элемент, до последнего не идем поэтому -1
        Console.Write(", ");
         
     
    } 
     Console.Write("]");
     Console.WriteLine();
}


// Теперь нам понадобится сама программа

var array = createArray();

Console.WriteLine("Сгенерировали массив из 12 элементов в диапазоне от [-9, 9]:");

printArray(array);
     
     
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Сумма положительных чисел в массиве");
Console.WriteLine(sumPositiveNumbers(array));
Console.WriteLine();



Console.WriteLine("Сумма отрицательных чисел в массиве");
Console.WriteLine(sumNegativeNumbers(array));
Console.WriteLine();