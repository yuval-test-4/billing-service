using Microsoft.AspNetCore.Mvc;

namespace BillingService.APIs;

[ApiController()]
public class CustomersController : CustomersControllerBase
{
    public CustomersController(ICustomersService service)
        : base(service) { }
}
