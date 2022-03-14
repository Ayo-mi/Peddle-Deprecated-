using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using Point_of_Sale.Customers.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale.Customers
{
    public partial class Customers : Form
    {

        private Main currentParentForm;
        //private Form currentChildForm;
        private Form currentChildDialog;
        private BunifuPanel buttonBorderPanel;
        private BunifuButton2 currentButton;
        //private Functions fxtn;

        public Customers(Main f)
        {
            InitializeComponent();
            //fxtn = new Functions();
            buttonBorderPanel = new BunifuPanel();
            buttonBorderPanel.Size = new Size(28, 5);
            panel1.Controls.Add(buttonBorderPanel);
            ActiveButton(customerBtn);
            currentParentForm = f;
        }

        protected void ActiveButton(Object senderbtn)
        {
            if (senderbtn != null)
            {

                currentButton = (BunifuButton2)senderbtn;

                //left boarder button
                buttonBorderPanel.Size = new Size(currentButton.Size.Width - 10, 5);
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

        protected void openChildDialog(Form childForm)
        {
            if (currentChildDialog != null)
            {
                currentChildDialog.Close();
            }
            currentChildDialog = childForm;
            childForm.ShowDialog();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
            ActiveButton(sender);
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
            ActiveButton(sender);
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            new Functions().openChildDialogOverlay(new Add_Customer_Group());
        }

        private void Customers_Shown(object sender, EventArgs e)
        {
            customerBtn.Focus();
        }

        private void bunifuButton226_Click(object sender, EventArgs e)
        {
            new Functions().openChildDialogOverlay(new Add_Customer());
        }
    }
}
