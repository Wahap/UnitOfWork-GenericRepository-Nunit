
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace UnitOfWork.Data
{
  [Table("jat")]
  public partial class jat
  {
    [Key]
    public int jatID { get; set; }
    public int jatMatID { get; set; }
    public string jatSource { get; set; }
   
    public string jatVehicle_Type { get; set; }
 
    //[StringLength(40)]
    public string jatMake { get; set; }
    //[StringLength(40)]
    public string jatModel { get; set; }
    public string jatBodyStyle { get; set; }
    public string jatNo_Of_Doors { get; set; }
    public string jatFuel { get; set; }
    public int jatEngineCc { get; set; }
    public decimal jatEngineLtr { get; set; }
    public string jatTransType { get; set; }
    public string jatNo_Of_Gears { get; set; }
    public string jatDrivenWheel { get; set; }
    public string jatTrim { get; set; }
    public string jatTurbo { get; set; }
    public int jatMax_kw { get; set; }
    public string jatLinkSummary { get; set; }
  }
}