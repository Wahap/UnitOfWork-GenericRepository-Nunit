using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.VolumeManager.DTO
{
  public class VehicleVolumeInfo
  {
    public int ResearchType { get; set; }
    // public bool IsSpecsExtract { get; set; }
    //public string VehicleId { get; set; }
    public string VehCountry { get; set; }
    public List<Translations> VehVehicleType { get; set; } = new List<Translations>();
    public string VehRegType { get; set; }
    public string VehMakeGroup { get; set; }
    public List<Translations> VehMake { get; set; } = new List<Translations>();
    public List<Translations> VehModel { get; set; } = new List<Translations>();
    public List<Translations> VehBodyType { get; set; } = new List<Translations>();
    public int VehLngId { get; set; }
    public string VehProductGroup { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<Translations> AggrTypes { get; set; } = new List<Translations>();
  }
}
