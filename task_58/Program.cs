int[,] CreateArrayFirst(int m, int n)
{
    int[,] numbers1 = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            numbers1[i, j] = new Random().Next(1, 10);
            Console.Write(numbers1[i, j] + " \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return numbers1;
}

int[,] CreateArraySecond(int m, int n)
{
    int[,] numbers2 = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            numbers2[i, j] = new Random().Next(1, 10);
            Console.Write(numbers2[i, j] + " \t");
        }
        Console.WriteLine();
    }
    return numbers2;
}

void PrintArray(int[,] numbers1, int[,] numbers2)
{
    Console.WriteLine();
    int[,] result = new int[numbers1.GetLength(0), numbers1.GetLength(1)];
    for (int i = 0; i < numbers1.GetLength(0); i++)
        {
            for(int j = 0; j < numbers1.GetLength(1); j++)
            {
                result[i, j] = numbers1[i, j] * numbers2[i, j];
                Console.Write(result[i, j] + " \t");
            }
            Console.WriteLine();
        }
}


PrintArray(CreateArrayFirst(4, 4), CreateArraySecond(4, 4));