using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale.Settings.Modals
{
    public partial class Add_Sales_Tax : Form
    {
        public Add_Sales_Tax()
        {
            InitializeComponent();
            bunifuShadowPanel1.ShadowColor = Color.FromArgb(65, 0, 0, 0);
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton226_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton225_Click(object sender, EventArgs e)
        {
            bunifuButton21_Click(sender, e);
        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
