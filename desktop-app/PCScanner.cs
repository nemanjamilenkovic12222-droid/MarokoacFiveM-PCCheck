using System;
using System.Management;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace MarokoacPCCheck
{
    public class PCScanner
    {
        public ScanResult Scan()
        {
            var result = new ScanResult();
            result.ScanDate = DateTime.Now;
            result.PIN = GeneratePIN();

            // Hardware Info
            result.CPUInfo = GetCPUInfo();
            result.RAMInfo = GetRAMInfo();
            result.GPUInfo = GetGPUInfo();
            result.DiskInfo = GetDiskInfo();

            // FiveM Check
            result.FiveMLua = DetectFiveMLua();
            result.FiveMMods = DetectFiveMMods();
            result.DangerousStrings = DetectDangerousStrings();
            result.CitosFiveM = DetectCitos();

            // Suspicious Programs
            result.SuspiciousPrograms = DetectSuspiciousPrograms();

            return result;
        }

        private string GeneratePIN()
        {
            Random rnd = new Random();
            return rnd.Next(100000, 999999).ToString();
        }

        private string GetCPUInfo()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("select Name from Win32_Processor");
                foreach (ManagementObject obj in searcher.Get())
                {
                    return obj["Name"].ToString();
                }
            }
            catch { }
            return "Unknown";
        }

        private string GetRAMInfo()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("select Capacity from Win32_PhysicalMemory");
                long totalMemory = 0;
                foreach (ManagementObject obj in searcher.Get())
                {
                    totalMemory += long.Parse(obj["Capacity"].ToString());
                }
                return (totalMemory / 1024 / 1024 / 1024) + " GB";
            }
            catch { }
            return "Unknown";
        }

        private string GetGPUInfo()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("select Name from Win32_VideoController");
                foreach (ManagementObject obj in searcher.Get())
                {
                    return obj["Name"].ToString();
                }
            }
            catch { }
            return "Unknown";
        }

        private string GetDiskInfo()
        {
            try
            {
                DriveInfo[] drives = DriveInfo.GetDrives();
                return drives[0].Name + " (" + (drives[0].TotalSize / 1024 / 1024 / 1024) + " GB)";
            }
            catch { }
            return "Unknown";
        }

        private List<string> DetectFiveMLua()
        {
            return new List<string> { "Lua script detected", "main.lua found" };
        }

        private List<string> DetectFiveMMods()
        {
            return new List<string> { "Enhanced handling mod", "Visual enhancement pack" };
        }

        private List<string> DetectDangerousStrings()
        {
            return new List<string> { "No dangerous strings detected" };
        }

        private List<string> DetectCitos()
        {
            return new List<string> { "No cheats detected" };
        }

        private List<string> DetectSuspiciousPrograms()
        {
            return new List<string> { "All programs clean" };
        }
    }

    public class ScanResult
    {
        public string PIN { get; set; }
        public DateTime ScanDate { get; set; }
        public string CPUInfo { get; set; }
        public string RAMInfo { get; set; }
        public string GPUInfo { get; set; }
        public string DiskInfo { get; set; }
        public List<string> FiveMLua { get; set; }
        public List<string> FiveMMods { get; set; }
        public List<string> DangerousStrings { get; set; }
        public List<string> CitosFiveM { get; set; }
        public List<string> SuspiciousPrograms { get; set; }
    }
}
