namespace GameOfLife
{
    public class Time
    {
        private readonly World _world;

        public Time(World world)
        {
            this._world = world;
        }

        public void Tick()
        {
            _world.CalculateNextRound();
            _world.MoveToNextRound();
        }
    }
}