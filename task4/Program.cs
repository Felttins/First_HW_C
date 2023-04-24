Console.Write("Введите число:");
int A = int.Parse(Console.ReadLine()!);
int B = 1;
while (A != B)
{
    if ( B % 2 ==0 )
    {
       Console.Write(B + " ");
       B++;
    }
    else
    {
        B++;
    }
}