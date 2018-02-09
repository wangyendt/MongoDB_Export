using System;
using System.Diagnostics;

namespace MongoDB_Export
{
    public static class CallExe
    {

        public static void RunExe(string strDomain)
        {
            string strBatName = "export_mongodb.bat";
            Process p = new Process();
            p.StartInfo.FileName = strBatName;
            string sArguments = strDomain;
            // MessageBox.Show(sArguments);
            p.StartInfo.Arguments = sArguments;
            p.StartInfo.UseShellExecute = true;
//            p.StartInfo.Verb = "runas";
            //p.StartInfo.RedirectStandardOutput = true;
            //p.StartInfo.RedirectStandardInput = true;
            //p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = false;
            p.Start();
            p.CloseMainWindow();
            p.WaitForExit();
            p.Close();
            p.Dispose();
        }
    }
}