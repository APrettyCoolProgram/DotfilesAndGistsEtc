# C# .NET Core 3.0 Class Library Project Template for Visual Studio 2019

> This is a changelog for the Visual Studio C# .NET Core 3.0 Class Library Project Template

## Build 200115
##### ADDED
* ../appdata/about-this-folder.md
* ../appdata/dev/dotfile/editorconfig/
* ../appdata/dev/dotfile/git/
* ../appdata/dev/dotfile/rider/
* ../appdata/dev/dotfile/visual-studio/
* ../appdata/dev/dotfile/visual-studio-code/
* ../appdata/extension/
* ../appdata/external/
* ../appdata/scripts/
* ../appdata/tools/
##### CHANGED
* ../AppData/ -> ../appdata/
* ../appdata/Cache/ -> ../appdata/cache/
* ../appdata/Configuration/-> ../appdata/conf/
* ../appdata/Development/ -> ../appdata/dev/
* ../appdata/Document/ -> ../appdata/doc/
* ../appdata/Export/ -> ../appdata/export/
* ../appdata/Font/ -> ../appdata/font/
* ../appdata/Image/ -> ../appdata/image/
* ../appdata/Import/ -> ../appdata/import/
* ../appdata/Runtime/ -> ../appdata/runtime/
* ../appdata/Temp/ -> ../appdata/temp/
* ../appdata/dev/dotfiles/ -> ../appdata/dev/dotfile/
* ../appdata/font/Embedded/ -> ../appdata/font/embedded/
* ../appdata/font/Local/ -> ../appdata/font/local/
* ../appdata/image/Embedded/ -> ../appdata/image/embedded/
* ../appdata/image/Local/ -> ../appdata/image/local/
* Updated CSharpNETCoreWPF.sln.licenseheader

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