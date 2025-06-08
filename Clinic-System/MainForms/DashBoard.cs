using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Clinic_System.UC_Forms;

namespace Clinic_System.Forms
{
	public partial class DashBoard: DevExpress.XtraEditors.XtraForm
	{
        public DashBoard()
		{
            InitializeComponent();
		}


        private void accPatient_Click(object sender, EventArgs e)//accordine control for Patient's
        {
            panelBody.Controls.Clear();
            Patients patienceFillUpForm = new Patients();
            patienceFillUpForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(patienceFillUpForm);
        }

        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void accDmcClinic_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }
    }
}
