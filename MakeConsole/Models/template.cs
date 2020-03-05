using System;
using File.Models;

public class Copy
{
  public static string GitFile(string input)
  {
    string result = $"{input}/bin  \n{input}.Tests/bin \n{input}/obj \n{input}.Tests/obj";
    return result;
  }

  public static string Csproj()
  {
    string results = @"
<Project Sdk='Microsoft.NET.Sdk'>
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp2.2</TargetFramework>
  </PropertyGroup>
</Project> 
";
    return results;
  }

  public static string TestCsproj(string projName)
  {
    string result1 = @"<Project Sdk='Microsoft.NET.Sdk'>

  <PropertyGroup>
    <TargetFramework>netcoreapp2.2</TargetFramework> 
  </PropertyGroup>
  <ItemGroup>
    <PackageReference Include = 'Microsoft.NET.Test.Sdk' Version = '15.0.0'/>
    <PackageReference Include = 'MSTest.TestAdapter' Version = '1.2'/>  
    <PackageReference Include = 'MSTest.TestFramework' Version = '1.2'/>        
  </ItemGroup>
          
  <ItemGroup>
";
    string result2 = $"  <ProjectReference Include = '..\\{projName}\\{projName}.csproj'/>";
    string result3 = @"         
  </ItemGroup>
</Project> ";
    return result1 + result2 + result3;
  }

  public static string ProgramCs(string nameSpace)
  {
    string result = @"using System;
using " + nameSpace + @".Models;

namespace " + nameSpace + @"
{
  public class Program
  {
    public static void Main()
    {
     Console.WriteLine();
    }
  }

}";
    return result;
  }

  public static string ModelsTest(string nameSpace)
  {
    string result = @"using Microsoft.VisualStudio.TestTools.UnitTesting;
using " + nameSpace + @".Models;
using System;

namespace " + nameSpace + @".Tests
{
  [TestClass]
  public class MakeFilesTests
  {
    [TestMethod]
    public void MethodName_WhatItDoes_ReturnObject()
    {

    }

  }
}";

    return result;

  }

  public static string Modelscs(string nameSpace)
  {
    string result = @"using System;

namespace " + nameSpace + @".Models
{
  class Test
  {
    public static void Temp()
    {

    }
  }

}";
    return result;
  }
}