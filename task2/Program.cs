Console.Write("Введите число 1:");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2:");
int B = int.Parse(Console.ReadLine()!);
if (A > B)
{
    Console.WriteLine($"Максимальное число: {A}, Минимальное число: {B}");
}
else
{
    Console.WriteLine($"Максимальное число: {B}, Минимальное число: {A}");
}