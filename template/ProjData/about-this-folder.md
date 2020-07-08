# ProjData/
This file is a placeholder to ensure that the ***ProjData/*** folders included are the GitHub repository, and are also
created (if they don't exist already) at runtime.

### Purpose
All project data belongs here.

Project data is static data that an project needs to function.

Examples of project data:
* Images for application controls
* Audio used in an application
* Static text and configuration files
* Datafiles required for development
* Project documentation and help files

Dynamic data that a project creates and/or manipulates should not be stored in `ProjData/*`, and should instead be stored in `AppData/*`

### Structure
Each of the following locations may have its own folder structure.

| Folder            | Contents                                     |
|------------------:|:---------------------------------------------|
| `ProjData/Asset/` | Project assets (i.e. images, sounds, fonts)  |
| `ProjData/Data`   | Project data                                 |
| `ProjData/Dev/`   | Project development data/documentation       |
| `ProjData/Doc`    | Project documentation                        |
| `ProjData/Help/`  | Project help data                            |