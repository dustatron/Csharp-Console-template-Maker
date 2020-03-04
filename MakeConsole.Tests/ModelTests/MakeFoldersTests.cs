using Microsoft.VisualStudio.TestTools.UnitTesting;
using File.Models;
using System.IO;
using System;

namespace File.Tests
{
  [TestClass]
  public class MakeFilesTests
  {
    [TestMethod]
    public void GetDirectory_ReturnCurrentWorkingDirectory_string()
    {
      string result = MakeFiles.GetDirectory();
      string testDir = "/Users/Guest/Desktop/MakeConsole.Solutions";
      System.Console.WriteLine("Dir = " + testDir);
      Assert.AreEqual(result, testDir);
    }

  }
}