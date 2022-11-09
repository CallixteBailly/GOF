using System.Collections;

namespace GOF.Iterator
{
    internal class ItemsCollection : IteratorAggregate
    {
        public List<Item>? Collection { get; set; } = new List<Item>();
        private bool _RemaningPriority = false;

        public void ReverseDirection()
        {
            _RemaningPriority = !_RemaningPriority;
        }

        public List<Item> GetItems()
        {
            return Collection ?? new List<Item>();
        }

        public void AddItem(Item item)
        {
            Collection?.Add(item);
        }

        public override IEnumerator GetEnumerator()
        {
            return new RemaningPriorityOrderIterator(this, _RemaningPriority);
        }
    }
}