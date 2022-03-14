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
    public partial class Advance_Promotion : Form
    {

        private Add_Promotion currentParentForm;
        private Advance_Reward currentchildForm;
        private bool isBuyAll = true;
        private bool isBuySpecific = false;
        private bool isSpendAll = true;
        private bool isSpendSpecific = false;
        private int currentHeight;
        private bool isReward1 = false;
        private bool isReward2 = false;
        private bool isReward3 = false;
        private bool isReward4 = false;

        public Advance_Promotion(Add_Promotion f)
        {
            InitializeComponent();
            currentParentForm = f;
            currentchildForm = new Advance_Reward(this);
            this.currentHeight = 312;
            rewardContainer.Controls.Add(currentchildForm.Panel1);
            rewardContainer.Controls.Add(currentchildForm.Panel2);
            rewardContainer.Controls.Add(currentchildForm.Panel3);
            rewardContainer.Controls.Add(currentchildForm.Panel4);
        }

        public Control AdvancePanel
        {
            get { return advancePanel; }
        }

        public int getCurrentHeight
        {
            get { return currentHeight; }
            set { currentHeight = value; }
        }

        public int ParentContainer
        {
            set { currentParentForm.PromoPanel.Height = value; }
            get { return currentParentForm.PromoPanel.Height; }
        }

        public int rewardHeight
        {
            set { rewardContainer.Height = value; }
        }

        private void bunifuDropdown3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (bunifuDropdown3.SelectedIndex == 0)
            {
                rewardDropdown.Items.Clear();
                rewardDropdown.Items.AddRange(new object[] {
                    "Get the following items",
                    "Save a certain amount",
                    "Pay a fixed price",
                    "Earn extra loyalty"});

                spendPanel.Visible = false;                             
                rewardPanel.Visible = true;
                rewardContainer.Dock = DockStyle.Top;
                rewardContainer.Visible = false;
                rewardPanel.Dock = DockStyle.Top;
                buyPanel.Visible = true;   
                buyPanel.Dock = DockStyle.Top;
                if (isBuyAll)
                {
                    currentParentForm.PromoPanel.Height = 558;
                    this.currentHeight = currentParentForm.PromoPanel.Height;
                }else if (isBuySpecific)
                {
                    currentParentForm.PromoPanel.Height = 702;
                    this.currentHeight = currentParentForm.PromoPanel.Height;
                }
            }
            else if (bunifuDropdown3.SelectedIndex == 1)
            {
                rewardDropdown.Items.Clear();
                rewardDropdown.Items.AddRange(new object[] {
                    "Get the following items",
                    "Save a certain amount",
                    "Earn extra loyalty"});

                buyPanel.Visible = false;
                rewardPanel.Visible = true;
                rewardContainer.Dock = DockStyle.Top;
                rewardContainer.Visible = false;
                rewardPanel.Dock = DockStyle.Top;
                spendPanel.Visible = true;
                spendPanel.Dock = DockStyle.Top;

                if (isSpendAll)
                {
                    currentParentForm.PromoPanel.Height = 558;
                    this.currentHeight = currentParentForm.PromoPanel.Height;
                }
                else if (isSpendSpecific)
                {
                    currentParentForm.PromoPanel.Height = 702;
                    this.currentHeight = currentParentForm.PromoPanel.Height;
                }
            }
            else
            {
                buyPanel.Visible = false;
                spendPanel.Visible = false;
                rewardPanel.Visible = false;
            }
        }

        private void bunifuLabel7_Click(object sender, EventArgs e)
        {
            qtyPanel.Visible = false;
            minMaxPanel.Location = new Point(93, 23);
            minMaxPanel.Visible = true;
        }

        private void bunifuLabel39_Click(object sender, EventArgs e)
        {
            minMaxPanel.Visible = false;
            qtyPanel.Location = new Point(93, 23);
            qtyPanel.Visible = true;
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {
            if (!isBuyAll)
            {
                isBuyAll = true;
                isBuySpecific = false;
                bAll.BorderColor = Color.DodgerBlue;
                bAll.BorderThickness = 3;
                bAll.BringToFront();
                bSpecific.BorderColor = Color.Silver;
                bSpecific.BorderThickness = 1;
                currentParentForm.PromoPanel.Height -= 144;
                this.currentHeight = currentParentForm.PromoPanel.Height;
                buyPanel.Height =136;
            }
        }

        private void bSpecific_Click(object sender, EventArgs e)
        {
            if (!isBuySpecific)
            {
                isBuyAll = false;
                isBuySpecific = true;
                bSpecific.BorderColor = Color.DodgerBlue;
                bSpecific.BorderThickness = 3;
                bSpecific.BringToFront();
                bAll.BorderColor = Color.Silver;
                bAll.BorderThickness = 1;
                currentParentForm.PromoPanel.Height += 144;
                this.currentHeight = currentParentForm.PromoPanel.Height;
                buyPanel.Height = 280;                
            }
        }

        private void bunifuLabel13_Click(object sender, EventArgs e)
        {
            if (!isSpendAll)
            {
                isSpendAll = true;
                isSpendSpecific = false;
                sAll.BorderColor = Color.DodgerBlue;
                sAll.BorderThickness = 3;
                sAll.BringToFront();
                sSpecific.BorderColor = Color.Silver;
                sSpecific.BorderThickness = 1;
                currentParentForm.PromoPanel.Height -= 144;
                this.currentHeight = currentParentForm.PromoPanel.Height;
                spendPanel.Height = 136;
            }
        }

        private void sSpecific_Click(object sender, EventArgs e)
        {
            if (!isSpendSpecific)
            {
                isSpendSpecific = true;
                isSpendAll = false;
                sSpecific.BorderColor = Color.DodgerBlue;
                sSpecific.BorderThickness = 3;
                sSpecific.BringToFront();
                sAll.BorderColor = Color.Silver;
                sAll.BorderThickness = 1;
                currentParentForm.PromoPanel.Height += 144;
                this.currentHeight = currentParentForm.PromoPanel.Height;
                spendPanel.Height = 280;
            }
        }

        private void rewardDropdown_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (bunifuDropdown3.SelectedIndex == 0)
            {
                if (rewardDropdown.SelectedIndex == 0)
                {
                    if (!isReward1)
                    {
                        isReward1 = true;
                        isReward2 = false;
                        isReward3 = false;
                        isReward4 = false;
                        currentchildForm.Panel1.Visible = true;
                        currentchildForm.Panel2.Visible = false;
                        currentchildForm.Panel3.Visible = false;
                        currentchildForm.Panel4.Visible = false;
                        currentchildForm.Panel1.Dock = DockStyle.Fill;
                        rewardContainer.Visible = true;
                        //currentchildForm.Panel1.Dock = DockStyle.Bottom;
                        currentParentForm.PromoPanel.Height += 95;
                        rewardContainer.Height = 95;
                        this.currentHeight = currentParentForm.PromoPanel.Height;
                    }
                }
                else if (rewardDropdown.SelectedIndex == 1)
                {
                    if (!isReward2)
                    {
                        isReward1 = false;
                        isReward2 = true;
                        isReward3 = false;
                        isReward4 = false;
                        currentchildForm.Panel1.Visible = false;
                        currentchildForm.Panel2.Visible = true;
                        currentchildForm.Panel3.Visible = false;
                        currentchildForm.Panel4.Visible = false;
                        currentchildForm.Panel2.Dock = DockStyle.Fill;
                        rewardContainer.Visible = true;
                        //currentchildForm.Panel1.Dock = DockStyle.Bottom;
                        currentParentForm.PromoPanel.Height += 225;
                        rewardContainer.Height = 225;
                        this.currentHeight = currentParentForm.PromoPanel.Height;
                    }
                }
                else if (rewardDropdown.SelectedIndex == 2)
                {
                    if (!isReward3)
                    {
                        isReward1 = false;
                        isReward2 = false;
                        isReward3 = true;
                        isReward4 = false;
                        currentchildForm.Panel1.Visible = false;
                        currentchildForm.Panel2.Visible = false;
                        currentchildForm.Panel3.Visible = true;
                        currentchildForm.Panel4.Visible = false;
                        currentchildForm.Panel3.Dock = DockStyle.Fill;
                        rewardContainer.Visible = true;
                        //currentchildForm.Panel1.Dock = DockStyle.Bottom;
                        currentParentForm.PromoPanel.Height += 117;
                        rewardContainer.Height = 117;
                        this.currentHeight = currentParentForm.PromoPanel.Height;
                    }
                }
                else if (rewardDropdown.SelectedIndex == 3)
                {
                    if (!isReward4)
                    {
                        isReward1 = false;
                        isReward2 = false;
                        isReward3 = false;
                        isReward4 = true;
                        currentchildForm.Panel1.Visible = false;
                        currentchildForm.Panel2.Visible = false;
                        currentchildForm.Panel3.Visible = false;
                        currentchildForm.Panel4.Visible = true;
                        currentchildForm.Panel4.Dock = DockStyle.Fill;
                        rewardContainer.Visible = true;
                        //currentchildForm.Panel1.Dock = DockStyle.Bottom;
                        currentParentForm.PromoPanel.Height += 117;
                        rewardContainer.Height = 117;
                        this.currentHeight = currentParentForm.PromoPanel.Height;
                    }
                }
            }
            
            else if (bunifuDropdown3.SelectedIndex == 1)
            {
                if (rewardDropdown.SelectedIndex == 0)
                {
                    if (!isReward1)
                    {
                        isReward1 = true;
                        isReward2 = false;
                        isReward3 = false;
                        isReward4 = false;
                        currentchildForm.Panel1.Visible = true;
                        currentchildForm.Panel2.Visible = false;
                        currentchildForm.Panel3.Visible = false;
                        currentchildForm.Panel4.Visible = false;
                        currentchildForm.Panel1.Dock = DockStyle.Fill;
                        rewardContainer.Visible = true;
                        //currentchildForm.Panel1.Dock = DockStyle.Bottom;
                        currentParentForm.PromoPanel.Height += 95;
                        rewardContainer.Height = 95;
                        this.currentHeight = currentParentForm.PromoPanel.Height;
                    }
                }
                else if (rewardDropdown.SelectedIndex == 1)
                {
                    if (!isReward2)
                    {
                        isReward1 = false;
                        isReward2 = true;
                        isReward3 = false;
                        isReward4 = false;
                        currentchildForm.Panel1.Visible = false;
                        currentchildForm.Panel2.Visible = true;
                        currentchildForm.Panel3.Visible = false;
                        currentchildForm.Panel4.Visible = false;
                        currentchildForm.Panel2.Dock = DockStyle.Fill;
                        rewardContainer.Visible = true;
                        //currentchildForm.Panel1.Dock = DockStyle.Bottom;
                        currentParentForm.PromoPanel.Height += 225;
                        rewardContainer.Height = 225;
                        this.currentHeight = currentParentForm.PromoPanel.Height;
                    }
                }
                else if (rewardDropdown.SelectedIndex == 2)
                {
                    if (!isReward4)
                    {
                        isReward1 = false;
                        isReward2 = false;
                        isReward3 = false;
                        isReward4 = true;
                        currentchildForm.Panel1.Visible = false;
                        currentchildForm.Panel2.Visible = false;
                        currentchildForm.Panel3.Visible = false;
                        currentchildForm.Panel4.Visible = true;
                        currentchildForm.Panel4.Dock = DockStyle.Fill;
                        rewardContainer.Visible = true;
                        //currentchildForm.Panel1.Dock = DockStyle.Bottom;
                        currentParentForm.PromoPanel.Height += 117;
                        rewardContainer.Height = 117;
                        this.currentHeight = currentParentForm.PromoPanel.Height;
                    }
                }
            }
        }
    }
}
