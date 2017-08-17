using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
* Name: Taeho Kim
* Date: August 17, 2017
* StudentID: 300914207
* Description: PickHighestCard Demo Project
* Version: 0.1 - Create reference to Form
*/

namespace COMP123_S2017_FinalExam_300914207
{
    public static class Program
    {
        // Create reference to Form
        public static PickHighestCardForm pickcard;

        /// <summary>
        /// This runs application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}
