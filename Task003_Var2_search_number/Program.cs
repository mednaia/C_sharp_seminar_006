// В двумерном массиве показать позицию числа, заданного пользователем или указать, что такого элемента нет
void PrintMatrix(int[,] matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
            Console.Write($"{matrix[i,j]} ");
    Console.WriteLine();
    }
}
int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows,columns];
    var random = new Random();
    for(int i=0;i<rows;i++)
        for(int j=0;j<columns;j++)
            matrix[i,j] = random.Next(minValue,maxValue);
    return matrix;
}
// int[]? IndexOf(int[,] matrix, int value)
// {
//     for(int i=0; i<matrix.GetLength(0);i++)
//         for(int j=0; j<matrix.GetLength(0);j++)
//             if(matrix[i,j]==value)
//                 return new int[2] {i,j};
//     return null;
// }
(int,int)? IndexOf(int[,] matrix, int value)
{
    for(int i=0; i<matrix.GetLength(0);i++)
        for(int j=0; j<matrix.GetLength(0);j++)
            if(matrix[i,j]==value)
                return (i,j);
    return null;
}
Console.Write("Enter amount of matrix rows: ");
int rows = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter amount of matrix columns: ");
int columns = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter left side of matrix columns: ");
int start = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Enter right side of matrix columns: ");
int finish = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = CreateMatrix(rows,columns,start,finish);
Console.WriteLine("Your matrix: ");
PrintMatrix(matrix);
Console.Write("Enter value to find in matrix: ");
int value = int.Parse(Console.ReadLine() ?? "0");
(int,int)? position = IndexOf(matrix,value);
// if(position==null)
//     Console.Write("There is no value in matrix.");
// else
//     Console.Write($"Position of element: {position.Value.Item1}  {position.Value.Item2}.");
Console.Write(position !=null 
? $"Position of element: {position.Value.Item1}  {position.Value.Item2}." 
: "There is no value in matrix.");
