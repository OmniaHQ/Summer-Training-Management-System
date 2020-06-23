using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using CrystalDecisions.Shared;

namespace project_db
{
    public partial class crystalform3 : Form
    {
        CrystalReport3 cr;
        public crystalform3()
        {
            InitializeComponent();
        }

        private void crystalform3_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport3();
            foreach (ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(v.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = cr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TAForm tform = new TAForm();
            tform.ShowDialog();
            this.Close();
        }
    }
}
