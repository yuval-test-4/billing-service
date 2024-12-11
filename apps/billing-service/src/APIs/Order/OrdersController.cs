using Microsoft.AspNetCore.Mvc;

namespace BillingService.APIs;

[ApiController()]
public class OrdersController : OrdersControllerBase
{
    public OrdersController(IOrdersService service)
        : base(service) { }
}
