using System.Threading.Tasks;

namespace App.School.v3.Data;

public interface Iv3DbSchemaMigrator
{
    Task MigrateAsync();
}
