using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
namespace kp_spz_klass
{
    class GetHDDInfo:IDeviceInfo
    {
        public List<HDDStorageInfo> hddInfo = new List<HDDStorageInfo>();
        public void GetDeviceInfo()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("\\root\\CIMV2", "SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject queryObj in searcher.Get())
            {
                hddInfo.Add(new HDDStorageInfo(queryObj["DeviceID"].ToString(), queryObj["SerialNumber"].ToString(),
                    queryObj["Model"].ToString(),
                    queryObj["InterfaceType"].ToString(),
                    queryObj["Manufacturer"].ToString(),
                    Math.Round(Convert.ToDouble(queryObj["Size"]) / 1024 / 1024 / 1024, 2)));
            }
        }
    }
}
