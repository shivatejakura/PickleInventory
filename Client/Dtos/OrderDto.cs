using PickleInventory.Domain.Entities;


namespace PickleInventory.Client.Dtos
{
    public record OrderDto
        (int OrderId,
        string UserId, 
        string UserName,
        string UserAddress,
        DateTime OrderDate,
        List<OrderItemDto> OrderItems,
        decimal TotalAmount,
        DeliveryStatus DeliveryStatus);
}
