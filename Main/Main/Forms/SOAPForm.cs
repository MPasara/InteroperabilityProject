using Main.localhost;
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
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace Main.Forms
{
    public partial class SOAPForm : Form
    {  

        MotoService1 service = new MotoService1();
        
        public SOAPForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string motorcycleMake = tbMake.Text;

            Motorcycle[] allBikes = service.GetAllMotorcycles();

            var dir = @"C:\Users\pasar\Desktop\Soap_file";
            var fileName = @"\motorcycles.xml";

            var filePath = dir + fileName;

            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);


            XmlSerializer xmlSerializer = new XmlSerializer(allBikes.GetType());
            TextWriter writer = new StreamWriter(filePath);
            xmlSerializer.Serialize(writer, allBikes);
            writer.Close();


            XPathNavigator nav;
            XPathDocument docNav;
            XPathNodeIterator nodeIter;
            string strExpression;

            if (FormValid())
            {
                docNav = new XPathDocument(filePath);
                Console.WriteLine("docNav: " + docNav.ToString());
                nav = docNav.CreateNavigator();
                strExpression = $"/ArrayOfMotorcycle/Motorcycle[Make = '{motorcycleMake}']";
                nodeIter = nav.Select(strExpression);

                if (nodeIter.Count==0) MessageBox.Show("No such motorcycle.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                while (nodeIter.MoveNext())
                {
                    Console.WriteLine("nodeIter val ->" + nodeIter.Current.Value);
                    tbResult.Text = nodeIter.Current.Value;
                }
            }

        }

        private bool FormValid()
        {
            bool ok = true;

            if (tbMake.Text == string.Empty)
            {
                ok = false;
                MessageBox.Show("Please enter make of motorcycle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return ok;
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            tbMake.Text = string.Empty;
            tbResult.Text = string.Empty;
        }
    }
}
