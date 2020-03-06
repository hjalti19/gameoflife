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
            return true;
        }
    }
}