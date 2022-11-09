using System.Collections;

namespace GOF.Iterator
{
    internal abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}