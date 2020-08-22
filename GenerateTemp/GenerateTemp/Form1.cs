using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateTemp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetValue_Click(object sender, EventArgs e)
        {
            List<string> cityList = new List<string> { "İstanbul", "Ankara", "Kayseri", "İzmir", "Antalya" };


            Random rd = new Random();
            var deger = rd.Next(-15, 40);
            var deger2 = rd.Next(-15, 40);
            var deger3 = rd.Next(-15, 40);
            var deger4 = rd.Next(-15, 40);
            var deger5 = rd.Next(-15, 40);
            tempIst.Text = deger + "°";
            tempAnk.Text = deger2.ToString() + "°";
            tempKay.Text = deger3.ToString() + "°";
            tempIzm.Text = deger4.ToString() + "°";
            tempAnt.Text = deger5.ToString() + "°";
            List<int> valueList = new List<int> { deger, deger2, deger3, deger4, deger5 };
            SetValues(cityList, valueList);


        }
        public void SetValues(List<string> cityList, List<int> valueList)

        {
            for (int i = 0; i < cityList.Count; i++)
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(@"http://192.168.159.131/WEBAPP/Temp/SaveValues?temp=" + valueList[i] + "&city="+cityList[i]);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string content = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }

        }
    }
}
