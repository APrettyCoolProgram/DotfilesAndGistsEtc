# projdata/
Required project data is stored in **projdata/**.

Project data is static data that a project needs to function, and is not created or modified by the project. Dynamic data that is created or modified by a project should be stored in the **appdata** folders.

Examples of project data:
* Images for project controls
* Audio used in an project
* Static text and configuration files
* Datafiles required for development
* Project documentation and help files

## Structure
Each of the following sub-folders may have its own structure.

| Folder            | Contents                                     |
|------------------:|:---------------------------------------------|
| `projdata/asset/` | Project assets (i.e. images, sounds, fonts)  |
| `projdata/data`   | Project data                                 |
| `projdata/dev/`   | Project development data/documentation       |
| `projdata/doc`    | Project documentation                        |
| `projdata/help/`  | Project help data                            |

## Making projdata/ available at runtime

### Visual Studio 2019
To ensure that the **projdata/** folder exists at runtime, set the properties for the `projdata/about-this-folder.md` file as such:
```
Build Action: None
Copy to Output Directory: Copy always
```
> <br>
> This file is a placeholder that ensures that the containing folder is included in a source code repositories, and available to a project at runtime.<br>
> For more information, please see [projdata](https://github.com/aprettycoolprogram/dotfiles-templates-and-gists-etc/tree/master/template/projdata) (b b200708) <br>
> <br>