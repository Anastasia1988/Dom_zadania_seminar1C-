// Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число С: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA < numberB && numberC < numberB )
{
    System.Console.WriteLine("max = " +  numberB);
}
else if(numberA > numberB && numberA > numberC)
{
    System.Console.Write("max = " +  numberA);
}
else if (numberC > numberB && numberC > numberA)
{
    System.Console.Write("max = " +  numberC);
}
else 
{
    System.Console.Write("Введены равные числа");
}