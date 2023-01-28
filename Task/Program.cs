Console.Write("Введите кол-во сколько будет элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Введите {i + 1} элемент: ");
    array[i] = Convert.ToString(Console.ReadLine());
}
