// Задача 29: Напишиите программу, которая задает массиив из 8 элементов и выводит их на экран.
// Например:
// 1,2,5,7,19 -> [1,2,5,7,19]
// 6,1,33 -> [6,1,33]


System.Console.WriteLine("Введите длину массива");
int arrayLength = Convert.ToInt32(Console.ReadLine());

int[] array = new int[arrayLength];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random(). Next(0, 100);
    System.Console.Write(array[i]+ " ");
}