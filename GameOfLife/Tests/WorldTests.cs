using GameOfLife;
using Xunit;

namespace Tests
{
    public class WorldTests
    {
        [Fact]
        public void DeadCellWithThreeNeighboursComesAlive()
        {
            bool alive = World.IsAliveInNextRound(false, 3);

            Assert.True(alive);
        }

        [Fact]
        public void DeadCellWithFewerThanThreeNeighboursStaysDead()
        {
            bool alive = World.IsAliveInNextRound(false, 2);
            
            Assert.False(alive);
        }

        [Fact]
        public void DeadCellWithMoreThanThreeNeighboursStaysDead()
        {
            bool alive = World.IsAliveInNextRound(false, 4);

            Assert.False(alive);
        }

        [Fact]
        public void AliveCellWithThreeNeighboursStaysAlive()
        {
            bool alive = World.IsAliveInNextRound(true, 3);

            Assert.True(alive);
        }

        [Fact]
        public void AliveCellWithTwoNeighboursStaysAlive()
        {
            bool alive = World.IsAliveInNextRound(true, 2);

            Assert.True(alive);
        }

        [Fact]
        public void AliveCellWithFewerThanTwoNeighboursDies()
        {
            bool alive = World.IsAliveInNextRound(true, 1);

            Assert.False(alive);
        }

        [Fact]
        public void AliveCellWithMoreThanThreeNeighboursDies()
        {
            bool alive = World.IsAliveInNextRound(true, 4);

            Assert.False(alive);
        }
    }
}