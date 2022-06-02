// В двумерном массиве n×k заменить четные элементы на противоположные
void FillArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(-100,101);
        }
    }
}
//--------------------------------------------------------------------------------------------+
void ChangeEvenElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                if(array[i,j]%2 == 0) array[i,j] = -array[i,j];
            }
    }
}
//--------------------------------------------------------------------------------------------+
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
    Console.WriteLine();
    }
}

Console.Write("Input the number of strings of array: ");
int n = int.Parse(Console.ReadLine()??"0");
Console.Write("Input the number of columns of array: ");
int k = int.Parse(Console.ReadLine()??"0");
int[,]array = new int[n,k];

FillArray(array);
PrintArray(array);
Console.WriteLine();
ChangeEvenElements(array);
PrintArray(array);
