using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iSMET
{
    public enum Architecture
    {
        x86,
        x64
    }
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
    public enum ApplicationType
    {
        ConsoleApplication = 0,
        FormApplication = 1,
        Powershell = 2
    }
}
