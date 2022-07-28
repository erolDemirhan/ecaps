using ecaps.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ecaps.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ecapsController : AbpControllerBase
{
    protected ecapsController()
    {
        LocalizationResource = typeof(ecapsResource);
    }
}
