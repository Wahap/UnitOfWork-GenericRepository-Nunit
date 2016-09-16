using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using UnitOfWork.Data;
using UnitOfWork.VolumeManager.Concrete;
using UnitOfWork.VolumeManager.DTO;
using UnitOfWork.VolumeManager.Interface;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitOfWork.Tests
{
  [TestClass]
  public class UnitTest1
  {
    [TestFixture]
    public class FetchVolumesAllTest
    {
      private IVolumeManager<List<jat>, VehicleVolume> fetchVolumesAllManager;

      [SetUp]
      public void Init()
      {
        fetchVolumesAllManager = new FetchCriteriaOptionsForVolumes();
      }

      [Test]
      public void TestFetchVolumesAll()
      {
        var vehicleVolumeInfo = VolumesTestHelper.GetVehicleVolumeInfo("F", "C", "R",
          "AUDI,MITSUBISHI,PEUGEOT", "AUDI:S1,AUDI:S2,PEUGEOT:208", -1, "2015-12-01", "2016-03-31", null);

        VehicleVolume vh = new VehicleVolume();



        var result = fetchVolumesAllManager.Manage(vh);

        Assert.AreEqual(result.Count(), 10);

      }
    }
  }
}
