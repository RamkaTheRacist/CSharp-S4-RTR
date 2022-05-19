//Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
Console.WriteLine("How much numbers wanna see?");
int choose = int.Parse(Console.ReadLine());
int[] array = new int[choose];
void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while(index < length)
    {
        array[index] = new Random().Next(100, 1000);
        index++;
    }
}
int countEven = 0;
int countOdd = 0;
FillArray(array);
for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0) countEven++;
    else countOdd++;
}
Console.WriteLine($"Even number in array is {countEven}, odd is {countOdd}");
