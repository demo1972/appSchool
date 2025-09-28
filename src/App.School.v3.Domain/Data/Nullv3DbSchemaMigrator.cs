using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace App.School.v3.Data;

/* This is used if database provider does't define
 * Iv3DbSchemaMigrator implementation.
 */
public class Nullv3DbSchemaMigrator : Iv3DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
