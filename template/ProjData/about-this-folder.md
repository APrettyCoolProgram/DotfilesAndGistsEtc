# ProjData/
This file is a placeholder to ensure that the ***ProjData/*** folders are included in the GitHub repository.

### Purpose
The `ProjData/` folders contains all project data.

Project data is static data that a project needs to function.

Examples of project data:
* Images for application controls
* Audio used in an application
* Static text and configuration files
* Datafiles required for development
* Project documentation and help files

Dynamic data that a project application creates and/or manipulates should not be stored in `ProjData/`, and should instead be stored in `AppData/`

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

To copy files to `ProjData/Asset/Audio/` at runtime, set the file properties as such:
```
Build Action: None
Copy to Output Directory: Copy always
```

To copy build files in `ProjData/Asset/Audio/Embedded/` as project resources, set the file properties as such:
```
Build Action: Resource
```

> [b200708](https://github.com/APrettyCoolProgram/dotfiles-templates-and-gists-etc)