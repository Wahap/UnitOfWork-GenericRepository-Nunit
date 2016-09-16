using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitOfWork.Interfaces
{
  public interface IConnectionValue
  {
    string SpecsDbName { get; set; }
    string ProjectDbName { get; set; }
    string MetricsDbName { get; set; }
    string DbName { get; set; }
    string ServerName { get; set; }
    DateTime StartDate { get; set; }
    DateTime EndDate { get; set; }
    bool LocalVehicles { get; set; }
  }
}