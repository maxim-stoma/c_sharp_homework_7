double[,] GetRandomArray(int rowNumber, int colNumber, double deviation)
{
    double[,] result = new double[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().NextDouble() * (2 * deviation) - deviation;
        }
    }
    return result;
}

void PrintArray(double[,] arrayToPrint)
{
    Console.Write("[ ]\t");
    const int startIndex = 65;
    for (int i = startIndex + 0; i < startIndex + arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{((char)i)}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(Math.Round(arrayToPrint[i,j], 2) + "\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введи количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи диапазон для рандома: ");
int range = Convert.ToInt32(Console.ReadLine());

double[,] randomArray = GetRandomArray(rows, columns, range);
PrintArray(randomArray);