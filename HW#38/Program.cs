// Задайте массив с вещественными числами
//Найдите разницу между максимальным и минимальным элементами массива
//[3.5,7.1,22.9,2.3,78.5]->76.2]

double[] CreateArrayRndDouble(int size)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
//array[i] = rand.NextDouble()*100;
    array[i] = rand.Next(-100,100)+rand.NextDouble();
    return array;
}
double[] arr  = CreateArrayRndDouble(8);
void PrintArray(double[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
    {
       if (i < array.Length-1) 
    {
       Console.Write("{0:F1}",array[i] );
       Console.Write("  ");
    }
    else Console.Write("{0:F1}", array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}
PrintArray(arr);
// метод нахождения максимального и минимального чисел в массиве

double MinMaxArray(double[] array)
{
double max = arr[0];
double min = arr[0];
for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i] > max) max = arr[i];
       if (arr[i] < min) min = arr[i];
   } 
//Console.WriteLine("Максимальное число в массиве: {0:F1}", max);
//Console.WriteLine("Минимальное число в массиве: {0:F1}", min);
//for (int i = 0; i < 2; i++)
//    {
//   result[0] = max;
//    result[1] = min;
//   }
//    return result;
//return max;
//return min;
double sum = max - min;
return sum;
}
//double[] arr2  = MinMaxArray(arr);
//PrintArray(arr2);
Console.WriteLine("Разница между максимальным и минимальным элементами в массиве: {0:F1}", MinMaxArray(arr));