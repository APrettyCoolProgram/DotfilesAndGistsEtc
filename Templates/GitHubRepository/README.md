<!---------------------------------------------------------------------------------------------------------------------
FILENAME: README.md
PROJECT: GRU-Readme (https://github.com/APrettyCoolProgram/GRUReadme)
VERSION: Version 3.2.0.19202
UPDATED: 12-2-2019 (1:20 PM) 
AUTHORS: development@aprettycoolprogram.com

Copyright 2019 A Pretty Cool Program

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
the License. You may obtain  a copy of the License at http://www.apache.org/licenses/LICENSE-2.0.

Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
specific language governing permissions and limitations under the License.
---------------------------------------------------------------------------------------------------------------------->

<!---------------------------------------------------------------------------------------------------------------------
INFORMATION
GRUReadme is customizable README.md template written in GitHub-flavored Markdown and HTML. The source contains an
abundance of comments walking you through how to use each component.
---------------------------------------------------------------------------------------------------------------------->

<!---------------------------------------------------------------------------------------------------------------------
ARCHIVED PROJECT BANNER (Optional)
You can use this component to make it clear to readers that they are looking at an archived repository. By default,
this block of code is commented out.

* If this README.md is not being used in an archived repository, remove it entirely.
* If there is a more recent repository, you can point to it here.
* You can also explain why the repository has been archived.
----------------------------------------------------------------------------- (Remove this comment block when done) -->
<!--
***
### THIS REPOSITORY HAS BEEN ARCHIVED
[RepositoryName] Development has been moved to [**RepositoryName**](https://github.com/GitHubAccount/RepositoryName/tree/master).

You can also have an explaination of why this repository has been archived.
***
-->

<!---------------------------------------------------------------------------------------------------------------------
DEVELOPMENT BRANCH BANNER  (Optional)
You can use this component to make it clear to readers that they are looking at a development branch of your
repository. By default, this block of code is commented out.

* If this README.md is not being used in a development branch, remove it entirely.
* There is a link pointing to the stable branch of the repository.
* You can add a little blurb about the development branch, if you want.
* You can give users commands that are specific to this development branch.
----------------------------------------------------------------------------- (Remove this comment block when done) -->
<!--
***
### THIS IS THE DEVELOPMENT BRANCH
You are probably looking for the [**stable branch**](https://github.com/GitHubAccount/RepositoryName/tree/master).

Here are some commands you can use with the development branch.

```
$ ExampleCommand1
$ ExampleCommand2
```
***
-->

<!---------------------------------------------------------------------------------------------------------------------
LOGO AND SHORT BLURB (Required)
Display your repository logo (if you have one), and a short blurb describing what the repository is.
 
* The repository name is optional; sometimes it looks good, sometimes it doesn't.
* This code uses HTML for content layout.
* The repository logo is optional, but recommended.
* The repository blurb is required
* Keep the repository blurb short, and save the details for the introduction.
* Increase/decrease the logo size by increasing/decreasing the "width" value.
----------------------------------------------------------------------------- (Remove this comment block when done) -->
<h2 align="center">
  GRU Readme
  <br>
  <img src="https://github.com/APrettyCoolProgram/GRU-Readme/blob/master/reporesources/image/GruReadmeLogoLarge.png" alt="GRU Readme" width="160">
  <br>
  A README.md template for GitHub repositories
  <br>
  <br>
</h2>
<br>

<!---------------------------------------------------------------------------------------------------------------------
REPOSITORY BADGE COMPONENT (Optional)
Badges are nice looking, graphical components that give the reader important information about your project. GRUReadme
has multiple badge components. This badge component contains badges that give the user important information about the
repository itself, including:

* Project status. Choose on of these to display
* The latest release
* Supported platform(s)
* Language(s) and framework(s) used
* License used

For Project status, choose one of the following:
* Active: ![Status](https://img.shields.io/badge/status-active-brightgreen.svg)
* Maintaned: ![Status](https://img.shields.io/badge/status-maintained-green.svg)
* Depreciated: ![Status](https://img.shields.io/badge/status-depreciated-yellowgreen.svg)
* Archived: ![Status](https://img.shields.io/badge/status-archived-yellow.svg)

* HTML is used for layout, the content used Markdown, so the spaces after/before the "div" statements are required.
* GRUReadme uses badges from sheilds.io (see https://shields.io for more information about customizing badges).
* Remove badges you don't use, and add badges you want.
----------------------------------------------------------------------------- (Remove this comment block when done) -->

<div align="center">

  ![Status](https://img.shields.io/badge/status-active-brightgreen.svg)
  ![GitHub release](https://img.shields.io/github/release/aprettycoolprogram/GRU-README?label=latest%20release)
  ![MadeFor](https://img.shields.io/badge/made_for-github-blue.svg)
  ![MadeWith](https://img.shields.io/badge/made_with-markdown/html-blue.svg)
  ![License](https://img.shields.io/github/license/APrettyCoolProgram/GRU-Readme)](https://www.apache.org/licenses/LICENSE-2.0)

</div>

<!---------------------------------------------------------------------------------------------------------------------
SCREENSHOT ZERO (Optional))
If this repository is an application, include a screenshot that gives the user an idea of what your project looks like.
For example, a login screen.

* This code uses HTML for content layout.
* Increase/decrease the logo size by increasing/decreasing the "width" value (but 400 is a good default).
----------------------------------------------------------------------------- (Remove this comment block when done) -->
<div align="center">
  <img src="https://github.com/APrettyCoolProgram/GRU-Readme/blob/master/reporesources/image/screenshot-zero.png" alt="Screenshot zero" width="400">
  <br>
</div>

<!---------------------------------------------------------------------------------------------------------------------
TABLE OF CONTENTS (Optional)
A Table of Contents allows users to quickly find exactly what they are looking for.

* HTML is used for layout, the content used Markdown, so the spaces after/before the "div" statements are required.
* Each TOC entry must have a coresponding anchor
* Remove the content you don't use
----------------------------------------------------------------------------- (Remove this comment block when done) -->
<h5 align="left">

  ### CONTENTS
  [ABOUT THIS REPOSITORY](#about-this-repository)<br>
  [FEATURES](#features)<br>
  [REQUIREMENTS](#requirements)<br>
  [EXAMPLE](#example)<br>
  [BEFORE YOU BEGIN](#before-you-begin)<br>
  [GETTING STARTED](#getting-started)<br>
  [INSTALLING](#installing)<br>
  [BUILD PROCESS](#build-process)<br>
  [SETUP](#setup)<br>
  [CONFIGURATION](#configuration)<br>
  [USAGE](#usage)<br>
  [UPDATING](#updating)<br>
  [UNINSTALLING](#uninstalling)<br>
  [DEMO](#demo)<br>
  [HOW IT WORKS](#how-it-works)<br>
  [API](#api)<br>
  [FAQ](#faq)<br>
  [SUPPORT](#support)<br>
  [DEVELOPMENT](#development)<br>
  [ADDENDUM](#addendum)

</h5>

<!---------------------------------------------------------------------------------------------------------------------
ABOUT THIS REPOSITORY (Required)
This section should introduce your repository, and encourage the reader to continue reading. Some common components of
an introduction are:

* Describe what the repository is.
* What problem(s) does it solve?
* What is the motivation/philosophy behind it?
* Why should the user care or want to use it?
* List one or two noteworthy features that stand out from simular repositories
* Clarify the level of knowlege required, and note key technical concepts/technologies/frameworks used
* Use screenshots and code snippits to illustrate general functionality
* Use Markdown to make text stand out.
----------------------------------------------------------------------------- (Remove this comment block when done) -->
# ABOUT THIS REPOSITORY
![GitHub last commit (branch)](https://img.shields.io/github/last-commit/aprettycoolprogram/GRU-README/master)
![GitHub issues](https://img.shields.io/github/issues/APrettyCoolProgram/GRU-Readme)
![GitHub pull requests](https://img.shields.io/github/issues-pr/aprettycoolprogram/GRU-README)
[![GitHub contributors](https://img.shields.io/github/contributors/aprettycoolprogram/GRU-Readme)](https://github.com/aprettycoolprogram/GRU-Readme/graphs/contributors/)

**Q:** What is the most important file in your GitHub repository?

**A:** README.md

Your repository README is the first thing users will see. It's your one shot to make a good first impression, and convince the reader they should learn more about your repository. But where do you start? What makes a good README file?

GRU-README is text-file README.md template written in GitHub-flavored Markdown and HTML. A simple text editor (even GitHub itself) is all you need. The GRU-Readme source code contains an abundance of comments that walk you through each of the components. Customize those you want to use, and remove those you don't need.

GRU-Reame was build on the shoulders of giants. Please see the [Addendum](#addendum) for additional README.md resources.

<!---------------------------------------------------------------------------------------------------------------------
FEATURES (Optional)
List some important features of your repository here. This shouldn't be an exhaustive list, just the cool stuff.
----------------------------------------------------------------------------- (Remove this comment block when done) -->
# FEATURES
* It's just a simple text file!
* Source code comments walk you through everything!

<!---------------------------------------------------------------------------------------------------------------------
REQUIREMENTS (Optional)
     Requirements are what a user will need in order to use this repository in any capacity. For example, GRU-Readme
     requires a text editor.
----------------------------------------------------------------------------- (Remove this comment block when done) -->
# REQUIREMENTS
* A computer
* Internet access
* A text editor
* Basic knowledge of [Markdown](https://daringfireball.net/projects/markdown/) syntax

<!---------------------------------------------------------------------------------------------------------------------
EXAMPLES
Examples uses of this repository, either links to use cases, or screenshots.
----------------------------------------------------------------------------- (Remove this comment block when done) -->
# EXAMPLES
Some examples of GRU-Readme in action:

* [GRU-Readme](https://github.com/APrettyCoolProgram/GRU-Readme/tree/master) (duh)

<!---------------------------------------------------------------------------------------------------------------------
BEFORE YOU BEGIN (Optional)
This section is for important information that the user should know before they continue, or that doesn't really fit
anywhere else.
----------------------------------------------------------------------------- (Remove this comment block when done) -->
# BEFORE YOU BEGIN
A GitHub README.md file can be written in GitHub-flavored Markdown, HTML, or a mix of both. Each of these formats have their advantages and disadvantages, and a well-written README will leverage the strength of each. In order to use GRU-README templates, you'll need to understand at least the basics of both.

#### What is markdown?
[Markdown](https://en.wikipedia.org/wiki/Markdown) is a lightweight markup language with plain text formatting syntax. Markdown's key design goal is *readability*. GRU-README uses GitHub-flavored Markdown, for the README *content*.

Here are some excellent Markdown resources:

* You can read the [GitHub-flavored Markdown Spec](https://github.github.com/gfm/), or read he GitHub Guide to [Mastering Markdown](https://guides.github.com/features/mastering-markdown/)
* [Markdown](https://daringfireball.net/projects/markdown/), [Markdown Basics](https://daringfireball.net/projects/markdown/basics), and [Markdown Syntax](https://daringfireball.net/projects/markdown/syntax) by John Gruber, the creator of Markdown
* Adam Pritchard has a nice [Markdown Cheatsheet](https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet)

#### What is HTML?
[HTML](https://en.wikipedia.org/wiki/HTML) is the standard markup language for creating web pages and web applications. Keep in mind that GitHub README.md files do not fully support HTML syntax - a small subset of HTML tags are allowed. In addition, most HTML structures are either unnecessary (thanks to Markdown), or unsupported. For the most part, GRU Readme templates use HTML to modify the *layout* of your README, such as complex tables or content positioning

<!---------------------------------------------------------------------------------------------------------------------
GETTING STARTED (Optional)
This section is an overview of how to install/configure/build/use the project. Always point the reader back to the list
of requirements, then list any pre-requisites, recommendations, and/or dependancies.

* Pre-requisites are different than requirements. Requirements are what you will need in order to use the project in
  any capacity (i.e. a text editor), and pre-requisites are what you need once you've met the requirements and have
  decided to use the project (i.e. a copy of the GRU-Readme file).
* Dependancies
* Recommendations
----------------------------------------------------------------------------- (Remove this comment block when done) -->
# GETTING STARTED
Before we continue, please verify you have met the [requirements](#requirements).

### PRE-REQUISITES
You will need a copy of the current GRU-Readme release, which you can find [here](https://github.com/APrettyCoolProgram/GRU-Readme/blob/master/README.md).

### DEPENDENCIES
List any dependencies, and instructions to install them, here.

### RECOMMENDATIONS
Remember: you never get a second chance to make a first impression. Put aside the necessary amount of time to create a document that is accurate, grammatically correct, and informative. Don't rush this!

<!---------------------------------------------------------------------------------------------------------------------
INSTALLATION (Optional)
Steps to install this project, with the following default sections (remove those you don't need):

* INSTALLATION: A brief overview of the installation process, and a link to the project requirements.
* How to use in a new project (if applicable)
* How to use in an existing project (if applicable)
* Windows installation (if applicable)
* MacOS installation (if applicable)
* Linux installation (if applicable)
* Other OS installation (if applicable)
----------------------------------------------------------------------------- (Remove this comment block when done) -->
# INSTALLING
You don't really *install* GRU-Readme, you just incorporate it into your project.

### USING GRU README IN A NEW PROJECT:
If you are using GRU-Readme in a new project, it's probably easier to just clone GRU-Readme and use that as your
repository base. This project is pretty bare-bones, and you can build around it. You will, however, be using the relatively
strict .gitignore that comes with GRU-Readme (which you can edit/replace/delete).

### USING GRU README IN AN EXISTING:
1. Copy the "reporesources" folder from GRU-Readme to the root of your repository
2. Copy this "README.md" file to the root of your repository

In both new and existing projects, GRU-Readme will point to files in the "reporesources" folder. This folder contains images that GRU-Readme uses. Feel free to rename that, or point to files in a different location.

The rest of this section are examples for more traditional installations.

### WINDOWS
1. The steps to install the project in Windows
2. Use both Markdown and/or HTML
3. Include screenshots when possible.
4. Remove this section if the project doesn't support Windows (and mention that in the "Other operating systems" section below).

### MACOS
1. The steps to install the project in MacOS
2. Use both Markdown and/or HTML
3. Include screenshots when possible.
4. 4. Remove this section if the project doesn't support MacOS (and mention that in the "Other operating systems" section below).

### LINUX
1. The steps to install the project in Linux
2. Use both Markdown and/or HTML
3. Include screenshots when possible.
4. Remove this section if the project doesn't support Linux (and mention that in the "Other operating systems" section below).

### OTHER OPERATING SYSTEMS
1. The steps to install the project in other operating systems
2. Use both Markdown and/or HTML
3. Include screenshots when possible.
4. If other operating systems are not supported, mention that here.

<!---------------------------------------------------------------------------------------------------------------------
BUILD PROCESS (Optional)
Build process instructions.
----------------------------------------------------------------------------- (Remove this comment block when done) -->
# BUILD PROCESS
If your project has a build process, document it here.

<!---------------------------------------------------------------------------------------------------------------------
SETUP (Optional)
Instructions to setup your project.
----------------------------------------------------------------------------- (Remove this comment block when done) -->
# SETUP
If your project has a setup procedure, document it here. For example, you may need to make changes to a configuration
file before using the project.

<!---------------------------------------------------------------------------------------------------------------------
CONFIGURATION (Optional)
Describe how to configure the project, if needed.
  
* This section is really going to depend on configuration syntax.
* You can use Markdown and/or HTML.
----------------------------------------------------------------------------- (Remove this comment block when done) -->
# CONFIGURATION
Many projects offer configuration options, which should be listed here. Keep in mind that any configuration that needs to be done before using this project should be listed in the [Setup](#setup) section above.

Since GRU-Readme doens't have any configuration, per se, I'll use [GRU-ReadmeToPDF](https://github.com/APrettyCoolProgram/GRU-ReadmeToPDF) as an example.

The GRU-ReadmeToPDF configuration file is named "project.config", and has the following options:

* **GitHubAccountName**<br>
(*"GitHub-account-name"*)<br>
This is the name of your GitHub account. For example: github.com/***APrettyCoolProgram***

* **StartFlag**<br>
(*"&lt;article"*)<br>
This is the line in the README.md source HTML that tells GRU-ReadmeToPDF to start capturing data.

### Important notes about the configuration
Optional notes about configuration go here.

<!---------------------------------------------------------------------------------------------------------------------
USAGE (Optional)
How to use the project.
----------------------------------------------------------------------------- (Remove this comment block when done) -->
# USAGE
The GRU-Readme README.md file is filled with comments like this:
```
<!-- ABOUT THIS PROJECT ---------------------------------------------------------- [ REQUIRED ] ---
     This section should introduce your project, and encourage the reader to continue reading.
     Some common components of an introduction are:
     
	 * Describe what the project does, and what problem(s) it solves
     * What is the motivation/philosophy behind the project
     * Why should the user care or want to use this project
     * List one or two noteworthy features that stand out from the rest
     * Clarify the level of knowlege required, and note key technical
       concepts/technologies/frameworks used
     * Use screenshots and code snippits to illustrate general functionality
     * Use Markdown to make text stand out.
------------------------------------------------------- [ REMOVE THIS COMMENT BLOCK WHEN DONE ] -->;
```
These comments are intended to walk you through creating content for each component, and can be removed to keep your final README.md clean. Some components are [REQUIRED], and some are [OPTIONAL], but in reality these are just guidelines.

The easiest way to use GRU-Readme is to simply open README.md in a text editor, start at the top, and follow the comments.

### IMPORTANT NOTES ABOUT USAGE
Optional notes about usage go here.

<!---------------------------------------------------------------------------------------------------------------------
UPDATING (Optional)
Updating procedure.
----------------------------------------------------------------------------- (Remove this comment block when done) -->
# UPDATING
Any updating procedures should be documented here.

<!---------------------------------------------------------------------------------------------------------------------
UNINSTALL (Optional)
Uninstall procedure.
----------------------------------------------------------------------------- (Remove this comment block when done) -->
# UNINSTALLING
Any uninstall procedures should be documented here.

<!---------------------------------------------------------------------------------------------------------------------
API (Optional)
API documentation.
----------------------------------------------------------------------------- (Remove this comment block when done) -->
# API
If your project contains an API, it should be documented here.

<!---------------------------------------------------------------------------------------------------------------------
HOW IT WORKS (Optional)
Sometimes it's fun to let users know how the magic happens.
----------------------------------------------------------------------------- (Remove this comment block when done) -->
# HOW IT WORKS
Sometimes it's fun to let users know how the magic happens.

<!---------------------------------------------------------------------------------------------------------------------
FAQ (Optional)
Frequently Asked Questions.
----------------------------------------------------------------------------- (Remove this comment block when done) -->
# FAQ
### Are you nice?
I think so.

<!---------------------------------------------------------------------------------------------------------------------
SUPPORT (Optional)
Support information.
----------------------------------------------------------------------------- (Remove this comment block when done) -->
# SUPPORT
Good luck!

<!---------------------------------------------------------------------------------------------------------------------
DEVELOPMENT (Optional)
Development information.
----------------------------------------------------------------------------- (Remove this comment block when done) -->
# DEVELOPMENT
The project is currently being developed by A Pretty Cool Program. If your interested in what's coming in the next release, the development branch of the project can be found [development branch](https://github.com/APrettyCoolProgram/GRU-Readme/tree/development).

### CONRIBUTING
If you are interested in contributing to this project, please see the [contributing guidelines](https://github.com/APrettyCoolProgram/GRU-Readme/blob/master/APrettyCoolProgramProjects/CODE_OF_CONDUCT.md).

<!---------------------------------------------------------------------------------------------------------------------
ADDENDUM (Optional)
Additional information.
----------------------------------------------------------------------------- (Remove this comment block when done) -->
# ADDENDUM 
### ACKNOWLEDGEMENTS
While designing these templates, I read, researched, and borrowed ideas from existing README resources, and this project would not have been possible without them.

* [The Documentation Compendium](https://github.com/kylelobo/The-Documentation-Compendium/blob/master/en/README_TEMPLATES/Standard.md) by kyleobo
* [Readme Driven Development](http://tom.preston-werner.com/2010/08/23/readme-driven-development.html) by Tom Preston-Werner
* Pretty much every example in [Awesome README](https://github.com/matiassingers/awesome-readme) by Matias Singers
* [Art of README](https://github.com/noffle/art-of-readme) by noffel
* [Make a README](https://www.makeareadme.com/) by Danny Guo
* [Structured README](https://github.com/shaloo/structuredreadme) by Shaloo Shalini
* [Zalando's README Template](https://github.com/zalando/zalando-howto-open-source/blob/master/READMEtemplate.md) by Zalando
* [How to write documentation that's actually useful](https://www.hpe.com/us/en/insights/articles/how-to-write-documentation-thats-actually-useful-1707.html) by Steven Vaughan-Nichols
* [Badges](https://github.com/Naereen/badges) by Naereen

### PROJECT RESOURCES
* [Repository](https://github.com/APrettyCoolProgram/GRU-Readme)
* [Homepage](https://github.com/APrettyCoolProgram/GRU-Readme)
* [Changelog](https://github.com/APrettyCoolProgram/GRU-Readme/blob/master/CHANGELOG.md)
* [Issues](https://github.com/APrettyCoolProgram/GRU-Readme/issues)
* [Pull requests](https://github.com/APrettyCoolProgram/GRU-Readme/pulls)
* [Project board](https://github.com/APrettyCoolProgram/GRU-Readme/projects)
* [Wiki](https://github.com/APrettyCoolProgram/GRU-Readme/wiki)
* [Security alerts](https://github.com/APrettyCoolProgram/GRU-Readme/network/alerts)
* [Insights](https://github.com/APrettyCoolProgram/GRU-Readme/pulse)
* [Code of conduct](https://github.com/APrettyCoolProgram/GRU-Readme/blob/master/CODE_OF_CONDUCT.md)
* [Contributing](https://github.com/APrettyCoolProgram/GRU-Readme/blob/master/CONTRIBUTING.md)
* [License](https://github.com/APrettyCoolProgram/GRU-Readme/blob/master/LICENSE.md)
* [Testing procedures](https://github.com/APrettyCoolProgram/GRU-Readme/blob/master/doc/testing-procedures.md)
* [Development notes](https://github.com/APrettyCoolProgram/GRU-Readme/blob/master/doc/development-notes.md)

### DOCUMENTATION

### BUILT WITH
* [shields.io](https://shields.io/)

### USED BY

### RELATED PROJECTS
<div>
  <a href="https://github.com/APrettyCoolProgram/GRU">
    <img src="https://github.com/APrettyCoolProgram/GRU/blob/master/reporesources/image/GruLogoLarge.png" align="left" title="GRU" width="100">
  </a>
  <br>
  <a href="https://github.com/APrettyCoolProgram/GRU"><b>GRU</b></a>
  <br>
  A collection of utilities for GitHub code repositories 
</div>
<br>

### ADDITIONAL
Suggestions for additional reading go here.

### LICENCING
Licensing information goes here.

### LINKS
Project links go here.

<!---------------------------------------------------------------------------------------------------------------------
DEVELOPER INFORMATION (Required)
Developer information.
----------------------------------------------------------------------------- (Remove this comment block when done) -->
***

<div align="center">

  [![Developed by](https://img.shields.io/badge/developed%20by-A%20Pretty%20Cool%20Program-17806D.svg)](https://aprettycoolprogram.com)&nbsp;
  [![GitHub](https://img.shields.io/github/followers/aprettycoolprogram.svg?label=GitHub&style=social)](https://github.com/APrettyCoolProgram)&nbsp;
  [![Twitter](https://img.shields.io/twitter/follow/aprettycoolprog.svg?label=Twitter&style=social)](https://twitter.com/aprettycoolprog)&nbsp;
  [![Feedback](https://img.shields.io/badge/contact-info@aprettycoolprogram.com-17806D.svg)](mailto:feedback@aprettycoolprogram.com)&nbsp;
  [![Built using](https://img.shields.io/badge/README%20built%20using-GRU%20README-17806D.svg)](https://github.com/APrettyCoolProgram/GRU--Readme)&nbsp;

</div>
