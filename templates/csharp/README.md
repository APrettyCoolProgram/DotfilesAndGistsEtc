<!-- my-developement-environment/templates/csharp/README.md 201111 -->

<!-- NOTE: The HTML indentations have to stay this way to work. -->
<table>
<tr>
<td img src="repository-data/image/document/readme/spacer.png" alt="blank-spacer" width="1000" height="1">

  ### CONTENTS
  [ABOUT THIS PROJECT](#about-this-project)<br>
  [USAGE](#usage)<br>
  [STEPS TO CREATE](#steps-to-create)<br>

</td>
</tr>
</table>

# About these templates
There are three .NET Core C# templates:
* [Class Library]()
* [Console Application]()
* [WPF Application]()

# Usage
To use these project template in Visual Studio 2019:
1. Download the the project template you would like to use:
* [Class Library]()
* [Console Application]()
* [WPF Application]()

2. Copy that .zip file to `%USERPROFILE%\Documents\Visual Studio 2019\Templates\ProjectTemplates\Visual C#\`

The next time you start Visual Studio, the project template will be available to use.

# Steps to create a .NET Core C# project template
The above templates are not very complex, and are therefore rarely updated.

You can create your own .NET Core C# project templates following these steps:

### Create a new project
1. Create a new Class Library (.NET Core), Console Application (.NET Core), or WPF Application (.NET Core) project.
2. Name it "dotnet-core-csharp-[class-library/console-application/wpf-application]-template".

### Add the following NuGet packages:
1. [Microsoft.CodeAnalysis.FxCopAnalysers](https://github.com/dotnet/roslyn-analyzers)
2. [Roslynator.Analysers](https://github.com/JosefPihrt/Roslynator)

### Change the version number
1. Open the .csproj file and change the version to **0.0.0.0**
2. **Save**