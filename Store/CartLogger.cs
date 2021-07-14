using System;

namespace Store
{
    public class CartLogger : ILogger
    {
        private readonly Cart _cart;

        public CartLogger(Cart cart)
        {
            _cart = cart;
        }

        public void Log()
        {
            Console.WriteLine($"Goods in Cart:");
            
            foreach (var cell in _cart.Cells) 
                Console.WriteLine($"Good - {cell.Good}, Count - {cell.Count}");
        }
    }
}