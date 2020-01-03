// ====================================================================================================================
// FILENAME: DevMode.cs
//  PROJECT: ProjectName (https://github.com/GitHubAccount/ProjectName)
//  UPDATED: MM-DD-YY (HH:MM AM)
//  AUTHORS: your.email@here.com
//
// Copyright [yyyy] [name of copyright owner]
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain  a copy of the License at http://www.apache.org/licenses/LICENSE-2.0.
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.
//
// ====================================================================================================================

/* Application Development Mode logic.
 *
 * Please see documentation at the end of this file.
 */
using System;

namespace CSharpNETCoreConsole
{
    // Application development mode.
    public static class DevMode
    {
        /// <summary>
        /// Use DevMode.
        /// </summary>
        /// <param name="startAppThenQuit">[true/false]</param>
        /// <param name="quickCodeTest">[true/false]</param>
        public static void UseDevModes(bool startAppThenQuit,bool quickCodeTest)
        {
            if(startAppThenQuit)
            {
                StartAppThenQuit();
            }

            if(quickCodeTest)
            {
                QuickCodeTest();
            }
        }

        /// <summary>
        /// Launch the application, do something(s), then quit.
        /// </summary>
        public static void StartAppThenQuit()
        {
            // CODE HERE
            Environment.Exit(0);
        }

        /// <summary>
        /// Test temporary code/functionality.
        /// </summary>
        public static void QuickCodeTest()
        {
            // CODE HERE
        }

        /// <summary>
        /// Tests a button's functionality.
        /// </summary>
        /// <param name="actionButtonNumber">i.e. "btnAction01"</param>
        public static void ActionButtonClicked(int actionButtonNumber)
        {
            switch(actionButtonNumber)
            {
                case 01:
                    // CODE HERE
                    break;
            }
        }
    }
}


/*

# Development Mode documentation
**Development Mode* (DevMode) allows you to do a few special things when an application starts.

Every CSharpNETCoreWPF project has a line in MainWindow() that looks like this:

```
DevMode.UseDevModes(true,false);
```
which calls `UseDevModes()` in DevMode.cs:
```
UseDevModes(bool startAppThenQuit,bool quickCodeTest)
```

### StartAppThenQuit()
There may be cases that you want to do something (i.e. build a configuration file that your application needs) prior to
using the application. StartAppThenQuit() will do whatever is added in the "// CODE HERE" block, then immediately (and
not gracefully) quit.

For this to work, the MainWindow constructor needs to look like this:
```
public MainWindow()
{
    InitializeComponent();

    DevMode.UseDevModes(true, false);
    DevMode.QuickCodeTest();

    StartApplication();
}
```
where `DevMode.UseDevModes(*TRUE*, true/false)`

### QuickTestCode()
There may be cases that you want to quickly test some code, and then continue running your application.
DevMode.QuickTestCode() will do whatever is added in the "// CODE HERE" block, then continue running your application.

For this to work, the MainWindow constructor needs to look like this:
```
public MainWindow()
{
    InitializeComponent();

    DevMode.UseDevModes(false,true);
    DevMode.QuickCodeTest();

    StartApplication();
}
```
where `DevMode.UseDevModes(true/false, *TRUE*)`

### ActionButtonClicked()
There may be cases that you want to have a button tests something (i.e. you want to test what should happen when an
event fires, but you don't want to create the UI yet). DevMode.ActionButton() will do whatever is added in
the "// CODE HERE" block. You can either have the Action Button event handler contain code that will eventually make
its way to  the final UI, or call "DevMode.ActionButton(01)", which will do whatever the code in this method says.

You can have any number of DevMode action buttons, and can reuse them for different testing purposes.
*/
