﻿using DAL.Entities.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Specifications
{
    public class OrderByPaymentIntentIdSpecification:BaseSpecification<Order>
    {
        public OrderByPaymentIntentIdSpecification(string paymentIntentId)
            :base(o=>o.PaymentIntentId==paymentIntentId)
        {

        }
    }
}
