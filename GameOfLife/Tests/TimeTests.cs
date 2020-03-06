using GameOfLife;
using Xunit;

namespace Tests
{
    public class TimeTests
    {
        [Fact]
        public void DeadCellWithThreeNeighboursComesAlive()
        {
            bool alive = Time.IsAliveInNextRound(false, 3);

            Assert.True(alive);
        }

        [Fact]
        public void DeadCellWithFewerThanThreeNeighboursStaysDead()
        {
            bool alive = Time.IsAliveInNextRound(false, 2);
            
            Assert.False(alive);
        }
    }
}