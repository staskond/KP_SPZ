using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace kp_spz_klass
{
    class HDDStorageInfo
    {
        List<HDDStorageInfo> informatino = new List<HDDStorageInfo>();
        public readonly string DeviceID;
        public readonly string SerialNumber;
        public readonly string Model;
        public readonly string InterfaceType;
        public readonly string Manufacturer;
        public readonly double Size;
        public HDDStorageInfo(string deviceID,string serialNumber, string model, string interfaceType, string manufacturer,double size)
        {
            Size = size;
            if (!(deviceID.Equals("") || serialNumber.Equals("") || model.Equals("") || interfaceType.Equals("") || manufacturer.Equals(""))){
                SerialNumber = serialNumber;
                Model = model;
                InterfaceType = interfaceType;
                Manufacturer = manufacturer;
                DeviceID = deviceID;
            }
            else
            {
                try
                {
                    throw new ArgumentException("Недопустимое значение при создании єкземпляра HDDStprageInfo");
                }
                catch(ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
