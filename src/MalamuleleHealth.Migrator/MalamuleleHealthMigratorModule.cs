using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MalamuleleHealth.Configuration;
using MalamuleleHealth.EntityFrameworkCore;
using MalamuleleHealth.Migrator.DependencyInjection;

namespace MalamuleleHealth.Migrator
{
    [DependsOn(typeof(MalamuleleHealthEntityFrameworkModule))]
    public class MalamuleleHealthMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MalamuleleHealthMigratorModule(MalamuleleHealthEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(MalamuleleHealthMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                MalamuleleHealthConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MalamuleleHealthMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
