Console.Clear();
Console.WriteLine("Введите длину массива");
int size = int.Parse(Console.ReadLine());
int[] Array(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-9, 9);
    }
    return result;
}
int [] Zamena(int[] Array)
{
    for (int i = 0; i < size; i++)
    Array[i] = Array[i] * -1;
    return Array;
}
int[] mass = Array(size);
Console.WriteLine(String.Join(" ", mass));
Console.WriteLine(String.Join(" ", Zamena(mass)));