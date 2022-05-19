//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
int[] array = new int[8];
void FillArray(int[] array) // any name
{
    int length = array.Length;
    int index = 0;
    while(index < length)
    {
        array[index] = new Random().Next(0, 2);
        index++;
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
FillArray(array);
PrintArray(array);