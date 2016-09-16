using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace UnitOfWork.VolumeManager.DTO
{
  public class SalesInsertionDoc
  {
    public SalesInsertionDoc()
    {
      LastModifiedDttm = DateTime.UtcNow;
    }

    // ReSharper disable once InconsistentNaming
    public SalesInsertionDocId _id { get; set; }
    public string SiGroupId { get; set; }
    public SpecsExtract SpecsExtractData { get; set; }
    public List<SalesInsertionValue> SiValues { get; set; }
    public string Source { get; set; } //SE - Specs Extract DB; SI - Sales Insertion DB; NEW - Newly added by user (Value before saving); USER - Added by the user (Value on/after saving)
    public string LastModifiedUserId { get; set; }
    public DateTime LastModifiedDttm { get; set; }
    public bool Committed { get; set; }
    public string Ved1 { get; set; }
    public string Ved2 { get; set; }
    public string Ved3 { get; set; }
    [BsonIgnore]
    public string UpsertStatusCode { get; set; }
    [BsonIgnore]
    public string UpsertStatusText { get; set; }
    [BsonIgnore]
    public string TransVehicleId { get; set; }
    [BsonIgnore]
    public string Flag { get; set; }
  }

  public class SalesInsertionDocId
  {
    //public string UserId { get; set; }
    public string VehicleId { get; set; }
    public DateTime DataDate { get; set; }
    public string CountryCode { get; set; }
  }
  public class SalesInsertionValue
  {
    public int Year { get; set; }
    public int Month { get; set; }
    public int? Value { get; set; }
    [BsonIgnore]
    public int? VolumesUpdateCount { get; set; }
    public bool IsWf { get; set; }
    public string LastModifiedUserId { get; set; }
    public DateTime LastModifiedDttm { get; set; }
  }
}
