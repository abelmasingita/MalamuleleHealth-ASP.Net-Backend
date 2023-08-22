using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MalamuleleHealth.Authorization;

namespace MalamuleleHealth
{
    [DependsOn(
        typeof(MalamuleleHealthCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MalamuleleHealthApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MalamuleleHealthAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MalamuleleHealthApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
