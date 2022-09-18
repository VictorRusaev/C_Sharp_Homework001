Console.Clear();

Console.WriteLine("Введите первое число: ");
string A = Console.ReadLine();
int numberA = int.Parse(A);

Console.WriteLine("Введите второе число: ");
string B = Console.ReadLine();
int numberB = int.Parse(B);

if(numberB > numberA) Console.WriteLine(numberB);
else
{
    Console.WriteLine(numberA);
}