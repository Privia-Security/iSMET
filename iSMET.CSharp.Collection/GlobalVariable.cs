using System;
using System.Collections.Generic;
using System.Linq;
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


    /// <summary>
    /// Generated File Architecture
    /// </summary>
    public enum Architecture
    {
        x86,
        x64
    }
    /// <summary>
    /// File Encryption Type
    /// </summary>
    public enum EncryptionType
    {
        NonEncryption = 0,
        Base64 = 1,
        Rinjdael = 2,
        DES = 3,
        TripleDES = 4,
        RcTwo = 5,
        RSA = 6,
        AESCBC = 7,
        BlowFish = 8
    }
    /// <summary>
    /// Application Type
    /// </summary>
    public enum ApplicationType
    {
        ConsoleApplication = 0,
        FormApplication = 1,
        ConsoleMemoryMapped = 2,
        FormMemoryMapped = 3,
        AspxExe = 4,
        Powershell = 5
    }
    /// <summary>
    /// Shellcode Type
    /// </summary>
    public enum ShellCodeType
    {
        ByteArray = 0,
        Dword = 1
    }
    /// <summary>
    /// Payload Type
    /// </summary>
    public enum Payload
    {
        x86_meterpreter_reverse_tcp = 0,
        x86_meterpreter_reverse_tcp_rc4 = 1,
        x86_meterpreter_bind_tcp = 2,
        x86_shell_reverse_tcp = 3,
        x86_shell_reverse_tcp_rc4 = 4,
        x86_shell_bind_tcp = 5,
        x86_shell_bind_tcp_rc4 = 6,
        x64_meterpreter_reverse_tcp = 7,
        x64_meterpreter_reverse_tcp_rc4 = 8,
        x64_meterpreter_bind_tcp = 9,
        x64_shell_reverse_tcp = 10,
        x64_shell_bind_tcp = 11,
        x64_shell_reverse_tcp_rc4 = 12,
        x64_shell_bind_tcp_rc4 = 13
    }
}
