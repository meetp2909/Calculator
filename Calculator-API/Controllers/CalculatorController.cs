using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CalculatorController : Controller
    {

        [HttpGet]
        public decimal Add(decimal a, decimal b)
        {
            return a+b;
        }

        [HttpGet]
        public decimal Subtract(decimal a , decimal b)
        {
            return a-b;
        }

        [HttpGet]
        public  decimal Multiply(decimal a, decimal b)
        {
            return a*b;
        }

        [HttpGet]
        public ActionResult Divide(decimal a, decimal b)

        {
            if(b==0){

                return BadRequest("Cannot divide by zero");
            }
                decimal result = a/b;
                return Ok(result);
        
        
        }
        // GET: Calculator_api
        
        [HttpGet]
        public ActionResult Modulo(decimal a, decimal b)
        {
            if(b ==0){
                return BadRequest("Cannot calculate modulo with zero divisor");
            }

            decimal remainder = a%b;
            return Ok(remainder);
        }

    }
}
