namespace OPEAManager
{
    partial class FormOPEA
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textPartNo = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textList = new System.Windows.Forms.TextBox();
            this.textRetail = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(611, 27);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(611, 56);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textPartNo
            // 
            this.textPartNo.Location = new System.Drawing.Point(24, 27);
            this.textPartNo.Name = "textPartNo";
            this.textPartNo.Size = new System.Drawing.Size(100, 20);
            this.textPartNo.TabIndex = 2;
            this.textPartNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(130, 27);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(421, 20);
            this.textDescription.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textRetail);
            this.groupBox1.Controls.Add(this.textList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 82);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pricing";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Retail";
            // 
            // textList
            // 
            this.textList.Location = new System.Drawing.Point(68, 23);
            this.textList.Name = "textList";
            this.textList.Size = new System.Drawing.Size(100, 20);
            this.textList.TabIndex = 2;
            this.textList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textRetail
            // 
            this.textRetail.Location = new System.Drawing.Point(68, 49);
            this.textRetail.Name = "textRetail";
            this.textRetail.Size = new System.Drawing.Size(100, 20);
            this.textRetail.TabIndex = 3;
            this.textRetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormOPEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 464);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textPartNo);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOPEA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OPEAForm";
            this.Load += new System.EventHandler(this.FormOPEA_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textPartNo;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textRetail;
        private System.Windows.Forms.TextBox textList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}