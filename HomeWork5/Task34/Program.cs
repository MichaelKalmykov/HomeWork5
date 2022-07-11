void PrintArray (int [] Array)
{
    for (int i = 0; i < Array.Length; i++)
   {  
        Console.Write($" {Array[i]} ");
    }
}

int [] Array = new int [5];
int NumEven = 0;
for (int i = 0; i < Array.Length ; i++)
{
    Array[i] = new Random().Next(100, 1000);
    if (Array[i] % 2==0)
    {
        NumEven++;
    }
        
} 

Console.Write("Случайный массив:");
PrintArray(Array);
Console.Write("  Количество чётных элементов: " + NumEven );
