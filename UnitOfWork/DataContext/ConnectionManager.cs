using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using UnitOfWork.Interfaces;

namespace UnitOfWork.DataContext
{
  public class ConnectionManager : IConntecionManager
  {

    public string GetMmxSourceVolumesConnectionString(IConnectionValue connectionValue)
    {
      if (connectionValue?.DbName == null)
        throw new Exception("ERROR: Invalid database name.");

      var serverName = ConfigurationManager.AppSettings["MmxSourceVolumesServer"];
      if (string.IsNullOrWhiteSpace(serverName))
        throw new Exception("ERROR: Invalid config value for MmxSourceVolumesServer.");

      var connectionString = "data source=" + serverName.ToLower() + ";Integrated Security=SSPI;" +
                             "User Instance=false;" +
                             "Initial Catalog=" + connectionValue.DbName;

      return connectionString;
    }
    public string GetJATONetBackendConnectionString()
    {
      var connectionString = ConfigurationManager.ConnectionStrings["JATONetBackend"].ConnectionString;
      return connectionString;
    }

    public string GetJATONetVConnectionString()
    {
      var connectionString = ConfigurationManager.ConnectionStrings["JATONETV"].ConnectionString;
      return connectionString;
    }

    public string GetSpecsConnectionString(IConnectionValue value)
    {
      string specsDatabseName;
      string serverName;

      if (value == null)
      {
        specsDatabseName = ConfigurationManager.AppSettings["DefaultSpecsDatabase"].ToLower();
        serverName = ConfigurationManager.AppSettings["SettingsServerName"].ToLower();
      }
      else
      {
        specsDatabseName = value.SpecsDbName;
        serverName = value.ServerName;
      }

      var connectionString = "data source=" + serverName + ";Integrated Security=SSPI;" +
                             "User Instance=false;" +
                             "Initial Catalog=" + specsDatabseName;

      return connectionString;
    }
  }
}