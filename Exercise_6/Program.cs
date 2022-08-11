//  Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


Random random = new Random();

int randomNumber = random.Next(000, 1000);

Console.WriteLine("Cлучайное трехзначное число " + randomNumber); // 355

int firstDigit = randomNumber / 10; // 35
int secondDigit = firstDigit % 10; // 5
int thirdDigit = randomNumber % 10;

int firstDigit2 = firstDigit / 10;
int finishNumber = firstDigit2;
int finishNumber2 = thirdDigit;



Console.WriteLine("решение " + finishNumber + finishNumber2 );


// мое творение.