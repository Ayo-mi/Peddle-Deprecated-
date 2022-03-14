using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using Point_of_Sale.Customers.Modals;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale
{
    class Functions
    {
        private Form currentChildDialog;
        private BunifuPanel buttonBorderPanel;
        private BunifuButton2 currentButton;
        private Form currentChildForm;

        public Functions()
        {
            buttonBorderPanel = new BunifuPanel();
            buttonBorderPanel.Size = new Size(28, 5);            
        }

        public void openChildDialogOverlay(Form form)
        {
            overlayBg formBackground = new overlayBg();
            try
            {

                    formBackground.Show();
                    form.Owner = formBackground;
                    openChildDialog(form);

                    formBackground.Dispose();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

        public void ActiveBtn(Object senderbtn, Panel parentContainer)
        {
            parentContainer.Controls.Remove(buttonBorderPanel);
            if (senderbtn != null)
            {

                currentButton = (BunifuButton2)senderbtn;

                //left boarder button
                parentContainer.Controls.Add(buttonBorderPanel);
                buttonBorderPanel.Size = new Size(currentButton.Size.Width - 10, 5);
                buttonBorderPanel.Location = new Point(currentButton.Location.X + 5, 0);
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

        public void openChildForm(Form parentForm, Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            parentForm.Controls.Add(childForm);
            parentForm.Tag = childForm;
            //formTitle.Text = childForm.Text;
            childForm.BringToFront();
            childForm.Show();
        }

        public void openChildDialog(Form childForm)
        {
            if (currentChildDialog != null)
            {
                currentChildDialog.Close();
            }
            currentChildDialog = childForm;
            childForm.ShowDialog();
        }

    }

}
