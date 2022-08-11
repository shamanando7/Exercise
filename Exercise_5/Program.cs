// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа. 


Random random = new Random();

int randomNumber = random.Next(10, 99);

Console.WriteLine(randomNumber);

int firstDigit = randomNumber % 10; // % остаток от целого числа

int secondDigit = randomNumber / 10;

if (firstDigit > secondDigit)

   Console.WriteLine(firstDigit);

else
   Console.WriteLine(secondDigit); 


   //Нам нужно будет посчитать первую цифру в числе и вторую цифру в числе.
   // firstdigit получаем либо 0 либо 9, т.е считаем младший разряд.
   // Соответственно младший разряд это остаток от деления на 10. Если делим 19 на 10, у нас в остатке 9, если 11 на 10, в остатке 1. 
   // secondDigit это старший разряд числа