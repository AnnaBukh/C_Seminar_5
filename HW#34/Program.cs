// Задача 34. Задайте массив, заполненный 
//случайными положительными трехзначными числами.
//Напишите программу, которая покажет 
//количество четных числе в массиве
//[345,897,568,234]->2
int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random(); // не обеспечивает уникальности чисел в массиве

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
} 
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length-1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}
int[] arr  = CreateArrayRndInt(6, 100, 1000);
PrintArray(arr);
int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0 ) count++;
    }
    return count;
}
Console.Write("Количество четных числе в массиве: ");
Console.WriteLine(Count(arr));