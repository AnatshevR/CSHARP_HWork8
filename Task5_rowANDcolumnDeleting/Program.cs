// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

//создать рандомный массив
//распечатать массив
//найти наименьший элемент
//создать новый массив без строки и столбца
// распечатать получившийся масиив


void PrintArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} "); 
        }
         Console.WriteLine();      
    }
}

void FillArray(int [,] matr)
{
    Random random = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j<matr.GetLength(1); j++)
        {
            matr[i,j]= random.Next(10,100);
        }
    }
}

int FindMinRowInd (int [,] matr)
{
    int MinRowPos= 0;
    int MinValue= matr [0,0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j<matr.GetLength(1); j++)
        {
            if (matr[i,j] < MinValue) 
            {
                MinValue = matr [i,j];
                MinRowPos = i;
            }
        }
    }
    return MinRowPos;
}

int FindMinColumnInd (int [,] matr)
{
    int MinColumnPos= 0;
    int MinValue= matr [0,0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j<matr.GetLength(1); j++)
        {
            if (matr[i,j] < MinValue) 
            {
                MinValue = matr [i,j];
                MinColumnPos = j;
            }
        }
    }
    return MinColumnPos;
}

int [,] newArray (int [,] matr, int x, int y)
{
    int [,] ChangedArray = new int [matr.GetLength(0)-1,matr.GetLength(1)-1];
    for (int i = 0; i < matr.GetLength(0)-1; i++)
    {
        for(int j = 0; j<matr.GetLength(1)-1; j++)
        {
            if (i== x && j == y)
            {
                ChangedArray[i,j] = matr [i+1,j+1];
            }
            
            else if (i >=  x) 
            {
                ChangedArray[i,j] = matr[i+1,j];
            }
            else if (j >= y)
            {
                ChangedArray[i,j] = matr [i,j+1];
            }

            else 
            {
                ChangedArray[i,j] = matr [i,j];
            }
            
        }
    }
    return ChangedArray;
}

Console.WriteLine("enter the amount of rows and columns of matrix");
int row = int.Parse(Console.ReadLine());
int column = int.Parse(Console.ReadLine());
int [,] matrix = new int[row,column];
FillArray(matrix);
Console.WriteLine();    
PrintArray (matrix);
int RowInd = FindMinRowInd (matrix);
Console.WriteLine(RowInd);
int ColumnInd = FindMinColumnInd (matrix);
Console.WriteLine(ColumnInd); 
int [,] FinalArray= newArray(matrix,RowInd,ColumnInd);
PrintArray(FinalArray);

