using Business.Abstract;
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
    public class UsersController : ControllerBase
    {

        IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _usersService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);



        }

        [HttpGet("getbyid")]

        public IActionResult GetById(int id)
        {
            var result = _usersService.GeyById(id);

            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);


        }
    }
}
