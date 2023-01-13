// Задача 60. 
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GetMatrix (int firstDimension, int secondDimension, int thirdDimension)
{
    int number = 0;
    Random rnd = new Random();
    char[] numbers = new char[90];
    int[,,] matrix = new int[firstDimension, secondDimension, thirdDimension];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                while (true)
                {
                    number = rnd.Next(10, 100);
                    if (numbers[number - 10] != '*')
                    {
                        numbers[number - 10] = '*';
                        break;
                    }
                }
                matrix[i, j, k] = number;
            }
        }
    }
    return matrix;
}

void ShowMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(2); l++)
            {
                Console.Write($"{matrix[i,j,l]}({i},{j},{l})  ");
            }
            Console.WriteLine();
        }
    }
}

int firstDimension = 3;
int secondDimension = 3;
int thirdDimension = 3;
int[,,] matrix = GetMatrix (firstDimension,secondDimension,thirdDimension);
ShowMatrix(matrix);