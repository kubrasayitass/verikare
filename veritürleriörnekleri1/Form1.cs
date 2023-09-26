using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veritürleriörnekleri1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            Sint sayi = Convert.ToInt32(txtSayi.Text);
            int sonuc = sayi * sayi;


            lblSonuç.Text = sonuc.ToString();




        }
    }
}
