// В двумерном массиве показать позицию числа, заданного пользователем или указать, что такого элемента нет
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

void SearchNumberInArray(int[,] array)
{
    Console.Write("Input the number: ");
    int n = int.Parse(Console.ReadLine()??"0");
    int check = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] == n)
            {
                Console.WriteLine($"Number {n} is in the array on [{i},{j}] position.");
                check=1;
            }
                
        }
    }
    if (check==0) Console.WriteLine($"Number {n} isn't in the array.");
}

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
SearchNumberInArray(array);


