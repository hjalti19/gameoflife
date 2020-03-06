using System.Runtime.CompilerServices;
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

        [Fact]
        public void DeadCellWithMoreThanThreeNeighboursStaysDead()
        {
            bool alive = Time.IsAliveInNextRound(false, 4);

            Assert.False(alive);
        }

        [Fact]
        public void AliveCellWithThreeNeighboursStaysAlive()
        {
            bool alive = Time.IsAliveInNextRound(true, 3);

            Assert.True(alive);
        }

        [Fact]
        public void AliveCellWithTwoNeighboursStaysAlive()
        {
            bool alive = Time.IsAliveInNextRound(true, 2);

            Assert.True(alive);
        }

        [Fact]
        public void AliveCellWithFewerThanTwoNeighboursDies()
        {
            bool alive = Time.IsAliveInNextRound(true, 1);

            Assert.False(alive);
        }

        [Fact]
        public void AliveCellWithMoreThanThreeNeighboursDies()
        {
            bool alive = Time.IsAliveInNextRound(true, 4);

            Assert.False(alive);
        }
    }
}