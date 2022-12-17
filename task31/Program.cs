//метод для создания массива со случайными числами
int [] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int [length];
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return array;
}
// (int, int) - это возврат после работы функции:
// 1. сумма положительных элементов
// 2. сумма отрицательных элементов
(int, int) SumPositiveAndNegative (int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPositive += array[i]; // sumPositive = sumPositive + array[i]    
        }
        else
        {
            sumNegative += array[i];
        }
    }
    return ( sumPositive, sumNegative);
}

const int LENGTH = 12;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;
// int[] massive = GetRandomArray(12, -9, 9);
int [] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"{string.Join(", ", massive)}");
(int sumP, int sumN) = SumPositiveAndNegative(massive);
Console.WriteLine($"Сумма положительных элементов = {sumP}, отрицательных = {sumN}");