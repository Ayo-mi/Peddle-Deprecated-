using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Point_of_Sale
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();           
        }
/*
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;
            switch(m.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = m.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                        break;
            }
            base.WndProc(ref m);
        }
*/

        private void closeLoader()
        {
            Thread.Sleep(3000);
            if (this.InvokeRequired)
            {
                Action safeWrite = delegate { closeLoader(); this.Close(); };
                this.Invoke(safeWrite);
            }else
                this.Close();
                        
        }
        public void showLoader()
        {
            this.ShowDialog();
        }

        private void Loader_Shown(object sender, EventArgs e)
        {
            var threadparameters = new ThreadStart(delegate { closeLoader(); });
            Thread t1 = new Thread(threadparameters);
            t1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
