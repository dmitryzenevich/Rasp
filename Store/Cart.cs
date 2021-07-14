using System.Collections.Generic;

namespace Store
{
    public class Cart
    {
        private readonly Warehouse _warehouse;
        private readonly List<Cell> _cells;

        public IReadOnlyCollection<IReadOnlyCell> Cells => _cells;

        public Cart(Warehouse warehouse)
        {
            _warehouse = warehouse;
            _cells = new List<Cell>();
        }
        
        public void Add(Good good, int count)
        {
            var readOnlyCell = _warehouse.Unload(good, count);
            _cells.Add(new Cell(readOnlyCell.Good, readOnlyCell.Count));
        }

        public Order Order() => new Order($"paylink");
    }
}