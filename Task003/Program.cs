// Задача 3: Напишите программу, которая принимает на 
// вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет


int InputInt(string message)
{
    Console.WriteLine(message);
    int dayOfWeek = Convert.ToInt32(Console.ReadLine());
    return dayOfWeek;
}
int dayOfWeek = InputInt("Введите число обозначающее день недели");
int dayOfWeeKSunday = 7;
int dayOfWeekSaturday = 6;
if (dayOfWeek < dayOfWeekSaturday && dayOfWeek <= dayOfWeeKSunday)
{
    Console.WriteLine("Рабочий день");

}
else
{
    if (dayOfWeek>dayOfWeeKSunday)
    {
        Console.WriteLine("Нет такого дня недели");
    }
    else
    {
        Console.WriteLine("Выходной день");
    }
}