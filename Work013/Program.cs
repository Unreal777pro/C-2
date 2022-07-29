//программа задает массив из 8 элементов и выводит их на экран



int [] randomArray = FillArrayRandomly(8,-100,100);
PrintArray(randomArray);


int[] FillArrayRandomly(int numberOfElements, int minValue = 0, int maxValue = 10)
{
    int[] array = new int[numberOfElements]; 
    int i =0;
    for (i = 0; i < numberOfElements; i++)
    {
        array[i] = new Random().Next(minValue,maxValue + 1);
    }
    return array;
}


void PrintArray(int[] array)
{
    int i = 0;
    
    
    Console.WriteLine();   
    
    for (i= 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    
    Console.WriteLine();   
}