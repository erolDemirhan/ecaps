using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ecaps.Data;

/* This is used if database provider does't define
 * IecapsDbSchemaMigrator implementation.
 */
public class NullecapsDbSchemaMigrator : IecapsDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
