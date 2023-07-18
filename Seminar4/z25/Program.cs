// Задача 25. Напишите цикл, который принимает на вход два числа (A  и  B) и выводит число A в натуральную степень B.
// Например:
// 3, 5 -> 243
// 2, 4 -> 16


System.Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());

int result = a;
while(b<0)
{
    System.Console.WriteLine("Введите положительное число");
    b = Convert.ToInt32(Console.ReadLine());
}
for (int i = 1; i < b; i++)
{
    result = result * a;
}

System.Console.WriteLine(result);
