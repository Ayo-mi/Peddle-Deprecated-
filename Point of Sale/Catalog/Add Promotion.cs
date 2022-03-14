using Point_of_Sale.Catalog.Util;
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
    public partial class Add_Promotion : Form
    {
        //private fields
        private Catalog currentParentForm;
        private bool isBasicPromo = true;
        private bool isAdvancePromo = false;
        private Basic_Promotion basicPromo;
        private Advance_Promotion advancePromo;
        public Add_Promotion(Catalog f)
        {
            InitializeComponent();
            currentParentForm = f;
            basicPromo = new Basic_Promotion(this);
            advancePromo = new Advance_Promotion(this);
            advancePromo.AdvancePanel.Visible = false;
            basicPromo.BasicPanel.Visible = false;
            childContainer.Controls.Add(basicPromo.BasicPanel);
            childContainer.Controls.Add(advancePromo.AdvancePanel);
            basicPromotion();
        }

        public Control PromoPanel
        {
            get { return promoTypePanel; }
        }

        private void basicPromotion()
        {
            removeAdvancePromo();                        
            basicPromo.BasicPanel.Visible = true;
            promoTypePanel.Height =basicPromo.getCurrentHeight;
            basicPromo.BasicPanel.Dock = DockStyle.Right;
            basicPromo.BasicPanel.Width = 742;
        }

        private void advancedPromotion()
        {
            removeBasicPromo();            
            advancePromo.AdvancePanel.Visible = true;
            promoTypePanel.Height = advancePromo.getCurrentHeight;
            advancePromo.AdvancePanel.Dock = DockStyle.Right;
            
        }

        private void removeBasicPromo()
        {
            //childContainer.Controls.Remove(basicPromo.BasicPanel);            
            basicPromo.BasicPanel.Visible = false;
        }

        private void removeAdvancePromo()
        {
            //childContainer.Controls.Remove(advancePromo.AdvancePanel);
            advancePromo.AdvancePanel.Visible = false;
        }

        private void basicPromoPanel_Click(object sender, EventArgs e)
        {
            if (!isBasicPromo)
            {
                isBasicPromo = true;
                isAdvancePromo = false;
                basicPromoPanel.BorderColor = Color.DodgerBlue;
                basicPromoPanel.BorderThickness = 3;
                basicPromoPanel.BringToFront();
                advancePromoPanel.BorderColor = Color.Silver;
                advancePromoPanel.BorderThickness = 1;
                basicPromotion();
            }
        }

        private void advancePromoPanel_Click(object sender, EventArgs e)
        {
            if (!isAdvancePromo)
            {
                isBasicPromo = false;
                isAdvancePromo = true;
                advancePromoPanel.BorderColor = Color.DodgerBlue;
                advancePromoPanel.BorderThickness = 3;
                advancePromoPanel.BringToFront();
                basicPromoPanel.BorderColor = Color.Silver;
                basicPromoPanel.BorderThickness = 1;
                advancedPromotion();
            }
        }
    }
}
