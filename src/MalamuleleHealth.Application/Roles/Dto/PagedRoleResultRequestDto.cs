using Abp.Application.Services.Dto;

namespace MalamuleleHealth.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

