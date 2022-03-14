using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale.Catalog.Modals
{
    public partial class VariantTable : Form
    {

        private bool isExpanded = false;
        private BunifuPanel buttonBorderPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 currentButton;
        private FlowLayoutPanel container;
        private Panel parentContainer;
        public VariantTable()
        {
            InitializeComponent();
            buttonBorderPanel = new BunifuPanel();
            buttonBorderPanel.Size = new Size(28, 5);
            tabPanel.Controls.Add(buttonBorderPanel);
            rowContainer.Size = new Size(929, 80);
            ActiveButton(bunifuButton1);
        }

        public VariantTable(FlowLayoutPanel container, Panel parentContainer)
        {
            InitializeComponent();
            this.container = container;
            this.parentContainer = parentContainer;
            container.Controls.Add(rowContainer);
            buttonBorderPanel = new BunifuPanel();
            buttonBorderPanel.Size = new Size(28, 5);
            tabPanel.Controls.Add(buttonBorderPanel);
            rowContainer.Size = new Size(929, 80);
            ActiveButton(bunifuButton1);
        }

        protected void ActiveButton(Object senderbtn)
        {
            if (senderbtn != null)
            {

                currentButton = (BunifuButton2)senderbtn;

                //left boarder button
                buttonBorderPanel.Size = new Size(currentButton.Size.Width - 8, 5);
                buttonBorderPanel.Location = new Point(currentButton.Location.X + 52, 61);
                buttonBorderPanel.ShowBorders = true;
                buttonBorderPanel.BorderRadius = 3;
                buttonBorderPanel.BorderThickness = 0;
                buttonBorderPanel.BorderColor = Color.DodgerBlue;
                buttonBorderPanel.BackgroundColor = Color.DodgerBlue;
                buttonBorderPanel.Visible = true;
                buttonBorderPanel.BringToFront();
                currentButton.Focus();

            }
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            if (!isExpanded)
            {
                leftPanel.Visible = true;
                while (rowContainer.Size.Height < 492)
                {
                    rowContainer.BorderColor = Color.White;
                    rowContainer.BackgroundColor = Color.White;
                    rowContainer.Size = new Size(929, rowContainer.Size.Height + 124);
                    parentContainer.Size = new Size(parentContainer.Size.Width, parentContainer.Size.Height + 60);
                    Thread.Sleep(10);
                }
                bunifuPictureBox1.BackColor = rowContainer.BackgroundColor;
                bunifuPictureBox2.BackColor = rowContainer.BackgroundColor;
                bunifuPictureBox1.Image = Properties.Resources.expand_arrow_50px;
                isExpanded = true;
            }
            else
            {
                leftPanel.Visible = false;
                rowContainer.BorderColor = Color.AliceBlue;
                rowContainer.BackgroundColor = Color.AliceBlue;
                rowContainer.Size = new Size(929, 80);
                bunifuPictureBox1.BackColor = rowContainer.BackgroundColor;
                bunifuPictureBox2.BackColor = rowContainer.BackgroundColor;
                bunifuPictureBox1.Image = Properties.Resources.more_than_50px;
                isExpanded = false;
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            bunifuPages1.SetPage(0);
            rowContainer.Size = new Size(929, 600);
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            bunifuPages1.SetPage(1);
            rowContainer.Size = new Size(929, 737);
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            bunifuPages1.SetPage(2);
            rowContainer.Size = new Size(929, 279);
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            bunifuPages1.SetPage(3);
            rowContainer.Size = new Size(929, 578);
        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            bunifuPages1.SetPage(4);
            rowContainer.Size = new Size(929, 518);
        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            bunifuPages1.SetPage(5);
            rowContainer.Size = new Size(929, 230);
        }
    }
}
