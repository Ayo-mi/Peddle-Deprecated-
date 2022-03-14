using Bunifu.UI.WinForms;
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
    public partial class Add_Product : Form
    {

        private bool standardP = true;
        private bool variantP = false;
        private bool compositeP = false;
        private String autoSku = "1001";
        private int y1, y2, index;
        public Add_Product()
        {
            y1 = 20;
            y2 = 47;
            index=1;
            InitializeComponent();            
        }

        private void populateSingleProductTable(BunifuDataGridView table)
        {
            
            table.Rows.Clear();            
            try
            {
                table.Rows.Add(Properties.Resources.box_50px,
                            bunifuTextBox1.Text+"\n"+autoSku,
                            "Auto-generated",
                            autoSku,
                            0.00,
                            0.00,
                            0.00);
            }catch (DataException e)
            {
                MessageBox.Show(e.Message);
            }
            /*

            List<SingleProduct> rowData = new List<SingleProduct>()
            {
                new SingleProduct()
                {
                    img= Properties.Resources.box_50px,
                    skuTyp = new String[] {"Auto-generated", "Custom SKU"},
                    sku = autoSku,
                    supplyPrice = 0.00,
                    markup = 0.00,
                    retailPrice = 0.00

                }
            };

            foreach (var data in rowData)
            {
                try
                {
                    table.Rows.Add(Properties.Resources.box_50px,
                        autoSku,
                        new String[] { "Auto-generated", "Custom SKU" },
                        autoSku,
                        0.00,
                        0.00,
                        0.00);
                }catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }*/

        }

        private void columnEditing_keyPress(Object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    
        private void createNewAttribute()
        {
            BunifuLabel customLbl1 = new BunifuLabel();
            customLbl1.AllowParentOverrides = false;
            customLbl1.AutoEllipsis = false;
            customLbl1.Cursor = System.Windows.Forms.Cursors.Default;
            customLbl1.CursorType = System.Windows.Forms.Cursors.Default;
            customLbl1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            customLbl1.Location = new System.Drawing.Point(21, y1+70);
            customLbl1.Name = "customLbl1";
            customLbl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            customLbl1.Size = new System.Drawing.Size(198, 16);
            customLbl1.TabIndex = 5;
            customLbl1.Text = "Variant Attribute <span style=\"font-weight: normal;\">(e.g. Color)</span>";
            customLbl1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            customLbl1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;

            //attrib combobox
            ComboBox customcomboBox1 = new ComboBox();
            customcomboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            customcomboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            customcomboBox1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customcomboBox1.FormattingEnabled = true;
            customcomboBox1.Items.AddRange(new object[] {
            "Color",
            "Size"});
            customcomboBox1.Location = new System.Drawing.Point(18, y2 + 70);
            customcomboBox1.Name = "customcomboBox1";
            customcomboBox1.Size = new System.Drawing.Size(198, 26);
            customcomboBox1.SelectedIndex = 0;
            customcomboBox1.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(customcomboBox1, "You can select an attribute from the dropdown\r\n(e.g. Color or Size). If the varia" +
        "nt type is not in\r\nthe options available in the dropdown, type in\r\nyour variant typ" +
        "e");
            this.bunifuToolTip1.SetToolTipIcon(customcomboBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(customcomboBox1, "Select a Variant Attribute");

            //value label
            BunifuLabel customLbl2 = new BunifuLabel();
            customLbl2.AllowParentOverrides = false;
            customLbl2.AutoEllipsis = false;
            customLbl2.Cursor = System.Windows.Forms.Cursors.Default;
            customLbl2.CursorType = System.Windows.Forms.Cursors.Default;
            customLbl2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
            customLbl2.Location = new System.Drawing.Point(323, y1+70);
            customLbl2.Name = "customLbl2";
            customLbl2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            customLbl2.Size = new System.Drawing.Size(177, 16);
            customLbl2.TabIndex = 7;
            customLbl2.Text = "Value <span style=\"font-weight: normal;\">(e.g. blue, red, green)</span>";
            customLbl2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            customLbl2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;

            //value textbox
            BunifuTextBox customTextbox1 = new BunifuTextBox();
            customTextbox1.DefaultFont = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customTextbox1.DefaultText = "";
            customTextbox1.FillColor = System.Drawing.Color.White;
            customTextbox1.Name = "customTextbox1";

            customTextbox1.PlaceholderForeColor = System.Drawing.Color.Silver;
            customTextbox1.PlaceholderText = "Enter value for this attribute";
            customTextbox1.BorderRadius = 5;

            customTextbox1.Size = new System.Drawing.Size(472, 35);
            customTextbox1.TextPlaceholder = "Enter value for this attribute";
            customTextbox1.Location = new Point(323, y2+70);
            this.bunifuToolTip1.SetToolTip(customTextbox1, "Once the variant attribute has been selected,\r\nyou can add your attribute values (" +
        "e.g. Red, Blue,\r\nMedium, Large), separated with comma");
            this.bunifuToolTip1.SetToolTipIcon(customTextbox1, null);
            bunifuToolTip1.SetToolTipTitle(customTextbox1, "Enter Attribute Value(s)");
            customTextbox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(customTextBox3_KeyPress);


            this.attribPanel.Controls.Add(customLbl1);
            this.attribPanel.Controls.Add(customLbl2);
            this.attribPanel.Controls.Add(customcomboBox1);
            this.attribPanel.Controls.Add(customTextbox1);
            this.attribPanel.Size = new Size(attribPanel.Size.Width, attribPanel.Size.Height + 69);
            vpPanel.Size = new Size(vpPanel.Size.Width, vpPanel.Size.Height +50);
            variantFlowPanel.Size = new Size(variantFlowPanel.Size.Width, variantFlowPanel.Height + 50);

            y1 = customLbl1.Location.Y;
            y2 = customTextbox1.Location.Y;

             void customTextBox3_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.KeyChar == ',')
                {
                    String[] val = customTextbox1.Text.Split(',');
                    bool found = false;
                    if (!String.IsNullOrWhiteSpace(val.Last().ToString()) && !String.IsNullOrWhiteSpace(customcomboBox1.Text))
                    {
                        foreach (DataGridViewRow r in vpTable.Rows)
                        {
                            if (string.Equals(r.Cells[8].Value.ToString(), customcomboBox1.Text, StringComparison.OrdinalIgnoreCase) && string.Equals(r.Cells[9].Value.ToString(), val.Last().Trim(), StringComparison.OrdinalIgnoreCase))
                            {
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            try
                            {
                                vpTable.Rows.Add(true,
                                            Properties.Resources.box_50px,
                                            val.Last().ToString().Trim() + "\n" + autoSku,
                                            "Auto-generated",
                                            autoSku,
                                            0.00,
                                            0.00,
                                            0.00,
                                            customcomboBox1.Text,
                                            val.Last().ToString().Trim());
                            }
                            catch (DataException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }

        }

        private void sPanel_Click(object sender, EventArgs e)
        {
            vpPanel.Visible = false;
            cpPanel.Visible = false;
            spPanel.Visible = true;
            standardP = true;
            compositeP = false;
            variantP = false;
            vPanel.BorderColor = Color.DarkGray;
            vPanel.BorderThickness = 1;
            cPanel.BorderColor = Color.DarkGray;
            cPanel.BorderThickness = 1;
            sPanel.BringToFront();
            sPanel.BorderColor = Color.FromArgb(65, 175, 75);
            sPanel.BorderThickness = 3;
            addBtn.Size = new Size(114, 38);
            addBtn.Text = "Add Prodcut";
        }

        private void cPanel_Click(object sender, EventArgs e)
        {
            vpPanel.Visible = false;
            cpPanel.Visible = true;
            spPanel.Visible = false;
            standardP = false;
            compositeP = true;
            variantP = false;
            sPanel.BorderColor = Color.DarkGray;
            sPanel.BorderThickness = 1;
            vPanel.BorderColor = Color.DarkGray;
            vPanel.BorderThickness = 1;
            cPanel.BringToFront();
            cPanel.BorderColor = Color.FromArgb(65, 175, 75);
            cPanel.BorderThickness = 3;
            addBtn.Size = new Size(99, 38);
            addBtn.Text = "Next";
        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {
            sPanel_Click(sender, e);
        }

        private void bunifuLabel7_Click(object sender, EventArgs e)
        {
            vPanel_Click(sender, e);
        }

        private void vPanel_Click(object sender, EventArgs e)
        {
            vpPanel.Visible = true;
            cpPanel.Visible = false;
            spPanel.Visible = false;
            standardP = false;
            compositeP = false;
            variantP = true;
            sPanel.BorderColor = Color.DarkGray;
            sPanel.BorderThickness = 1;
            cPanel.BorderColor = Color.DarkGray;
            cPanel.BorderThickness = 1;
            vPanel.BringToFront();
            vPanel.BorderColor = Color.FromArgb(65, 175, 75);
            vPanel.BorderThickness = 3;
            addBtn.Size = new Size(114, 38);
            addBtn.Text = "Add Prodcut";
        }

        private void bunifuLabel9_Click(object sender, EventArgs e)
        {
            cPanel_Click(sender, e);
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Product_Load(object sender, EventArgs e)
        {
            populateSingleProductTable(spTable);
        }

        private void spTable_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {            
            e.Control.KeyPress -= new KeyPressEventHandler(columnEditing_keyPress);
            if(spTable.CurrentCell.ColumnIndex == 3 || spTable.CurrentCell.ColumnIndex == 4 || spTable.CurrentCell.ColumnIndex == 5 || spTable.CurrentCell.ColumnIndex == 6)
            {
                TextBox tb = e.Control as TextBox;
                if(tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(columnEditing_keyPress);
                }
            }
        }

        private void spTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (spTable.CurrentCell.ColumnIndex == 3)
            {
                spTable.CurrentRow.Cells[1].Value = bunifuTextBox1.Text+"\n"+spTable.CurrentRow.Cells[3].Value;
            }
            if (spTable.CurrentCell.ColumnIndex == 2)
            {
                if((String)spTable.CurrentCell.Value == "Auto-generated")
                {
                    spTable.Columns[3].ReadOnly = true;
                }
                else
                {
                    spTable.Columns[3].ReadOnly = false;
                }
            }
        }

     
        private void bunifuPictureBox2_Click_1(object sender, EventArgs e)
        {
            if (index < 3)
            {
                index += 1;
                createNewAttribute();                
            }
            if (index == 3)
            {
                bunifuLabel16.Visible = false;
                bunifuPictureBox2.Visible = false;
            }
        }

        private void vpTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (vpTable.CurrentCell.ColumnIndex == 4)
            {
                String[] a = vpTable.CurrentRow.Cells[2].Value.ToString().Split(new String[] {"\r\n", "\n", "\r"},StringSplitOptions.None);
                vpTable.CurrentRow.Cells[2].Value = a.First().ToString() + "\n" + vpTable.CurrentRow.Cells[4].Value;
            }
            if (vpTable.CurrentCell.ColumnIndex == 3)
            {
                if ((String)vpTable.CurrentCell.Value == "Auto-generated")
                {
                    vpTable.Columns[4].ReadOnly = true;
                }
                else
                {
                    vpTable.Columns[4].ReadOnly = false;
                }
            }
        }

        private void bunifuRadioButton2_CheckedChanged2(object sender, BunifuRadioButton.CheckedChangedEventArgs e)
        {
            if(bunifuRadioButton2.Checked == true)
            {
                bunifuTextBox2.Enabled = true;
            }
            else
            {
                bunifuTextBox2.Enabled = false;
            }

        }

        private void bunifuTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                String[] val = bunifuTextBox3.Text.Split(',');
                bool found = false;
                if (!String.IsNullOrWhiteSpace(val.Last().ToString()) && !String.IsNullOrWhiteSpace(comboBox1.Text))
                {
                    foreach (DataGridViewRow r in vpTable.Rows)
                    {
                        if (string.Equals(r.Cells[8].Value.ToString(), comboBox1.Text, StringComparison.OrdinalIgnoreCase) && string.Equals(r.Cells[9].Value.ToString(), val.Last().Trim(), StringComparison.OrdinalIgnoreCase))
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        try
                        {
                            vpTable.Rows.Add(true,
                                        Properties.Resources.box_50px,
                                        val.Last().ToString().Trim() + "\n" + autoSku,
                                        "Auto-generated",
                                        autoSku,
                                        0.00,
                                        0.00,
                                        0.00,
                                        comboBox1.Text,
                                        val.Last().ToString().Trim());
                        }
                        catch (DataException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

    }
}
