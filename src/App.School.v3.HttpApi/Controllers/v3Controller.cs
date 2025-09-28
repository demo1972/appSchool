using App.School.v3.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace App.School.v3.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class v3Controller : AbpControllerBase
{
    protected v3Controller()
    {
        LocalizationResource = typeof(v3Resource);
    }
}
