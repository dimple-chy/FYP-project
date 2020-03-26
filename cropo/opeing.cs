using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cropo
{
    public partial class opeing : Form
    {
        public opeing()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }
        public void StartForm()
        {
            Application.Run(new SplashScreen());
        }
        public void customizeDesign()
        {
            panelViewSubmenu.Visible = false;
            panelHelpSubmenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelViewSubmenu.Visible == true)
                panelViewSubmenu.Visible = false;
            if (panelHelpSubmenu.Visible == true)
                panelHelpSubmenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void butNew_Click(object sender, EventArgs e)
        {
            openChildForm(new @new());
        }

        private void butView_Click(object sender, EventArgs e)
        {
            showSubMenu(panelViewSubmenu);
        }

        private void butReport_Click(object sender, EventArgs e)
        {
            openChildForm(new Report());
            hideSubMenu();
        }

        private void butHelp_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHelpSubmenu);
        }

        private void butInfo_Click(object sender, EventArgs e)
        {
            openChildForm(new Info());
            hideSubMenu();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void butNew_MouseEnter(object sender, EventArgs e)
        {
            butNew.BackColor = Color.Blue;
        }

        private void butNew_MouseLeave(object sender, EventArgs e)
        {
            butNew.BackColor = Color.Black;
        }
        private void butNew_MouseClick(object sender, MouseEventArgs e)
        {
            butNew.BackColor = Color.Blue;
        }

        private void butHelp_MouseEnter(object sender, EventArgs e)
        {
            butHelp.BackColor = Color.Blue;
        }

        private void butHelp_MouseLeave(object sender, EventArgs e)
        {
            butHelp.BackColor = Color.Black;
        }

        private void butView_MouseEnter(object sender, EventArgs e)
        {
            butView.BackColor = Color.Blue;
        }

        private void butView_MouseLeave(object sender, EventArgs e)
        {
            butView.BackColor = Color.Black;
        }

        private void butReport_MouseEnter(object sender, EventArgs e)
        {
            butReport.BackColor = Color.Blue;
        }

        private void butReport_MouseLeave(object sender, EventArgs e)
        {
            butReport.BackColor = Color.Gray;
        }

        private void butInfo_MouseEnter(object sender, EventArgs e)
        {
            butInfo.BackColor = Color.Blue;
        }

        private void butInfo_MouseLeave(object sender, EventArgs e)
        {
            butInfo.BackColor = Color.Gray;
        }    

        private void opeing_FormClosing(object sender, FormClosingEventArgs e)
        {
            //asking user if they can close application
            string message = "Do you want to close this System?";
            string title = "Exit";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result = MessageBox.Show(message, title, buttons, icon);
            if (result == DialogResult.OK)
            {
                e.Cancel = false;//if ok then close the program
            }
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;//if cancle continue program
            }
        }

        private void butNext_Click(object sender, EventArgs e)
        {
            if (pictureBoxlogo.Visible == true)
            {
                pictureBoxback.Visible = true;
                pictureBoxback2.Visible = false;
                pictureBoxlogo.Visible = false;
            }
            else if (pictureBoxback.Visible == true)
            {
                pictureBoxback2.Visible = true;
                pictureBoxlogo.Visible = false;
                pictureBoxback.Visible = false;

            }
            else if (pictureBoxback2.Visible == true)
            {
                pictureBoxlogo.Visible = true;
                pictureBoxback.Visible = false;
                pictureBoxback2.Visible = false;
            }
        }

        private void butPre_Click(object sender, EventArgs e)
        {
            if (pictureBoxlogo.Visible == true)
            {
                pictureBoxback2.Visible = true;
                pictureBoxback.Visible = false;
                pictureBoxlogo.Visible = false;
            }
            else if (pictureBoxback2.Visible == true)
            {
                pictureBoxback.Visible = true;
                pictureBoxlogo.Visible = false;
                pictureBoxback2.Visible = false;
            }
            else if (pictureBoxback.Visible == true)
            {
                pictureBoxlogo.Visible = true;
                pictureBoxback2.Visible = false;
                pictureBoxback.Visible = false;

            }
        }

        private void butNext_MouseEnter(object sender, EventArgs e)
        {
            butNext.BackColor = Color.Blue;
        }

        private void butNext_MouseLeave(object sender, EventArgs e)
        {
            butNext.BackColor = Color.Black;
        }

        private void butPre_MouseEnter(object sender, EventArgs e)
        {
            butPre.BackColor = Color.Blue;
        }

        private void butPre_MouseLeave(object sender, EventArgs e)
        {
            butPre.BackColor = Color.Black;
        }

        private void pictureBoxback2_Click(object sender, EventArgs e)
        {

        }
    }
}
