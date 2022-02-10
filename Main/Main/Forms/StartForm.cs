using Main.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDhmz_Click(object sender, EventArgs e)
        {
            DhmzForm dhmz = new DhmzForm();
            dhmz.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Environment.Exit(1);
            }
        }

        private void btnXsd_Click(object sender, EventArgs e)
        {
            XsdForm xsd = new XsdForm();
            xsd.Show();
        }

        private void btnRng_Click(object sender, EventArgs e)
        {
            RngForm rng = new RngForm();
            rng.Show();
        }

        private void btnSoap_Click(object sender, EventArgs e)
        {
            SOAPForm soap = new SOAPForm();
            soap.Show();
        }
    }
}
