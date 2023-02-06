// f (1) = 1
// f (2) = 1
// f (n) = f(n-1)+f(n-2)

// int Fibonachi(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonachi(n - 1) + Fibonachi(n - 2);
// }

// for (int i = 1; i < 10; i++)
// {
//     System.Console.WriteLine(Fibonachi(i));
// }


//Рекурсия с Фибоначи


decimal fRec = 0;
decimal fIte = 0;

decimal FibonachiRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonachiRecursion(n - 1) + FibonachiRecursion(n - 2);
}

decimal FibonachiIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;

        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}

Console.ReadLine();

DateTime dt = DateTime.Now;
for (int n = 10; n < 40; n++)
{
    System.Console.WriteLine($" FibonachiIteration({n}) = {FibonachiIteration(n)} fIte = {fIte.ToString("### ### ###"), -15}");
    fIte = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);


System.Console.WriteLine();
Console.ReadLine();
for (int n = 10; n < 40; n++)
{
    System.Console.WriteLine($" FibonachiRecursion({n}) = {FibonachiRecursion(n)} fRec = {fRec.ToString("### ### ###"), -15}");
    fRec = 0;

}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);



