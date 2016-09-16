using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnitOfWork.Data;

namespace UnitOfWork.Interfaces
{
  public interface IUnitOfWorkForMmxSourceVolumeDb : IDisposable
  {

    IRepository<jat> JatRepository { get; }
    IRepository<Links> LinksRepository { get; }

    bool DbExist { get; }

  }
}