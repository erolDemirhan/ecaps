using System.Threading.Tasks;

namespace ecaps.Data;

public interface IecapsDbSchemaMigrator
{
    Task MigrateAsync();
}
