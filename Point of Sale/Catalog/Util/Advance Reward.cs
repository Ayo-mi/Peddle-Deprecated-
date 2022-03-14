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
    public partial class Advance_Reward : Form
    {

        private Advance_Promotion currentParent;
        //private bool i
        public Advance_Reward(Advance_Promotion f)
        {
            InitializeComponent();
            currentParent = f;
        }

        public Control Panel1
        {
            get { return getPanel; }
        }

        public Control Panel2
        {
            get { return savePanel; }
        }

        public Control Panel3
        {
            get { return forPanel; }
        }

        public Control Panel4
        {
            get { return earnPanel; }
        }

        private void allPanel_Click(object sender, EventArgs e)
        {
            allPanel.BorderColor = Color.DodgerBlue;
            allPanel.BorderThickness = 3;
            allPanel.BringToFront();
            specificPanel.BorderColor = Color.Silver;
            specificPanel.BorderThickness = 1;
            currentParent.ParentContainer -= 144;
            currentParent.getCurrentHeight = currentParent.ParentContainer;
            getPanel.Height = 95;
            currentParent.rewardHeight = 95;
        }

        private void bunifuLabel18_Click(object sender, EventArgs e)
        {
            specificPanel.BorderColor = Color.DodgerBlue;
            specificPanel.BorderThickness = 3;
            specificPanel.BringToFront();
            allPanel.BorderColor = Color.Silver;
            allPanel.BorderThickness = 1;
            currentParent.ParentContainer += 144;
            currentParent.getCurrentHeight = currentParent.ParentContainer;
            getPanel.Height = 280;
            currentParent.rewardHeight = 280;
        }
        
        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            discountPanel.BorderColor = Color.DodgerBlue;
            discountPanel.BorderThickness = 3;
            discountPanel.BringToFront();
            nairaPanel.BorderColor = Color.Silver;
            nairaPanel.BorderThickness = 1;
            freePanel.BorderColor = Color.Silver;
            freePanel.BorderThickness = 1;
            priceTxt.LeftIcon.Image = null;
            priceTxt.RightIcon.Image = Properties.Resources.percentage_100px;
            amountPanel.Location = new Point(308, 3);
            amountPanel.Visible = true;
            qtyPanel.Visible = false;
            panelNaira.Visible = false;
        }

        private void bunifuPictureBox2_Click(object sender, EventArgs e)
        {
            nairaPanel.BorderColor = Color.DodgerBlue;
            nairaPanel.BorderThickness = 3;
            nairaPanel.BringToFront();
            discountPanel.BorderColor = Color.Silver;
            discountPanel.BorderThickness = 1;
            freePanel.BorderColor = Color.Silver;
            freePanel.BorderThickness = 1;
            priceTxt.RightIcon.Image = null;
            priceTxt.LeftIcon.Image = Properties.Resources.naira_50px;
            panelNaira.Location = new Point(308, 3);
            panelNaira.Visible = true;
            amountPanel.Visible = false;
            qtyPanel.Visible = false;
        }

        private void freePanel_Click(object sender, EventArgs e)
        {
            freePanel.BorderColor = Color.DodgerBlue;
            freePanel.BorderThickness = 3;
            freePanel.BringToFront();
            discountPanel.BorderColor = Color.Silver;
            discountPanel.BorderThickness = 1;
            nairaPanel.BorderColor = Color.Silver;
            nairaPanel.BorderThickness = 1;
            qtyPanel.Location = new Point(308, 3);
            qtyPanel.Visible = true;
            amountPanel.Visible = false;
            panelNaira.Visible = false;
        }


        private void saveDiscPanel_Click(object sender, EventArgs e)
        {
            saveDiscPanel.BorderColor = Color.DodgerBlue;
            saveDiscPanel.BorderThickness = 3;
            saveDiscPanel.BringToFront();
            saveNairaPanel.BorderColor = Color.Silver;
            saveNairaPanel.BorderThickness = 1;
            saveNairaTxtbox.Visible = false;
            saveDiscTxtbox.Location = new Point(247, 44);
            saveDiscTxtbox.Visible = true;
        }

        private void bunifuPictureBox4_Click(object sender, EventArgs e)
        {
            saveNairaPanel.BorderColor = Color.DodgerBlue;
            saveNairaPanel.BorderThickness = 3;
            saveNairaPanel.BringToFront();
            saveDiscPanel.BorderColor = Color.Silver;
            saveDiscPanel.BorderThickness = 1;
            saveDiscTxtbox.Visible = false;
            saveNairaTxtbox.Location = new Point(247, 44);
            saveNairaTxtbox.Visible = true;
        }
    }
}
