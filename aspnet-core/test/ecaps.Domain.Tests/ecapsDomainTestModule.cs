using ecaps.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ecaps;

[DependsOn(
    typeof(ecapsEntityFrameworkCoreTestModule)
    )]
public class ecapsDomainTestModule : AbpModule
{

}
