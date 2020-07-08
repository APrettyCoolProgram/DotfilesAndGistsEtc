# About ProjData/
This file is a placeholder that ensures that the **ProjData/** folders:
* Are included in a source code repositories
* Are available to a project at runtime

### Purpose of ProjData/
The **ProjData/** folders contain required project data.

Project data is data that a project needs to function. Project data is generally static, and is not created/modified by the project/application. Data that is create/modified by a project/application should be stored in the **AppData** folders.

Examples of project data:
* Images for application controls
* Audio used in an application
* Static text and configuration files
* Datafiles required for development
* Project documentation and help files

### Structure
Each of the following sub-folders may have its own structure.

| Folder            | Contents                                     |
|------------------:|:---------------------------------------------|
| `ProjData/Asset/` | Project assets (i.e. images, sounds, fonts)  |
| `ProjData/Data`   | Project data                                 |
| `ProjData/Dev/`   | Project development data/documentation       |
| `ProjData/Doc`    | Project documentation                        |
| `ProjData/Help/`  | Project help data                            |

### Copying `ProjData/` locally at runtime

#### Visual Studio 2019
To copy files to `ProjData/Asset/Audio/` at runtime, set the file properties as such:
```
Build Action: None
Copy to Output Directory: Copy always
```

To copy build files in `ProjData/Asset/Audio/Embedded/` as project resources, set the file properties as such:
```
Build Action: Resource
```

> [Dotfiles, Templates, and Gists, Etc. b200708](https://github.com/APrettyCoolProgram/dotfiles-templates-and-gists-etc)