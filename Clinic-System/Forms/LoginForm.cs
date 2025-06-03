using Clinic_System;
using Clinic_System.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinic_System {
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm {
        public LoginForm() {
            InitializeComponent();
        }

        private void btn_LoginButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            
        }
    }
}
