# projdata/
The **projdata/** folder contains all project data.

Project data is static data that is not created or modified by a project. Dynamic data that is created or modified by a project should be stored in the **appdata** folders.

# Structure
This is the top level.
| **projdata/**                       |                                                                   |
|:------------------------------------|:------------------------------------------------------------------|
| [asset/](#project-assets)           | Project assets (ex: audio files, images, fonts) |
| [config/](#project-configurations)  | Project configuration files |
| [dev/](#project-development)        | Development data |
| [doc/](#project-documentation)      | Documentation |
| [runtime/](#project-runtime)        | Runtime data |

### Project assets
All project assets are stored in **projdata/asset/**.

Examples of project assets are:
* An image for a button control
* A sound effect when a button is pushed
* A non-standard font

| **projdata/asset/**                 | Asset type/sub-type                                               |
|:------------------------------------|:------------------------------------------------------------------|
| asset/audio/                        | Audio |
| asset/font /                        | Fonts |
| asset/image/control                 | Images used on controls |
| asset/image/doc                     | Images used in documentation |
| asset/image/icon                    | Icons |
| asset/image/logo                    | Logos |
| asset/video/screenshot              | Screenshots |
| asset/video/                        | Video |

### Project configurations
All project assets are stored in **projdata/config/**.

### Project development
Development data is stored in **projdata/dev/**.

Examples of development development data:
* Development notes and code snippits
* Data used during development
* Information about third party components

| **projdata/dev/**                   |                                                                   |
|:------------------------------------|:------------------------------------------------------------------|
| dev/archive/                        | Development data |
| dev/doc/                            | Development data |

### Project documentation
Development data is stored in **projdata/doc/**.

Examples of project documentation:
* Project manuals
* Project documents (ex: changelogs, roadmaps, etc)

| **projdata/dev/**                   |                                                                   |
|:------------------------------------|:------------------------------------------------------------------|
| doc/help/                           | Documentation |
| doc/howto/                          | Documentation |
| doc/man/                            | Documentation |
| doc/proj/                           | Documentation |

### Project runtime
All runtime data is stored in **projdata/runtime/**.











| Folder            | Contents                                                                    |
|------------------:|:----------------------------------------------------------------------------|
| `audio/`          | Audio files that are copied locally to **projdata/asset/audio/** at runtime |
| `audio/embedded/` | Audio files that are built as a project resource.                           |



> This file is a placeholder that ensures that the containing folder is included in a source code repositories, and available to a project at runtime.



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