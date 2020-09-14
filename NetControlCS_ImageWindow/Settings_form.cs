using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Globalization;
using System.Collections;
using System.Threading;
using System.Windows.Forms;

/*
 * FH.Net Control(6.21), remade from VB to C# by Y.P.
*/

namespace NetControlCS
{
    public partial class Settings_form : Form
    {
        public Settings_form()
        {
            InitializeComponent();
            
            // create an arraylist for the locales 
            ArrayList locales = new ArrayList();
            locales.Add(CultureInfo.GetCultureInfo("ja"));
            locales.Add(CultureInfo.GetCultureInfo("en"));
            
            // bind the arraylist to the combobox 
            this.cmbLanguage.DataSource = locales;


            this.cmbLanguage.DisplayMember = "DisplayName";
            this.cmbLanguage.SelectedIndex = 1;


            this.txtIpAddress1.Enabled = rdoRemote1.Checked;

            this.txtFzPath1.Text = Form1.get_txtFzPath();
            this.txtIpAddress1.Text = Form1.get_txtIpAddress();
            this.nudLineNo1.Value = Form1.get_lineNo();
            if (Form1.get_selectedMode() == 0) {
                this.rdoSimulator1.Checked = true;
            } else {
                this.rdoRemote1.Checked = true;
            };

            this.chkSimOFFON.Enabled = rdoSimulator1.Checked;
        }

        private void btnFolder1_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = fbdCoreRA.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                txtFzPath1.Text = fbdCoreRA.SelectedPath;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = (CultureInfo) this.cmbLanguage.SelectedItem;
        }

        private void rdoRemote1_CheckedChanged(object sender, EventArgs e)
        {
            this.txtIpAddress1.Enabled = rdoRemote1.Checked;
            this.chkSimOFFON.Enabled = rdoSimulator1.Checked;
        }
    }

}
