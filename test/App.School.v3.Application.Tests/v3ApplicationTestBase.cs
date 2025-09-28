using Volo.Abp.Modularity;

namespace App.School.v3;

public abstract class v3ApplicationTestBase<TStartupModule> : v3TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
