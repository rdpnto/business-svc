using System.ComponentModel;

namespace BusinessSvc.Domain.Enums
{
    public enum OrderStatus
    {
        [Description("Order completed successfully")]
        Completed = 0,

        [Description("Order awaiting payment confirmation")]
        Pending = 1,

        [Description("Order on the way to the customer")]
        Shipped = 2,

        [Description("Order failed")]
        Failed = 3
    }
}
