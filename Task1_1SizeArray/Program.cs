// Частотный словарь для одномерного массива (версия 1)


int [] array = {5,65,125,45,78,111111,66,2,1,5,7,1,1,1,1,1,};
Console.WriteLine(string.Join ("*", array ));

    for (int i = 0; i < array.Length; i++)
    {
        int minposition = i;
        for (int l = i;l<array.Length;l++)
            {
                if( array[l]<array[i]) 
                {
                    minposition = l;
                     int tempo = array [i];
                    array [i] = array [minposition];
                     array [minposition] = tempo;
                }
            }
       
    }
Console.WriteLine(string.Join ("*", array ));

    for (int i = 0; i < array.Length; i++)
    {
        int count = 0;
        double freq = 0;
        if(i==0 || array[i]!=array[i-1])
        { 
            for (int l = i;l<array.Length;l++)
        
            {
                if( array[i]==array[l]) 
                {
                    count++;
                }
            }
            double a = count;
            double b = array.Length;
            freq = Math.Round((a/b) * 100, 3);
            Console.WriteLine( array[i] + " is met " + count + " times" + "Frequency is: " + freq + "%");
        }
       
    }
