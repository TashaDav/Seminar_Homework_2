// Задача №13
// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
int B = 0;
if (A > 99 && A < 1000)
{
    B = A % 10;
    Console.WriteLine(B);
}
else if (A / 1000 > 0 && A / 1000 < 10)
{
    B = (A % 100)/10;
    Console.WriteLine(B);
}
else if (A / 1000 > 10 && A / 1000 < 10)
{
    A = (A % 1000)/100;
    Console.WriteLine(A);
}
else if (A / 1000 > 100 && A / 1000 < 1000)
{
    B = (A % 10000)/1000;
    Console.WriteLine(B);

}
else
{
    Console.WriteLine("Третьей цифры нет");
}
