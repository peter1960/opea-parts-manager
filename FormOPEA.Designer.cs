﻿namespace OPEAManager
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
            this.textRetail = new System.Windows.Forms.TextBox();
            this.textList = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboSupplier = new System.Windows.Forms.ComboBox();
            this.comboFranchise = new System.Windows.Forms.ComboBox();
            this.radioButtonSupplier = new System.Windows.Forms.RadioButton();
            this.radioButtonFranchise = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxSuperbyDescription = new System.Windows.Forms.TextBox();
            this.textBoxSuperceedsDescription = new System.Windows.Forms.TextBox();
            this.textBoxSuperbyPart = new System.Windows.Forms.TextBox();
            this.textBoxSuperceedsPart = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCreated = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxUpdated = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(600, 24);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(600, 56);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textPartNo
            // 
            this.textPartNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textPartNo.Location = new System.Drawing.Point(24, 27);
            this.textPartNo.Name = "textPartNo";
            this.textPartNo.Size = new System.Drawing.Size(100, 20);
            this.textPartNo.TabIndex = 0;
            this.textPartNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textDescription
            // 
            this.textDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textDescription.Location = new System.Drawing.Point(130, 27);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(421, 20);
            this.textDescription.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textRetail);
            this.groupBox1.Controls.Add(this.textList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(351, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 82);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pricing";
            // 
            // textRetail
            // 
            this.textRetail.Location = new System.Drawing.Point(68, 49);
            this.textRetail.Name = "textRetail";
            this.textRetail.Size = new System.Drawing.Size(100, 20);
            this.textRetail.TabIndex = 3;
            this.textRetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textList
            // 
            this.textList.Location = new System.Drawing.Point(68, 23);
            this.textList.Name = "textList";
            this.textList.Size = new System.Drawing.Size(100, 20);
            this.textList.TabIndex = 2;
            this.textList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Part";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboSupplier);
            this.groupBox2.Controls.Add(this.comboFranchise);
            this.groupBox2.Controls.Add(this.radioButtonSupplier);
            this.groupBox2.Controls.Add(this.radioButtonFranchise);
            this.groupBox2.Location = new System.Drawing.Point(24, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 73);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Part Origin";
            // 
            // comboSupplier
            // 
            this.comboSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSupplier.FormattingEnabled = true;
            this.comboSupplier.Location = new System.Drawing.Point(106, 42);
            this.comboSupplier.Name = "comboSupplier";
            this.comboSupplier.Size = new System.Drawing.Size(174, 21);
            this.comboSupplier.TabIndex = 3;
            // 
            // comboFranchise
            // 
            this.comboFranchise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFranchise.FormattingEnabled = true;
            this.comboFranchise.Location = new System.Drawing.Point(106, 15);
            this.comboFranchise.Name = "comboFranchise";
            this.comboFranchise.Size = new System.Drawing.Size(174, 21);
            this.comboFranchise.TabIndex = 2;
            // 
            // radioButtonSupplier
            // 
            this.radioButtonSupplier.AutoSize = true;
            this.radioButtonSupplier.Location = new System.Drawing.Point(9, 42);
            this.radioButtonSupplier.Name = "radioButtonSupplier";
            this.radioButtonSupplier.Size = new System.Drawing.Size(63, 17);
            this.radioButtonSupplier.TabIndex = 1;
            this.radioButtonSupplier.TabStop = true;
            this.radioButtonSupplier.Text = "Supplier";
            this.radioButtonSupplier.UseVisualStyleBackColor = true;
            // 
            // radioButtonFranchise
            // 
            this.radioButtonFranchise.AutoSize = true;
            this.radioButtonFranchise.Location = new System.Drawing.Point(9, 19);
            this.radioButtonFranchise.Name = "radioButtonFranchise";
            this.radioButtonFranchise.Size = new System.Drawing.Size(71, 17);
            this.radioButtonFranchise.TabIndex = 0;
            this.radioButtonFranchise.TabStop = true;
            this.radioButtonFranchise.Text = "Franchise";
            this.radioButtonFranchise.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxSuperbyDescription);
            this.groupBox3.Controls.Add(this.textBoxSuperceedsDescription);
            this.groupBox3.Controls.Add(this.textBoxSuperbyPart);
            this.groupBox3.Controls.Add(this.textBoxSuperceedsPart);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(24, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(651, 89);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alternatives";
            // 
            // textBoxSuperbyDescription
            // 
            this.textBoxSuperbyDescription.Location = new System.Drawing.Point(212, 54);
            this.textBoxSuperbyDescription.Name = "textBoxSuperbyDescription";
            this.textBoxSuperbyDescription.Size = new System.Drawing.Size(421, 20);
            this.textBoxSuperbyDescription.TabIndex = 7;
            // 
            // textBoxSuperceedsDescription
            // 
            this.textBoxSuperceedsDescription.Location = new System.Drawing.Point(212, 20);
            this.textBoxSuperceedsDescription.Name = "textBoxSuperceedsDescription";
            this.textBoxSuperceedsDescription.Size = new System.Drawing.Size(421, 20);
            this.textBoxSuperceedsDescription.TabIndex = 5;
            // 
            // textBoxSuperbyPart
            // 
            this.textBoxSuperbyPart.Location = new System.Drawing.Point(106, 54);
            this.textBoxSuperbyPart.Name = "textBoxSuperbyPart";
            this.textBoxSuperbyPart.Size = new System.Drawing.Size(100, 20);
            this.textBoxSuperbyPart.TabIndex = 6;
            this.textBoxSuperbyPart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxSuperceedsPart
            // 
            this.textBoxSuperceedsPart.Location = new System.Drawing.Point(106, 19);
            this.textBoxSuperceedsPart.Name = "textBoxSuperceedsPart";
            this.textBoxSuperceedsPart.Size = new System.Drawing.Size(100, 20);
            this.textBoxSuperceedsPart.TabIndex = 4;
            this.textBoxSuperceedsPart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Superceeded By";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Superceeds";
            // 
            // textBoxCreated
            // 
            this.textBoxCreated.Enabled = false;
            this.textBoxCreated.Location = new System.Drawing.Point(71, 239);
            this.textBoxCreated.Name = "textBoxCreated";
            this.textBoxCreated.Size = new System.Drawing.Size(125, 20);
            this.textBoxCreated.TabIndex = 9;
            this.textBoxCreated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Created";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Modified";
            // 
            // textBoxUpdated
            // 
            this.textBoxUpdated.Enabled = false;
            this.textBoxUpdated.Location = new System.Drawing.Point(71, 262);
            this.textBoxUpdated.Name = "textBoxUpdated";
            this.textBoxUpdated.Size = new System.Drawing.Size(125, 20);
            this.textBoxUpdated.TabIndex = 11;
            this.textBoxUpdated.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormOPEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 301);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxUpdated);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCreated);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textPartNo);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOPEA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OPEAForm";
            this.Load += new System.EventHandler(this.FormOPEA_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormOPEA_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonSupplier;
        private System.Windows.Forms.RadioButton radioButtonFranchise;
        private System.Windows.Forms.ComboBox comboSupplier;
        private System.Windows.Forms.ComboBox comboFranchise;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxSuperbyDescription;
        private System.Windows.Forms.TextBox textBoxSuperceedsDescription;
        private System.Windows.Forms.TextBox textBoxSuperbyPart;
        private System.Windows.Forms.TextBox textBoxSuperceedsPart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCreated;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxUpdated;
    }
}