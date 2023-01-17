// Задача 4 * : Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// Не использовать строки для расчета.

int InputInt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number = InputInt("Введите число");
int a = number / 100;
int b = (number % 100) / 10;
int e = number % 10;

Console.WriteLine($"{a}{e}");
