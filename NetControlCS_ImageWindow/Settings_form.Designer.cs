namespace NetControlCS
{
    partial class Settings_form
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
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.txtFzPath1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnFolder1 = new System.Windows.Forms.Button();
            this.grpSetting1 = new System.Windows.Forms.GroupBox();
            this.chkSimOFFON = new System.Windows.Forms.CheckBox();
            this.nudLineNo1 = new System.Windows.Forms.NumericUpDown();
            this.txtIpAddress1 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.rdoRemote1 = new System.Windows.Forms.RadioButton();
            this.rdoSimulator1 = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.fbdCoreRA = new System.Windows.Forms.FolderBrowserDialog();
            this.grpSetting1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLineNo1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(77, 36);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(164, 21);
            this.cmbLanguage.TabIndex = 32;
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(12, 39);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(61, 13);
            this.lblLanguage.TabIndex = 31;
            this.lblLanguage.Text = "Language :";
            // 
            // txtFzPath1
            // 
            this.txtFzPath1.Location = new System.Drawing.Point(77, 71);
            this.txtFzPath1.Name = "txtFzPath1";
            this.txtFzPath1.Size = new System.Drawing.Size(318, 20);
            this.txtFzPath1.TabIndex = 34;
            this.txtFzPath1.Text = "C:\\OMRON\\FZ_FH_FJ_Simulator\\631";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 76);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 13);
            this.Label1.TabIndex = 33;
            this.Label1.Text = "FZ Path:";
            // 
            // btnFolder1
            // 
            this.btnFolder1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFolder1.Font = new System.Drawing.Font("MS UI Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnFolder1.Location = new System.Drawing.Point(401, 71);
            this.btnFolder1.Name = "btnFolder1";
            this.btnFolder1.Size = new System.Drawing.Size(23, 20);
            this.btnFolder1.TabIndex = 35;
            this.btnFolder1.Text = "...";
            this.btnFolder1.UseVisualStyleBackColor = true;
            this.btnFolder1.Click += new System.EventHandler(this.btnFolder1_Click);
            // 
            // grpSetting1
            // 
            this.grpSetting1.Controls.Add(this.chkSimOFFON);
            this.grpSetting1.Controls.Add(this.nudLineNo1);
            this.grpSetting1.Controls.Add(this.txtIpAddress1);
            this.grpSetting1.Controls.Add(this.Label3);
            this.grpSetting1.Controls.Add(this.Label2);
            this.grpSetting1.Controls.Add(this.rdoRemote1);
            this.grpSetting1.Controls.Add(this.rdoSimulator1);
            this.grpSetting1.Location = new System.Drawing.Point(15, 121);
            this.grpSetting1.Name = "grpSetting1";
            this.grpSetting1.Size = new System.Drawing.Size(269, 106);
            this.grpSetting1.TabIndex = 36;
            this.grpSetting1.TabStop = false;
            this.grpSetting1.Text = "Connection Mode";
            // 
            // chkSimOFFON
            // 
            this.chkSimOFFON.AutoSize = true;
            this.chkSimOFFON.Location = new System.Drawing.Point(83, 20);
            this.chkSimOFFON.Name = "chkSimOFFON";
            this.chkSimOFFON.Size = new System.Drawing.Size(111, 17);
            this.chkSimOFFON.TabIndex = 14;
            this.chkSimOFFON.Text = "Simulator is runing";
            this.chkSimOFFON.UseVisualStyleBackColor = true;
            // 
            // nudLineNo1
            // 
            this.nudLineNo1.Location = new System.Drawing.Point(66, 74);
            this.nudLineNo1.Name = "nudLineNo1";
            this.nudLineNo1.Size = new System.Drawing.Size(30, 20);
            this.nudLineNo1.TabIndex = 12;
            // 
            // txtIpAddress1
            // 
            this.txtIpAddress1.Location = new System.Drawing.Point(127, 42);
            this.txtIpAddress1.Name = "txtIpAddress1";
            this.txtIpAddress1.Size = new System.Drawing.Size(136, 20);
            this.txtIpAddress1.TabIndex = 11;
            this.txtIpAddress1.Text = "10.5.6.100";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(6, 76);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(47, 13);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Line No:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(66, 46);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(61, 13);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "IP Address:";
            // 
            // rdoRemote1
            // 
            this.rdoRemote1.AutoSize = true;
            this.rdoRemote1.Checked = true;
            this.rdoRemote1.Location = new System.Drawing.Point(6, 43);
            this.rdoRemote1.Name = "rdoRemote1";
            this.rdoRemote1.Size = new System.Drawing.Size(62, 17);
            this.rdoRemote1.TabIndex = 8;
            this.rdoRemote1.TabStop = true;
            this.rdoRemote1.Text = "Remote";
            this.rdoRemote1.UseVisualStyleBackColor = true;
            this.rdoRemote1.CheckedChanged += new System.EventHandler(this.rdoRemote1_CheckedChanged);
            // 
            // rdoSimulator1
            // 
            this.rdoSimulator1.AutoSize = true;
            this.rdoSimulator1.Location = new System.Drawing.Point(6, 20);
            this.rdoSimulator1.Name = "rdoSimulator1";
            this.rdoSimulator1.Size = new System.Drawing.Size(68, 17);
            this.rdoSimulator1.TabIndex = 7;
            this.rdoSimulator1.Text = "Simulator";
            this.rdoSimulator1.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Font = new System.Drawing.Font("MS UI Gothic", 8.25F);
            this.btnCancel.Location = new System.Drawing.Point(310, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 28);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOK.Font = new System.Drawing.Font("MS UI Gothic", 8.25F);
            this.btnOK.Location = new System.Drawing.Point(142, 274);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 28);
            this.btnOK.TabIndex = 37;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Settings_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpSetting1);
            this.Controls.Add(this.btnFolder1);
            this.Controls.Add(this.txtFzPath1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.lblLanguage);
            this.Name = "Settings_form";
            this.Text = "Settings";
            this.grpSetting1.ResumeLayout(false);
            this.grpSetting1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLineNo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cmbLanguage;
        internal System.Windows.Forms.Label lblLanguage;
        internal System.Windows.Forms.TextBox txtFzPath1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnFolder1;
        internal System.Windows.Forms.GroupBox grpSetting1;
        internal System.Windows.Forms.CheckBox chkSimOFFON;
        internal System.Windows.Forms.NumericUpDown nudLineNo1;
        internal System.Windows.Forms.TextBox txtIpAddress1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.RadioButton rdoRemote1;
        internal System.Windows.Forms.RadioButton rdoSimulator1;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.FolderBrowserDialog fbdCoreRA;
    }
}