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

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


void FindNumber(int[] array, int number)
{
    bool find = false;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == number)
        {
            find = true;
        }
    }
    if (find == true)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("Нет");
    }

}

const int LENGTH = 12;
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;
int [] massive = GetRandomArray(LENGTH, LEFTRANGE, RIGHTRANGE);
Console.WriteLine($"{string.Join(" ,",massive)}");
int a = ReadInt("Введите число");
FindNumber(massive, a);

