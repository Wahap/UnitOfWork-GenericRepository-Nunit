using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitOfWork.Interfaces
{
  public interface IConntecionManager
  {
    //string GetJATONetBackendConnectionString();
    //string GetJATONetVConnectionString();

    string GetSpecsConnectionString(IConnectionValue value);
  }
}