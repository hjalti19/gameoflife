namespace GameOfLife
{
    public class Cell
    {
        public Cell(bool isAlive)
        {
            IsAlive = isAlive;
        }
        
        public bool IsAlive { get; private set; }

        public bool IsAliveInNextRound { private get; set; }

        public void MoveToNextRound()
        {
            IsAlive = IsAliveInNextRound;
        }
    }
}