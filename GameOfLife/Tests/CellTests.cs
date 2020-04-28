using GameOfLife;
using Xunit;

namespace Tests
{
    public class CellTests
    {
        [Fact]
        public void ConstructDeadCell()
        {
            var cell = new Cell(false);
            
            Assert.False(cell.IsAlive);
        }

        [Fact]
        public void ConstructLiveCell()
        {
            var cell = new Cell(true);
            
            Assert.True(cell.IsAlive);
        }

        [Fact]
        public void MoveFromDeadToDead()
        {
            var cell = new Cell(false) { IsAliveInNextRound = false };

            cell.MoveToNextRound();
            
            Assert.False(cell.IsAlive);
        }

        [Fact]
        public void MoveFromDeadToAlive()
        {
            var cell = new Cell(false) { IsAliveInNextRound = true };

            cell.MoveToNextRound();
            
            Assert.True(cell.IsAlive);
        }

        [Fact]
        public void MoveFromAliveToDead()
        {
            var cell = new Cell(true) { IsAliveInNextRound = false };

            cell.MoveToNextRound();
            
            Assert.False(cell.IsAlive);
        }

        [Fact]
        public void MoveFromAliveToAlive()
        {
            var cell = new Cell(true) { IsAliveInNextRound = true };

            cell.MoveToNextRound();
            
            Assert.True(cell.IsAlive);
        }
    }
}

