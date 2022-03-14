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
    public partial class Add_Product : Form
    {
        private Catalog currentParentForm;
        private bool standardP=false;
        private bool compositeP = false;
        private bool variantP = false;
        public Add_Product(Catalog f)
        {
            InitializeComponent();
            currentParentForm = f;
            standardP = true;
        }

        private void standardProduct()
        {
            //show panels needed for a single product
            skuPanel.Visible = true;
            supplierPanel.Visible = true;
            currentInventPanel.Visible = true;
            packagePanel.Visible = true;

            //hide unwanted panels
            vpPanel1.Visible = false;
            cpPanel1.Visible = false;
            compositeProduPanel.Visible = false;
           

            standardP = true;
            compositeP = false;
            variantP = false;
            vPanel.BorderColor = Color.DarkGray;
            vPanel.BorderThickness = 1;
            cPanel.BorderColor = Color.DarkGray;
            cPanel.BorderThickness = 1;
            sPanel.BringToFront();
            sPanel.BorderColor = Color.DodgerBlue;
            sPanel.BorderThickness = 3;
        }

        private void variantProduct()
        {
            //show panels needed for a single product            
            supplierPanel.Visible = false;
            vpPanel1.Visible = true;

            //hide unwanted panels
            skuPanel.Visible = false;            
            currentInventPanel.Visible = false;
            packagePanel.Visible = false;
            cpPanel1.Visible = false;
            compositeProduPanel.Visible = false;

            standardP = false;
            compositeP = false;
            variantP = true;
            sPanel.BorderColor = Color.DarkGray;
            sPanel.BorderThickness = 1;
            cPanel.BorderColor = Color.DarkGray;
            cPanel.BorderThickness = 1;
            vPanel.BringToFront();
            vPanel.BorderColor = Color.DodgerBlue;
            vPanel.BorderThickness = 3;
        }

        private void compositeProduct()
        {
            // show panels needed for a single product
            cpPanel1.Visible = true;
            compositeProduPanel.Visible = true;

            //hide unwanted panels
            skuPanel.Visible = false;
            currentInventPanel.Visible = false;
            packagePanel.Visible = false;
            supplierPanel.Visible = false;
            vpPanel1.Visible = false;

            standardP = false;
            compositeP = true;
            variantP = false;
            sPanel.BorderColor = Color.DarkGray;
            sPanel.BorderThickness = 1;
            vPanel.BorderColor = Color.DarkGray;
            vPanel.BorderThickness = 1;
            cPanel.BringToFront();
            cPanel.BorderColor = Color.DodgerBlue;
            cPanel.BorderThickness = 3;
        }

        private void bunifuPictureBox5_Click(object sender, EventArgs e)
        {
            currentParentForm.openChildForm(new Products(currentParentForm));
            currentParentForm.TabVisible = true;
        }

        private void bunifuRadioButton2_CheckedChanged2_1(object sender, Bunifu.UI.WinForms.BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if (bunifuRadioButton2.Checked == true)
            {
                customLoyaltyPanel.Visible = true;
                loyaltyPanel.Size = new Size(1191, 222);
            }
            else
            {
                customLoyaltyPanel.Visible = false;
                loyaltyPanel.Size = new Size(1191, 126);
            }
        }

        private void sPanel_Click(object sender, EventArgs e)
        {
            standardProduct();
        }

        private void vPanel_Click(object sender, EventArgs e)
        {
            variantProduct();
        }

        private void bunifuLabel23_Click(object sender, EventArgs e)
        {
            compositeProduct();
        }

        private void bunifuPictureBox4_Click(object sender, EventArgs e)
        {
            //vpPanel1.Size =new Size(vpPanel1.Size.Width, vpPanel1.Size.Height+60);
            Modals.Test row = new Modals.Test(attribPanel, panel6, vpPanel1);
        }
    }
}
