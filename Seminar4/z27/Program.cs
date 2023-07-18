// Задача 27: Напишите программу, которая  принимает на вход чсло и выдает сумму цифр в числе.
// Например:
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int sum = 0;

while(num>0)
{
    int num1 = num % 10;
    num = num / 10;
    sum = sum + num1;
}

System.Console.WriteLine(sum);