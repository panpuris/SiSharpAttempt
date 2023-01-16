// f(x) = x**2 + 1
// double f (double x)
// {
//     double result = x * x + 1;
//     return result
// }

//стихийный проект
// int a = 146;
// int b = 145;
// int c = 112;
// int a1 = 144;
// int b1 = 333;
// int c1 = 111;
// int a2 = 222;
// int b2 = 321;
// int c2 = 1203;
// int max = a;
// if (max < b) max = b1;
// if (max < c) max = c;

// if (max < a1) max = a1;
// if (max < b1) max = b1;
// if (max < c1) max = c1;

// if (max < a2) max = a2;
// if (max < b2) max = b2;
// if (max < c2) max = c2;

// System.Console.WriteLine(max);


// метод с функцией

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 146;
int b1 = 1111;
int c1 = 112;
int a2 = 144;
int b2 = 56125;
int c2 = 111;
int a3 = 222;
int b3 = 324531;
int c3 = 111;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max_a = Max(max1, max2, max3);
int max_a = Max (
    Max (a1,b1,c1),
    Max (a2,b2,c2),
    Max (a3,b3,c3)
);


System.Console.WriteLine(max_a);



