using Volo.Abp.Modularity;

namespace App.School.v3;

/* Inherit from this class for your domain layer tests. */
public abstract class v3DomainTestBase<TStartupModule> : v3TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
