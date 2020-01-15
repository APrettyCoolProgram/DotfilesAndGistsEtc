// ====================================================================================================================
// FILENAME: MainWindow.xaml.cs
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

/* Application MainWindow logic.
 */
using System.Windows;

namespace CSharpNETCoreWPF
{
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Interaction logic for MainWindow.xaml.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            DevMode.UseDevModes(false, false);

            StartApplication();
        }

        /// <summary>
        /// Initializes the application.
        /// </summary>
        private static void StartApplication()
        {
            CustomizeWindow();
            CustomizeControls();

            /* YOUR CODE HERE
             */
        }

        /// <summary>
        /// Customize the MainWindow.
        /// </summary>
        private static void CustomizeWindow()
        {
            /* YOUR CODE HERE
             */
        }

        /// <summary>
        /// Customize window controls.
        /// </summary>
        private static void CustomizeControls()
        {
            /* YOUR CODE HERE
             */
        }
    }
}
