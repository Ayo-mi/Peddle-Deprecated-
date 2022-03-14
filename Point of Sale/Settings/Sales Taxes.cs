using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point_of_Sale.Settings.Modals;

namespace Point_of_Sale.Settings
{
    public partial class Sales_Taxes : Form
    {

        private Form currentChildDialog;
        public Sales_Taxes()
        {
            InitializeComponent();
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

        private void bunifuButton220_Click(object sender, EventArgs e)
        {
            openChildDialog(new Add_Sales_Tax());
        }

        private void bunifuButton219_Click(object sender, EventArgs e)
        {
            openChildDialog(new Group_Tax());
        }
    }
}
