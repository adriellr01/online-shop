using Microsoft.AspNetCore.Mvc;
using OnlineShop.Core.Repositories;

namespace OnlineShop.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {

        private readonly IPaymentRepository _paymentrepository;
        public PaymentController(IPaymentRepository payment)
        {
            _paymentrepository = payment;
        }
        [HttpGet]
        public ActionResult Getall()
        {
            var payment = _paymentrepository.GetAll();
            return Ok(payment);
        }
    }
}


