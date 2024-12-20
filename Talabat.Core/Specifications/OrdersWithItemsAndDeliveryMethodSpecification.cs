﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entities.Order_Aggregate;

namespace Talabat.Core.Specifications
{
    public class OrdersWithItemsAndDeliveryMethodSpecification : BaseSpecification<Order>
    {
        public OrdersWithItemsAndDeliveryMethodSpecification(string buyerEmail) : base(O => O.BuyerEmail == buyerEmail)
        {
            Includes.Add(O => O.Items);
            Includes.Add(O => O.DeliveryMethod);

            AddOrderByDescending(O => O.OrderDate);
        }

        public OrdersWithItemsAndDeliveryMethodSpecification(string buyerEmail, int orderId)
                : base(O => O.BuyerEmail == buyerEmail && O.Id == orderId)
        {
            Includes.Add(O => O.Items);
            Includes.Add(O => O.DeliveryMethod);

        }
    }
}
