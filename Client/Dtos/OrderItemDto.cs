namespace PickleInventory.Client.Dtos
{
	public class OrderItemDto
	{
		public int OrderItemId { get; set; }
		public int PickleId { get; set; }
		public int OrderId { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }

	}
}
