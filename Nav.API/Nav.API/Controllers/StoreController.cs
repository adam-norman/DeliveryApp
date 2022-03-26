using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nav.Application.Queries;
using Nav.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace Nav.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly IMediator _mediatR;
        private readonly ILogger<StoreController> _logger;

        public StoreController(IMediator mediatR, ILogger<StoreController> logger)
        {
            _mediatR = mediatR;
            _logger = logger;
        }

        [HttpPost("GetStoreListByUserGeoLocation")]
        [ProducesResponseType(typeof(IEnumerable<Store>),(int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Store>>> GetStoreListByUserGeoLocation([FromBody] Location location)
        {
            var query = new GetStoresListByUserLocationQuery(location);
            var storesList =await _mediatR.Send(query);
            return Ok(storesList);
        }
    }
}
