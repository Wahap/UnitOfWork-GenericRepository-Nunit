using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnitOfWork.Data;
using UnitOfWork.DataContext;
using UnitOfWork.Interfaces;

namespace UnitOfWork.BO
{
  public class UnitOfWorkForMmxSourceVolumesDb : IUnitOfWorkForMmxSourceVolumeDb
  {
    private MmxSourceVolumesDb mmxSourceVolumesDb;
    private IRepository<jat> jatRepository;
    private IRepository<Links> linkRepository;

    public UnitOfWorkForMmxSourceVolumesDb(IConnectionValue connectionValue)
    {
      mmxSourceVolumesDb = new MmxSourceVolumesDb(connectionValue);
    }

    public bool DbExist => mmxSourceVolumesDb.Database.Exists();

    public IRepository<jat> JatRepository => jatRepository ?? (jatRepository = new Repository<jat>(mmxSourceVolumesDb));

    public IRepository<Links> LinksRepository => linkRepository ?? (linkRepository = new Repository<Links>(mmxSourceVolumesDb));


    public void Dispose()
    {
      if (mmxSourceVolumesDb != null)
      {
        mmxSourceVolumesDb.Dispose();
        mmxSourceVolumesDb = null;
      }
    }
  }
}