# C# .NET Core 3.0 WPF Project Template for Visual Studio 2019

> This is a changelog for the Visual Studio C# .NET Core 3.0 WPF Project Template

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