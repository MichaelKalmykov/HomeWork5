void PrintArray (int [] Array)
{
    for (int i = 0; i < Array.Length; i++)
   {  
        Console.Write($" {Array[i]} ");
    }
}
int [] Array = new int [5];
int summ = 0;
for (int i = 0; i < Array.Length ; i++)
{
    Array[i] = new Random().Next(0, 101);
    if (Array[i] % 2==1)
    {
        summ += Array[i];
    }      
} 

Console.Write("Случайный массив:");
PrintArray(Array);
Console.Write("Сумма всех нечётных элементов этого массива: " + summ);

