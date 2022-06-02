// Показать двумерный массив размером m×n заполненный целыми числами
Console.Write("Input the number of strings of array: ");
int m = int.Parse(Console.ReadLine()??"0");
Console.Write("Input the number of columns of array: ");
int n = int.Parse(Console.ReadLine()??"0");
int[,]array = new int[m,n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(-10,10); //[1,10)
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine(); 
}
