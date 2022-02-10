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
using System.Xml;

namespace Main.Forms
{
    public partial class RngForm : Form
    {
        public RngForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnChooseXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open XML file";
            ofd.Filter = "XML files|*.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    HandleXmlFile(ofd);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            }
        }

        private static void HandleXmlFile(OpenFileDialog ofd)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(ofd.FileName);

            MemoryStream xmlStream = new MemoryStream();
            xmlDocument.Save(xmlStream);

            byte[] data = Encoding.UTF8.GetBytes(Encoding.UTF8.GetString(xmlStream.ToArray()));

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:5000/api/Motorcycles");
            request.Method = "POST";
            request.Accept = "application/xml";
            request.ContentType = "application/xml";

            Stream requestData = request.GetRequestStream();
            requestData.Write(data, 0, data.Length);
            requestData.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream responseData = response.GetResponseStream();

            MessageBox.Show("File posted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit?","Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==DialogResult.OK)
            {
                Close();
            }
        }
    }
}
