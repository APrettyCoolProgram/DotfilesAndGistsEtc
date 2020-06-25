# Creating .NET Core project templates

## Creating dotnet-core-csharp-wpf-template

### Create a new project
1. Create a new WPF App (.NET Core) project.
2. Name it "dotnet-core-csharp-wpf-template".

### Add a "sourcecode.licenseheader" file
1. Add the file to the project root.
2. The contents of the file should be:
```
extensions: designer.cs generated.cs
extensions: .xaml
<!--
	<project-name>: https://github-account/repository-name
	<project-name>.<class-name>.<file-name>.xaml
	b0000.0000
	(c) <YYYY> <name-of-copyright-owner>. Licensed under the Apache License 2.0
	This project uses the dotnet-core-csharp-wpf-template (v2.2): https://github.com/aprettycoolprogram/some-templates
-->

extensions: .cs
// <project-name>: https://github-account/repository-name
// <project-name>.<class-name>.<file-name>.cs
// b0000.0000
// (c) <YYYY> <name-of-copyright-owner>. Licensed under the Apache License 2.0
// This project uses the dotnet-core-csharp-wpf-template-v2.2: https://github.com/aprettycoolprogram/some-templates

```
3. Save the "sourcecode.licenseheader" file.

### Make modifications to the MainWindow.xaml file
1. Add the license header.
2. Run FormatXML on the code.

### Make modifications to the MainWindow.xaml.cs file
1. Add the license header.
2. Run Code Cleanup on the code.

### Change the Output path
1. Right-click on the "dotnet_core_csharp_wpf_template" project
2. Click "Properties"
3. Under Build > Output, change the "Output path" to "../../build"
4. Save

### Add the following NuGet packages:
1. Microsoft.CodeAnalysis.FxCopAnalysers
2. Roslynator.Analysers

### Export the .editorconfig file
1. Tools > Options > Code Style

### Change the version number
1. Open the .csproj file and change the version to "0.0.0.0"
2. Save

## Creating dotnet-core-csharp-class-library-template
***v2.2***

### Create a new project
1. Create a new Class Library(.NET Core) project.
2. Name it "dotnet-core-csharp-class-library-template".

### Add a "sourcecode.licenseheader" file
1. Add the file to the project root.
2. The contents of the file should be:
```
extensions: designer.cs generated.cs
extensions: .xaml
<!--
	<project-name>: https://github-account/repository-name
	<project-name>.<class-name>.<file-name>.xaml
	b0000.0000
	(c) <YYYY> <name-of-copyright-owner>. Licensed under the Apache License 2.0
	This project uses the dotnet-core-csharp-wpf-template-v2.2: https://github.com/aprettycoolprogram/some-templates
-->

extensions: .cs
// <project-name>: https://github-account/repository-name
// <project-name>.<class-name>.<file-name>.cs
// b0000.0000
// (c) <YYYY> <name-of-copyright-owner>. Licensed under the Apache License 2.0
// This project uses the dotnet-core-csharp-wpf-template-v2.2: https://github.com/aprettycoolprogram/some-templates

```
3. Save the "sourcecode.licenseheader" file.

### Change the Output path
1. Right-click on the "dotnet_core_csharp_class-library_template" project
2. Click "Properties"
3. Under Build > Output, change the "Output path" to "../../build"
4. Save

### Add the following NuGet packages:
1. Microsoft.CodeAnalysis.FxCopAnalysers
2. Roslynator.Analysers

### Export the .editorconfig file
1. Tools > Options > Code Style

### Change the version number
1. Open the .csproj file and change the version to "0.0.0.0"
2. Save