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
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IMapper mapper;

        public ApplicationUserController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
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
            user.Address = mappedUser.Address;
            user.Specialist = mappedUser.Specialist;

            var result = await userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return Ok(user);
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


        [HttpGet("GetDoctors")]
        public async Task<IActionResult> GetDoctors()
        {
            var doctors = await userManager.GetUsersInRoleAsync("Doctor");

            var mappedDoctors = mapper.Map<List<ApplicationUserDto>>(doctors);
            return Ok(mappedDoctors);
        }

        [HttpGet("GetNurses")]
        public async Task<IActionResult> GetNurses()
        {
            var nurses = await userManager.GetUsersInRoleAsync("Nurse");

            var mappedNurses = mapper.Map<List<ApplicationUserDto>>(nurses);
            return Ok(mappedNurses);
        }
        [HttpGet("GetLabTechnician")]
        public async Task<IActionResult> GetLabTechnicians()
        {
            var labt = await userManager.GetUsersInRoleAsync("LabTechnician");

            var mappedLabts = mapper.Map<List<ApplicationUserDto>>(labt);
            return Ok(mappedLabts);
        }
        [HttpGet("GetPatients")]
        [Authorize(Roles = "Administrator, Doctor, Nurse, Pharmacist, LabTechnician")]
        public async Task<IActionResult> GetPatients()
        {
            var pts = await userManager.GetUsersInRoleAsync("Patient");

            var mappedPts = mapper.Map<List<ApplicationUserDto>>(pts);
            return Ok(mappedPts);
        }
        [HttpGet("GetPharmacists")]
        public async Task<IActionResult> GetPharmacists()
        {
            var pms = await userManager.GetUsersInRoleAsync("Pharmacist");

            var mappedPhms = mapper.Map<List<ApplicationUserDto>>(pms);
            return Ok(mappedPhms);
        }
        [HttpGet("GetAdmins")]
        [Authorize(Roles = "Administrator, Doctor, Nurse, Pharmacist, LabTechnician")]
        public async Task<IActionResult> GetAdmins()
        {
            var admins = await userManager.GetUsersInRoleAsync("Administrator");

            var mappedAdmins = mapper.Map<List<ApplicationUserDto>>(admins);
            return Ok(mappedAdmins);
        }

        [HttpPost("UpdateUserRole")]
        public async Task<IActionResult> UpdateUserRole(UpdateUserRoleDto updateModel)
        {
            var user = await userManager.FindByIdAsync(updateModel.UserId);

            if (user == null)
            {
                return NotFound("User not found");
            }

            // Check if the new role exists
            if (!await roleManager.RoleExistsAsync(updateModel.NewRole))
            {
                return BadRequest("Role not found");
            }

            var currentRoles = await userManager.GetRolesAsync(user);

            // Remove the user from current roles
            var removeResult = await userManager.RemoveFromRolesAsync(user, currentRoles);

            if (!removeResult.Succeeded)
            {
                return BadRequest("Failed to remove user from roles");
            }

            // Add the user to the new role
            var addResult = await userManager.AddToRoleAsync(user, updateModel.NewRole);

            if (!addResult.Succeeded)
            {
                return BadRequest("Failed to add user to the new role");
            }

            return Ok("User role updated successfully");
        }

    }

}