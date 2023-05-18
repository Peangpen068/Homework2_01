using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of rows for Pascal's triangle: ");
        int numRows;

        while (!int.TryParse(Console.ReadLine(), out numRows) || numRows < 0)
        {
            Console.WriteLine("Invalid Pascal's triangle row number. Please enter a non-negative integer.");
            Console.Write("Enter the number of rows for Pascal's triangle: ");
        }

        Console.WriteLine("Pascal's triangle:");
        for (int i = 0; i <= numRows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                int coef = CalculateCoefficient(i, j);
                Console.Write(coef + " ");
            }
            Console.WriteLine();
        }
    }

    static int CalculateCoefficient(int row, int column)
    {
        if (column == 0 || column == row)
            return 1;
        else
            return CalculateCoefficient(row - 1, column - 1) + CalculateCoefficient(row - 1, column);
    }
}
