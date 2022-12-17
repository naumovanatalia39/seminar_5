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

const int LENGTH = 7;
const int LEFTRANGE = 1;
const int RIGHTRANGE = 150;
int [] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"{string.Join(", ", massive)}");

int min = massive[0];
int max = massive[1];
for(int i = 0; i < massive.Length; i++)
{
    if(massive[i] > max)
    {
        max = massive[i];
    }
    else if(massive[i] < min)
    {
        min = massive[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {max -min}");