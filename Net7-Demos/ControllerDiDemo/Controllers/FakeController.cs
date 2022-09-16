using Demos.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ControllerDiDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FakeController : ControllerBase
    {

        // .NET 6 implementation
        //[HttpGet("cars")]
        //public IEnumerable<string> Get([FromServices] IFakeService fakeService)
        //{
        //    return fakeService.GetCarBrands();
        //}

        // .NET 7 implementation
        [HttpGet("cars")]
        public IEnumerable<string> Get(IFakeService fakeService)
        {
            return fakeService.GetCarBrands();
        }
    }
}