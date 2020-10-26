using System;
using System.IO;

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
	public class GeneralFunction
    {
		/// <summary>
		/// Convert Byte Array to String
		/// </summary>
		/// <param name="bytes"></param>
		/// <returns></returns>
		public static string ByteArrayToString(byte[] bytes)
		{
			var text = BitConverter.ToString(bytes);
            var text2 = string.Empty;
            var array = text.Split('-');
			foreach (var t in array)
            {
                text2 = text2 + "0x" + t + ",";
            }
			return text2.Substring(0, text2.Length - 1);
		}
		/// <summary>
		/// Generate Random Password for Symmetric Encryption Module
		/// </summary>
		/// <param name="start">Start Password</param>
		/// <param name="end">End Password Length</param>
		/// <returns></returns>
		public static string RandomPassword(int start, int end)
		{
            var random = new Random();
            var array = $"0123456789abcdefghijklmnoprstuvwxyz./-+,_=)(&%^'!<>".ToCharArray();
            var text = string.Empty;
			for (var i = start; i < end; i++)
			{
				text += array[random.Next(0, array.Length - 1)].ToString();
			}
			return text;
		}
		/// <summary>
		/// Generate Random File Name for Meterpreter Output File
		/// </summary>
		/// <param name="start"></param>
		/// <param name="end"></param>
		/// <returns></returns>
		public static string RandomFileName(int start, int end)
		{
            var random = new Random();
            var array = $"0123456789abcdefghijklmnoprstuvwxyz".ToCharArray();
            var text = string.Empty;
			for (var i = start; i < end; i++)
			{
				text += array[random.Next(0, array.Length - 1)].ToString();
			}
			return text;
		}
		/// <summary>
		/// Generate Random Hex String for BlowFish Encryption Module
		/// </summary>
		/// <returns></returns>
		public static string RandomHexString()
		{
            var rdm = new Random();
            var hexValue = string.Empty;
			int num;

			for (var i = 0; i < 2; i++)
			{
				num = rdm.Next(0, int.MaxValue);
				hexValue += num.ToString("X8");
			}

			return hexValue;
		}
		/// <summary>
		/// Convert String Value to Byte Array
		/// </summary>
		/// <param name="value">Convert String Value</param>
		/// <returns></returns>
		public static byte[] ConvertToByteArray(string value)
		{
			byte[] bytes;
			if (string.IsNullOrEmpty(value))
			{
				bytes = null;
			}
			else
			{
                var string_length = value.Length;
                var character_index = value.StartsWith("0x", StringComparison.Ordinal) ? 2 : 0;
                var number_of_characters = string_length - character_index;
				var add_leading_zero = false;
				if (number_of_characters % 2 != 0)
				{
					add_leading_zero = true;
					number_of_characters++;
				}
				bytes = new byte[number_of_characters / 2];
                var write_index = 0;
				if (add_leading_zero)
				{
					bytes[write_index++] = FromCharacterToByte(value[character_index], character_index, 0);
					character_index++;
				}
				for (var read_index = character_index; read_index < value.Length; read_index += 2)
				{
                    var upper = FromCharacterToByte(value[read_index], read_index, 4);
                    var lower = FromCharacterToByte(value[read_index + 1], read_index + 1, 0);
					bytes[write_index++] = ((byte)(upper | lower));
				}
			}
			return bytes;
		}
		/// <summary>
		/// Convert Charecter to Byte Method
		/// </summary>
		/// <param name="character"></param>
		/// <param name="index"></param>
		/// <param name="shift"></param>
		/// <returns></returns>
		private static byte FromCharacterToByte(char character, int index, int shift = 0)
		{
            var value = (byte)character;
			if ((64 < value && 71 > value) || (96 < value && 103 > value))
			{
                var flag2 = 64 == (64 & value);
				if (flag2)
				{
                    var flag3 = 32 == (32 & value);
					if (flag3)
					{
						value = (byte)(value + 10 - 97 << shift);
					}
					else
					{
						value = (byte)(value + 10 - 65 << shift);
					}
				}
			}
			else
			{
                var flag4 = 41 < value && 64 > value;
				if (!flag4)
				{
					throw new InvalidOperationException($"Character '{character}' at index '{index}' is not valid alphanumeric character.");
				}
				value = (byte)(value - 48 << shift);
			}
			return value;
		}
		/// <summary>
		/// Clean Directory Method, Saved Directory Cleaner
		/// </summary>
        public static void CleanDirectory()
        {
            try
            {
                var directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\Saved\\");
                var files = directoryInfo.GetFiles("*.*");
                var array = files;
                for (int i = 0; i < array.Length; i++)
                {
                    if (!array[i].Name.Contains("Stub.bin") || !array[i].Name.Contains("iSMETShellCode.txt") || !array[i].Name.Contains("stub.bin") || !array[i].Name.Contains("iSMETShellCode.txt"))
                    {
                        File.Delete($"{Directory.GetCurrentDirectory()}\\Saved\\{array[i].Name}");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"An error occurred: {ex.Message}", @"iSMET Error!");
            }
        }
	}
}
