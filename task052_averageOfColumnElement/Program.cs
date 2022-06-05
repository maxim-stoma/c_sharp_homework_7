int[,] GetRandomArray(int rowNumber, int colNumber)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(1, 100);
        }
    }
    return result;
}

void PrintArray(int[,] arrayToPrint)
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
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void ColumnAverage(int[,] averageNumber)
{

    Console.WriteLine();
    double sumOfColumnElements = 0;
    const int startIndex = 65;
    for (int j = 0; j < averageNumber.GetLength(1); j++)
    {
        int columnName = j + startIndex;
        for (int i = 0; i < averageNumber.GetLength(0); i++)
        {
            sumOfColumnElements += averageNumber[i, j];
        }
        Console.Write($"Среднее арифметическое элементов колонны [{((char)columnName)}]: ");
        Console.WriteLine(Math.Round(sumOfColumnElements / (averageNumber.GetLength(0)), 2));
        sumOfColumnElements = 0;
    }
}

Console.Clear();
Console.Write("Введи количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] randomArray = GetRandomArray(rows, columns);
PrintArray(randomArray);
ColumnAverage(randomArray);
Console.ReadLine();