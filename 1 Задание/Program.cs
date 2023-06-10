//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine()!);
int max = 0;
if ( a > b)
{
    Console.Write("Большее число = ");
    Console.Write( max = a );
}
else
{
    Console.Write("Большее число = ");
    Console.WriteLine( max = b);
}


