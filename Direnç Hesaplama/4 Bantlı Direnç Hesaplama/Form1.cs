using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Bantlı_Direnç_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double renk1, renk2, carpan, tolerans, sonuc;

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            renk1 = Convert.ToDouble(cmbBoxRenk1.SelectedIndex.ToString());
            renk2 = Convert.ToDouble(cmbBoxRenk2.SelectedIndex.ToString());
            tolerans = Convert.ToDouble(cmbBoxCarpan.SelectedIndex.ToString());

            sonuc = ((renk1 * 10) + renk2) * carpan;
            txtDeger.Text = sonuc.ToString() + " " + "Ohm";
        }

        private void cmbBoxTolerans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbBoxTolerans.SelectedIndex == 0)
            {
                txtToleransRnk.BackColor = Color.Gold;
                carpan = 0.1;
                txtTolerans.Text = "%5";
            }
            else if(cmbBoxTolerans.SelectedIndex == 1)
            {
                txtToleransRnk.BackColor = Color.Silver;
                carpan = 0.01;
                txtTolerans.Text = "%10";
            }
        }

        private void cmbBoxCarpan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxCarpan.SelectedIndex == 0)
            {
                txtCrpnRnk.BackColor = Color.Black;
                carpan = 1;
            }
            else if (cmbBoxCarpan.SelectedIndex == 1)
            {
                txtCrpnRnk.BackColor = Color.Brown;
                carpan = 10;
            }
            else if (cmbBoxCarpan.SelectedIndex == 2)
            {
                txtCrpnRnk.BackColor = Color.Red;
                carpan = 100;
            }
            else if (cmbBoxCarpan.SelectedIndex == 3)
            {
                txtCrpnRnk.BackColor = Color.Orange;
                carpan = 1000;
            }
            else if (cmbBoxCarpan.SelectedIndex == 4)
            {
                txtCrpnRnk.BackColor = Color.Yellow;
                carpan = 10000;
            }
            else if (cmbBoxCarpan.SelectedIndex == 5)
            {
                txtCrpnRnk.BackColor = Color.Green;
                carpan = 100000;
            }
            else if (cmbBoxCarpan.SelectedIndex == 6)
            {
                txtCrpnRnk.BackColor = Color.Blue;
                carpan = 1000000;
            }
            else if (cmbBoxCarpan.SelectedIndex == 7)
            {
                txtCrpnRnk.BackColor = Color.Purple;
                carpan = 10000000;
            }
            else if (cmbBoxCarpan.SelectedIndex == 8)
            {
                txtCrpnRnk.BackColor = Color.Gray;
                carpan = 100000000;
            }
            else if (cmbBoxCarpan.SelectedIndex == 9)
            {
                txtCrpnRnk.BackColor = Color.White;
                carpan = 1000000000;
            }
        }

        private void cmbBoxRenk2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxRenk2.SelectedIndex == 0)
            {
                txtRnk2.BackColor = Color.Black;
            }
            else if (cmbBoxRenk2.SelectedIndex == 1)
            {
                txtRnk2.BackColor = Color.Brown;
            }
            else if (cmbBoxRenk2.SelectedIndex == 2)
            {
                txtRnk2.BackColor = Color.Red;
            }
            else if (cmbBoxRenk2.SelectedIndex == 3)
            {
                txtRnk2.BackColor = Color.Orange;
            }
            else if (cmbBoxRenk2.SelectedIndex == 4)
            {
                txtRnk2.BackColor = Color.Yellow;
            }
            else if (cmbBoxRenk2.SelectedIndex == 5)
            {
                txtRnk2.BackColor = Color.Green;
            }
            else if (cmbBoxRenk2.SelectedIndex == 6)
            {
                txtRnk2.BackColor = Color.Blue;
            }
            else if (cmbBoxRenk2.SelectedIndex == 7)
            {
                txtRnk2.BackColor = Color.Purple;
            }
            else if (cmbBoxRenk2.SelectedIndex == 8)
            {
                txtRnk2.BackColor = Color.Gray;
            }
            else if (cmbBoxRenk2.SelectedIndex == 9)
            {
                txtRnk2.BackColor = Color.White;
            }
        }

        private void cmbBoxRenk1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxRenk1.SelectedIndex == 0)
            {
                txtRnk1.BackColor = Color.Black;
            }
            else if(cmbBoxRenk1.SelectedIndex == 1)
            {
                txtRnk1.BackColor = Color.Brown;
            }
            else if( cmbBoxRenk1.SelectedIndex == 2)
            {
                txtRnk1.BackColor= Color.Red;
            }
            else if(cmbBoxRenk1.SelectedIndex == 3)
            {
                txtRnk1.BackColor = Color.Orange;
            }
            else if (cmbBoxRenk1.SelectedIndex == 4)
            {
                txtRnk1.BackColor = Color.Yellow;
            }
            else if(cmbBoxRenk1.SelectedIndex == 5)
            {
                txtRnk1.BackColor = Color.Green;
            }
            else if (cmbBoxRenk1.SelectedIndex == 6)
            {
                txtRnk1.BackColor = Color.Blue;
            }
            else if (cmbBoxRenk1.SelectedIndex == 7)
            {
                txtRnk1.BackColor = Color.Purple;
            }
            else if(cmbBoxRenk1.SelectedIndex == 8)
            {
                txtRnk1.BackColor = Color.Gray;
            }
            else if(cmbBoxRenk1.SelectedIndex == 9)
            {
                txtRnk1.BackColor = Color.White;
            }
        }
    }
}



