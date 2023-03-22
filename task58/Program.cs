// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
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

int[,] firstMartrix = GenerateMatrix(3,3);
Console.WriteLine($"Первая матрица:");
PrintMatrix(firstMartrix);

int[,] secomdMartrix = GenerateMatrix(3,3);;
Console.WriteLine($"Вторая матрица:");
PrintMatrix(secomdMartrix);

int[,] resultMatrix = GenerateMatrix(3,3);

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintMatrix(resultMatrix);