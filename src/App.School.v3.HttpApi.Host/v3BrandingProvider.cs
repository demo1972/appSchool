using Microsoft.Extensions.Localization;
using App.School.v3.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace App.School.v3;

[Dependency(ReplaceServices = true)]
public class v3BrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<v3Resource> _localizer;

    public v3BrandingProvider(IStringLocalizer<v3Resource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
