using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GDMAPSM
{
    class ConnectSharedFolders
    {
        #region 连接共享文件夹
        /// <summary>
        /// 连接共享文件夹
        /// </summary>
        public bool ConnectToSharedFolder(string filename, string Name, string Pwd)
        {
            try
            {
                bool status = false;
                int ljcs = 0;
                do
                {
                    status = connectState(filename, Name, Pwd);
                    ljcs++;
                    if (ljcs >= 20)
                    {
                        break;
                    }
                }
                while (!status);

                if (!status)
                    MessageBox.Show("连接远程电脑" + filename + "失败，请检查名称是否正确");
                return status;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private bool connectState(string path, string userName, string passWord)
        {
            bool Flag = false;
            string dosLine = string.Empty;
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            try
            {
                proc.StartInfo.FileName = "cmd.exe";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardInput = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();
                if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(passWord))
                    dosLine = "net use " + path + " "; // + passWord + " /user:" + userName;
                else
                    dosLine = "net use " + path + " " + passWord + " /user:" + userName;
                proc.StandardInput.WriteLine(dosLine);
                proc.StandardInput.WriteLine("exit");
                while (!proc.HasExited)
                {
                    proc.WaitForExit(1000);
                }
                string errormsg = proc.StandardError.ReadToEnd();
                proc.StandardError.Close();
                if (string.IsNullOrEmpty(errormsg))
                {
                    Flag = true;
                }
                else
                {
                    throw new Exception(errormsg);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                proc.Close();
                proc.Dispose();
            }
            return Flag;
        }
        #endregion
    }
}
