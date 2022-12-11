/* Напишите программу, которая принимает на вход числа n, min, max. 
Затем генерирует массив размером n и заполняет его случайными числами в диапазоне от min до max.
5, 1, 19 -> [1, 2, 5, 7, 19]
3, 1, 33 -> [6, 1, 33]
*/
Console.Write("Введите N: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Введите MIN число: ");
int numberMin = int.Parse(Console.ReadLine()!);
Console.Write("Введите MAX число: ");
int numberMax = int.Parse(Console.ReadLine()!);

int[] array = new int[number];
Mass(array);
PrintArray(array);

int[] Mass(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(numberMin, numberMax);
    }
    return arr;
}
void PrintArray(int[] ar)
{
    int count = ar.Length;
    
    for (int j = 0; j < count; j++)
    {
        Console.WriteLine(ar[j]);
    }
}