//Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
int[] array = new int[12];
void FillArray(int[] array) // any name
{
    int length = array.Length;
    int index = 0;
    while(index < length)
    {
        array[index] = new Random().Next(0, 10);
        index++;
    }
}
FillArray(array);
int sum = 0;
for(int i = 0; i < array.Length; i++)
{
    sum = sum + array[i];
}
Console.WriteLine($"Result is {sum}");