namespace NumberService.Logic
{
    public class Service
    {
        public BufferS<long> Buffer { get; set; } = new BufferS<long>(5);
    }
}
