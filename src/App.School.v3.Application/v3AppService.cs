using App.School.v3.Localization;
using Volo.Abp.Application.Services;

namespace App.School.v3;

/* Inherit your application services from this class.
 */
public abstract class v3AppService : ApplicationService
{
    protected v3AppService()
    {
        LocalizationResource = typeof(v3Resource);
    }
}
