namespace PickleInventory.Domain.Entities
{
	public enum PickeType
	{
		Veg = 0,
		NonVeg = 1
	}
	public class Pickle
	{
		public int PickleId { get; set; }

		public required string PickleName { get; set; }

		public required string PickleDescription { get; set; }
		public PickeType PickleType { get; set; }

		public decimal PicklePrice { get; set; }
		public decimal PickleVolume { get; set; }

		public float PickelRating { get; set; }	
		public int PickelWeightMax { get; set; }

		public required string PickleUrl { get; set; }


	}

}
