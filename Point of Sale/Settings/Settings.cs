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
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using Point_of_Sale.Settings;
using Point_of_Sale.Settings.Modals;

namespace Point_of_Sale
{
    public partial class settings : Form
    {

        private Main currentParentForm;
        private Form currentChildForm;        
        private Form currentChildDialog;
        private BunifuPanel buttonBorderPanel;
        private BunifuButton2 currentButton;
        private Functions fxtn;

        public settings(Main f)
        {
            InitializeComponent();
            //fxtn = new Functions();
            buttonBorderPanel = new BunifuPanel();
            buttonBorderPanel.Size = new Size(28, 5);
            panel1.Controls.Add(buttonBorderPanel);
            currentParentForm = f;
        }       

        protected void ActiveButton(Object senderbtn)
        {
            if (senderbtn != null)
            {

                currentButton = (BunifuButton2)senderbtn;

                //left boarder button
                buttonBorderPanel.Size = new Size(currentButton.Size.Width-10, 5);
                buttonBorderPanel.Location = new Point(currentButton.Location.X+5, 0);
                buttonBorderPanel.ShowBorders = true;
                buttonBorderPanel.BorderRadius = 3;
                buttonBorderPanel.BorderThickness = 0;
                buttonBorderPanel.BorderColor = Color.DodgerBlue;
                buttonBorderPanel.BackgroundColor = Color.DodgerBlue;
                buttonBorderPanel.Visible = true;
                buttonBorderPanel.BringToFront();
                currentButton.Focus();

            }
        }

        protected void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            //formTitle.Text = childForm.Text;
            childForm.BringToFront();
            childForm.Show();
        }

        protected void openChildDialog(Form childForm)
        {
            if (currentChildDialog != null)
            {
                currentChildDialog.Close();
            }
            currentChildDialog = childForm;
            childForm.ShowDialog();
        }

        public void showTabBtn(Boolean visiblity)
        {
            try
            {
                flowLayoutPanel1.Visible = visiblity;
                panel1.Visible = visiblity;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }                          
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            openChildForm(new General());
            ActiveButton(sender);
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            openChildForm(new Outlets_Registers());
            ActiveButton(sender);
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            //bunifuPages1.SetPage(1);
            ActiveButton(sender);           
        }

        private void bunifuButton27_Click(object sender, EventArgs e)
        {
            openChildForm(new Users(this));
            ActiveButton(sender);
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            openChildForm(new Payment_Type());
            ActiveButton(sender);
        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            openChildForm(new Sales_Taxes());
            ActiveButton(sender);
        }

        private void bunifuButton26_Click(object sender, EventArgs e)
        {
            openChildForm(new Loyalty());
            ActiveButton(sender);
        }

        private void bunifuButton28_Click(object sender, EventArgs e)
        {
            openChildForm(new Store_Credit());
            ActiveButton(sender);
        }

        private void settings_Load(object sender, EventArgs e)
        {
            openChildForm(new General());
            genSettings.Focus();
            ActiveButton(genSettings);
        }
    }
}
