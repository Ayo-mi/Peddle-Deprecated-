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
    public partial class Outlets_Registers : Form
    {

        private Form currentChildDialog;
        public Outlets_Registers()
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

        private void setPage(int index)
        {
            bunifuPages1.SetPage(index);
        }

        private void bunifuCheckBox3_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox3.Checked == true)
            {
                bunifuPanel30.Size = new Size(978, 823);
                bunifuLabel108.Visible = true;
                bunifuTextBox26.Visible = true;
            }
            else
            {
                bunifuPanel30.Size = new Size(978, 746);
                bunifuLabel108.Visible = false;
                bunifuTextBox26.Visible = false;
            }
        }

        private void bunifuCheckBox5_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox5.Checked == true)
            {
                bunifuCheckBox6.Location = new Point(368, 423);
                bunifuLabel124.Location = new Point(397, 427);
                bunifuPanel32.Size = new Size(978, 490);
                bunifuTextBox31.Visible = true;
                bunifuLabel123.Visible = true;
            }
            else
            {
                bunifuPanel32.Size = new Size(978, 414);
                bunifuLabel124.Location = new Point(397, 329);
                bunifuCheckBox6.Location = new Point(368, 329);
                bunifuTextBox31.Visible = false;
                bunifuLabel123.Visible = false;
            }
        }

        private void bunifuCheckBox7_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox7.Checked == true)
            {
                bunifuPanel33.Size = new Size(978, 320);
                bunifuPanel34.Visible = true;
            }
            else
            {
                bunifuPanel33.Size = new Size(978, 170);
                bunifuPanel34.Visible = false;
            }
        }

        private void bunifuButton211_Click(object sender, EventArgs e)
        {
            openChildDialog(new Add_Outlet());
        }

        private void bunifuPictureBox8_Click(object sender, EventArgs e)
        {
            setPage(0);
        }

        private void bunifuButton225_Click(object sender, EventArgs e)
        {
            bunifuPictureBox8_Click(sender, e);
        }

        private void bunifuButton212_Click(object sender, EventArgs e)
        {
            setPage(1);
        }
    }
}
