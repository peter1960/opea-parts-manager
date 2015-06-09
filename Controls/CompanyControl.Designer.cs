namespace OPEAManager.Controls
{
    partial class CompanyControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.inputURL = new OPEAManager.InputControl();
            this.nameControl1 = new OPEAManager.NameControl();
            this.addressControl1 = new OPEAManager.AddressControl();
            this.phoneControl1 = new OPEAManager.PhoneControl();
            this.SuspendLayout();
            // 
            // inputURL
            // 
            this.inputURL.Location = new System.Drawing.Point(7, 251);
            this.inputURL.Name = "inputURL";
            this.inputURL.Size = new System.Drawing.Size(272, 35);
            this.inputURL.TabIndex = 2;
            this.inputURL.txtValue = "";
            // 
            // nameControl1
            // 
            this.nameControl1.Location = new System.Drawing.Point(3, 3);
            this.nameControl1.Name = "nameControl1";
            this.nameControl1.Name1 = "";
            this.nameControl1.Name2 = "";
            this.nameControl1.Size = new System.Drawing.Size(279, 68);
            this.nameControl1.TabIndex = 1;
            // 
            // addressControl1
            // 
            this.addressControl1.Add1 = "";
            this.addressControl1.Add2 = "";
            this.addressControl1.City = "";
            this.addressControl1.Location = new System.Drawing.Point(3, 120);
            this.addressControl1.Name = "addressControl1";
            this.addressControl1.Size = new System.Drawing.Size(265, 137);
            this.addressControl1.State = "";
            this.addressControl1.TabIndex = 0;
            // 
            // phoneControl1
            // 
            this.phoneControl1.Location = new System.Drawing.Point(3, 62);
            this.phoneControl1.Name = "phoneControl1";
            this.phoneControl1.Phone1 = "";
            this.phoneControl1.Phone2 = "";
            this.phoneControl1.Size = new System.Drawing.Size(265, 70);
            this.phoneControl1.TabIndex = 3;
            // 
            // CompanyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.phoneControl1);
            this.Controls.Add(this.inputURL);
            this.Controls.Add(this.nameControl1);
            this.Controls.Add(this.addressControl1);
            this.Name = "CompanyControl";
            this.Size = new System.Drawing.Size(282, 298);
            this.ResumeLayout(false);

        }

        #endregion

        private AddressControl addressControl1;
        private NameControl nameControl1;
        private InputControl inputURL;
        private PhoneControl phoneControl1;
    }
}
