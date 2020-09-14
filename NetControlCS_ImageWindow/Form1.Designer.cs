namespace NetControlCS
{
    partial class Form1
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
            this.coreRA1 = new FZ_Control.CoreRA();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.imageWindow1 = new FZ_Control.ImageWindow();
            this.btn_trigger = new System.Windows.Forms.Button();
            this.chkWheelControl0 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // coreRA1
            // 
            this.coreRA1.ConnectMode = FZ_Control.ConnectionMode.Remote;
            this.coreRA1.ContainerControl = this;
            // 
            // btn_settings
            // 
            this.btn_settings.Location = new System.Drawing.Point(25, 43);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(132, 37);
            this.btn_settings.TabIndex = 0;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Enabled = false;
            this.btn_connect.Location = new System.Drawing.Point(25, 123);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(132, 42);
            this.btn_connect.TabIndex = 1;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // imageWindow1
            // 
            this.imageWindow1.BackColor = System.Drawing.SystemColors.Control;
            this.imageWindow1.ConnectCoreRAComponent = this.coreRA1;
            this.imageWindow1.Location = new System.Drawing.Point(231, 43);
            this.imageWindow1.Name = "imageWindow1";
            this.imageWindow1.Size = new System.Drawing.Size(243, 202);
            this.imageWindow1.TabIndex = 2;
            // 
            // btn_trigger
            // 
            this.btn_trigger.Enabled = false;
            this.btn_trigger.Location = new System.Drawing.Point(25, 211);
            this.btn_trigger.Name = "btn_trigger";
            this.btn_trigger.Size = new System.Drawing.Size(132, 34);
            this.btn_trigger.TabIndex = 3;
            this.btn_trigger.Text = "Trigger";
            this.btn_trigger.UseVisualStyleBackColor = true;
            this.btn_trigger.Click += new System.EventHandler(this.btn_trigger_Click);
            // 
            // chkWheelControl0
            // 
            this.chkWheelControl0.AutoSize = true;
            this.chkWheelControl0.Location = new System.Drawing.Point(290, 251);
            this.chkWheelControl0.Name = "chkWheelControl0";
            this.chkWheelControl0.Size = new System.Drawing.Size(129, 17);
            this.chkWheelControl0.TabIndex = 4;
            this.chkWheelControl0.Text = "Enable Wheel Control";
            this.chkWheelControl0.UseVisualStyleBackColor = true;
            this.chkWheelControl0.CheckedChanged += new System.EventHandler(this.chkWheelControl0_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.chkWheelControl0);
            this.Controls.Add(this.btn_trigger);
            this.Controls.Add(this.imageWindow1);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_settings);
            this.Name = "Form1";
            this.Text = "Form FH Connect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FZ_Control.CoreRA coreRA1;
        private System.Windows.Forms.Button btn_trigger;
        private FZ_Control.ImageWindow imageWindow1;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_settings;
        internal System.Windows.Forms.CheckBox chkWheelControl0;
    }
}

