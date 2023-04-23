using System;

namespace NumberService.Logic
{
    public struct Buff<T>
    {
        public T[] BufferS;
        public Buff(int size)
        {
           BufferS = new T[size];
        }

        private static bool IsFool (int curr,int size) => curr == size;

        public void Insert(ref int curr, int size, T num)
        {
            BufferS[curr] = num;
            if (IsFool(curr,size))
                curr = 0;
            else
                curr++;
        }
    }
}
