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

void FindElementPosition(int[,] elementToFind, int result)
{
    Console.Write("Введи порядковый номер элемента: ");
    int serialNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("[ ]\t");
    const int startIndex = 65;
    for (int i = startIndex + 0; i < startIndex + elementToFind.GetLength(1); i++)
    {
        Console.Write($"[{((char)i)}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < elementToFind.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < elementToFind.GetLength(1); j++)
        {
            if (serialNumber == (i * elementToFind.GetLength(1) + j))
            {
                result = elementToFind[i, j];
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(elementToFind[i, j] + "\t");
                Console.ResetColor();
            }
            else
            {
                Console.Write(elementToFind[i, j] + "\t");
            }
        }
        Console.WriteLine();
    }
    if (serialNumber > (elementToFind.GetLength(0) * elementToFind.GetLength(1)) || serialNumber < 0)
    {
        Console.WriteLine("\n Ты явно ошибся...Тут нет элемента с таким порядковым номером.");
    }
    else
    {
        Console.WriteLine($"Число с порядковым номером {serialNumber}: {result}");
    }
}

Console.Clear();
Console.Write("Введи количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] randomArray = GetRandomArray(rows, columns);
int soughtFor = 0;
PrintArray(randomArray);
Console.WriteLine();
FindElementPosition(randomArray, soughtFor);