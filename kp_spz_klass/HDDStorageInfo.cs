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
        private readonly string deviceID;
        private readonly string serialNumber;
        private readonly string model;
        private readonly string interfaceType;
        private readonly string manufacturer;
        private readonly double size;
        public HDDStorageInfo(string deviceID,string serialNumber, string model, string interfaceType, string manufacturer,double size)
        {
            this.size = size;
            if (!(deviceID.Equals("") || serialNumber.Equals("") || model.Equals("") || interfaceType.Equals("") || manufacturer.Equals(""))){
                this.serialNumber = serialNumber;
                this.model = model;
                this.interfaceType = interfaceType;
                this.manufacturer = manufacturer;
                this.deviceID = deviceID;
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
        public override string ToString()
        {
            return "DeviceID: " + deviceID +
                "\nManufacturer: " + manufacturer +
                "\nModel: " + model + 
                "\nSerialNumber: " + serialNumber + 
                "\nSize: " + size + " Gb.";
        }
        public string GetDeviceID() { return deviceID; }
        public string GetSerialNumber() { return serialNumber; }
        public string GetModel() { return model; }
        public string GetInterfaceType() { return interfaceType; }
        public string GetManufacturer() { return manufacturer; }
        public double GetSize() { return size; }
    }
}
