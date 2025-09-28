using App.School.v3.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace App.School.v3.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(v3EntityFrameworkCoreModule),
    typeof(v3ApplicationContractsModule)
)]
public class v3DbMigratorModule : AbpModule
{
}
