using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ecaps;

[Dependency(ReplaceServices = true)]
public class ecapsBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ecaps";
}
