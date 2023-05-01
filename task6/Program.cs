Console.Clear();
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0)
    Console.WriteLine($"{n} -> да ");
else
    Console.WriteLine($"{n} -> нет ");