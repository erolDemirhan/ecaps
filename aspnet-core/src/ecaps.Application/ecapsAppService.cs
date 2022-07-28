using System;
using System.Collections.Generic;
using System.Text;
using ecaps.Localization;
using Volo.Abp.Application.Services;

namespace ecaps;

/* Inherit your application services from this class.
 */
public abstract class ecapsAppService : ApplicationService
{
    protected ecapsAppService()
    {
        LocalizationResource = typeof(ecapsResource);
    }
}
