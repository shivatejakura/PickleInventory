namespace PickleInventory.Domain.Entities
{
    public enum DeliveryStatus
    {
        Unknown = 0,
        Pending = 1,
        InTransit = 2,
        OutForDelivery = 3,
        Delayed = 4,
        Delivered = 5,
        Cancelled = 6,
        Returned = 7
    }

    public class Order
    {
        public int OrderId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserAddress { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public decimal TotalAmount => OrderItems.Sum(item => item.OrderQuantity * item.Pickle.PicklePrice);
        public DeliveryStatus DeliveryStatus { get; set; }
    }

}
