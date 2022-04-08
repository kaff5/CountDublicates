using back.Models.TestDir;
using back.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBBACK2.Models.Data;

namespace back.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public ITestService service;
        public TestController(ITestService service)
        {
            this.service = service;
        }

        [HttpGet]
        public ActionResult<List<TestsDto>> Get()
        {
            return Ok(service.GetTests());
        }



        [HttpPost]
        public ActionResult<TestDto> Post([FromBody] TestModel model)
        {
            return Ok(service.PostTest(model));
        }
    }
}
