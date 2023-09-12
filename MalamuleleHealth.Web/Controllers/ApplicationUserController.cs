using AutoMapper;
using DataInterface.Domain;
using MalamuleleHealth.Application.Repository.IRepository;
using MalamuleleHealth.EFCore.Application;
using MalamuleleHealth.Web.Configurations.Dto;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MalamuleleHealth.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IMapper mapper;

        public ApplicationUserController(UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            this.userManager = userManager;
            this.mapper = mapper;
        }


        [HttpGet("GetUsers")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ApplicationUserDto>))]
        [ProducesResponseType(400, Type = typeof(IEnumerable<ApplicationUserDto>))]
        public async Task<IActionResult> GetUsers()
        {
            var users = userManager.Users.ToList();
            var mappedUsers = mapper.Map<List<ApplicationUserDto>>(users);
            return Ok(mappedUsers);
        }

        [HttpGet("GetUser")]
        [ProducesResponseType(200, Type = typeof(ApplicationUserDto))]
        [ProducesResponseType(400, Type = typeof(ApplicationUserDto))]
        public async Task<IActionResult> GetUser(string userId)
        {
            if(userId == null) { return BadRequest(); }

            var user = userManager.Users.ToList().FirstOrDefault(u => u.Id == userId);

            if (user == null) { return BadRequest("User Not Found!"); }
            var mappedUser = mapper.Map<ApplicationUserDto>(user);

            return Ok(mappedUser);
        }

    }

}