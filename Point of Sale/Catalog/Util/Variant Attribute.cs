using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale.Catalog.Modals
{
    public partial class Test : Form
    {

        private FlowLayoutPanel container;
        private Panel containerParent;
        private Panel parent;
        public Test()
        {
            InitializeComponent();
        }

        public Test(FlowLayoutPanel container, Panel containerParent, Panel parent)
        {
            InitializeComponent();
            this.container = container;
            this.containerParent = containerParent;
            this.parent = parent;
            container.Controls.Add(panel1);
            containerParent.Height += 100;
            parent.Height += 100;
        }

        private void bunifuPictureBox3_Click(object sender, EventArgs e)
        {
            container.Controls.Remove(panel1);
            container.Controls.Add(panel1);
            containerParent.Height -= 100;
            parent.Height -= 100;
        }
    }
}
