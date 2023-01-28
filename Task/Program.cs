Console.Write("Введите кол-во сколько будет элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Введите {i + 1} элемент: ");
    array[i] = Convert.ToString(Console.ReadLine());
}

Console.WriteLine();
string[] arrayTwo = new string[n];
int m = 3;
int sum = 0;
for (int j = 0; j < n; j++)
{
    int element = array[j].Length;
    if (element <= m)
    {
        arrayTwo[sum] = array[j];
        sum++;
    } 
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
PrintArray(arrayTwo);
