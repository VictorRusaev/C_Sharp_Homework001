Console.Clear();

Console.WriteLine("Введите первое число: ");
string A = Console.ReadLine();
int numberA = int.Parse(A);

Console.WriteLine("Введите второе число: ");
string B = Console.ReadLine();
int numberB = int.Parse(B);

Console.WriteLine("Введите третье число: ");
string C = Console.ReadLine();
int numberC = int.Parse(C);

int max = numberA;

if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.WriteLine(max);
