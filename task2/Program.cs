//Определить, присутствует ли в заданном массиве, некоторое число

int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
void FillArray(int[] array) 
{
    int length = array.Length;
    int index = 0;
    while(index < length)
    {
        array[index] = new Random().Next(1, 100);

        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
//int[] array = new int[10];
//FillArray(array);
Console.WriteLine("Insert ur number");
int k = int.Parse(Console.ReadLine());
int count = array.Length;
int r = 0;
for (int  i = 0; i < count; i++)
{
    if(array[i] == k)
    {
        r++;
    }

}
if(r > 0)
{
    Console.WriteLine($"{k} is in array");
}
else
{
    Console.WriteLine($"{k} isnt in array");
}
//PrintArray(array);