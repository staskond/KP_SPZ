using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kp_spz_klass
{
    class VideoControllerStorageInfo
    {
        private readonly string deviceID;
        private readonly string videoProcessor;
        private readonly string adapterRAM;
        private readonly string caption;
        private readonly string description;

        public string GetDeviceID() { return deviceID; }
        public string GetVodeoProcessor() { return videoProcessor; }
        public string GetAdapterRAM() { return adapterRAM; }
        public string GetCaption() { return caption; }
        public string GetDescription() { return description; }

        public VideoControllerStorageInfo(string deviceID, string videoProcessor, string adapterRAM, string caption, string description)
        {
            if (!(deviceID.Equals("") || videoProcessor.Equals("") || videoProcessor.Equals("") || adapterRAM.Equals("") || caption.Equals("") || description.Equals("")))
            {
                this.deviceID = deviceID;
                this.videoProcessor = videoProcessor;
                this.adapterRAM = adapterRAM;
                this.caption = caption;
                this.description = description;
            }
            else
            {
                try
                {
                    throw new ArgumentException("Недопустимое значение при создании єкземпляра VideoControllerStorageInfo.");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public override string ToString()
        {
            return "Device ID: " + deviceID + "\nCaption :" + caption + "\nVideo processor: " + videoProcessor + "\nAdapter RAM: " + adapterRAM + "\nDescription :" + description;
        }
    }
}
