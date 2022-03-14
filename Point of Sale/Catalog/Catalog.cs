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

namespace Point_of_Sale.Catalog
{
    public partial class Catalog : Form
    {

        private Form currentChildDialog;
        private Form currentChildForm;
        private Main currentParentForm;
        private BunifuPanel buttonBorderPanel;
        private BunifuButton2 currentButton;

        public Catalog(Main f)
        {
            InitializeComponent();
            buttonBorderPanel = new BunifuPanel();
            buttonBorderPanel.Size = new Size(28, 5);
            panel1.Controls.Add(buttonBorderPanel);
            ActiveButton(bunifuButton1);
            currentParentForm = f;
        }

        public bool TabVisible
        {
            get { return tabPanel.Visible; }
            set { tabPanel.Visible = value; }
        }

        protected void ActiveButton(Object senderbtn)
        {
            if (senderbtn != null)
            {

                currentButton = (BunifuButton2)senderbtn;

                //left boarder button
                buttonBorderPanel.Size = new Size(currentButton.Size.Width-13, 5);
                buttonBorderPanel.Location = new Point(currentButton.Location.X + 5, 0);
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

        public void openChildForm(Form childForm)
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

        private void Catalog_Shown(object sender, EventArgs e)
        {
            bunifuButton1.Focus();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new Products(this));
            ActiveButton(sender);
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
            openChildForm(new Products(this));
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            openChildForm(new Promotions(this));
            ActiveButton(sender);
        }
    }
}
