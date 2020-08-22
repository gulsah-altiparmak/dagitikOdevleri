using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnUcuzUrun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            wsHepsiBurada.wsAddSoapClient wsHB = new wsHepsiBurada.wsAddSoapClient();
            DataSet dsHB = new DataSet();
            dsHB = wsHB.urunFiyatiGetir(textBox1.Text);
            if (dsHB.Tables[0].Rows.Count > 0)
            {
                LBUrunKodu.Text = dsHB.Tables[0].Rows[0]["URUNKODU"].ToString();
                LBUrunAdi.Text = dsHB.Tables[0].Rows[0]["URUNADI"].ToString();
                LBUrunFiyati.Text = dsHB.Tables[0].Rows[0]["FIYAT"].ToString();


            }
            else
            {
                LBUrunKodu.Text = "...";
                LBUrunAdi.Text = "...";
                LBUrunFiyati.Text = "...";
            }


        }
    }
}
