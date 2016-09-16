using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.VolumeManager.DTO
{
  public class CriteriaOptions
  {
    public string UserId { get; set; }
    public List<Translations> RegList { get; set; }
    public List<Translations> VehicleTypeList { get; set; } = new List<Translations>();
    public List<Translations> MakeList { get; set; } = new List<Translations>();
    public List<Translations> ModelList { get; set; } = new List<Translations>();
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool MatchEngineCc { get; set; }
    public bool MatchGvw { get; set; }
    public string Co2 { get; set; }
    public string NationalCode { get; set; }
    public string CountryCode { get; set; }
    public List<VehicleVolume> SelectedVehicles { get; set; }
    public List<SalesInsertionDoc> SalesInsertions { get; set; }
    public bool ApplyMix { get; set; }
  }
  public class Translations
  {
    public string LongText { get; set; }
    public string ShortText { get; set; }
    public string TextValue { get; set; }
  }
  public class VehicleVolume
  {
    public int MatId { get; set; }
    public string VehicleId { get; set; }
    public string ManufCode { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Version { get; set; }

    public string BodyType { get; set; }
    public string NumberOfDoors { get; set; }
    public string FuelType { get; set; }
    public int? EngineCc { get; set; }
    public decimal? EngineLitres { get; set; }
    public string TransmissionType { get; set; }
    public string NumberOfGears { get; set; }
    public string DriveWheels { get; set; }
    public string Rim { get; set; }
    public string Trim { get; set; }
    public string Turbo { get; set; }
    public int? PowerKw { get; set; }
    public int? Gvw { get; set; }
    public DateTime? PrdDate { get; set; }
    public int? PrdId { get; set; }
    public Int16 Year { get; set; }
    public byte Month { get; set; }
    public string Region { get; set; }
    public string RegsType { get; set; }
    public decimal? Volumes { get; set; }

    public int? Hp { get; set; }
    public string RoofType { get; set; }
    public string Seats { get; set; }
    public int? PayLoad { get; set; }
    public int? Cyls { get; set; }
    public int? WBase { get; set; }
    public int? ModYr { get; set; }
    public int? NatCode { get; set; }
    public string RegBody { get; set; }
    public string CabType { get; set; }
    public string WbaseType { get; set; }
    public string ManuelSeq { get; set; }
    public dynamic DoNotLink { get; set; }
    public string Hybrid { get; set; }
  }
}
