# ProjData/
Any static data that a project needs to function, and is not created or modified by the project, is stored in **ProjData/**.

Examples of project data:
* Images for project controls
* Audio used in an project
* Static text and configuration files
* Datafiles required for development
* Project documentation and help files

Data that is created or modified by a project should be stored in the **AppData** folders.

## Structure
Each of the following sub-folders may have its own structure.

| Folder            | Contents                                     |
|------------------:|:---------------------------------------------|
| `ProjData/Asset/` | Project assets (i.e. images, sounds, fonts)  |
| `ProjData/Data`   | Project data                                 |
| `ProjData/Dev/`   | Project development data/documentation       |
| `ProjData/Doc`    | Project documentation                        |
| `ProjData/Help/`  | Project help data                            |

## Making ProjData/ available at runtime
The **ProjData/** folder should be available to a project at runtime. The instructions below only affect **ProjData/**, any sub-folders will need to be modified individually.

### Visual Studio 2019
To ensure that the `ProjData/` folder exists at runtime, set the properties for the `ProjData/about-this-folder.md` file as such:
```
Build Action: None
Copy to Output Directory: Copy always
```

> This file is a placeholder that ensures that the containing folder is included in a source code repositories, and optionally available to a project at runtime. [Dotfiles, Templates, and Gists, Etc. b200708](https://github.com/APrettyCoolProgram/dotfiles-templates-and-gists-etc)