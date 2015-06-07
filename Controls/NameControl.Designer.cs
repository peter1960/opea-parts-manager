namespace OPEAManager
{
    partial class NameControl
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
            this.input1 = new OPEAManager.InputControl();
            this.input2 = new OPEAManager.InputControl();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(4, 3);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(261, 35);
            this.input1.TabIndex = 0;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(4, 32);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(261, 35);
            this.input2.TabIndex = 1;
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(265, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private InputControl input1;
        private InputControl input2;
    }
}
