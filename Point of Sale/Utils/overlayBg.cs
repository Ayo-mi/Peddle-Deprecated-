using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_of_Sale.Customers.Modals
{
    public partial class overlayBg : Form
    {
        public overlayBg()
        {
            InitializeComponent();           
        }

        public overlayBg(Form childDialog)
        {
            InitializeComponent();                                   
            childDialog.ShowDialog();
            //this.MaximizedBounds=Screen.FromHandle()
        }

        private void overlayBg_Load(object sender, EventArgs e)
        {            
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //this.WindowState = FormWindowState.Maximized;
           
           
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
           
            //MessageBox.Show(m.WindowState.ToString());
            
        }
    }
}
