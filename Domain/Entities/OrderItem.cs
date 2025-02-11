namespace PickleInventory.Domain.Entities
{
	public class OrderItem
	{
		public int OrderItemId { get; set; }
		public int OrderId { get; set; }
		public int PickleId { get; set; }
		public int OrderQuantity { get; set; }

		public Pickle? Pickle { get; set; }



	}
}
