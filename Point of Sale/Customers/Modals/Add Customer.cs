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

namespace Point_of_Sale.Customers.Modals
{
    public partial class Add_Customer : Form
    {

        private BunifuPanel buttonBorderPanel;
        private BunifuButton2 currentButton;

        public Add_Customer()
        {
            InitializeComponent();
            buttonBorderPanel = new BunifuPanel();
            buttonBorderPanel.Size = new Size(28, 5);
            panel1.Controls.Add(buttonBorderPanel);            
            ActiveButton(bunifuButton22);
        }

        protected void ActiveButton(Object senderbtn)
        {
            if (senderbtn != null)
            {

                currentButton = (BunifuButton2)senderbtn;

                //left boarder button
                buttonBorderPanel.Size = new Size(currentButton.Size.Width-10, 5);
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

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
            ActiveButton(bunifuButton22);
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
            ActiveButton(bunifuButton23);
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Customer_Shown(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
            bunifuButton22.Focus();
        }
      
    }
}
