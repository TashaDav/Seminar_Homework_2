// Напишите программу, которая принимает на вход трехзначное число и на выходе
// показывет ВТОРУЮ цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите техзначное число");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 100 & a < 1000)
{
    Console.WriteLine(a % 100 / 10);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}

// ЭТОЛОННОЕ РЕШЕНИЕ, ПОКА НЕ ПОНЯТНОЕ ДЛЯ МЕНЯ (!!!РЗОБРАТЬСЯ!!!)
// int Prompt (string message)
// {
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// int number = Prompt("Введите трехзначное число > ");
// if (number < 100 || number >=1000)
// {
//     Console.WriteLine("Вы ввели не трехзначное число, пожалуйст повторите ввод");
//         return;
// }
// Console.WriteLine($"Введите число '{number}'");
// int secondRank = number / 10 % 10;
// Console.WriteLine($"Вторая цифра '{secondRank}'");