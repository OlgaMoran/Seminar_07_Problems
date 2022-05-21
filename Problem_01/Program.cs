// Спирально заполнить двумерный массив

int[,] spiral = new int[5, 5];
int m = spiral.GetLength(0);
int n = spiral.GetLength(1);
int s = 1;

for (int j = 0; j < n; j++)
{
    spiral[0, j] = s;
    s++;
}

for (int i = 1; i < m; i++)
{
    spiral[i, n - 1] = s;
    s++;
}

for (int j = n - 2; j >= 0; j--)
{
    spiral[m - 1, j] = s;
    s++;
}

for (int i = m - 2; i > 0; i--)
{
    spiral[i, 0] = s;
    s++;
}

int x = 1;
int y = 1;

while (s < m * n)
{
    while (spiral[x, y + 1] == 0)
    {
        spiral[x, y] = s;
        s++;
        y++;
    }
    while (spiral[x + 1, y] == 0)
    {
        spiral[x, y] = s;
        s++;
        x++;
    }
    while (spiral[x, y - 1] == 0)
    {
        spiral[x, y] = s;
        s++;
        y--;
    }
    while (spiral[x - 1, y] == 0)
    {
        spiral[x, y] = s;
        s++;
        x--;
    }

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (spiral[i, y] == 0) spiral[i, y] = s;
        }
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (spiral[i, j] < n) Console.Write(spiral[i, j] + ",  ");
        else Console.Write(spiral[i, j] + ", ");
    }
    System.Console.WriteLine("");
}
