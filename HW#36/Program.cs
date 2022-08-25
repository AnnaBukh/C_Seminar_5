// Задайте одномерный массив, 
//заполненный случаными числами
//Найдите сумму элементов, стоящих на нечетных позициях
// (позции массива 1,3,5.. без 0)
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
int[] arr  = CreateArrayRndInt(7, 1, 20);
PrintArray(arr);
int Sum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)//цикл с "1", шаг = 2 м
    {
        sum = sum + array[i];
    }
    return sum;
}
Console.Write("Сумма элементов в массиве, стоящих на нечетных позициях: ");
Console.WriteLine(Sum(arr));