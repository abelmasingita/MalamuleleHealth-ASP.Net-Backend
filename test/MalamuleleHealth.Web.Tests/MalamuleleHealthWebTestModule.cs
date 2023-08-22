using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MalamuleleHealth.EntityFrameworkCore;
using MalamuleleHealth.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MalamuleleHealth.Web.Tests
{
    [DependsOn(
        typeof(MalamuleleHealthWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MalamuleleHealthWebTestModule : AbpModule
    {
        public MalamuleleHealthWebTestModule(MalamuleleHealthEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MalamuleleHealthWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MalamuleleHealthWebMvcModule).Assembly);
        }
    }
}