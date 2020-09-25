namespace Projek.Repository
{
    public class DetailCart
    {
        public string ProductID { get; internal set; }
        public object ProductName { get; internal set; }
        public int ProductPrice { get; internal set; }
        public int ProductQuantity { get; internal set; }
        public int ProductSubTotal { get; internal set; }
    }
}