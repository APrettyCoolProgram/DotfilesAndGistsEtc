# C# .NET Core 3.0 Class Library Project Template for Visual Studio 2019

> This is a changelog for the Visual Studio C# .NET Core 3.0 Class Library Project Template

## Build 200103
##### ADDED
* Build now builds to "../bin/"
* XML documentation is exported to "../bin/
* ../AppData/Cache/
* ../AppData/Export/
* ../AppData/Import/
##### CHANGED
* Renamed "AboutThisFolder.md" files to "about-this-folder.md"
* Updated "about-this-folder.md" files
* ../AppData/Document/CHANGELOG.md -> ../AppData/Development/changelog.md
* ../AppData/Document/LICENSE.md -> ../AppData/Development/license.md
* ../AppData/Document/NOTICES.md -> ../AppData/Development/notices.md
* ../AppData/Development/DevelopmentNotes.md -> ../AppData/Development/development-notes.md
* ../AppData/Development/KnownIssues.md -> ../AppData/Development/known-issues.md
* ../AppData/Development/Roadmap.md -> ../AppData/Development/roadmap.md
* ../AppData/Development/ScratchData.md -> ../AppData/Development/scratch-data.md
* ../AppData/Development/CSharpNETCoreWPF.md -> ../AppData/Development/changelog-csharp-netcore-wpf.md
* ../Config/ -> ../Configuration/
* ../Config/Config.cs -> ../Configuration/Configuration.cs


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