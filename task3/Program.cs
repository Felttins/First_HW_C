Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);
if (A % 2 == 1)
{
    Console.WriteLine($"Число {A}, - не чётное");
}
else
{
    Console.WriteLine($"Число {A}, - чётное");
}