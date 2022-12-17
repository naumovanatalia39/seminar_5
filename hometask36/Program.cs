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

const int LENGTH = 12;
const int LEFTRANGE = -50;
const int RIGHTRANGE = 150;
int [] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"{string.Join(", ", massive)}");
int sum = 0;
for(int i = 1; i < massive.Length; i += 2 )
{
    sum += massive[i];
}
Console.WriteLine($"Сумма элементов, находящихся на нечетных позициях равна {sum}");