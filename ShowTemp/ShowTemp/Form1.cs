using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowTemp
{
    public partial class Form1 : Form
    {

        public int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public DataSet deneme()
        {
            var service = new tempService.wsAddSoapClient();
            return service.GetTempValues();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            deneme();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var db = deneme();
            i++;
            dGAnt.Text = db.Tables[0].Rows[0][2].ToString();
            dgIzm.Text = db.Tables[0].Rows[1][2].ToString();
            dgKay.Text = db.Tables[0].Rows[2][2].ToString();
            dgAnk.Text = db.Tables[0].Rows[3][2].ToString();
            dgIst.Text = db.Tables[0].Rows[4][2].ToString();
                
        }
    }
}
