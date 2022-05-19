//Найти сумму чисел одномерного массива стоящих на нечетной позиции
int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int size = array.Length;
int res = 0;
for(int i = 0; i < size; i++)
{
    if(i % 2 != 0)
    {
        res = res + array [i];
        
    }
}
Console.WriteLine($"Result = {res}");
