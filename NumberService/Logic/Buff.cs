using System;

namespace NumberService.Logic
{
    public struct Buff<T>
    {
        public Buff() { }
        private bool _isFool (int curr,int size) => curr == size;

        public void Insert(ref int curr, int size, T[] arr, T num)
        {
            arr[curr] = num;
            if (_isFool(curr,size))
                curr = 0;
            else
                curr++;
        }
    }
}
