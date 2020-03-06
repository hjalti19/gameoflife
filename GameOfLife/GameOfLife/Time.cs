namespace GameOfLife
{
    public class Time
    {
        private readonly World world;

        public Time(World world)
        {
            this.world = world;
        }

        public static bool IsAliveInNextRound(bool alive, int neighbours)
        {
            if (neighbours == 3)
            {
                return true;
            }

            return alive && neighbours == 2;
        }
    }
}