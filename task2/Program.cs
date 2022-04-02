//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]


int[] num_array=new int[123];

Console.WriteLine(" Введите диапозон массива: ");

int array_range = Convert.ToInt16(Console.ReadLine());

int count=0;

   for(int i=0;i<123; i++)
{
num_array[i]=new Random().Next(array_range);
Console.Write("["+num_array[i]+"] ");
    
    if (num_array[i] <100 && num_array[i]>9) count++;
}
Console.WriteLine("");
Console.Write(count+" числа/чисел из отрезка [10,99] в массиве.");
