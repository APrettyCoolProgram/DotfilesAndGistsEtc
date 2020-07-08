# projdata/
| /                                   |                                                                   |
|:------------------------------------|:------------------------------------------------------------------|
| asset/                              | Assets |
| asset/audio/                        | Audio |
| asset/font /                        | Fonts |
| asset/image/                        | Images |
| asset/image/control/                | ...for controls |
| asset/image/control/                | ...for documentation |
| asset/video/                        | Video |
| aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa | aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa |






| `projdata/data`     | Project data                                |
| `projdata/dev/`     | Project development data/documentation      |
| `projdata/doc`      | Project documentation                       |
| `projdata/help/`    | Project help data                           |
| `projdata/runtime/` | Project runtime                             |












| Folder            | Contents                                                                    |
|------------------:|:----------------------------------------------------------------------------|
| `audio/`          | Audio files that are copied locally to **projdata/asset/audio/** at runtime |
| `audio/embedded/` | Audio files that are built as a project resource.                           |



> This file is a placeholder that ensures that the containing folder is included in a source code repositories, and available to a project at runtime.

Required project data is stored in **projdata/**.

Project data is static data that is not created or modified by the project. Dynamic data that is created or modified by a project should be stored in the **appdata** folders.

Examples of project data:
* Images for project controls
* Audio used in an project
* Static text and configuration files
* Datafiles required for development
* Project documentation and help files

## Structure
| Folder              | Contents                                    |
|--------------------:|:--------------------------------------------|
| `projdata/asset/`   | Project assets (i.e. images, sounds, fonts) |
| `projdata/data`     | Project data                                |
| `projdata/dev/`     | Project development data/documentation      |
| `projdata/doc`      | Project documentation                       |
| `projdata/help/`    | Project help data                           |
| `projdata/runtime/` | Project runtime                             |

## Making projdata/ available at runtime
### Visual Studio
To ensure that the **projdata/** folder exists at runtime, set the properties for the `projdata/about-this-folder.md` file as such:
```
Build Action: None
Copy to Output Directory: Copy always
```

> Built using [projdata b200708](https://github.com/aprettycoolprogram/dotfiles-templates-and-gists-etc/tree/master/template/projdata)