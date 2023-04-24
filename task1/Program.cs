Console.Write("Введите число 1: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
int B = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 3: ");
int C = int.Parse(Console.ReadLine()!);
if (A > B)
{
    if (A > C)
    {
        Console.WriteLine(A);
    }
}
else
    {
        if (B > C)
        {
            Console.WriteLine(B);
        }
        else
        {
            Console.WriteLine("Максимальное число = " ,C );
        }
    }