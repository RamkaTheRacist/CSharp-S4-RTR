//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
//Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] array = new int[123];
void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while(index < length)
    {
        array[index] = new Random().Next(1000); //чтоб хоть как-то работало
        index++;
    }
}
FillArray(array);
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 9 && array[i] < 100) count++;
}
Console.WriteLine($"{count} numbers from 10 to 99 in array");