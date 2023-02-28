Console.Clear();
Console.WriteLine("Введите длину массива");
int size = int.Parse(Console.ReadLine());
int[] Array(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 150);
    }
    return result;
}
int Kolichestvo(int[] Array)
{
    int a = 0;
    for(int i = 0; i < Array.Length; i++)
    {
        if(Array[i] >= 10 && Array[i] <= 99) a++;
    }
    return a; 
}
int[] mass = Array(size);
int n = Kolichestvo(mass);
Console.WriteLine($"В данном массиве в заданном отрезке лежит {n} элементов");