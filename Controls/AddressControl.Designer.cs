namespace OPEAManager
{
    partial class AddressControl
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
            this.inputAddress1 = new OPEAManager.InputControl();
            this.inputAddress2 = new OPEAManager.InputControl();
            this.inputCity = new OPEAManager.InputControl();
            this.inputState = new OPEAManager.InputControl();
            this.SuspendLayout();
            // 
            // inputAddress1
            // 
            this.inputAddress1.Location = new System.Drawing.Point(4, 3);
            this.inputAddress1.Name = "inputAddress1";
            this.inputAddress1.Size = new System.Drawing.Size(261, 35);
            this.inputAddress1.TabIndex = 0;
            this.inputAddress1.txtValue = "";
            // 
            // inputAddress2
            // 
            this.inputAddress2.Location = new System.Drawing.Point(4, 32);
            this.inputAddress2.Name = "inputAddress2";
            this.inputAddress2.Size = new System.Drawing.Size(261, 35);
            this.inputAddress2.TabIndex = 1;
            this.inputAddress2.txtValue = "";
            // 
            // inputCity
            // 
            this.inputCity.Location = new System.Drawing.Point(4, 70);
            this.inputCity.Name = "inputCity";
            this.inputCity.Size = new System.Drawing.Size(261, 35);
            this.inputCity.TabIndex = 2;
            this.inputCity.txtValue = "";
            // 
            // inputState
            // 
            this.inputState.Location = new System.Drawing.Point(4, 96);
            this.inputState.Name = "inputState";
            this.inputState.Size = new System.Drawing.Size(261, 35);
            this.inputState.TabIndex = 3;
            this.inputState.txtValue = "";
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inputState);
            this.Controls.Add(this.inputCity);
            this.Controls.Add(this.inputAddress2);
            this.Controls.Add(this.inputAddress1);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(265, 137);
            this.ResumeLayout(false);

        }

        #endregion

        private InputControl inputAddress1;
        private InputControl inputAddress2;
        private InputControl inputCity;
        private InputControl inputState;
    }
}
