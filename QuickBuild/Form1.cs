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
                String VS_Root = @"C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\Common7\IDE\devenv.com";
                String Project = String.Format(@"{0}\UE4.sln", textBox_workspace.Text);
                Thread t = new Thread(() => StartProcess(VS_Root, string.Format("{0} /build \"Development Editor|Win64\" /Project \"CodaGame\"", Project)));
                t.Start();
                t.Join();
                AddListBox("StartBuld Editor now, please waitting for 15 min...");
            }

            if (checkBox_BuildCookRun.Checked)
            {
                string archivedirectory = String.Format(@"{0}\Archive_Data\{1}", textBox_workspace.Text, comboBox_Platform.Text);
                string RunUAT = String.Format(@"{0}\Engine\Build\BatchFiles\RunUAT.bat", textBox_workspace.Text);
                string uproject = @"-ScriptsForProject=CodaGame/CodaGame.uproject BuildCookRun ";
                string params_part1 = "-nocompileeditor -nop4 -project=CodaGame -cook -stage -CrashReporter -ue4exe=UE4Editor-Cmd.exe -pak -package -compressed -archive";
                string params_part2 = "-prereqs -build -UbtArgs=\"\" -utf8output -compile -unattended -iterate";
                string params_part3 = String.Format("-clientconfig={0} -serverconfig={1} -targetplatform={2} -archivedirectory={3}", comboBox_Config.Text, comboBox_Config.Text, comboBox_Platform.Text, archivedirectory);
                Thread t = new Thread(() => StartProcess(RunUAT, string.Format("{0}{1}{2}{3}", uproject, params_part1, params_part2, params_part3)));
                t.Start();
                t.Join();
                AddListBox("StartBuld BuildCookRun now, please waitting for 30 min...");
            }

            if (checkBox_Backup.Checked)
            {
                String BackupScript = String.Format(@"robocopy {0}\Archive_Data\PS4 \\10.0.1.50\Coda\Shanghai\12.CustomBuild\{1} /MIR /NP /NFL", textBox_workspace.Text, textBox_ShareFolderName.Text);
                Thread t = new Thread(() => StartProcess("cmd.exe", BackupScript));
                t.Start();
                t.Join();
                AddListBox("StartBuld backup now, please waitting for 5 min...");
            }

            if (checkBox_OpenEditor.Checked)
            {
                String EditorAddress = String.Format(@"{0}\Engine\Binaries\Win64\UE4Editor.exe", textBox_workspace.Text);
                Thread t = new Thread(() => StartProcess(EditorAddress, string.Format(@"{0}\CodaGame\CodaGame.uproject", textBox_workspace.Text)));
                t.Start();
                AddListBox("Start open editor now, please waitting for 10 min...");
            }
        }
    }
}
