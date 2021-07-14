using System;
using System.Collections.Generic;
using System.Linq;

namespace Store
{
    public class Warehouse
    {
        private readonly List<Cell> _cells;

        public IReadOnlyCollection<IReadOnlyCell> Cells => _cells;

        public Warehouse()
        {
            _cells = new List<Cell>();
        }

        public void Delive(Good good, int count)
        {
            var newCell = new Cell(good, count);

            var cell = _cells.FirstOrDefault(c => c.Good.Equals(good));

            if (cell == null)
                _cells.Add(newCell);
            else
                cell.Merge(newCell);
        }

        public IReadOnlyCell Unload(Good good, int count)
        {
            var cellIndex = _cells.FindIndex(c => c.Good.Equals(good));

            if (cellIndex == -1)
                throw new InvalidOperationException("This product does not exist");

            var cell = _cells[cellIndex];
            
            if (cell.Count < count)
                throw new InvalidOperationException("Not enough goods");
            
            cell.Withdraw(count);
            return cell;
        }
    }
}