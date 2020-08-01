using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;

namespace iSMET
{
    public class Compiler
    {
		public bool isCreated = false;
		public string nameSpace = string.Empty;
		private static List<string> _netFrameworkList = new List<string>();
		private static List<string> _x64NetFrameworkList = new List<string>();
		private const string AsmInfo = "using System.Reflection; using System.Threading; using System.Runtime.CompilerServices; using System.Runtime.InteropServices; [assembly: AssemblyTitle(\"iSMET Meterpreter Builder\")] [assembly: AssemblyDescription(\"iSMET Meterpreter Builder\")] [assembly: AssemblyConfiguration(\"\")] [assembly: AssemblyCompany(\"@mindspoof\")] [assembly: AssemblyProduct(\"http://eyupcelik.com.tr\")] [assembly: AssemblyCopyright(\"Copyright ©  2017 @mindspoof\")] [assembly: AssemblyTrademark(\"\")] [assembly: AssemblyCulture(\"\")] [assembly: ComVisible(false)] [assembly: Guid(\"7bfe290e-8784-4277-8de9-eb4a6bcf83cc\")] [assembly: AssemblyVersion(\"1.0.0.0\")] [assembly: AssemblyFileVersion(\"1.0.0.0\")]";
		public void Console(string random, string fileName, string buildCode, string arch)
		{
			DeleteCsFileInDirectory();
			var strText1 = $"{Directory.GetCurrentDirectory()}\\{random}.cs";
			var strText2 = $"{Directory.GetCurrentDirectory()}\\{random}{fileName}";
			var arguments = string.Empty;
			if (arch == Architecture.x86.ToString())
			{
				NetFrameWorkDirectory();
				var text3 = _netFrameworkList[_netFrameworkList.Count - 1];
				arguments = string.Concat(new string[]
				{
					" /c C:\\Windows\\Microsoft.NET\\Framework\\",
					text3,
					"\\csc.exe /unsafe /platform:",
					arch,
					" /out:\"",
					strText2,
					"\" \"",
					strText1,
					"\" \"" + Directory.GetCurrentDirectory() + "\\AssemblyInfo.cs\""
				});
			}
			else if(arch == Architecture.x64.ToString())
			{
				X64NetFrameWorkDirectory();
				var text4 = _x64NetFrameworkList[_x64NetFrameworkList.Count - 1];
				arguments = string.Concat(new string[]
				{
					" /c C:\\Windows\\Microsoft.NET\\Framework\\",
					text4,
					"\\csc.exe /unsafe /platform:",
					arch,
					" /out:\"",
					strText2,
					"\" \"",
					strText1,
					"\" \"" + Directory.GetCurrentDirectory() + "\\AssemblyInfo.cs\""
				});
			}
			File.WriteAllText($"{Directory.GetCurrentDirectory()}\\AssemblyInfo.cs", AsmInfo);
			File.WriteAllText(strText1, buildCode);
			BuildRunMeterpreter("C:\\Windows\\System32\\cmd.exe", arguments);
			DeleteCsFileInDirectory();
			GetCreatedFile(strText2);
		}
		public void Form(string random, string fileName, string buildCode, string arch)
		{
			var contents = string.Empty;
			var contents2 = string.Empty;
			if (!string.IsNullOrEmpty(nameSpace))
			{
				contents2 = "using System; using System.Collections.Generic; using System.Linq; using System.Windows.Forms; using System.Threading; namespace " + nameSpace + " { static class Program { [STAThread] static void Main() { Application.EnableVisualStyles(); Application.SetCompatibleTextRenderingDefault(false); Application.Run(new Form1()); } } }";
			}
			else
			{
				contents2 = "using System; using System.Collections.Generic; using System.Linq; using System.Windows.Forms; using System.Threading; namespace MeterpreterForm { static class Program { [STAThread] static void Main() { Application.EnableVisualStyles(); Application.SetCompatibleTextRenderingDefault(false); Application.Run(new Form1()); } } }";
			}
			if (!string.IsNullOrEmpty(nameSpace))
			{
				contents = "namespace " + nameSpace + " { partial class Form1 { private System.ComponentModel.IContainer components = null; protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); } private void InitializeComponent() { this.SuspendLayout(); this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; this.ClientSize = new System.Drawing.Size(465, 372); this.Name = \"Form1\"; this.ShowInTaskbar = false; this.Text = \"Form1\"; this.WindowState = System.Windows.Forms.FormWindowState.Minimized; this.Load += new System.EventHandler(this.Form1_Load); this.ResumeLayout(false); } } }";
			}
			else
			{
				contents = "namespace MeterpreterForm { partial class Form1 { private System.ComponentModel.IContainer components = null; protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); } private void InitializeComponent() { this.SuspendLayout(); this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; this.ClientSize = new System.Drawing.Size(465, 372); this.Name = \"Form1\"; this.ShowInTaskbar = false; this.Text = \"Form1\"; this.WindowState = System.Windows.Forms.FormWindowState.Minimized; this.Load += new System.EventHandler(this.Form1_Load); this.ResumeLayout(false); } } }";
			}
			DeleteCsFileInDirectory();
			var path = $"{Directory.GetCurrentDirectory()}\\Form1.cs";
            var path2 = $"{Directory.GetCurrentDirectory()}\\Form1.Designer.cs";
            var path3 = $"{Directory.GetCurrentDirectory()}\\Program.cs";
            var text = $"{Directory.GetCurrentDirectory()}\\{random}{fileName}";
            var arguments = string.Empty;
			if (arch == Architecture.x86.ToString())
			{
				NetFrameWorkDirectory();
                var text2 = _netFrameworkList[_netFrameworkList.Count - 1];
				arguments = string.Concat(new string[]
				{
					" /c C:\\Windows\\Microsoft.NET\\Framework\\",
					text2,
					"\\csc.exe /target:winexe /platform:",
					arch,
					" /out:\"",
					text,
					"\" \"",
					Directory.GetCurrentDirectory(),
					"\\*.cs\" \"",
					Directory.GetCurrentDirectory(),
					"\\AssemblyInfo.cs\""
				});
			}
			else if (arch == Architecture.x64.ToString())
			{
				X64NetFrameWorkDirectory();
                var text3 = _x64NetFrameworkList[_x64NetFrameworkList.Count - 1];
				arguments = string.Concat(new string[]
				{
					" /c C:\\Windows\\Microsoft.NET\\Framework\\",
					text3,
					"\\csc.exe /target:winexe /platform:",
					arch,
					" /out:\"",
					text,
					"\" \"",
					Directory.GetCurrentDirectory(),
					"\\*.cs\" \"",
					Directory.GetCurrentDirectory(),
					"\\AssemblyInfo.cs\""
				});
			}
			File.WriteAllText($"{Directory.GetCurrentDirectory()}\\AssemblyInfo.cs", AsmInfo);
			File.WriteAllText(path, buildCode);
			File.WriteAllText(path2, contents);
			File.WriteAllText(path3, contents2);
			BuildRunMeterpreter("C:\\Windows\\System32\\cmd.exe", arguments);
			DeleteCsFileInDirectory();
			GetCreatedFile(text);
		}
		public void PowerShell(string random, string fileName, string buildCode)
		{
			DeletePsFileInDirectory();
            var text = $"{Directory.GetCurrentDirectory()}\\{random}.ps1";
			File.WriteAllText(text, buildCode);
			GetCreatedFile(text);
		}
		private static void BuildRunMeterpreter(string filename, string arguments)
		{
            var process = new Process {StartInfo = {FileName = filename}};
            if (!string.IsNullOrEmpty(arguments))
			{
				process.StartInfo.Arguments = arguments;
			}
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.RedirectStandardOutput = true;
			var stdOutput = new StringBuilder();
			process.OutputDataReceived += delegate (object sender, DataReceivedEventArgs args)
			{
				stdOutput.AppendLine(args.Data);
			};
			string value = null;
			try
			{
				process.Start();
				process.BeginOutputReadLine();
				value = process.StandardError.ReadToEnd();
				process.WaitForExit();
			}
			catch (Exception)
			{

			}
			bool flag2 = process.ExitCode == 0;
			if (!flag2)
			{
				var stringBuilder = new StringBuilder();
				if (!string.IsNullOrEmpty(value))
				{
					stringBuilder.AppendLine(value);
				}
				if (stdOutput.Length != 0)
				{
					stringBuilder.AppendLine("Std output:");
					stringBuilder.AppendLine(stdOutput.ToString());
				}
			}
		}
		private static void NetFrameWorkDirectory()
		{
			_netFrameworkList.Clear();
			const string path = "C:\\Windows\\Microsoft.NET\\Framework";
			var directories = Directory.GetDirectories(path);
			foreach (var t in directories)
            {
                var array = t.Split(new char[]
                {
                    '\\'
                });
                if (array[array.Length - 1].StartsWith("v"))
                {
                    if (array[array.Length - 1].StartsWith("VJ"))
                    {
                        break;
                    }
                    _netFrameworkList.Add(array[array.Length - 1]);
                }
            }
		}
		private static void X64NetFrameWorkDirectory()
		{
			_x64NetFrameworkList.Clear();
			const string path = "C:\\Windows\\Microsoft.NET\\Framework64";
			var directories = Directory.GetDirectories(path);
			foreach (var t in directories)
            {
                var array = t.Split(new char[]
                {
                    '\\'
                });
                if (array[array.Length - 1].StartsWith("v"))
                {
                    if (array[array.Length - 1].StartsWith("VJ"))
                    {
                        break;
                    }
                    _x64NetFrameworkList.Add(array[array.Length - 1]);
                }
            }
		}
		private static void DeleteCsFileInDirectory()
		{
			try
			{
				var directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory());
				var files = directoryInfo.GetFiles("*.cs");
				var array = files;
				for (var i = 0; i < array.Length; i++)
				{
					FileInfo fileInfo = array[i];
					File.Delete($"{Directory.GetCurrentDirectory()}\\{fileInfo.Name}");
				}
				var files2 = directoryInfo.GetFiles("*.csproj");
				var array2 = files2;
				for (var j = 0; j < array2.Length; j++)
				{
					FileInfo fileInfo2 = array2[j];
					File.Delete($"{Directory.GetCurrentDirectory()}\\{fileInfo2.Name}");
				}
				var files3 = directoryInfo.GetFiles("*.json");
				var array3 = files3;
				for (var k = 0; k < array3.Length; k++)
				{
					FileInfo fileInfo3 = array3[k];
					File.Delete($"{Directory.GetCurrentDirectory()}\\{fileInfo3.Name}");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}", @"iSMET Error!", MessageBoxButton.OK, MessageBoxImage.Hand);
			}
		}
		private static void DeletePsFileInDirectory()
		{
			try
			{
				var directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory());
				var files = directoryInfo.GetFiles("*.ps1");
				var array = files;
				for (int i = 0; i < array.Length; i++)
				{
					FileInfo fileInfo = array[i];
					File.Delete($"{Directory.GetCurrentDirectory()}\\{fileInfo.Name}");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}", "iSMET Error!", MessageBoxButton.OK, MessageBoxImage.Hand);
			}
		}
		private void GetCreatedFile(string directory)
		{
			try
			{
				if (File.Exists(directory))
				{
					isCreated = true;
				}
				else
				{
					isCreated = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}", $"iSMET Error!", MessageBoxButton.OK, MessageBoxImage.Hand);
			}
		}
	}
}
