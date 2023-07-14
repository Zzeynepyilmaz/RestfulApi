using Microsoft.AspNetCore.Mvc;

namespace RestfulApi.Controllers
{
    public class ProductsController : Controller
    {
        public string Get()
        {
            return "Product1";
        }
    }
}
