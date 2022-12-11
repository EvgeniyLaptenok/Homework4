/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
Ограничения:
- Нельзя использовать класс Math
- Должна быть отдельная функция Power, которая возвразает результат
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода
*/
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

int total = Exponentiation(number1, number2);
Console.WriteLine("Результат: " + total);
int Exponentiation(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result *= num1;
    }
    return result;
}