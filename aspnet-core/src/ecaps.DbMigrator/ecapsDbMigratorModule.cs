using ecaps.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ecaps.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ecapsEntityFrameworkCoreModule),
    typeof(ecapsApplicationContractsModule)
    )]
public class ecapsDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
