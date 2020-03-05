using System;
using System.IO;


namespace File.Models
{
  public class MakeFiles
  {
    public static void Start(string projName, string nameSpace)
    {
      string dir = GetDirectory();
      MakeOutput(dir, projName, nameSpace);
    }
    public static string GetDirectory()
    {
      string path = Directory.GetCurrentDirectory();
      int homePathIndex = path.IndexOf(".Solutions") + 10;
      string homePath = path.Substring(0, homePathIndex);

      return homePath;
    }

    public static void MakeOutput(string filePath, string projName, string nameSpace)
    {
      string OutputPath = Path.Combine(filePath, projName + ".Solutions");
      Directory.CreateDirectory(OutputPath);

      string gitignore = Path.Combine(OutputPath, ".gitignore");
      System.IO.File.WriteAllText(gitignore, Copy.GitFile(projName));

      string README = Path.Combine(OutputPath, "README.md");
      System.IO.File.WriteAllText(README, "");

      //Program
      string programPath = Path.Combine(OutputPath, projName);
      Directory.CreateDirectory(programPath);

      string csproj = Path.Combine(programPath, $"{projName}.csproj");
      System.IO.File.WriteAllText(csproj, Copy.Csproj());

      string programcs = Path.Combine(programPath, $"Program.cs");
      System.IO.File.WriteAllText(programcs, Copy.ProgramCs(nameSpace));

      string modelsPath = Path.Combine(programPath, "Models");
      Directory.CreateDirectory(modelsPath);

      string modelcs = Path.Combine(modelsPath, $"{projName}.cs");
      System.IO.File.WriteAllText(modelcs, Copy.Modelscs(nameSpace));


      //Test section
      string testPath = Path.Combine(OutputPath, projName + ".Tests");
      Directory.CreateDirectory(testPath);

      string modeltestPath = Path.Combine(testPath, "ModelTests");
      Directory.CreateDirectory(modeltestPath);

      string testcsproj = Path.Combine(testPath, $"{projName}.Tests.csproj");
      System.IO.File.WriteAllText(testcsproj, Copy.TestCsproj(projName));

      string modelTestcs = Path.Combine(modeltestPath, $"{projName}Tests.cs");
      System.IO.File.WriteAllText(modelTestcs, Copy.ModelsTest(nameSpace));

    }
  }

}