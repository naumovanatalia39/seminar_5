int [] array = new int [9];
for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(100,1000);
}
Console.Write(string.Join(", ", array));
Console.WriteLine();
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        count ++;
    }
}
Console.WriteLine($"Количество чётных чисел в массиве {count}");
