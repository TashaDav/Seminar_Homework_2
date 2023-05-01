// Зачада №15
// Напишите программу, которая принимает на вход цифру, обозначающую день
// недели, и проверяет, является ли этот день выходным.

// 6 -> yes
// 7 -> yes
// 1 -> no

Console.WriteLine("Введите номер дня недели");
int number = int.Parse(Console.ReadLine()!);
if (number >= 1 && number <= 5)
{
    Console.WriteLine("Это не выходной день.");
}
else if (number >= 6 && number <= 7)
{
    Console.WriteLine("Сегодня выходной день, ура!");
}
else
{
    Console.WriteLine("Такого дня недели не существует.");
}