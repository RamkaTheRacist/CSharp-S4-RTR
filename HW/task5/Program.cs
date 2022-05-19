//Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.WriteLine("How much numbers wanna see?");
int choose = int.Parse(Console.ReadLine());
int[] array = new int[choose];
void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while(index < length)
    {
        array[index] = new Random().Next(1000);
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
//PrintArray(array);
int count1 = 0;
int count2 = array.Length - 1;
int any = 0;
if(array.Length % 2 == 0)
{
    while((count1 <= array.Length / 2) && (count2 >= array.Length / 2))
    {
    any = array[count1] * array[count2];
    Console.WriteLine();
    Console.WriteLine($"{array[count1]} * {array[count2]} = {any}");
    count1++;
    count2--;
    }
}
else
{
    while((count1 != array.Length / 2) && (count2 != array.Length / 2))
    {
    any = array[count1] * array[count2];
    Console.WriteLine();
    Console.WriteLine($"{array[count1]} * {array[count2]} = {any}");
    count1++;
    count2--;
    }  
}