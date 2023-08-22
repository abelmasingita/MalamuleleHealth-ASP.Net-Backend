using Abp.AutoMapper;
using MalamuleleHealth.Authentication.External;

namespace MalamuleleHealth.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
