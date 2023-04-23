namespace NumberService.Logic
{
    public class Service
    {
        private Buff<int> cl;
        
        public Service() 
        {
             cl = new Buff<int>(5);
        }     

        public void Add (int num) => cl.Insert(num);

        public int[] Select() => cl.BufferS.ToArray();
    }
}
