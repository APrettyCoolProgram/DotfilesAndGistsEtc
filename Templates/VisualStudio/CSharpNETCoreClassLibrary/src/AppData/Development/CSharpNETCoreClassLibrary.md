# C# .NET Core 3.0 Class Library Project Template for Visual Studio 2019

> This is a changelog for the Visual Studio C# .NET Core 3.0 WPF Project Template

## Build 191126
##### INFORMATION
* Project name is now "CSharpNETCoreClassLibrary"
* Partial code rewrite
##### ADDED
* Microsoft.CodeAnalysis.FxCopAnalyzers NuGet package
* Roslynator.Analyzers NuGet package
##### CHANGED
* All header comments are formatted the same
* /AppData/Development/IDE -> /AppData/Development/Dotfiles
* Configuration.cs -> Config.cs
* Config.cs is now static
* DevMode.cs is now static
* Maintenance.cs is now static
* Updated dotfiles
##### REMOVED
* Configuration.Configuration() constructor
* Configuration.DevMode() constructor
* Configuration.Maintenance() constructor

## Build 191122
##### INFORMATION
* Project name is now "CSharp_NETCore_ClassLibrary_ProjectTemplate"
##### CHANGED
* Namespace changed to CSharp_NETCore_ClassLibrary_ProjectTemplate
* Updated included dotfiles

## Build 191120
##### INFORMATION
* Project name is now "CSharp_NETCore_ClassLibrary_Template"
##### ADDED
* Configuration.Configuration() constructor
* Configuration.DevMode() constructor
* Configuration.Maintenance() constructor


## Build 1911115
##### ADDED
* /AppData/Image/Embedded/
* /AppData/Image/Embedded/About_this_folder.md
* /AppData/Image/Local/
* /AppData/Image/Local/About_this_folder.md
* /AppData/Font/Embedded/
* /AppData/Font/Embedded/About_this_folder.md
* /AppData/Font/Local/
* /AppData/Font/Local/About_this_folder.md
##### CHANGED
* MainWindow.Start() -> MainWindow.StartLibrary()
* MainWindow.StartLibrary() is now static a method
* DevMode.LaunchThenQuit() -> DevMode.LaunchApplicationThenQuit()
* DevMode.Testing() -> DevMode.TestCode()
* /AppData/Images -> /AppData/Image
##### REMOVED
* MainWindow.Setup()

## Build 191023
##### INFORMATION
* Initial release