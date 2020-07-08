# projdata/
Project data is static data that is not created or modified by a project. Dynamic data that is created or modified by a project should be stored in the **appdata** folders.

### Structure
| projdata/                           |                                                                   |
|:------------------------------------|:------------------------------------------------------------------|
| asset/                              | Assets (audio, images, etc) |
|   asset/                            | Assets (audio, images, etc) |
| config/                             | Configuration files |
| dev/                                | Development data |
| doc                                 | Documentation |
| help                                | Help data |
| runtime                             | Runtime data |

| projdata/asset                      |                                                                   |
|:------------------------------------|:------------------------------------------------------------------|
| audio/                              | Audio |
| font /                        | Fonts |
| image/control                 | Images used on controls|
| image/doc                     | Images used in documentation |
| image/icon                    | Icons |
| image/logo                    | Logos |
| video/screenshot              | Screenshots |

| projdata/config                     |                                                                   |
|:------------------------------------|:------------------------------------------------------------------|
| asset/audio/                        | Audio |
| asset/font /                        | Fonts |
| asset/image/control                 | Images used on controls|
| asset/image/doc                     | Images used in documentation |
| asset/image/icon                    | Icons |
| asset/image/logo                    | Logos |
| asset/video/screenshot              | Screenshots |





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