// ============================================================================================================ 2:10 PM
//    FILENAME: DevMode.cs
//       BUILD: YYYYMMDD
//     PROJECT: ProjectName (https://github.com/GitHubAccount/ProjectName)
//     AUTHORS: your.email@here.com
//   COPYRIGHT: Copyright YYYY You
//     LICENSE: LicenseName
// ====================================================================================================================

/* Development Mode logic.
 */
using System;

namespace CSharpNETCoreWPFProjectTemplate
{
    public static class DevMode
    {
        /// <summary>Launch the application, do something(s), then quit.</summary>
        /// <param name="quitAfterLaunch">Determines if any of this code runs. [true, FALSE]</param>
        public static void LaunchApplicationThenQuit(bool quitAfterLaunch = false)
        {
            /* There may be cases that you want to do something (i.e. build a configuration file that your application
             * needs) prior to using the application. DevMode.LaunchApplicationThenQuit() will do whatever is added
             * in the "// YOUR CODE HERE" block, then immediately (and not gracefully) quit.
             *
             * For this to work, you'll need to have "DevMode.LaunchApplicationThenQuit(true)" immediately after the
             * "InitializeComponent()" statement in the MainWindow() constructor. Since executing the code in this
             * method can lead to unintended consequences, the quitAfterLaunch boolean automatically defaulted to
             * "false", and you'll need to call "DevMode.LaunchApplicationThenQuit(true)" implicitly.
             */
            if(quitAfterLaunch)
            {
                // YOUR CODE HERE.
                Environment.Exit(0);
            }
        }

        /// <summary>Allows you to test code in Development Mode.</summary>
        /// <param name="useTestCode">[true, FALSE]</param>
        public static void TestCode(bool useTestCode = false)
        {
            /* There may be cases that you want to quickly test some code, and then continue running your application.
             * DevMode.TestCode() will do whatever is added in the "// YOUR CODE HERE" block, then continue running
             * your application.
             *
             * For this to work, you'll need to have "TestCode(true)" immediately after the
             * "DevMode.LaunchApplicationThenQuit()" statement in the MainWindow() constructor. Since executing the
             * code in this  method can lead to unintended consequences, the quitAfterLaunch boolean automatically
             * defaulted to "false", and you'll need to call "DevMode.TestCode(true)" implicitly.
             */
            if(useTestCode)
            {
                // YOUR CODE HERE
            }
        }

        /// <summary>Tests something with an ActionButton.</summary>
        /// <param name="actionButtonNumber"></param>
        public static void ActionButton(int actionButtonNumber)
        {
            /* There may be cases that you want to have a button tests something (i.e. you want to test what should
             * happen when an event fires, but you don't want to create the UI yet). DevMode.ActionButton() will do
             * whatever is added in the "// YOUR CODE HERE" block. You can either have the Action Button event handler
             * contain code that will eventually make its way to  the final UI, or call "DevMode.ActionButton(01)",
             * which will do whatever the code in this method says.
             *
             * You can have any number of DevMode action buttons, and can reuse them for different testing purposes.
             */
            switch(actionButtonNumber)
            {
                case 01:
                    // YOUR CODE HERE
                    break;

                default:
                    break;
            }
        }
    }
}