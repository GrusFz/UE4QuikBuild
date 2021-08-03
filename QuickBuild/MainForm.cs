using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;

namespace QuickBuild
{
    public partial class QuickBuild : Form
    {
        public QuickBuild()
        {
            InitializeComponent();
        }

        void AddListBox(string str)
        {
            if (listBox1.InvokeRequired)
            {
                Action<string> actionDelegate = (x) => { this.listBox1.Items.Add(str); };
                this.listBox1.Invoke(actionDelegate, str);
            }
            else
            {
                this.listBox1.Items.Add(str);
            }

        }

        public void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (outLine.Data == null)
                return;
            AddListBox(outLine.Data);
        }

        public void StartProcess(String InFileName,String InArg)
        {
            Process p = new Process();
            p.StartInfo.WorkingDirectory = @"C:\";
            p.StartInfo.FileName = InFileName;
            p.StartInfo.Arguments = InArg;
            p.StartInfo.UseShellExecute = false;
            //p.StartInfo.RedirectStandardInput = true;
            //p.StartInfo.RedirectStandardOutput = false;
            ////p.StartInfo.RedirectStandardError = true;
            //p.StartInfo.CreateNoWindow = true;
            p.Start();
            //p.StandardInput.AutoFlush = true;
            //p.StandardInput.WriteLine("exit");
            //p.BeginOutputReadLine();
            //p.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            p.WaitForExit();
        }
        private void IterateBuild_Click(object sender, EventArgs e)
        {
            if (checkBox_BuildEditor.Checked)
            {
                string engineDir = textBox_EngineDir.Text;
                string projectDir = textBox_ProjectDir.Text;
                string projectName = System.IO.Path.GetFileNameWithoutExtension(projectDir);
                string RunUBT = string.Format(@"{0}\Build\BatchFiles\Build.bat", engineDir);
                string configuration = comboBox_Config.Text;
                string UBT_Param = "";
                UBT_Param += string.Format("-Target=\"{0}Editor Win64 {1} -Project=\\\"{2}\\\"\" ", projectName, configuration, projectDir);
                UBT_Param += "-Target=\"ShaderCompileWorker Win64 Development -Quiet\" ";
                UBT_Param += "-WaitMutex ";
                UBT_Param += "-FromMsBuild ";
                AddListBox(string.Format("{0} {1}", RunUBT, UBT_Param));
                Thread t = new Thread(() => StartProcess(RunUBT, UBT_Param));
                t.Start();
                t.Join();
                AddListBox("StartBuld Editor now, please waitting for 15 min...");
            }

            if (checkBox_BuildCookRun.Checked)
            {
                string engineDir = textBox_EngineDir.Text;
                string projectDir = textBox_ProjectDir.Text;
                string archivedDir = textBox_ArchivedDir.Text;
                string platform = comboBox_Platform.Text;
                string configuration = comboBox_Config.Text;
                string RunUAT = string.Format(@"{0}\Build\BatchFiles\RunUAT.bat", engineDir);
                string UAT_Param = "";
                UAT_Param += string.Format(@"-ScriptsForProject={0} BuildCookRun ", projectDir);
                UAT_Param += "-nocompileeditor ";
                UAT_Param += "-nop4 ";
                UAT_Param += string.Format(@"-project={0} ",projectDir);
                UAT_Param += "-cook ";
                UAT_Param += "-stage ";
                UAT_Param += "-CrashReporter ";
                UAT_Param += string.Format(@"-ue4exe={0}\Binaries\Win64\UE4Editor-Cmd.exe ", engineDir);
                UAT_Param += "-pak ";
                UAT_Param += "-package ";
                UAT_Param += "-compressed ";
                UAT_Param += "-archive ";
                UAT_Param += "-prereqs ";
                UAT_Param += "-build ";
                UAT_Param += "-UbtArgs= ";
                UAT_Param += "-utf8output ";
                UAT_Param += "-compile ";
                UAT_Param += "-unattended ";
                UAT_Param += "-iterate ";
                UAT_Param += string.Format(@"-clientconfig={0} ", configuration);
                UAT_Param += string.Format(@"-serverconfig={0} ", configuration);
                UAT_Param += string.Format(@"-targetplatform={0} ", platform);
                UAT_Param += string.Format(@"-archivedirectory={0} ", archivedDir);
                UAT_Param += "-compile ";
                AddListBox(string.Format("{0} {1}", RunUAT, UAT_Param));
                Thread t = new Thread(() => StartProcess(RunUAT, UAT_Param));
                t.Start();
                t.Join();
                AddListBox("StartBuld BuildCookRun now, please waitting for 30 min...");
            }

            if (checkBox_Backup.Checked)
            {
                String BackupScript = String.Format(@"robocopy {0}\Archive_Data\PS4 \\10.0.1.50\Coda\Shanghai\12.CustomBuild\{1} /MIR /NP /NFL", textBox_EngineDir.Text, textBox_ShareFolderName.Text);
                Thread t = new Thread(() => StartProcess("cmd.exe", BackupScript));
                t.Start();
                t.Join();
                AddListBox("StartBuld backup now, please waitting for 5 min...");
            }

            if (checkBox_OpenEditor.Checked)
            {
                String EditorAddress = String.Format(@"{0}\Engine\Binaries\Win64\UE4Editor.exe", textBox_EngineDir.Text);
                Thread t = new Thread(() => StartProcess(EditorAddress, string.Format(@"{0}\CodaGame\CodaGame.uproject", textBox_EngineDir.Text)));
                t.Start();
                AddListBox("Start open editor now, please waitting for 10 min...");
            }
        }
        private void listBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == 3) //Crtl+C
            {
                Clipboard.SetDataObject(listBox1.SelectedItem.ToString().Trim());
            }
        }
    }
}
