using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale.Catalog
{
    public partial class Products : Form
    {

        private Form currentChildForm;
        private Catalog currentParentForm;

        public Products(Catalog f)
        {
            InitializeComponent();
            currentChildForm = this;
            currentParentForm = f;
        }
      
        private void bunifuLabel30_Click(object sender, EventArgs e)
        {

        }

       
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuTextBox14_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton226_Click(object sender, EventArgs e)
        {
            //new Functions().openChildDialogOverlay(new Modals.Add_Product());
            
            currentParentForm.openChildForm(new Add_Product(currentParentForm));
            currentParentForm.TabVisible = false;
            
            

        }
    }
}
