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
    public partial class dashoard : Form
    {

        private Main currentParentForm;
        public dashoard(Main f)
        {
            InitializeComponent();
            responsiveness();
            currentParentForm = f;
        }

        private void responsiveness()
        {
             if (this.Size.Width > 1012)
            {
                panelSales5.Visible = true;
                panelSales1.Location = new Point(53, 40);
                panelSales2.Location = new Point(281, 40);
                panelSales3.Location = new Point(509, 40);
                panelSales4.Location = new Point(737, 40);
                panelSales5.Location = new Point(965, 40);
            }
            else if (this.Size.Width <= 1012)
            {
                panelSales5.Visible = false;
                panelSales1.Location = new Point(53, 40);
                panelSales2.Location = new Point(281, 40);
                panelSales3.Location = new Point(509, 40);
                panelSales4.Location = new Point(737, 40);
            }
        }

        private void dashoard_Load(object sender, EventArgs e)
        {
            responsiveness();
        }

        private void dashoard_Resize(object sender, EventArgs e)
        {
            responsiveness();
        }

    }
}
