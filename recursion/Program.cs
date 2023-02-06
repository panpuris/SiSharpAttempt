
// Сравнение методов итеративных и рекурсии.
// написание от 1 до 10 
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return String.Empty;
}


// написание от 10 до 1
string NumbersFors(int a, int b)
{
    string result = String.Empty;
    for (int i = b; i >= a; i--)
    {
        result += $"{i} ";
    }
    return result;
}



string NumbersRip(int a, int b)
{
    if (a <= b) return NumbersRip(a + 1, b) + $"{a} ";
    else return String.Empty;
}
System.Console.WriteLine(NumbersFor(1, 10));
System.Console.WriteLine(NumbersRec(1, 10));
System.Console.WriteLine(NumbersFors(1, 10));
System.Console.WriteLine(NumbersRip(1, 10));


// сумма чисел от 1 до n

int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;

}

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

System.Console.WriteLine(SumFor(55));
System.Console.WriteLine(SumRec(55));

// Поиск значения факториала
int Factorial(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}

int FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n - 1);
}

System.Console.WriteLine(Factorial(5));
System.Console.WriteLine(FactorialRec(5));

// Вычисление числа A в степени N

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= a;
    }
    return result;
}

System.Console.WriteLine(PowerFor(2, 10));


int PowerRec(int a, int n)
{
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
}
System.Console.WriteLine(PowerRec(2, 10));

int PowerRecMath (int a, int n)
{
    if (n == 0 ) return 1;
    else if (n%2 == 0) return PowerRecMath(a*a,n/2);
    else return PowerRecMath(a,n-1)*a;

}
System.Console.WriteLine(PowerRecMath(2,10));


// Работа с символами

char [] s = {'а', 'и', 'с', 'в'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)

{
    for (int j = 0; j<count;j++)
    {
        System.Console.WriteLine($"{n++, -5}{s[i]}{s[j]}");
    }
    
}//здесь понадобиться новый цикл for для каждой последующей буквы

void FindWords (string alphabet, char [] word, int length = 0)
{
    if (length == word.Length)
    {
        System.Console.WriteLine($"{n++} {new String(word)}");
        return;
    }

    for (int i=0;i<alphabet.Length;i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet,word,length+1);
    }
}
FindWords("аисв", new char[5]);
