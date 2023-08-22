using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MalamuleleHealth.Configuration;

namespace MalamuleleHealth.Web.Host.Startup
{
    [DependsOn(
       typeof(MalamuleleHealthWebCoreModule))]
    public class MalamuleleHealthWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MalamuleleHealthWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MalamuleleHealthWebHostModule).GetAssembly());
        }
    }
}
