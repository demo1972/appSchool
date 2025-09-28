using Volo.Abp.Modularity;

namespace App.School.v3;

[DependsOn(
    typeof(v3DomainModule),
    typeof(v3TestBaseModule)
)]
public class v3DomainTestModule : AbpModule
{

}
