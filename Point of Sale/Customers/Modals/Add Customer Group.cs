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
    public partial class Add_Customer_Group : Form
    {
        public Add_Customer_Group()
        {
            InitializeComponent();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton225_Click(object sender, EventArgs e)
        {
            bunifuButton21_Click(sender, e);
        }
    }
}
