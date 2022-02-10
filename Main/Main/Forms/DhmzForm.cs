using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;


namespace Main
{
    public partial class DhmzForm : Form
    {
        private string temperature = "";

        public DhmzForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            tbTemperature.ReadOnly = true;
            
        }

        private void DhmzForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGetTemperature_Click(object sender, EventArgs e)
        {
            HandleXmlData();

            if (FormValid())
            {
                if (temperature == "500.0") 
                {
                    MessageBox.Show("No such city", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tbTemperature.Text = temperature.ToString() + " °C";
                    lbInfo.Text = string.Empty;
                }
                
            }
        }

        private void HandleXmlData()
        {
            string cityName = tbCityName.Text;
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\pasar\Desktop\IIS\Main\Main\Assets\data.xml");
            doc.DocumentElement.ChildNodes[0].InnerText = "Weather.getTemperature";
            doc.DocumentElement.ChildNodes[1].ChildNodes[0].ChildNodes[0].ChildNodes[0].InnerText = cityName;

            MemoryStream xmlStream = new MemoryStream();
            doc.Save(xmlStream);

            byte[] data = Encoding.UTF8.GetBytes(Encoding.UTF8.GetString(xmlStream.ToArray()));

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:8080");
            request.Method = "POST";
            request.Accept = "application/xml";
            request.ContentType = "application/xml";

            Stream requestData = request.GetRequestStream();
            requestData.Write(data, 0, data.Length);
            requestData.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream responseData = response.GetResponseStream();

            XmlDocument responseDocument = new XmlDocument();
            responseDocument.Load(responseData);

            temperature = responseDocument.DocumentElement.ChildNodes[0].InnerText;
            
        }

        private bool FormValid()
        {
            bool ok = true;

            if (tbCityName.Text == string.Empty)
            {
                ok = false;
                lbInfo.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
                lbInfo.Text = "Plese enter city.";
            }

            return ok;
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            tbCityName.Text = string.Empty;
            tbTemperature.Text = string.Empty;
            lbInfo.Text = string.Empty;
        }
    }
}
