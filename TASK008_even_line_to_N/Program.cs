Console.Clear();

Console.WriteLine("Введите число: ");
string numberN = Console.ReadLine();
int N = int.Parse(numberN);

int i = 2;

while(i <= N)
{
    if(i % 2 == 0)
    {
        Console.Write(i);
        Console.Write(" ");
        i += 2;
    }
    
}

