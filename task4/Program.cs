//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double[] array = {1, 2, 3, 4, 5, 55, 6, 7, 8, 9, 10};
double size = array.Length;
double min = array[0];
double max = array[0];
for(int i = 0; i < size; i++)
{
    if(min > array[i])
    {
        min = array[i];
    }
    if(max < array[i])
    {
        max = array[i];
    }
}
double res = max - min;
Console.WriteLine($"Result is {res}");
