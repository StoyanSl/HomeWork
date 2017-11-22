using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        List<List<long>> matrix = new List<List<long>>();
        var matrixSpec = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
        MatrixFilling(matrix, matrixSpec);
        var targetCell = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int targetRow = targetCell[0];
        int targetCol = targetCell[1];
        long sum = 0;
        long targetCellValue = matrix[targetRow][targetCol];
        for (int i = targetRow-1; i <= targetRow+1; i++)
        {
            for (int j = targetCol - 1; j<= targetCol + 1; j++)
            {
                sum += matrix[i][j];
            }
        }
        sum -= matrix[targetRow][targetCol];
        matrix[targetRow][targetCol] = matrix[targetRow][targetCol] * sum;
        for (int i = targetRow - 1; i <= targetRow + 1; i++)
        {
            for (int j = targetCol - 1; j <= targetCol + 1; j++)
            {
                if (!(i==targetRow&&j==targetCol))
                {
                    matrix[i][j] = matrix[i][j] * targetCellValue;
                }
                
            }
        }
        foreach (var row in matrix)
        {
            Console.WriteLine(string.Join(" ",row));
        }
    }
    
    private static void MatrixFilling(List<List<long>> matrix, List<long> matrixSpec)
    {
        for (int i = 0; i < matrixSpec[0]; i++)
        {
            var inputNumbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            matrix.Add(inputNumbers);
        }
    }
}

