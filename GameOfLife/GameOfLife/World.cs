namespace GameOfLife
{
    public class World
    {
        private readonly Cell[][] plain;

        public World(Cell[][] plain)
        {
            this.plain = plain;
        }
    }
}