using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using Ninject;
using UnitOfWork.VolumeManager.Interface;
using UnitOfWork.VolumeManager.DTO;

namespace UnitOfWork.Services.Controllers
{
  [EnableCors(origins: "*", headers: "*", methods: "*")]
  public class FetchVolumesForMakeModelController : ApiController
    {
    // GET: FetchVolumesForMakeModel
    private readonly IVolumeManager<List<VehicleVolume>, VehicleVolumeInfo> getvolumes;
    public FetchVolumesForMakeModelController([Named("FetchVolumesforMakeModel")] IVolumeManager<List<VehicleVolume>, VehicleVolumeInfo> getvolumes)
    {
      this.getvolumes = getvolumes;
    }

    [Route("load")]
    [HttpPost]
    public List<VehicleVolume> Load(VehicleVolumeInfo value)
    {
      return getvolumes.Manage(value);
    }


  }
}