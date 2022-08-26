// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/* 
Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();

void Palindrome(string number)
{
    for (int i = 0; i<number.Length / 2; i++)
        if (number[i] != number[number.Length - 1 - i]){
           System.Console.WriteLine("Введеное число НЕ является Палиндромом");
        }
        System.Console.WriteLine("Введеное число Является Палиндромом");
}

if (number!.Length == 5){
  Palindrome(number);
}
else Console.WriteLine("Введи пятизнаячное число");
 */




 //Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/* double GetRange (int xa, int ya, int za, int xb, int yb, int zb){
    return Math.Round(Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((ya - yb),2) + Math.Pow((za-zb),2)),2);
 }

System.Console.WriteLine(GetRange(7, -5, 0, 1, -1, 9)); */




// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/* void GetNumber(int n) 
{
    for (int i = 1; i <= n; i++) {
        System.Console.WriteLine((Math.Pow((i),3)) + " ");
    }
}
GetNumber(5); */