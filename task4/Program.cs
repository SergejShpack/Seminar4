
//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новом массиве.


int[] GetNewNatArray(int array_size,int array_range)
{
    int[] num_array=new int[array_size];
       for(int i=0;i<array_size; i++)
        {
        num_array[i]=new Random().Next(array_range);
        Console.Write("["+num_array[i]+"] ");
        }
    Console.WriteLine("");        
         return  num_array; 
}

Console.WriteLine("Введите размер массива: ");

int user_size = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Введите диапозон массива: ");

int user_range = Convert.ToInt16(Console.ReadLine());

int[] user_array=GetNewNatArray(user_size,user_range);

int[] mult_array= new int[user_size/2+1]; 

Console.WriteLine("Произведение пар чисел: ");
    for(int i=0;i<(user_size/2); i++)
{
    mult_array[i]=user_array[i]*user_array[user_size-1-i];
    Console.Write("["+ mult_array[i]+"] ");
}
     if ((user_size%2)!=0) 
{
    mult_array[user_size/2]=user_array[user_size/2];
    Console.WriteLine($"[{mult_array[user_size/2]}] ");
}    