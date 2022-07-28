using Volo.Abp.Modularity;

namespace ecaps;

[DependsOn(
    typeof(ecapsApplicationModule),
    typeof(ecapsDomainTestModule)
    )]
public class ecapsApplicationTestModule : AbpModule
{

}
