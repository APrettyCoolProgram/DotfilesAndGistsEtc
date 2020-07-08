# projdata/help/
> This file is a placeholder that ensures that the containing folder is included in a source code repositories, and available to a project at runtime.

Project help data is stored in **projdata/help/**.

## Making projdata/help/ available at runtime
### Visual Studio 2019
To ensure that the **projdata/help/** folder exists at runtime, set the properties for the `projdata/help/about-this-folder.md` file as such:
```
Build Action: None
Copy to Output Directory: Copy always
```

> Built using [projdata b200708](https://github.com/aprettycoolprogram/dotfiles-templates-and-gists-etc/tree/master/template/projdata)