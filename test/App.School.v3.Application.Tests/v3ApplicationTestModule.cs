using Volo.Abp.Modularity;

namespace App.School.v3;

[DependsOn(
    typeof(v3ApplicationModule),
    typeof(v3DomainTestModule)
)]
public class v3ApplicationTestModule : AbpModule
{

}
