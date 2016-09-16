
using System.Data.Entity;
using UnitOfWork.Data;
using UnitOfWork.Interfaces;

namespace UnitOfWork.DataContext
{
  public class MmxSourceVolumesDb : DbContext
  {
    public DbSet<jat> jat { get; set; }
    public DbSet<Links> links { get; set; }

    public MmxSourceVolumesDb(IConnectionValue connectionValue)
    {
      Database.Connection.ConnectionString = new ConnectionManager().GetMmxSourceVolumesConnectionString(connectionValue);

    }
  }
}