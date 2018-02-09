using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDB_Export
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string strDatabaseAddr = tbDataBaseAddr.Text;
            string strLibName = tbLibName.Text;
            string strSetName = tbSetName.Text;
            string strSaveDir = tbExportDir.Text;
            string strSaveFileName = tbExportFileName.Text;
            CallExe.RunExe(strDatabaseAddr + " " + strLibName + " " + strSetName + " " +
                                        strSaveDir + strSaveFileName);
        }
    }
}
