# C# .NET Core 3.0 WPF Project Template for Visual Studio 2019

> This is a changelog for the Visual Studio C# .NET Core 3.0 WPF Project Template

## Build 191126
##### INFORMATION
* Project name is now "CSharpNETCoreWPF"
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
* Project name is now "CSharp_NETCore_WPF_ProjectTemplate"
##### CHANGED
* Namespace changed to CSharp_NETCore_WPF_ProjectTemplate
* Updated included dotfiles

## Build 191120
##### INFORMATION
* Project name is now "CSharp_NETCore_WPF_Template"
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
* MainWindow.Start() -> MainWindow.StartApplication()
* MainWindow.StartApplication() now contains SetupWindow() and SetupControls()
* MainWindow.StartApplication(),MainWindow.SetupWindow(), and MainWindow.SetupControls() are now static methods
* DevMode.LaunchThenQuit() -> DevMode.LaunchApplicationThenQuit()
* DevMode.Testing() -> DevMode.TestCode()
* /AppData/Images -> /AppData/Image
##### REMOVED
* MainWindow.Setup()

## Build 191023
##### INFORMATION
* Migrated to .NET Core 3.0

## Build 191021
##### CHANGED
* ../Build/ -> ../build/
##### REMOVED
* /Du/

## Build 190918
##### CHANGED
* Updated Du to b190918

## Build 190916
##### CHANGED
* Updated Du to b190916
* All XAML files have the Exended Toolkit enabled
* All XAML code has been formatted

## Build 190912
##### CHANGED
* Updated Du to b190912
* Main(): DevMode.Testing(true) -> DevMode.Testing(false)
##### REMOVED
* ../Startup/Startup.cs
* ../Startup/

## Build 190910
##### INFORMATION
* Initial release