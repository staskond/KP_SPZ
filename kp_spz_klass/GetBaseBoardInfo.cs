using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace kp_spz_klass
{
    class GetBaseBoardInfo:IDeviceInfo
    {
        public List<BaseBoardStrorageInfo> baseBoard = new List<BaseBoardStrorageInfo>();
        public void GetDeviceInfo()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("\\root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
            foreach(ManagementObject queryObj in searcher.Get())
            {
                baseBoard.Add(new BaseBoardStrorageInfo(queryObj["Caption"].ToString(), queryObj["Product"].ToString(), queryObj["SerialNumber"].ToString()));
            }
        }
    }
}
