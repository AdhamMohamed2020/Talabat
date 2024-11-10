using System.Collections.Generic;
using Talabat.Core.Entities;

namespace Talabat.APIs.Dtos
{
    public class CustomerBasketDto
    {
        public string Id { get; set; }
        public List<BasketItemDto> Items { get; set; } = new List<BasketItemDto>();

        public string PaymentIntentId { get; set; }
        public decimal ShippingPrice { get; set; }
        public string ClientSecret { get; set; }
        public int? DeliveryMethodId { get; set; }


    }
}
