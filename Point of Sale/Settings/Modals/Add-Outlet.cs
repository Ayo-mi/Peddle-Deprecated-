using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale
{
    public partial class Add_Outlet : Form
    {
        public Add_Outlet()
        {
            InitializeComponent();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
        }

        private void bunifuButton212_Click(object sender, EventArgs e)
        {
            bunifuButton22_Click(sender, e);
        }

        private void bunifuButton210_Click(object sender, EventArgs e)
        {
            bunifuButton23_Click(sender, e);
        }

        private void bunifuButton215_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(3);
        }

        private void bunifuButton217_Click(object sender, EventArgs e)
        {
            bunifuButton23_Click(sender, e);
        }

        private void bunifuButton29_Click(object sender, EventArgs e)
        {
            bunifuButton22_Click(sender, e);
        }

        private void bunifuButton27_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(2);
        }

        private void bunifuButton211_Click(object sender, EventArgs e)
        {
            bunifuButton27_Click(sender, e);
        }

        private void bunifuButton218_Click(object sender, EventArgs e)
        {
            bunifuButton22_Click(sender, e);
        }

        private void bunifuButton213_Click(object sender, EventArgs e)
        {
            bunifuButton23_Click(sender, e);
        }

        private void bunifuButton214_Click(object sender, EventArgs e)
        {
            if(bunifuDropdown6.SelectedIndex == 1)
            {
                bunifuPages1.SetPage(4);
            }
            else
            {
                bunifuButton215_Click(sender, e);
            }
            
        }

        private void bunifuButton219_Click(object sender, EventArgs e)
        {
            if (bunifuDropdown6.SelectedIndex == 1)
            {
                bunifuPages1.SetPage(4);
            }
            else
            {
                bunifuButton27_Click(sender, e);
            }
            
        }

        private void bunifuButton223_Click(object sender, EventArgs e)
        {
            bunifuButton23_Click(sender, e);
        }

        private void bunifuButton224_Click(object sender, EventArgs e)
        {
            bunifuButton22_Click(sender, e);
        }

        private void bunifuButton225_Click(object sender, EventArgs e)
        {
            bunifuButton27_Click(sender, e);
        }

        private void bunifuButton226_Click(object sender, EventArgs e)
        {
            bunifuButton215_Click(sender, e);
        }

        private void bunifuDropdown6_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(bunifuDropdown6.SelectedIndex == 1)
            {
                bunifuPages1.SetPage(4);
            }
        }
    }
}
