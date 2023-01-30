// Напишите программу, которая на вход принимает число и выдает,
// является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.WriteLine("Введите число : ");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberN %2==0)
{
    System.Console.WriteLine("Введено четное число");
}
else
{
    System.Console.WriteLine("Введено нечетное число");
}
