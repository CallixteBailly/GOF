namespace GOF.Iterator
{
    internal class RemaningPriorityOrderIterator : Iterator
    {
        private readonly ItemsCollection _collection;
        private int _position = -1;

        private readonly bool _reverse = false;

        public RemaningPriorityOrderIterator(ItemsCollection collection, bool _RemaningPriority = false)
        {
            _collection = collection;
            _reverse = _RemaningPriority;

            if (_RemaningPriority)
            {
                _collection.Collection = collection.GetItems().OrderBy(o => o.Remaning).ToList();
            }
        }

        public override object Current()
        {
            return _collection.GetItems()[_position];
        }

        public override int Key()
        {
            return _position;
        }

        public override bool MoveNext()
        {
            int updatedPosition = _position + 1;

            if (updatedPosition >= 0 && updatedPosition < _collection.GetItems().Count)
            {
                _position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            _position = _reverse ? _collection.GetItems().Count - 1 : 0;
        }
    }
}