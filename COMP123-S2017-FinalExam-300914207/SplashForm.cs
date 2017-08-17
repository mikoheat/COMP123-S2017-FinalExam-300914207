using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
* Name: Taeho Kim
* Date: August 17, 2017
* StudentID: 300914207
* Description: PickHighestCard Demo Project
* Version: 0.1 - Add label on design.
*/

namespace COMP123_S2017_FinalExam_300914207
{
    public partial class SplashForm : Form
    {
        // PUBLIC PROPERTIES
        public PickHighestCardForm cardpick
        {
            get
            {
                return Program.pickcard;
            }
        }

        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            

            this.cardpick.Show();

            this.Hide();

            SplashFormTimer.Enabled = false;
        }
    }
}
