// Частотный словарь для одномерного массива (версия 2)
// задачи 1) применить методы
// 2) применить генератор псевдослучайных чисел

void PrintArray(int [] matr)
{
    for (int i = 0; i < matr.Length; i++)
    {
       Console.Write($"{matr[i]} ");       
    }
     Console.WriteLine();
}

void FillArray(int [] matr)
{
    Random random = new Random();
    for (int i = 0; i < matr.Length; i++)
    {
        matr[i]= random.Next(1,100);
    }
}

int [] sortArray(int [] matr)
{
        for (int i = 0; i < matr.Length; i++)
        {
            int minposition = i;
            for (int l = i;l<matr.Length;l++)
            {
                if( matr[l]<matr[i]) 
                {
                    minposition = l;
                    int tempo = matr [i];
                    matr [i] = matr [minposition];
                    matr [minposition] = tempo;
                }
            }
        }
        return matr;
}

double [,] finalarray(int [] matr)
{
    double [,] fArray = new double [3,matr.Length];
    for (int i = 0; i < matr.Length; i++)
    {
        int count = 0;
        double freq = 0;
        if(i==0 || matr[i]!=matr[i-1])
        { 
            for (int l = i;l<matr.Length;l++)
        
            {
                if( matr[i]==matr[l]) 
                {
                    count++;
                }
            }
            double a = count;
            double b = matr.Length;
            freq = Math.Round((a/b) * 100, 3);
            fArray[0,i] = matr[i];
            fArray[1,i] = count;
            fArray[2,i] = freq;
            //Console.WriteLine( array[i] + " is met " + count + " times" + "Frequency is: " + freq + "%");
        }
       
    } 
    return fArray;  
}
void printDouble(double [,] Dmatr)
{
for (int i = 0; i < Dmatr.GetLength(0); i++)
{
    for (int j = 0; j < Dmatr.GetLength(1); j++)
    {
        Console.Write("{0,4}", Dmatr[i, j]);
    }
    Console.WriteLine();
}
}

void printResult (double [,] matr)
{
   for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i,j]!=0) Console.WriteLine( matr[i,j] + " is met " + matr[1,j] + " times" + "Frequency is: " + matr[2,j] + "%");
        }
        //Console.WriteLine();
    }
} 


Console.WriteLine("enter the legth of matrix");
int le = int.Parse(Console.ReadLine());
int [] matrix = new int[le];
FillArray(matrix);
PrintArray (matrix);
sortArray(matrix);
PrintArray(matrix);
double [,] FinalMatrix = finalarray (matrix);
printDouble(FinalMatrix);
printResult(FinalMatrix);



// Console.WriteLine(string.Join ("*", array ));

