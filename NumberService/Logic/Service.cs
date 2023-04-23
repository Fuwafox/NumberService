namespace NumberService.Logic
{
    public class Service
    {
        public Buff<int> cl;
        
        public Service() 
        {
             cl = new Buff<int>(5);
        }     
    }
}
