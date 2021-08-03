using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace QuickBuild
{
    class Core
    {
        static void StartProcess(String InFileName, String InArg) 
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
    }
}
