using Business.Abstract;
using Entites.Concrete;
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
    public class RentalDetailsController : ControllerBase
    {
        IRentalDetailsService _rentalDetailsService;

        public RentalDetailsController(IRentalDetailsService rentalDetailsService)
        {
            _rentalDetailsService = rentalDetailsService;

            
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _rentalDetailsService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpGet("bycarsid")]
        public IActionResult GetRentalDetailsByCarsId(int id)
        {
            var result = _rentalDetailsService.GetRentalDetailsByCarsId(id);

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);


        }

        [HttpPost("delete")]
        public IActionResult Delete(RentalDetails rentalDetails)
        {

            var result = _rentalDetailsService.Delete(rentalDetails);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

    }
}
