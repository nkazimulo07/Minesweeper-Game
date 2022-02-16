using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class CountMines
    {
        public int FindMines(string[,] grid, int row, int column, int count)
        {
            var mine = "*";

            for (int x = Math.Max(0, row - 1); x <= Math.Min(row + 1, grid.GetLength(0)); x++)
            {
                for (int y = Math.Max(0, column - 1); y <= Math.Min(column + 1, grid.GetLength(1)); y++)
                {
                    if (x >= 0 && y >= 0 && x < grid.GetLength(0) && y < grid.GetLength(1))
                    {
                        if (x != row || y != column)
                        {
                            if (grid[x, y] == mine )
                            {
                                count++;
                            }
                        }
                    }
                }
            }

            return count;
        }
    }
}
