using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gunad=cmbGun.Text;
            int gunNo=cmbGun.SelectedIndex;
            gunNo++;
            lblSonuc.Text = gunad + "Haftanın" + gunNo + "Gündür";

            if(gunNo==1|| gunNo == 2||gunNo==3)
            {
                lblSonuc.Text = "Çıkış Saatleri 16:40";
            }
            else if(gunNo==4|| gunNo==5)
            {
                lblSonuc.Text = "Çıkış Saatleri 15:50";
            }
            else
            {
                lblSonuc.Text = "Tatil";
            }
        }
    }
}
