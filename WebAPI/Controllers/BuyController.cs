using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyController : ControllerBase
    {
        private IBuyService _buyService;

        public BuyController(IBuyService buyService)
        {
            _buyService = buyService;
        }
        [HttpPost]
        public IActionResult Add(Buy buy)
        {
            var result = _buyService.Add(buy);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
