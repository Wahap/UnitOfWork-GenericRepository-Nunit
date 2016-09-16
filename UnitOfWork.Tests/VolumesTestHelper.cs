using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.VolumeManager.DTO;

namespace UnitOfWork.Tests
{
  public static class VolumesTestHelper
  {
    public static VehicleVolumeInfo GetVehicleVolumeInfo(string country, string vehVehicleTypesCsv = null, string regType = null,
      string makesCsv = null, string modelsCsv = null, int lngId = -1, string startDate = null, string endDate = null, string aggrTypesCsv = null)
    {
      var vehicleVolumeInfo = new VehicleVolumeInfo
      {
        VehCountry = country
      };

      if (vehVehicleTypesCsv != null)
      {
        var vehicleTypes = new List<Translations>();
        vehVehicleTypesCsv.Split(',').ToList().ForEach(vt => vehicleTypes.Add(new Translations { TextValue = vt }));
        vehicleVolumeInfo.VehVehicleType = vehicleTypes;
      }

      if (regType != null)
        vehicleVolumeInfo.VehRegType = regType;

      if (makesCsv != null)
      {
        var makes = new List<Translations>();
        makesCsv.Split(',').ToList().ForEach(m => makes.Add(new Translations { TextValue = m }));
        vehicleVolumeInfo.VehMake = makes;
      }

      if (modelsCsv != null)
      {
        var models = new List<Translations>();
        modelsCsv.Split(',').ToList().ForEach(m => models.Add(new Translations { TextValue = m }));
        vehicleVolumeInfo.VehModel = models;
      }

      if (lngId >= 0)
        vehicleVolumeInfo.VehLngId = lngId;

      if (startDate != null)
        vehicleVolumeInfo.StartDate = DateTime.SpecifyKind(DateTime.Parse(startDate), DateTimeKind.Utc);

      if (endDate != null)
        vehicleVolumeInfo.EndDate = DateTime.SpecifyKind(DateTime.Parse(endDate), DateTimeKind.Utc);

      if (aggrTypesCsv != null)
      {
        var aggrTypes = new List<Translations>();
        aggrTypesCsv.Split(',').ToList().ForEach(at => aggrTypes.Add(new Translations { TextValue = at }));
        vehicleVolumeInfo.AggrTypes = aggrTypes;
      }

      return vehicleVolumeInfo;
    }

    public static VehicleVolume GetVehicleVolume(string make, string model, string bodyType = null, string numberOfDoors = null, string fuelType = null, int? engineCc = null,
      decimal? engineLitres = null, string transmissionType = null, string numberOfGears = null, string driveWheels = null, string trim = null, string turbo = null, int? powerKw = null,
      string region = null, string regsType = null, decimal? volumes = null)
    {
      var vehicleVolume = new VehicleVolume
      {
        Make = make,
        Model = model,
        BodyType = bodyType,
        NumberOfDoors = numberOfDoors,
        FuelType = fuelType,
        EngineCc = engineCc,
        EngineLitres = engineLitres,
        TransmissionType = transmissionType,
        NumberOfGears = numberOfGears,
        DriveWheels = driveWheels,
        Trim = trim,
        Turbo = turbo,
        PowerKw = powerKw,
        Region = region,
        RegsType = regsType,
        Volumes = volumes
      };

      return vehicleVolume;
    }
  }
}
