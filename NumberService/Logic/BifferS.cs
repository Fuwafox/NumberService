namespace NumberService.Logic
{
    public class BufferS<T>
    {
        private T[] _buffer;
        private int _headpos;
        private int _tailpos;
        private int _length;
        private int _bufferSize;
        private object _lock = new object();

        public BufferS(int bufferSize)
        {
            _buffer = new T[bufferSize];
            _bufferSize = bufferSize;
            _headpos = bufferSize - 1;
        }

        private bool IsEmpty => _length == 0;

        private bool IsFull => _length == _bufferSize;

        public T Delete()
        {
            lock (_lock)
            {
                if (IsEmpty)
                    throw new InvalidOperationException("Упс. Попробуйте сначала что-нибудь добавить.");

                var tail = _buffer[_tailpos];
                _tailpos = NextPosition(_tailpos);
                _length--;
                return tail;
            }
        }

        private int NextPosition(int position) => (position + 1) % _bufferSize;

        public void Insert(T item)
        {
            lock (_lock)
            {
                _headpos = NextPosition(_headpos);
                _buffer[_headpos] = item;
                if (IsFull)
                    _tailpos = NextPosition(_tailpos);
                else
                    _length++;
            }
        }

        public List<T> ToList() => _buffer.ToList();
    }
}
