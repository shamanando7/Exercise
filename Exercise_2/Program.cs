// Напишите программу, которая будет выдавать название дня недели по заданному номеру.


Console.WriteLine("Введите номер дня недели");
string? numberString1 = Console.ReadLine ();
int number1= int.Parse (numberString1);

if (number1==1)  //условие
{
   Console.WriteLine ("Понедельник");
}

else if (number1==2)  //условие
{
   Console.WriteLine ("Вторник");
}

else if (number1==3)  //условие
{
   Console.WriteLine ("Среда");
}

else if (number1==4)  //условие
{
   Console.WriteLine ("Четверг");
}

else if (number1==5)  //условие
{
   Console.WriteLine ("Пятница");
}


else if (number1==6)  //условие
{
   Console.WriteLine ("Суббота");
}

else if (number1==7)  //условие
{
   Console.WriteLine ("Воскресенье");
}

else 
{
    Console.WriteLine ("Неверно введены данные");
}