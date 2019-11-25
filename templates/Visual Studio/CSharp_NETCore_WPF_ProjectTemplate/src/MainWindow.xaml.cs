// ============================================================================================================ 2:10 PM
//    FILENAME: MainWindow.xaml.cs
//       BUILD: YYYYMMDD
//     PROJECT: ProjectName (https://github.com/GitHubAccount/ProjectName)
//     AUTHORS: your.email@here.com
//   COPYRIGHT: Copyright YYYY You
//     LICENSE: LicenseName
// ====================================================================================================================

/* This is the main window/logic of the project.
 */
using System.Windows;

namespace CSharpNETCoreWPFProjectTemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>Default constructor.</summary>
        public MainWindow()
        {
            InitializeComponent();
            DevMode.LaunchApplicationThenQuit();
            DevMode.TestCode();
            StartApplication();
        }

        /// <summary>Initializes a project.</summary>
        private static void StartApplication()
        {
            SetupWindow();
            SetupControls();

            /* OK, ADD YOUR STUFF HERE!
             */
        }

        /// <summary>Applies customizations to the Main() window when the application launches.</summary>
        private static void SetupWindow()
        {
            /* Any window customizations go here.
             */
        }

        /// <summary>Setup window controls.</summary>
        private static void SetupControls()
        {
            /* Any control customizations go here.
             */
        }
    }
}