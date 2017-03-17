using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pp
{
    public partial class Form2 : Form
    {
        public string SetMny
        {
            set
            {
                lMny2.Text = value;
            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        int tPianyi = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            lT2.Text = DateTime.Now.AddSeconds(tPianyi).ToString("HH:mm:ss");
        }

        private void bttnDeffT_Click(object sender, EventArgs e)
        {
            tPianyi--;
        }

        private void bttnAddT_Click(object sender, EventArgs e)
        {
            tPianyi++;
        }

        private void lT2_DoubleClick(object sender, EventArgs e)
        {
            tPianyi = 0;
        }
    }
}
