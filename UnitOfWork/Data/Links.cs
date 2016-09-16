using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace UnitOfWork.Data
{
  public partial class Links
  {
    [Key]
    public int id { get; set; }

    public int matid { get; set; }
    public string vehicle_type { get; set; }
    public string newvehid { get; set; }
    //public int vehid { get; set; }
    public DateTime firstdate { get; set; }
    public DateTime lastdate { get; set; }
    //[NotMapped]
    //public int Count { get; set; }
  }
}