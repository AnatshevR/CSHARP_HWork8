// Частотный словарь для таблиц

//в конечном итоге привожу к двумерному массиву 
//в 1 строке число
//во 2 строке количество повторений
//в 3 строке соответственно %


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

int [] convert2to1(int [,] matr)
{
    int le = matr.GetLength(0) * matr.GetLength(1);
    int [] Smatrix = new int [le];
    int count = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j<matr.GetLength(1); j++)
        {
            Smatrix[count]= matr[i,j];
            count++;
        }
    }
    return Smatrix;

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
        Console.Write("{0,5}", Dmatr[i, j]);
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


Console.WriteLine("enter the amount of rows and columns of matrix");
int row = int.Parse(Console.ReadLine());
int column = int.Parse(Console.ReadLine());
int [,] matrix = new int[row,column];
FillArray(matrix);
Console.WriteLine();    
PrintArray (matrix);
Console.WriteLine();    
int [] SingleMatrix = convert2to1 (matrix);
sortArray(SingleMatrix);
double [,] FinalMatrix = finalarray (SingleMatrix);
printDouble(FinalMatrix);
printResult(FinalMatrix);






