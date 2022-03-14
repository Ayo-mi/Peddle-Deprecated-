using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale.Settings
{
    public partial class Users : Form
    {

        private settings currentParentForm;
        private BunifuPanel buttonBorderPanel;
        private BunifuButton2 currentButton;
        public Users(settings f)
        {
            InitializeComponent();
            buttonBorderPanel = new BunifuPanel();
            buttonBorderPanel.Size = new Size(28, 5);
            bunifuPanel2.Controls.Add(buttonBorderPanel);
            currentParentForm = f;
        }

        protected void ActiveButton(Object senderbtn)
        {
            if (senderbtn != null)
            {

                currentButton = (BunifuButton2)senderbtn;

                //left boarder button
                buttonBorderPanel.Location = new Point(currentButton.Location.X + 20, currentButton.Location.Y + 34);
                buttonBorderPanel.ShowBorders = true;
                buttonBorderPanel.BorderRadius = 3;
                buttonBorderPanel.BorderThickness = 0;
                buttonBorderPanel.BorderColor = Color.CornflowerBlue;
                buttonBorderPanel.BackgroundColor = Color.CornflowerBlue;
                buttonBorderPanel.Visible = true;
                buttonBorderPanel.BringToFront();
                currentButton.Focus();

            }
        }

        private void mainPage(int index)
        {
            bunifuPages1.SetPage(index);
        }

        private void subPage(int index)
        {
            bunifuPages2.SetPage(index);
        }

        private void Users_Shown(object sender, EventArgs e)
        {
            ActiveButton(usersBtn);
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            subPage(0);
            ActiveButton(sender);
        }

        private void roleTabBtn_Click(object sender, EventArgs e)
        {
            subPage(1);
            ActiveButton(sender);
        }

        private void bunifuButton226_Click(object sender, EventArgs e)
        {
            currentParentForm.showTabBtn(false);
            mainPage(1);
        }

        private void bunifuPictureBox5_Click(object sender, EventArgs e)
        {
            currentParentForm.showTabBtn(true);
            mainPage(0);
        }
    }
}
