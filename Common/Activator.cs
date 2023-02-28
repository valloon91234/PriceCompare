using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace KeyGen
{
    public static class Activator
    {
        public static string RunCMD(string cmd)
        {
            using (Process p = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = cmd,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            })
            {
                p.Start();
                StreamReader sr = p.StandardOutput;
                sr.ReadLine();
                sr.ReadLine();
                string line = sr.ReadLine().Trim();
                sr.Close();
                return line;
            }
        }

        public static string GetHDModel()
        {
            string result = RunCMD(@"/c wmic path win32_physicalmedia where tag='\\\\.\\PHYSICALDRIVE0' get model").Trim();
            if (result.Length > 0) return result;
            result = RunCMD(@"/c wmic diskdrive where deviceid='\\\\.\\PHYSICALDRIVE0' get model").Trim();
            return result;
        }

        public static string GetHDSerialNumber()
        {
            string result = RunCMD(@"/c wmic path win32_physicalmedia where tag='\\\\.\\PHYSICALDRIVE0' get serialnumber").Trim();
            if (result.Length > 0) return result;
            result = RunCMD(@"/c wmic diskdrive where deviceid='\\\\.\\PHYSICALDRIVE0' get serialnumber").Trim();
            return result;
        }

        public static string GetRequestCode(int digits = 8)
        {
            string model = GetHDModel();
            string sn = GetHDSerialNumber();
            if (string.IsNullOrWhiteSpace(sn))
            {
                DateTime now = DateTime.Now;
                sn = model + ((now.Year % 50) * 12 + now.Month - 1);
            }
            byte[] bytes = Encoding.UTF8.GetBytes(sn);
            MD5 md5 = MD5CryptoServiceProvider.Create();
            bytes = md5.ComputeHash(bytes);
            string u = BitConverter.ToUInt64(bytes, 0).ToString();
            string content = "";
            int crc = 0;
            int contentLength = digits - 1;
            for (int i = 0; i < contentLength; i++)
            {
                content += u[i];
                crc += Convert.ToInt32(u[i].ToString());
            }
            crc = (10 - crc % 10) % 10;
            return content + crc;
        }

        public static bool CheckRequestCode(string requestCode, int length = 0)
        {
            requestCode = StringUtil.GetNumbers(requestCode);
            int inputLength = requestCode.Length;
            if (length > 0 && length != inputLength) return false;
            int sum = 0;
            for (int i = 0; i < inputLength; i++)
            {
                sum += Convert.ToInt32(requestCode[i].ToString());
            }
            return sum % 10 == 0;
        }

        public static readonly byte[] KEY_BYTES = { 111, 102, 23, 207 };

        public static string GenerateActivationCode(string requestCode = null, int digits = 12)
        {
            if (requestCode == null)
                requestCode = GetRequestCode();
            else
                requestCode = StringUtil.GetNumbers(requestCode);
            byte[] requestCodeBytes = Encoding.UTF8.GetBytes(requestCode);
            requestCodeBytes = StringUtil.XorBytes(requestCodeBytes, KEY_BYTES);
            byte[] key;
            using (SHA256 sha256 = SHA256.Create())
            {
                key = sha256.ComputeHash(requestCodeBytes);
            }
            string u = BitConverter.ToUInt64(key, 0).ToString();
            string content = "";
            int crc = 0;
            int contentLength = digits - 1;
            for (int i = 0; i < contentLength; i++)
            {
                content += u[i];
                crc += Convert.ToInt32(u[i].ToString());
            }
            crc = 10 - crc % 10;
            return content + crc;
        }

        public static bool CheckActivationCode(string activationCode, int length = 0)
        {
            activationCode = StringUtil.GetNumbers(activationCode);
            int inputLength = activationCode.Length;
            if (length > 0 && length != inputLength) return false;
            int sum = 0;
            for (int i = 0; i < inputLength; i++)
            {
                sum += Convert.ToInt32(activationCode[i].ToString());
            }
            return sum % 10 == 0;
        }

        public static string ExportCode(string input)
        {
            int length = input.Length;
            if (length % 4 != 0) return input;
            string result = "";
            for (int i = 0; i < length; i++)
            {
                if (i % 4 == 0 && i > 0) result += "-";
                result += input[i];
            }
            return result;
        }

        public static string ExportRequestCode(string requestCode = null)
        {
            if (requestCode == null) requestCode = GetRequestCode();
            return ExportCode(requestCode);
        }

        public static string ExportActivationCode(string requestCode)
        {
            return ExportCode(GenerateActivationCode(requestCode));
        }

        public static bool CheckVM()
        {
            using (var searcher = new System.Management.ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
            {
                using (var items = searcher.Get())
                {
                    foreach (var item in items)
                    {
                        string manufacturer = item["Manufacturer"].ToString().ToLower();
                        if ((manufacturer == "microsoft corporation" && item["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL"))
                            || manufacturer.Contains("vmware")
                            || item["Model"].ToString() == "VirtualBox")
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

    }
}
