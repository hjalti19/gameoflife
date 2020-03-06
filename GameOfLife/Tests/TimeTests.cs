using GameOfLife;
using Xunit;

namespace Tests
{
    public class TimeTests
    {
        [Fact]
        public void DeadCellWithThreeNeighboursComesAlive()
        {
            var alive = Time.IsAliveInNextRound(false, 3);

            Assert.True(alive);
        }        
    }
}