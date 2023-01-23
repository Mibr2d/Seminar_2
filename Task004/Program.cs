// Задача 4 * : Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// Не использовать строки для расчета.

// int InputInt(string message)
// {
//     Console.WriteLine(message);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }
// int number = InputInt("Введите число");
// int a = number / 100;
// int b = (number % 100) / 10;
// int e = number % 10;

// Console.WriteLine($"{a}{e}");



//Убрать из случайного трехзначного числа вторую цифру
int RandomInt()
{
    Random rnd = new Random();
    return rnd.Next(100, 1000);
}

int number = RandomInt();
int rank1=number %10;
int rank2=number %100;
int result=rank2*10+rank1;
System.Console.WriteLine($"Изначальное число{number}, результат {result}");
