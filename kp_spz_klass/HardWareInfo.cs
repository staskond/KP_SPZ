using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kp_spz_klass
{
    [Serializable]
    class HardWareInfo
    {
        public string HDDserialNumber { get; set; }
        public string ProcessorName { get; set; }
        public string ProcessorID { get; set; }
        public string VideoControllerId { get; set; }
        public string BaseGoardSerialNumber { get; set; }
        public DateTime EndData { get; set; }

        public HardWareInfo(string HDDserialNumber,
            string ProcessorName,
            string ProcessorID,
            string VideoControllerId,
            string BaseGoardSerialNumber,
            DateTime endDate)
        {
            this.HDDserialNumber = HDDserialNumber;
            this.ProcessorName = ProcessorName;
            this.ProcessorID = ProcessorID;
            this.VideoControllerId = VideoControllerId;
            this.BaseGoardSerialNumber = BaseGoardSerialNumber;
            this.EndData = endDate;
        }

        public HardWareInfo(string HDDserialNumber,
            string ProcessorName,
            string ProcessorID,
            string VideoControllerId,
            string BaseGoardSerialNumber)
        {
            this.HDDserialNumber = HDDserialNumber;
            this.ProcessorName = ProcessorName;
            this.ProcessorID = ProcessorID;
            this.VideoControllerId = VideoControllerId;
            this.BaseGoardSerialNumber = BaseGoardSerialNumber;
        }

        public bool Equals(HardWareInfo obj)
        {
            return (this.BaseGoardSerialNumber.Equals(obj.BaseGoardSerialNumber)
                && (this.EndData >= obj.EndData)
                && this.HDDserialNumber.Equals(HDDserialNumber)
                && this.ProcessorID.Equals(obj.ProcessorID)
                && this.ProcessorName.Equals(obj.ProcessorName)
                && this.VideoControllerId.Equals(obj.VideoControllerId));
        }
    }
}
