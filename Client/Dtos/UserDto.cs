namespace PickleInventory.Client.Dtos
{
    public record UserDto
        (string UserId,
        string UserName,
        string UserAddress,
        string Email,
        string PhoneNumber,
        string Role,
        string Password);
    
}
