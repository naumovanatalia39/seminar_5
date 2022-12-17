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

void FindCount (int[] array, int minRange, int maxRange)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= minRange && array[i] <= maxRange)
        {
         count ++;
        }
    }
    Console.WriteLine($"Количество чисел от 10 до 99: {count}");
}

const int LENGTH = 123;
const int LEFTRANGE = 0;
const int RIGHTRANGE = 150;
int [] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"{string.Join(", ", massive)}");
Console.WriteLine();
FindCount(massive, 10, 99);