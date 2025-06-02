using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using OData.Data;

namespace OData.Controllers
{
    [Route("odata/[controller]")]
    public class GadgetsController : ODataController
    {
        private readonly MyWorldDbContext _myWorldDbContext;

        public GadgetsController(MyWorldDbContext myWorldDbContext)
        {
            _myWorldDbContext = myWorldDbContext;
        }

        [EnableQuery]
        [HttpGet("Get")]
        public IActionResult Get()
        {
            return Ok(_myWorldDbContext.Gadgets.AsQueryable());
        }
    }
}
