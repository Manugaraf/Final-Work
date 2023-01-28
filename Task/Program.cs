Console.Write("Введите кол-во сколько будет элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Введите {i + 1} элемент: ");
    array[i] = Convert.ToString(Console.ReadLine());
}

Console.WriteLine();
for (int j = 0; j < n; j++)
{
    int m = 3;
    int element = array[j].Length;
    if (element <= m)
    {
        Console.Write($"{array[j]} ");
    } 
}
