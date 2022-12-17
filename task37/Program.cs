int[] array = {1,2,3,4,5};
int count = 1;
if(array.Length % 2 == 0)
{
    count = array.Length / 2;
}
else
{
    count = array.Length / 2 + 1;
}
int[] array2 = new int [count]; // int[] array2 = new int[array.Length / 2 + array.Length % 2]

for(int i = 0; i < array2.Length; i++)
{
    array2[i] = array[i] * array[array.Length - 1 - i];
    if(i == array.Length -i -1)
    {
        array2[i] = array[i];
    }
}
Console.WriteLine(string.Join(", ",array2));