// В двумерном массиве целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

// void PrintArrayIfThereIsNoZero(int[,] matrix)
// {
//     int x = matrix.GetLength(0);
//     int y = matrix.GetLength(1);
//     for (int i = 0; i < x; i++)
//     {
//         for (int j = 0; j < y; j++)
//         {
//             {
//                 if (matrix[i, j] != 0)
//                 {
//                     if (matrix[i, j] < 10) Console.Write(matrix[i, j] + "  ");
//                     else Console.Write($"{matrix[i, j]} ");
//                 }
//             }
//         }
//         Console.WriteLine();
//     }

// }



// void FillArrayNotRepeatingNumbers(int[,] array, int count)
// {
//     int x = array.GetLength(0);
//     int y = array.GetLength(1);
//     if (count >= x * y)
//     {
//         int[] arr = new int[count];
//         int a = 0;
//        for (int i = 0; i < count; i++)
//         {
//             arr[i] = a + 1;
//             a++;
//         }
//         for (int i = 0; i < x; i++)
//         {
//             for (int j = 0; j < y; j++)
//             {
//                 for (int k = 0; k < count; k++)
//                 {
//                     int newRandomValue = new Random().Next(1, arr[count-1]);
//                     array[i, j] = newRandomValue;
//                     count--;
//                 }
//             }
//         }
//     }
//     else Console.WriteLine("Not enough numbers to fill the array. Enlarge the count or make the array smaller!");
// }


void FillArray(int[,] matrix)
{
    int x = matrix.GetLength(0);
    int y = matrix.GetLength(1);
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] matrix)
{
    int x = matrix.GetLength(0);
    int y = matrix.GetLength(1);
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int MinArray(int[,] array)
{
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    int min = array[0, 0];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            if (array[i, j] < min) min = array[i, j];
        }
    }
   return min;
}
System.Console.WriteLine();

int[,] myArray = new int[5, 5];
FillArray(myArray);
PrintArray(myArray);
MinArray(myArray);
