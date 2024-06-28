using System;

class Program
{
    static void Main()
    {
        // Создаем и заполняем двумерный массив
        int[,] array = new int[5, 5];
        Random rand = new Random();

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rand.Next(-100, 101); // случайное число от -100 до 100
            }
        }

        // Выводим массив на экран
        Console.WriteLine("Массив:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j],5}");
            }
            Console.WriteLine();
        }

        // Находим минимальный и максимальный элементы массива и их позиции
        int minElement = array[0, 0];
        int maxElement = array[0, 0];
        int minIndex = 0, maxIndex = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < minElement)
                {
                    minElement = array[i, j];
                    minIndex = i * array.GetLength(1) + j;
                }
                if (array[i, j] > maxElement)
                {
                    maxElement = array[i, j];
                    maxIndex = i * array.GetLength(1) + j;
                }
            }
        }

        // Вычисляем сумму элементов между минимальным и максимальным элементами
        int startIndex = Math.Min(minIndex, maxIndex);
        int endIndex = Math.Max(minIndex, maxIndex);
        int sum = 0;

        for (int k = startIndex; k <= endIndex; k++)
        {
            int row = k / array.GetLength(1);
            int col = k % array.GetLength(1);
            sum += array[row, col];
        }

        // Выводим результаты
        Console.WriteLine($"\nМинимальный элемент: {minElement}");
        Console.WriteLine($"Максимальный элемент: {maxElement}");
        Console.WriteLine($"Сумма элементов между минимальным и максимальным (включительно): {sum}");
    }
}