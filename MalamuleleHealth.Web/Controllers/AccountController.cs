using AutoMapper;
using DataInterface.Domain;
using MalamuleleHealth.Application.Repository.IRepository;
using MalamuleleHealth.EFCore.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MalamuleleHealth.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUnitofWork unitofWork;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IMapper mapper;

        public AccountController(IUnitofWork unitofWork, UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            this.unitofWork = unitofWork;
            this.userManager = userManager;
            this.mapper = mapper;
        }

        [HttpPost(Name ="Register")]
        public async Task<IActionResult> RegisterAsync(Registration NewUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = mapper.Map<ApplicationUser>(NewUser);
            var result = await userManager.CreateAsync(user, NewUser.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            await userManager.AddToRoleAsync(user, "Patient");

            return Ok();

        }

    }

}