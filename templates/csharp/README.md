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
These templates are for .NET Core 5, and are not updated very often. For instructions on creating your own .NET Core 5.0 C# templates, see below.

# Usage
To use these project template in Visual Studio 2019:
1. Download the the project template you would like to use:
* [WPF Application]()

2. Copy that .zip file to `%USERPROFILE%\Documents\Visual Studio 2019\Templates\ProjectTemplates\Visual C#\`

The next time you start Visual Studio, the project template will be available to use.

# Steps to create a .NET Core C# project
You can create your own .NET Core 5.0 C# project templates following these steps:

## Create a new project
1. Create one of the following Visual Studio 2019 Projects:
  * Class Library (.NET Core)
  * Console Application (.NET Core)
  * WPF Application (.NET Core) project.
2. Name it something you like

## Change the project properties
1. Once the project solution has loaded, right click on the project and choose "Properties"
2. Under "Application > Target framework", choose ".NET 5.0"
3. Under "Application > Package" change the "Assembly version" and "Assembly file verison" to "0.0.0.0"
4. Save the project