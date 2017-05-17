using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
namespace kp_spz_klass
{
    class GetProcessorInfo: IDeviceInfo
    {
        public List<ProcessorStorageInfo> processorInfo = new List<ProcessorStorageInfo>();
        ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
        public void GetDeviceInfo()
        {
            foreach(ManagementObject queryObj in searcher.Get()){
                processorInfo.Add(new ProcessorStorageInfo(queryObj["Name"].ToString(),
                    Convert.ToInt32(queryObj["NumberOfCores"]),
                    queryObj["ProcessorId"].ToString()));
            }
        }
    }
}
