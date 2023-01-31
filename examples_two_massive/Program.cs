
string[,] table = new string[2, 5];
// table [0,1] table [0,1] table [0,2] table [0,3] table [0,4] 1 строка 
// table [1,0] table [1,1] table [1,2] table [1,3] table [1,4] 2 строка
table[1, 2] = "слово";
for (int rows = 0; rows < 2; rows++)
{
    for (int colums = 0; colums < 5; colums++)
    {
        System.Console.Write($"-{table[rows, colums]}-");
    }
    System.Console.WriteLine();
}

// int[,] matrix = new int[3, 4];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         System.Console.Write($"{matrix[i, j]} ");
//     }
//     System.Console.WriteLine();
// }

// описание метода для создание матрицы

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }

}

void FillArray(int [,] matr)
{
    for (int i = 0;i<matr.GetLength(0);i++)
    {
        for (int j = 0;j<matr.GetLength(1);j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    }
}


int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);