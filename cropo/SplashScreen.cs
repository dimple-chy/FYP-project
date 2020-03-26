using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cropo
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            time.Start();
        }
        private void time_Tick(object sender, EventArgs e)
        {
            time.Start();
            progressBar1.Increment(1);
            if (progressBar1.Value==100)
            {
                time.Stop();
            }
        }
    }
}
