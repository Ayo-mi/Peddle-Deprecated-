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
    public partial class Loyalty : Form
    {
        public Loyalty()
        {
            InitializeComponent();
        }

        private void setPage(int index)
        {
            bunifuPages1.SetPage(index);
        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox1.Checked == true)
            {
                bunifuPanel22.Enabled = true;
            }
            else
            {
                bunifuPanel22.Enabled = false;
            }
        }

        private void bunifuButton215_Click(object sender, EventArgs e)
        {
           /* Form formBackground = new Form();
            settings s = new settings();
            Main m = new Main();
         
            formBackground.Size = new Size(m.Width, m.Height);
            formBackground.Location = new Point(m.Location.X, m.Location.Y);

            formBackground.Show();
            formBackground.Owner = s;
            (formBackground.Owner as settings).flowLayoutPanel1 p;
            formBackground.Dispose();
             */ 
            setPage(1);               
        }

        private void bunifuPictureBox6_Click(object sender, EventArgs e)
        {            
            setPage(0);
        }

        private void bunifuButton218_Click(object sender, EventArgs e)
        {
            bunifuPictureBox6_Click(sender, e);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
