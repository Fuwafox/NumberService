using System;

namespace NumberService.Logic
{
    public struct Buff<T>
    {
        public T[] BufferS;
        private int _curr;
        private readonly int _size;

        public Buff(int size)
        {
           BufferS = new T[size];
            _curr = 0;
            _size = size;
        }
        
        private readonly object _obLock = new();
        
        private static bool IsFool (int curr,int size) => curr == size-1;

        public void Insert(T num)
        {
            lock (_obLock)
            {
                BufferS[_curr] = num;
                if (IsFool(_curr, _size))
                    _curr = 0;
                else
                   _curr++;
            }
        }
    }
}
