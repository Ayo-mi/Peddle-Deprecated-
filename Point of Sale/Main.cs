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
using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;

namespace Point_of_Sale
{
    public partial class Main : Form
    {
        //private fields
        private Form currentChildForm;
        private Form currentChildDialog;
        private Form currentMessageDialog;
        private int borderSize = 2;
        private BunifuButton2 currentButton;
        private BunifuPanel leftBoarderPanel;
  
        public Main()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.GetBounds(new Point(1370, 730));
            leftBoarderPanel =new BunifuPanel();
            leftBoarderPanel.Size = new Size(5, 15);
            sideNav.Controls.Add(leftBoarderPanel);
            //Form
            this.ControlBox = false;
            this.DoubleBuffered = true;            
        }
     
        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwind, int wMsg, int wParam, int lParam);

        private void ActiveButton(Object senderbtn)
        {
            if (senderbtn != null)
            {
               
                currentButton = (BunifuButton2) senderbtn;
                
                //left boarder button
                leftBoarderPanel.Location = new Point(0, currentButton.Location.Y+20);
                leftBoarderPanel.ShowBorders = true;
                leftBoarderPanel.BorderRadius = 3;
                leftBoarderPanel.BorderThickness = 0;
                leftBoarderPanel.BorderColor = Color.AliceBlue;
                leftBoarderPanel.BackgroundColor = Color.AliceBlue;
                leftBoarderPanel.Visible = true;
                leftBoarderPanel.BringToFront();
                currentButton.Focus();
                               
            }
        }
       
        public void openChildForm(Form childForm)
        {
            if(formTitle.Text == childForm.Text)
            {
                return;
            }
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            desktopPanel.Controls.Add(childForm);
            desktopPanel.Tag = childForm;
            formTitle.Text = childForm.Text;
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

        private void closeDialog()
        {
            Thread.Sleep(3000);
            //currentChildDialog.Close();

        }
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(0, 8, 8, 0);
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void setPage(int index)
        {
            pagesPanel.SetPage(index);
        }

        private void initSetup()
        {
            formIcon.Image = global::Point_of_Sale.Properties.Resources.login_100px;
            
            formTitle.Text = "Sign In";
            notifBadge.Enabled = false;
            formTitle.BringToFront();
            panel1.Visible = false;
            notifBadge.Visible = false;
            notification.Visible = false;
            profilePic.Visible = false;
            username.Visible = false;
            userEmail.Visible = false;

            AdjustFormTitle();
        }

        private void prepareLoggedUserEnvironment()
        {
            notifBadge.Enabled = false;
            
            panel1.Visible = true;
            notifBadge.Visible = true;
            notifBadge.Enabled = true;
            notification.Visible = true;
            profilePic.Visible = true;
            username.Visible = true;
            userEmail.Visible = true;
            
            ActiveButton(dashboardBtn);
            formIcon.Image = global::Point_of_Sale.Properties.Resources.dashboard_layout_dodgerblue100px;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = bunifuPagesSlide.TabCount;
            int a = 0;
            while (a <= i)
            {
                bunifuPagesSlide.SetPage(a);
                a = a + 1;
            }
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
               // this.Size= (Size)new Point(1368, 730);
              //  this.Location = new Point(0, 0);
                WindowState = FormWindowState.Maximized;
                //MessageBox.Show(this.Size.ToString());
                iconButtonMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            } else
            {
                WindowState = FormWindowState.Normal;
                iconButtonMaximize.IconChar= FontAwesome.Sharp.IconChar.WindowMaximize;
            }
        }

        private void iconButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initSetup();
        }
        private void iconButtonExit_MouseEnter(object sender, EventArgs e)
        {
            iconButtonExit.BackColor = Color.Red;
            iconButtonExit.IconColor = Color.AliceBlue;
        }

        private void iconButtonExit_MouseLeave(object sender, EventArgs e)
        {
            iconButtonExit.BackColor = Color.AliceBlue;
            iconButtonExit.IconColor = Color.Gray;
        }
        private void notification_MouseEnter(object sender, EventArgs e)
        {
           notification.BackColor = Color.AliceBlue;
        }

        private void notification_MouseLeave(object sender, EventArgs e)
        {
            notification.BackColor = Color.AliceBlue;
        }

        private void emailLogTxt_TextChange(object sender, EventArgs e)
        {
            if (!(emailLogTxt.Text == string.Empty))
            {
                this.emailLogTxt.IconRight = global::Point_of_Sale.Properties.Resources.times_circle_solid;
                this.emailLogTxt.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            }
            else
            {
                this.emailLogTxt.IconRight = null;
            }
        }

        private void emailLogTxt_OnIconRightClick(object sender, EventArgs e)
        {
            emailLogTxt.Text = string.Empty;
        }

        private void passwordLogTxt_OnIconRightClick(object sender, EventArgs e)
        {
            if (passwordLogTxt.UseSystemPasswordChar)
            {
                passwordLogTxt.UseSystemPasswordChar = false;
                passwordLogTxt.PasswordChar = '\0';
                this.passwordLogTxt.IconRight = global::Point_of_Sale.Properties.Resources.eye_slash_solid;
                this.passwordLogTxt.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            }
            else
            {
                passwordLogTxt.UseSystemPasswordChar = true;
                passwordLogTxt.PasswordChar = '●';
                this.passwordLogTxt.IconRight = global::Point_of_Sale.Properties.Resources.eye_regular;
                this.passwordLogTxt.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            }
        }

        private void passwordLogTxt_TextChange(object sender, EventArgs e)
        {
            if (!(passwordLogTxt.Text == string.Empty) && passwordLogTxt.UseSystemPasswordChar)
            {
                this.passwordLogTxt.IconRight = global::Point_of_Sale.Properties.Resources.eye_regular;
                this.passwordLogTxt.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            }
            else if (!(passwordLogTxt.Text == string.Empty) && !passwordLogTxt.UseSystemPasswordChar)
            {
                this.passwordLogTxt.IconRight = global::Point_of_Sale.Properties.Resources.eye_slash_solid;
                this.passwordLogTxt.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            }
            else
            {
                this.passwordLogTxt.IconRight = null;
            }
        }

        private void lblForgetPassword_MouseEnter(object sender, EventArgs e)
        {
            lblForgetPassword.ForeColor = Color.RoyalBlue;
        }

        private void lblForgetPassword_MouseLeave(object sender, EventArgs e)
        {
            lblForgetPassword.ForeColor = Color.DodgerBlue;
        }
        private void signupBtn_Click(object sender, EventArgs e)
        {
            formIcon.Image = global::Point_of_Sale.Properties.Resources.add_user_male_100px;
            formTitle.Text = "Sign Up";
            setPage(1);
        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            formIcon.Image = global::Point_of_Sale.Properties.Resources.password_reset_100px;
            formTitle.Text = "Forget Password";
            setPage(2);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            formIcon.Image = global::Point_of_Sale.Properties.Resources.login_100px;
            formTitle.Text = "Sign In";
            setPage(0);
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            formIcon.Image = global::Point_of_Sale.Properties.Resources.logout_rounded_left_100px;
            formTitle.Text = "Sign In";
            setPage(0);
        }

        private void notifBadge_MouseHover(object sender, EventArgs e)
        {
            return;
        }
        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            //openChildDialog(new Loader());
            
            prepareLoggedUserEnvironment();
            AdjustFormTitle();            
            openChildForm(new dashoard(this));
            dashboardBtn.Focus();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ActiveButton(currentButton);
            AdjustFormTitle();
            changeIcon();
        }

        private void changeIcon()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                iconButtonMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            }else if (WindowState == FormWindowState.Normal)
            {
                iconButtonMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            }
        }
        private void AdjustFormTitle()
        {
            if (WindowState == FormWindowState.Maximized && panel1.Visible)
            {
                formIcon.Location = new Point(10, 2);
                formTitle.Location = new Point(60, 11);
            }
            else if (WindowState == FormWindowState.Normal && panel1.Visible)
            {
                formIcon.Location = new Point(3, 2);
                formTitle.Location = new Point(48, 11);
            }
            else if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized && !panel1.Visible)
            {
                formIcon.Location = new Point(3, 2);
                formTitle.Location = new Point(48, 11);
            }
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            openChildForm(new dashoard(this));
            formIcon.Image = global::Point_of_Sale.Properties.Resources.dashboard_layout_dodgerblue100px;
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            formIcon.Image = global::Point_of_Sale.Properties.Resources.price_tag_dodgerblue100px;
        }

        private void saleAnalyticBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            formIcon.Image = global::Point_of_Sale.Properties.Resources.increase_dodgerblue100px;
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            formIcon.Image = global::Point_of_Sale.Properties.Resources.payroll_dodgerblue100px;
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            formIcon.Image = global::Point_of_Sale.Properties.Resources.people_dodgerblue100px;
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            formIcon.Image = global::Point_of_Sale.Properties.Resources.settings_dodgerblue100px;
        }

        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void notifBadge_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            initSetup();
            setPage(0);
        }

        private void slide2_Click(object sender, EventArgs e)
        {

        }

        private void posBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            formIcon.Image = global::Point_of_Sale.Properties.Resources.cash_register_dodger100px;
        }

        private void salesAnalytic_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            formIcon.Image = global::Point_of_Sale.Properties.Resources.increase_dodgerblue100px;
        }

        private void catalog_Click(object sender, EventArgs e)
        {
            openChildForm(new Catalog.Catalog(this));
            ActiveButton(sender);
            formIcon.Image = global::Point_of_Sale.Properties.Resources.tags_dodger100px;
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            formIcon.Image = global::Point_of_Sale.Properties.Resources.boxes_dodeger100px;
        }

        private void customerBtn_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Customers.Customers(this));
            ActiveButton(sender);
            formIcon.Image = global::Point_of_Sale.Properties.Resources.people_dodgerblue100px;
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new settings(this));
            ActiveButton(sender);            
            formIcon.Image = global::Point_of_Sale.Properties.Resources.settings_dodgerblue100px;
        }
    }
}
