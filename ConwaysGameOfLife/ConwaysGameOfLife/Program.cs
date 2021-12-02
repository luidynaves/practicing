using System;
using System.Collections.Generic;

namespace ConwaysGameOfLife
{
    class Program
    {
        static List<int[]> NEIGHBOURS = new List<int[]>
        {
            new int[] { -1,  0 }, //north
            new int[] { -1,  1 }, //northeast
            new int[] {  0,  1 }, //east
            new int[] {  1,  1 }, //southeast
            new int[] {  1,  0 }, //south
            new int[] {  1, -1 }, //southwest
            new int[] {  0, -1 }, //west
            new int[] { -1, -1 }, //northwest
        };

        static bool[,] _grid;
        static int _rows;
        static int _cols;

        static void Main(string[] args)
        {
            _rows = 5;
            _cols = 5;
            _grid = CreateGrid(_rows, _cols);

            PrintGrid(_rows, _cols);

            while (true)
            {
                for (int row = 0; row < _rows; row++)
                {
                    for (int col = 0; col < _cols; col++)
                    {
                        _grid[row, col] = IsCellLives(row, col);
                    }
                }

                PrintGrid(_rows, _cols);
            }
        }

        private static void PrintGrid(int rows, int cols)
        {
            Console.WriteLine("====================================");

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"  {_grid[row, col]}");
                }

                Console.WriteLine("");
            }

            Console.WriteLine("====================================");
        }

        static bool IsCellLives(int row, int col)
        {
            int neighboursNumber = 0;
            bool currentCell = _grid[row, col];

            foreach (var neighbour in NEIGHBOURS)
            {
                int neighbourRow = neighbour[0] + row;
                int neighbourCol = neighbour[1] + col;

                if (neighbourRow < 0 || neighbourRow > _rows - 1)
                    continue;

                if (neighbourCol < 0 || neighbourCol > _cols - 1)
                    continue;

                if (_grid[neighbourRow, neighbourCol])
                    neighboursNumber++;
            }

            if (currentCell && neighboursNumber < 2)
                return false;

            if (currentCell && neighboursNumber <= 3)
                return true;

            if (currentCell && neighboursNumber > 3)
                return false;

            if (!currentCell && neighboursNumber == 3)
                return true;

            return true;
        }

        static bool[,] CreateGrid(int rows, int cols)
        {
            bool[,] grid = new bool[rows, cols];

            var random = new Random();

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    grid[row, col] = random.Next(2) == 1;
                }
            }

            return grid;
        }
    }
}
