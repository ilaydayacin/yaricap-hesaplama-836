using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YARIÇAP_HESAPLAMA_836
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            double cap, alan, cevre; 
            cap = Convert.ToDouble(txtCap.Text);
            //pi = 3.14;

            alan = Math.PI * cap * cap;
            cevre= 2* Math.PI * cap;

            lblAlan.Text = "Alan: " + alan.ToString();
            lblCevre.Text = "Çevre: " + cevre.ToString();
        }
    }
}
