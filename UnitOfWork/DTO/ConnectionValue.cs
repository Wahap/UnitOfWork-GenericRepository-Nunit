using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UnitOfWork.Interfaces;

namespace UnitOfWork.DTO
{
  public class ConnectionValue: IConnectionValue
  {
    public string SpecsDbName { get; set; }
    public string ProjectDbName { get; set; }
    public string MetricsDbName { get; set; }
    public string DbName { get; set; }
    public string ServerName { get; set; }
    public string SettingsDbName { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool LocalVehicles { get; set; }
  }
}