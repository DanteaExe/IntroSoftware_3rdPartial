using static System.Console;

List<List<int>> matr1 = new()
{
    new List<int> {1, 3, 2},
    new List<int> {4, 3, 5},
    new List<int> {2, 1, 0}
};

List<List<int>> matr2 = new()
{
    new List<int> {4, 2, 1},
    new List<int> {3, 3, 0},
    new List<int> {4, 5, 1}
};

List<List<int>> result = new();


result = Multply2Matriz(matr1, matr2, result);

PrintMatriz(result);

List<List<int>> Multply2Matriz(List<List<int>> matr1, List<List<int>> matr2, List<List<int>> result)
{
    for (int i = 0; i < matr1.Count; i++)
    {
        result.Add(new List<int>());
        for (int j = 0; j < matr2.Count; j++)
        {
            result[i].Add(0);
        }
    }

    for (int i = 0; i < matr1.Count; i++)
    {
        for (int j = 0; j < matr2.Count; j++)
        {
            for (int k = 0; k < matr1.Count; k++)
            {
                result[i][j] += matr1[i][k] * matr2[k][j];
            }
        }
    }
    return result;
}

void PrintMatriz(List<List<int>> matr)
{
    for (int i = 0; i < matr.Count; i++)
    {
        for (int j = 0; j < matr2[0].Count; j++)
        {
            Write(result[i][j] + " ");
        }
        WriteLine();
    }
}