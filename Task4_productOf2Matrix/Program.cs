// Найти произведение двух матриц


        void PrintArray(int[,] matr)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Console.Write($"{matr[i, j]} ");
                }
                Console.WriteLine();
            }
        }

static int NewMethod(int[,] matrix1, int[,] matrix2, int i, int j, int count, int summ)
{
    summ = summ + ((matrix1[i, j + count]) * (matrix2[i + count, j]));
    return summ;
}

void FillArray(int[,] matr)
        {
            Random random = new Random();
            for (int i = 0; i < matr.GetLength(0); i++)
            {

                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = random.Next(10);
                }
            }
        }

Console.Write("enter amount of rows in 1 array: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("enter amount of columns in 1 array: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] matrix1 = new int[rows, columns];
FillArray(matrix1);
PrintArray(matrix1);

Console.Write("enter amount of rows in 2 array: ");
int rows2 = int.Parse(Console.ReadLine()!);
Console.Write("enter amount of columns in 2 array: ");
int columns2 = int.Parse(Console.ReadLine()!);

int[,] matrix2 = new int[rows2, columns2];
FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine("magic happens...");


int [,] productMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
if (matrix1.GetLength(1) != matrix1.GetLength(0))
{
    Console.WriteLine(" product of this two matrix is impossible");

}
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < productMatrix.GetLength(1); j++)
    {
        productMatrix[i,j] = 0;
        for (int k = 0; k< matrix1.GetLength(1); k++)
        {
            productMatrix[i,j] += matrix1[i,k] * matrix2[k,j];
        }
                        
    }
}
PrintArray(productMatrix);
 