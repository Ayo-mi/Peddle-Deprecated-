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
    public partial class Payment_Type : Form
    {
        public Payment_Type()
        {
            InitializeComponent();
        }

        private void setPage(int index)
        {
            bunifuPages1.SetPage(index);
        }

        private void bunifuDropdown11_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (bunifuDropdown11.SelectedIndex <= 0)
            {
                panel13.Visible = true;
                bunifuSeparator11.Visible = true;
            }
            else
            {
                panel13.Visible = false;
                bunifuSeparator11.Visible = false;
            }
        }

        private void bunifuButton221_Click(object sender, EventArgs e)
        {
            setPage(1);
        }

        private void bunifuPictureBox7_Click(object sender, EventArgs e)
        {
            setPage(0);
        }

        private void bunifuButton223_Click(object sender, EventArgs e)
        {
            bunifuPictureBox7_Click(sender, e);
        }
    }
}
