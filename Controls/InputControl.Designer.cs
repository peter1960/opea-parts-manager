namespace OPEAManager
{
    partial class InputControl
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
            this.txtLabel = new System.Windows.Forms.Label();
            this.textInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLabel
            // 
            this.txtLabel.AutoSize = true;
            this.txtLabel.Location = new System.Drawing.Point(3, 11);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(56, 13);
            this.txtLabel.TabIndex = 0;
            this.txtLabel.Text = "Item Label";
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(76, 8);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(173, 20);
            this.textInput.TabIndex = 1;
            // 
            // InputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.txtLabel);
            this.Name = "InputControl";
            this.Size = new System.Drawing.Size(261, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtLabel;
        private System.Windows.Forms.TextBox textInput;
    }
}
