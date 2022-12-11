/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
Ограничения:
- Должна быть отдельная функция, которая возвразает результат суммы цифр
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода
*/
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine(Sum(number));
int Sum(int number)
{
    int array = Convert.ToString(number).Length;
    int totalresult = 0;

    for (int i = 0; i < array; i++)
    {
        int result = number - number % 10;
        totalresult += (number - result);
        number = number / 10;
    }
    return totalresult;
}

