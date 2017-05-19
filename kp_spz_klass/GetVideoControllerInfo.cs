using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace kp_spz_klass
{
    class GetVideoControllerInfo: IDeviceInfo
    {
        public List<VideoControllerStorageInfo> videoControllers = new List<VideoControllerStorageInfo>();

        public void GetDeviceInfo()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");

            foreach(ManagementObject queryObj in searcher.Get())
            {
                videoControllers.Add(new VideoControllerStorageInfo(queryObj["DeviceID"].ToString(),
                    queryObj["VideoProcessor"].ToString(),
                    queryObj["AdapterRAM"].ToString(),
                    queryObj["Caption"].ToString(),
                    queryObj["Description"].ToString()));
            }
        }
    }
}
