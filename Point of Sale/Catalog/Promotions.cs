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
    public partial class Promotions : Form
    {
        private Catalog currentParentForm;
        private BunifuPanel buttonBorderPanel;
        private BunifuButton2 currentButton;
        public Promotions(Catalog f)
        {
            InitializeComponent();
            currentParentForm = f;
            buttonBorderPanel = new BunifuPanel();            
            bunifuPanel2.Controls.Add(buttonBorderPanel);
            ActiveButton(btn1,37);
        }

        protected void ActiveButton(Object senderbtn, int widthh=28)
        {
            if (senderbtn != null)
            {

                currentButton = (BunifuButton2)senderbtn;

                //left boarder button
                buttonBorderPanel.Size = new Size(currentButton.Width-10, 5);
                buttonBorderPanel.Location = new Point(currentButton.Location.X+5, currentButton.Location.Y + 34);
                buttonBorderPanel.ShowBorders = true;
                buttonBorderPanel.BorderRadius = 3;
                buttonBorderPanel.BorderThickness = 1;
                buttonBorderPanel.BorderColor = Color.CornflowerBlue;
                buttonBorderPanel.BackgroundColor = Color.CornflowerBlue;
                buttonBorderPanel.Visible = true;
                buttonBorderPanel.BringToFront();
                //currentButton.Focus();

            }
        }

        private void Promotions_Shown(object sender, EventArgs e)
        {
            btn1.Focus();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
            ActiveButton(sender,37);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
            ActiveButton(sender);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(2);
            ActiveButton(sender);
        }

        private void bunifuButton226_Click(object sender, EventArgs e)
        {
            currentParentForm.openChildForm(new Add_Promotion(currentParentForm));
            currentParentForm.TabVisible = false;
        }
    }
}
