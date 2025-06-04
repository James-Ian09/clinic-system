namespace Clinic_System.Forms
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accDmcClinic = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accPatient = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accStudentElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.panelBody = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accDmcClinic});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(260, 445);
            this.accordionControl1.TabIndex = 0;
            // 
            // accDmcClinic
            // 
            this.accDmcClinic.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accPatient});
            this.accDmcClinic.Expanded = true;
            this.accDmcClinic.Name = "accDmcClinic";
            this.accDmcClinic.Text = "DMC CLINIC";
            // 
            // accPatient
            // 
            this.accPatient.Name = "accPatient";
            this.accPatient.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accPatient.Text = "Patient ";
            this.accPatient.Click += new System.EventHandler(this.accPatient_Click);
            // 
            // accStudentElement
            // 
            this.accStudentElement.Name = "accStudentElement";
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "Element3";
            // 
            // panelBody
            // 
            this.panelBody.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.panelBody.Appearance.Options.UseBackColor = true;
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(260, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(783, 445);
            this.panelBody.TabIndex = 1;
            // 
            // DashBoard
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 445);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.accordionControl1);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accDmcClinic;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accStudentElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accPatient;
        private DevExpress.XtraEditors.PanelControl panelBody;
    }
}