using System.ComponentModel;

namespace BusinessSvc.Domain.Enums
{
    public enum OrderStatus
    {
        [Description("Order awaiting payment confirmation")]
        Pending = 0,

        [Description("Order on the way to the customer")]
        Shipped = 1,

        [Description("Order completed successfully")]
        Completed = 10,

        [Description("Order failed")]
        Failed = 11
    }
}
