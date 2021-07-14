using System;

namespace Store
{
    public class Cell : IReadOnlyCell
    {
        public Good Good { get; }
        public int Count { get; private set; }

        public Cell(Good good, int count)
        {
            Good = good;
            Count = count;
        }

        public void Merge(Cell newCell)
        {
            if (newCell.Good.Equals(Good) == false)
                throw new InvalidOperationException("Goods aren't equals.");

            Count += newCell.Count;
        }

        public void Withdraw(int count)
        {
            if (count > Count)
                throw new ArgumentOutOfRangeException(nameof(count));
        }
    }
}