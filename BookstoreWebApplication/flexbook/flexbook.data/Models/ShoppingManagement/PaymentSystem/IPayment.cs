﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexbook.Data.Models.ShoppingManagement.PaymentSystem
{
    public interface IPayment
    {
        decimal Price { get; set; }
    }
}