namespace BasicMVCApp.Models
{
    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}