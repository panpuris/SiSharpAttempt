
int Factorial(int n)//Для больших чисел необходимо использовать тип данных double 
{
    // 1! = 1
    // 0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
System.Console.WriteLine(Factorial(8));

for ( int i = 1; i < 20; i++)
{
    System.Console.WriteLine($"{i}! = {Factorial(i)}");
}

