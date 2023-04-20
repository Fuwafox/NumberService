namespace NumberService.Logic
{
    public class Service
    {
        public int[] BufferS { get; set; }
        private int _curr;
        private int _size;
        private Buff<int> cl;
        private object _obLock = new object();

        public Service() 
        {
            BufferS = new int[5];
            cl = new Buff<int>();
            _curr = 0;
            _size = 5;
        }
        public void Insert(int num)
        {
            lock (_obLock) 
            {
                cl.Insert(ref _curr, _size - 1, BufferS, num);
            }
        }
        
    }
}
