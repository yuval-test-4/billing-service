using BillingService.Infrastructure;

namespace BillingService.APIs;

public class OrdersService : OrdersServiceBase
{
    public OrdersService(BillingServiceDbContext context)
        : base(context) { }
}
