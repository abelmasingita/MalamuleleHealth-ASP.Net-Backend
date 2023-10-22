using AutoMapper;
using DataInterface.Configurations.Dto.User;
using DataInterface.Domain;
using MalamuleleHealth.Application.Repository.IRepository;
using MalamuleleHealth.EFCore;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
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
        private readonly UserManager<User> userManager;

        private readonly IMapper mapper;

        public ApplicationUserController(UserManager<User> userManager, IMapper mapper)
        {
            this.userManager = userManager;

            this.mapper = mapper;
        }

        [HttpGet("GetUsers")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<ApplicationUserDto>))]
        [ProducesResponseType(400, Type = typeof(IEnumerable<ApplicationUserDto>))]
        [Authorize(Roles = "Administrator, Doctor, Nurse, Pharmacist, LabTechnician")]
        public IActionResult GetUsers()
        {
            var users = userManager.Users.ToList();

            var mappedUsers = mapper.Map<List<ApplicationUserDto>>(users);
            return Ok(mappedUsers);
        }

        [HttpGet("GetUser")]
        [ProducesResponseType(200, Type = typeof(ApplicationUserDto))]
        [ProducesResponseType(400, Type = typeof(ApplicationUserDto))]
        [Authorize(Roles = "Administrator, Doctor, Nurse, Pharmacist, LabTechnician")]
        public async Task<IActionResult> GetUser(string userId)
        {
            if (userId == null) { return BadRequest(); }

            // var user = userManager.Users.ToList().FirstOrDefault(u => u.Id == userId);
            var user = await userManager.FindByIdAsync(userId);

            if (user == null) { return NotFound(); }
            var mappedUser = mapper.Map<ApplicationUserDto>(user);

            return Ok(mappedUser);
        }

        [HttpPut("UpdateUser")]
        [ProducesResponseType(200, Type = typeof(UpdateApplicationUserDto))]
        [ProducesResponseType(400, Type = typeof(UpdateApplicationUserDto))]
        [Authorize(Roles = "Administrator, Doctor, Nurse, Pharmacist, LabTechnician")]
        public async Task<IActionResult> UpdateUser(string userId, [FromBody] UpdateApplicationUserDto userUpdate)
        {
            if (userId == null || userUpdate == null) { return BadRequest(); }

            var user = await userManager.FindByIdAsync(userId);

            if (user == null) { return NotFound(); }
            var mappedUser = mapper.Map<UpdateApplicationUserDto>(user);

            user.FirstName = mappedUser.FirstName;
            user.LastName = mappedUser.LastName;
            user.PhoneNumber = mappedUser.PhoneNumber;
            user.LockoutEnabled = mappedUser.LockoutEnabled;

            var result = await userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                // User deleted successfully
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }

        [HttpDelete("DeleteUser")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteUser(string userId)
        {
            if (userId == null) { return BadRequest(); }

            var user = await userManager.FindByIdAsync(userId);

            if (user == null) { return NotFound(); }

            var result = await userManager.DeleteAsync(user);

            if (result.Succeeded)
            {
                // User deleted successfully
                return Ok(result);
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }



        //[HttpPut("UpdateUserRole")]
        //[ProducesResponseType(200, Type = typeof(UpdateApplicationUserDto))]
        //[ProducesResponseType(400, Type = typeof(UpdateApplicationUserDto))]
        //[Authorize(Roles = "Administrator")]
        //public async Task<IActionResult> UpdateUserRole(string userId, [FromBody] UpdateUserRoleDto userUpdate)
        //{
        //    if (userId == null || userUpdate == null) { return BadRequest(); }

        //    var user = await userManager.FindByIdAsync(userId);

        //    if (user == null) { return NotFound(); }


        //    var mappedUser = mapper.Map<UpdateApplicationUserDto>(user);

        //     user.FirstName = mappedUser.FirstName;
        //     user.LastName = mappedUser.LastName;
        //     user.PhoneNumber = mappedUser.PhoneNumber;
        //     user.LockoutEnabled = mappedUser.LockoutEnabled;

        //     var result = await userManager.UpdateAsync(user);

        //     if (result.Succeeded)
        //     {
        //         // User deleted successfully
        //         return Ok(result);
        //     }
        //     else
        //     {
        //         return BadRequest(result.Errors);
        //     }
        //}

    }

}