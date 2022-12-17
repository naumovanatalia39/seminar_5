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

int[] ReversMassive(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return (array);
}

const int LENGTH = 12;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;
int [] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"Первоначальный массив {string.Join(" ,",massive)}");
int [] newMassive = ReversMassive(massive);
Console.WriteLine($"Массив с перевернутыми числами {string.Join(" ,",newMassive)}");