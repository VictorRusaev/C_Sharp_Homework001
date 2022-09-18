Console.Clear();

Console.WriteLine("Введите число: ");
string A = Console.ReadLine();
int numberA = int.Parse(A);

if (numberA % 2 == 0) Console.WriteLine("Чётное");
else Console.WriteLine("Нечётное");