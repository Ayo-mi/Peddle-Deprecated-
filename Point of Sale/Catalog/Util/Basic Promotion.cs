using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale.Catalog.Util
{
    public partial class Basic_Promotion : Form
    {

        private Add_Promotion currentParentForm;
        private bool isDiscount = true;
        private bool isNaira = false;
        private bool isAll = true;
        private bool isSpecific = false;
        private int currentHeight;

        public Basic_Promotion(Add_Promotion f)
        {
            InitializeComponent();
            currentParentForm = f;
            this.currentHeight = 346;
        }

        public Control BasicPanel
        {
            get { return basicPanel; }
        }

        public int getCurrentHeight
        {
            get { return currentHeight; }
        }
      
        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            isDiscount = true;
            isNaira = false;
            discountPanel.BorderColor = Color.DodgerBlue;
            discountPanel.BorderThickness = 3;
            discountPanel.BringToFront();
            nairaPanel.BorderColor = Color.Silver;
            nairaPanel.BorderThickness = 1;            
            priceTxt.RightIcon.Image = Properties.Resources.percentage_100px;
        }

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {
            isDiscount = false;
            isNaira = true;
            nairaPanel.BorderColor = Color.DodgerBlue;
            nairaPanel.BorderThickness = 3;
            nairaPanel.BringToFront();
            discountPanel.BorderColor = Color.Silver;
            discountPanel.BorderThickness = 1;
            priceTxt.RightIcon.Image = Properties.Resources.naira_50px;
        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {
            if (!isAll)
            {
                isAll = true;
                isSpecific = false;
                allPanel.BorderColor = Color.DodgerBlue;
                allPanel.BorderThickness = 3;
                allPanel.BringToFront();
                specificPanel.BorderColor = Color.Silver;
                specificPanel.BorderThickness = 1;
                currentParentForm.PromoPanel.Height -= 120;
                this.currentHeight = currentParentForm.PromoPanel.Height;
                basicPanel.Height = 120;
            }
        }

        private void specificPanel_Click(object sender, EventArgs e)
        {
            if (!isSpecific)
            {
                isAll = false;
                isSpecific = true;
                specificPanel.BorderColor = Color.DodgerBlue;
                specificPanel.BorderThickness = 3;
                specificPanel.BringToFront();
                allPanel.BorderColor = Color.Silver;
                allPanel.BorderThickness = 1;
                currentParentForm.PromoPanel.Height += 120;
                this.currentHeight = currentParentForm.PromoPanel.Height;
                basicPanel.Height = 120;
            }
        }
    }
}
