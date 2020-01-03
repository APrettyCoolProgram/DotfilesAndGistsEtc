// ====================================================================================================================
// FILENAME: DevMode.cs
//  PROJECT: ProjectName (https://github.com/GitHubAccount/project-name)
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

namespace CSharpNETCoreWPF
{
    /// <summary>
    /// Development Mode.
    /// </summary>
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