using System;
class Program
{
    static void Main()
    {
        int num = Readnum();
        Console.WriteLine("Pascal's Triangle:");
        for (int i = 0; i <= num; i++)
        {
            for (int j = 0; j <= i; j++)
                Console.Write(CalculatePascalValue(i, j) + " ");

            Console.WriteLine();
        }
    }
    static int Readnum()
    {
        int num;
        while (!int.TryParse(Console.ReadLine(), out num) || num < 0)
            Console.WriteLine("Invalid Pascal's triangle row number.\nEnter the Pascal's triangle row number again: ");
        return num;
    }
    static int CalculatePascalValue(int row, int column)
    {
        return (column == 0 || column == row) ? 1 : CalculatePascalValue(row - 1, column - 1) + CalculatePascalValue(row - 1, column);
    }
}