using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

/* 
 * FH .Net Control (6.21), remade from VB to C# by Y.P.
*/

namespace NetControlCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Default path to the FH Simulator folder
        private static string txtFzPath = "C:\\OMRON\\FZ_FH_FJ_Simulator\\631";
        private static string txtIpAddress = "10.5.6.100";
        // selectedMode: 0 - Local, 1 - Remote
        private static int selectedMode = 1;
        private static int lineNo = 0;
        private static int cmbSelectIndex = 0;
        private static bool chkSimOFFON_checked = false;


        public static string get_txtFzPath()
        {
            return txtFzPath;
        }

        public static string get_txtIpAddress()
        {
            return txtIpAddress;
        }

        public static int get_selectedMode()
        {
            return selectedMode;
        }

        public static int get_lineNo()
        {
            return lineNo;
        }

        public static int get_cmbSelectIndex()
        {
            return cmbSelectIndex;
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            this.btn_connect.Enabled = true;
            SaveData(this.coreRA1);
        }

        //SaveData == Set settings + Save data to connect
        private void SaveData(FZ_Control.CoreRA coreRANo)
        {
            if (coreRANo.FzPath != "")
            {
                txtFzPath = coreRANo.FzPath;
                lineNo = coreRANo.LineNo;
                selectedMode = (int) coreRANo.ConnectMode;
                txtIpAddress = coreRANo.IpAddress;
            
             } else {
                txtFzPath = "C:\\OMRON\\FZ_FH_FJ_Simulator\\631";
                lineNo = 0;
                selectedMode = 1;
                txtIpAddress = "10.5.6.100";
            }

            //Creating new form for Settings setup
            Settings_form lineSetting = new Settings_form();
            DialogResult dr = new DialogResult();
            dr = lineSetting.ShowDialog();

            if (dr == DialogResult.OK) {

                cmbSelectIndex = lineSetting.cmbLanguage.SelectedIndex;
                coreRANo.FzPath = lineSetting.txtFzPath1.Text;
                /* because c# Windows paths ... (@_@) */
                coreRANo.FzPath = lineSetting.txtFzPath1.Text.Replace(@"\\", @"\");

                coreRANo.LineNo = (int) lineSetting.nudLineNo1.Value;
                chkSimOFFON_checked = lineSetting.chkSimOFFON.Checked;

                if (lineSetting.rdoRemote1.Checked)
                {
                        coreRANo.ConnectMode = FZ_Control.ConnectionMode.Remote;
                } else {
                        coreRANo.ConnectMode = FZ_Control.ConnectionMode.Local;
                }
                    coreRANo.IpAddress = lineSetting.txtIpAddress1.Text;

             }

             lineSetting.Dispose();

        }

        //Connection to FH after settings were set.
        private bool Connect(FZ_Control.CoreRA coreRANo) {

            string path = Path.Combine(coreRANo.FzPath, "FZ-CoreRA.EXE");
            if (!File.Exists(path)) {
                MessageBox.Show("Can not find FZ-CoreRA.EXE in connection path." + System.Environment.NewLine + "Please check the path.");
                return false;
            }

            FZ_Control.ConnectionState state = coreRANo.ConnectStart();

            switch (state) {
                case FZ_Control.ConnectionState.Success:
                    MessageBox.Show("Excuting connection processing");
                    break;
                case FZ_Control.ConnectionState.InvalidArgumentError:
                    MessageBox.Show("Failed to excute connection processing.");
                    return false;
                case FZ_Control.ConnectionState.DirectoryNotFoundError:
                    MessageBox.Show("The specified path does not exist.");
                    return false;
            }

            if (coreRA1.ConnectMode == FZ_Control.ConnectionMode.Local & !chkSimOFFON_checked) {
                coreRA1.Macro_DirectExecute("MeasureStart");
            }

            return true;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (Connect(this.coreRA1) == false) {
                return;
            }

            //this.btn_settings.Enabled = false;
            this.btn_trigger.Enabled = true;
        }

        private void btn_trigger_Click(object sender, EventArgs e)
        {
            coreRA1.Macro_DirectExecute("Measure");
        }

        private void chkWheelControl0_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkWheelControl0.Checked == true)
            {
                imageWindow1.WheelZoomEnabled = true;
            }
            else
            {
                imageWindow1.WheelZoomEnabled = false;
            }
        }
    }
}
