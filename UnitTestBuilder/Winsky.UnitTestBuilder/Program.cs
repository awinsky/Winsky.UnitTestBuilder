
using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis.MSBuild;



const string path =  @"C:\Users\winsky\source\repos\Winsky.UnitTestBuilder\UnitTestBuilder\UnitTestBuilder.sln";
const string projectName = "LibraryToBeTested"; //"LibraryToBeTested";




var visualStudioInstances = MSBuildLocator.QueryVisualStudioInstances();



MSBuildLocator.RegisterMSBuildPath(@"C:\Program Files\dotnet\sdk\6.0.302");

var workspace = MSBuildWorkspace.Create();
var sln = await workspace.OpenSolutionAsync(path);

var diagnostics = workspace.Diagnostics;
foreach (var diagnostic in diagnostics)
{
    Console.WriteLine(diagnostic.Message);
}

var project = sln.Projects.FirstOrDefault(x => x.Name == projectName);
if (project == null) return;
var sampleToAnalyzeCompilation = await project.GetCompilationAsync();

foreach (var document in project.Documents)
{
    var tree = await document.GetSyntaxTreeAsync();
}


Console.ReadLine();