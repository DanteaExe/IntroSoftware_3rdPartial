using static System.Console;

List<List<int>> matr1 = new List<List<int>>
        {
            new List<int> {1, 3, 2},
            new List<int> {4, 3, 5},
            new List<int> {2, 1, 0}
        };

List<List<int>> matr2 = new List<List<int>>
        {
            new List<int> {4, 2, 1},
            new List<int> {3, 3, 0},
            new List<int> {4, 5, 1}
        };

List<List<int>> result = new List<List<int>>();
string? option;

do
{
    ShowMenu();
    option = ReadLine();

    switch (option)
    {
        case "1":
            result = Multiply2Matrices(matr1, matr2, result);
            PrintMatrix(result);
            break;
        case "2":
            WriteLine("Add rows of matrix: ");
            int rows = int.Parse(ReadLine());
            WriteLine("Add columns of matrix :");
            int columns = int.Parse(ReadLine());

            matr1 = ReadMatrix(rows, columns);

            matr2 = ReadMatrix(columns, rows);
            result = Multiply2Matrices(matr1, matr2, result);
            PrintMatrix(result);
            break;
        case "3":
            WriteLine("byeeeeeee");
            break;
        default:
            WriteLine("that's not a valid option, try a valid one.");
            break;
    }

    WriteLine();
} while (option != "3");


List<List<int>> Multiply2Matrices(List<List<int>> matr1, List<List<int>> matr2, List<List<int>> result)
{
    result.Clear();

    for (int i = 0; i < matr1.Count; i++)
    {
        result.Add(new List<int>());
        for (int j = 0; j < matr2[0].Count; j++)
        {
            result[i].Add(0);
        }
    }

    for (int i = 0; i < matr1.Count; i++)
    {
        for (int j = 0; j < matr2[0].Count; j++)
        {
            for (int k = 0; k < matr2.Count; k++)
            {
                result[i][j] += matr1[i][k] * matr2[k][j];
            }
        }
    }

    return result;
}

void PrintMatrix(List<List<int>> matr)
{
    for (int i = 0; i < matr.Count; i++)
    {
        for (int j = 0; j < matr[i].Count; j++)
        {
            Write(matr[i][j] + " ");
        }
        WriteLine();
    }
}

List<List<int>> ReadMatrix(int filas, int columnas)
{
    List<List<int>> matriz = new List<List<int>>();

    for (int i = 0; i < filas; i++)
    {
        matriz.Add(new List<int>());
        for (int j = 0; j < columnas; j++)
        {
            WriteLine($"Add element: [{i}][{j}]:");
            int elemento = int.Parse(ReadLine());
            matriz[i].Add(elemento);
        }
    }

    return matriz;
}

void ShowMenu()
{
    WriteLine("Choose an option:");
    WriteLine("1. Multuply matrix (static)");
    WriteLine("2. Multuply matix (dynamic)");
    WriteLine("3. Exit");
}