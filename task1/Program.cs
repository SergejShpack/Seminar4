//Задайте массив, заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.



Console.Write("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int counter = 0;

Console.Write("Массив, заполненный случайными положительными трёхзначными числами: ");


int[] array = new int[length];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 1000);
    Console.Write(array[i]); if (i < length - 1 ) Console.Write("; ");
    if (array[i] % 2 == 0) counter +=1;
}
Console.WriteLine("]"); Console.WriteLine("");
Console.Write("Количество чётных чисел в массиве: ");
Console.WriteLine(counter);
