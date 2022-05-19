//Посчитать количество вхождений элемента в массив
int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 4, 1, 2, 5, 67, 123, 2};
Console.WriteLine("Insert ur number");
int number = int.Parse(Console.ReadLine());
int count = array.Length;
int any = 0;
for (int  i = 0; i < count; i++)
{
    if(array[i] == number)
    {
        any++; 
    }

}
if(any > 0)
{
    Console.WriteLine($"{number} is in array {any} times");
}
else
{
    Console.WriteLine($"{number} isnt in array");
}