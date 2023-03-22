// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GenerateMatrix(int m, int n)
{
 int[,] matrix = new int [m,n];
 Random rand = new Random();
 for (int i = 0; i < m; i++)
 {
    for (int j = 0; j < n; j++)
    {
      matrix[i,j]=rand.Next(0,10);   
    }
 }
 return matrix;
}
void SortToLower(int[,]  matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - 1; k++)
            {
                if (matr[i, k] < matr[i, k + 1])
                {
                    int temp = matr[i, k + 1];
                   matr[i, k + 1] = matr[i, k];
                    matr[i, k] = temp;
                }
            }
        }
    }
}
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}
int[,]matrix= GenerateMatrix(4,4);
PrintMatrix(matrix);
System.Console.WriteLine();
SortToLower(matrix);
PrintMatrix(matrix);