using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Deneme
{
    public partial class Form1 : Form
    {
        int index = 0;
        public Form1()
        { 
            InitializeComponent();
        }
        public void VeriCek()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"Kreditoren_20141006-093812-818.xml");

            
            foreach (XmlNode item in doc.ChildNodes[1].SelectNodes("KREDITOR"))
            {   if(item.Value[index] == index) {      
                label1.Text = item["LIFNR"].InnerText;
                label4.Text = item["NAME1"].InnerText;
                if (item["NAME2"] == null)
                {
                    label3.Text = " ";
                }
                else { label3.Text = item["NAME2"].InnerText; }
                label2.Text = item["STRASSE"].InnerText;
                label5.Text = item["ADRESSE"].InnerText;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //İleri
            // XmlNode secilenNode =doc.SelectSingleNode("/Kitaplik/Kitap[@Id=" + id + "]");
            index++;
            VeriCek();
        }

        private void button2_Click(object sender, EventArgs e)
        {   //Geri
            index--;
            VeriCek();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
