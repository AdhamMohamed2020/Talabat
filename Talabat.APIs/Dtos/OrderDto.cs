using Talabat.Core.Entities.Order_Aggregate;

namespace Talabat.APIs.Dtos
{
    public class OrderDto
    {
            public string basketId { get; set; }
            public int deliveryMethodId { get; set; }
            public AddressDto shippingAddress { get; set; }
    }
}
