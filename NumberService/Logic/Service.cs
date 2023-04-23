namespace NumberService.Logic
{
    public class Service
    {
        private int _curr;
        private readonly int _size;
        public Buff<int> cl;
        private readonly object _obLock = new();
        public Service() 
        {
            _curr = 0;
            _size = 5;
             cl = new Buff<int>(_size);
        }
        public void Insert(int num)
        {
            lock (_obLock) 
            {
                cl.Insert(ref _curr, _size - 1, num);
            }
        }

        
    }
}
