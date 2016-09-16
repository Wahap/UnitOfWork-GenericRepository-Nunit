using System.Collections.Generic;
using System.Linq;
using UnitOfWork.BO;
using UnitOfWork.Data;
using UnitOfWork.DTO;
using UnitOfWork.Interfaces;
using UnitOfWork.VolumeManager.DTO;
using UnitOfWork.VolumeManager.Interface;

namespace UnitOfWork.VolumeManager.Concrete
{
  public class FetchCriteriaOptionsForVolumes : IVolumeManager<List<jat>, VehicleVolume>
  {
    public List<jat> Manage(VehicleVolume value)
    {
      var returnList = new List<jat>();
      using (IUnitOfWorkForMmxSourceVolumeDb sourceVolumesDb = new UnitOfWorkForMmxSourceVolumesDb(new ConnectionValue { DbName = "F_R" }))
      {
        IQueryable<jat> jatQueryAll = sourceVolumesDb.JatRepository.GetAll();

        //Registration Types

        var dd = jatQueryAll.Select(x => x.jatMake).ToList();

        jat jj = new jat();
        jj.jatMake = "AUDI";
        jj.jatID = 2;
        var dd2= sourceVolumesDb.JatRepository.FindById(jj.jatID);

        returnList= jatQueryAll.Take(10).ToList();


      }


      return returnList.Take(10).ToList();
    }
  }
  
}
