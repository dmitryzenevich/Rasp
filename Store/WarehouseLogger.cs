using System;

namespace Store
{
    public class WarehouseLogger : ILogger
    {
        private readonly Warehouse _warehouse;

        public WarehouseLogger(Warehouse warehouse)
        {
            _warehouse = warehouse;
        }

        public void Log()
        {
            Console.WriteLine($"Goods in Warehouse:");
            
            foreach (var cell in _warehouse.Cells) 
                Console.WriteLine($"Good - {cell.Good}, Count - {cell.Count}");
        }
    }
}