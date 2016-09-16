using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.VolumeManager.Interface
{
  public interface IVolumeManager<out T1, in T2>
  {
    T1 Manage(T2 value);
  }
}
