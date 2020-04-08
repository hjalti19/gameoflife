using System;

namespace GameOfLife
{
    public class World
    {
        private readonly Cell[,] _plain;

        public World(Cell[,] plain)
        {
            this._plain = plain;
        }

        public static bool IsAliveInNextRound(bool alive, int neighbours)
        {
            if (neighbours == 3)
            {
                return true;
            }

            return alive && neighbours == 2;
        }

        public void CalculateNextRound()
        {
            for (int i = 0; i < _plain.GetLength(0); i++)
            {
                for (int j = 0; j < _plain.GetLength(1); j++)
                {
                    int neighbours = GetNeighbours(i, j);
                    bool isAliveNextRound = IsAliveInNextRound(_plain[i, j].IsAlive, neighbours);
                    _plain[i, j].IsAliveInNextRound = isAliveNextRound;
                }
            }
        }

        public void MoveToNextRound()
        {
            foreach (Cell cell in _plain)
            {
                cell.MoveToNextRound();
            }
        }

        private int GetNeighbours(int x, int y)
        {
            int neighbours = 0;
            
            for (int i = Math.Max(0, x - 1); i < Math.Min(_plain.GetLength(0), x + 2); i++)
            {
                for (int j = Math.Max(0, y - 1); j < Math.Min(_plain.GetLength(1), y + 2); j++)
                {
                    if (_plain[i, j].IsAlive && !(i == x && j == y))
                    {
                        neighbours++;
                    }
                }
            }

            return neighbours;
        }
    }
}