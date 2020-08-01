using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace iSMET.Packer
{
    public class MemoryFunction
    {
        public static void MemoryInvoke(object args, string filePath)
        {
            string exeToRun = filePath;
            var exeBytes = File.ReadAllBytes(exeToRun);

            FileStream fs = new FileStream(exeToRun, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            byte[] bin = br.ReadBytes(Convert.ToInt32(fs.Length));
            fs.Close();
            br.Close();
            Assembly a = Assembly.Load(exeBytes);
            MethodInfo method = a.EntryPoint;
            object o = a.CreateInstance(method.Name);
            try
            {
                method.Invoke(null, new object[] { args });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void MemoryInvoke(object args, byte[] byteStream)
        {
            Assembly a = Assembly.Load(byteStream);
            MethodInfo method = a.EntryPoint;
            object o = a.CreateInstance(method.Name);
            try
            {
                method.Invoke(null, new object[] { args });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
