Console.Write("Введите число:");
int A = int.Parse(Console.ReadLine()!);
int B = 0;
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