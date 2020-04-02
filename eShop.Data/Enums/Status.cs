using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Enums
{
    public enum Status
    {
        Inactive,
        Active
    }

    public enum OrderStatus
    {
        InProgress,
        Confirmed,
        Shipping,
        Success,
        Canceled
    }

    public enum TransactionStatus
    {
        Success,
        Failed
    }
}
