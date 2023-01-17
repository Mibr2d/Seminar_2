// Задача 2: Напишите программу, которая выводит третью 
// цифру заданного числа или сообщает, что третьей цифры 
// нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6
int InputInt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = InputInt("Введите целое  число");
if (number > 99 && number < 1000)
{
    int result = number%10;
    Console.WriteLine("Последняя цифра числа равна " + result);
}
else 
{
    Console.WriteLine("Третьей цифры нет ");
}
