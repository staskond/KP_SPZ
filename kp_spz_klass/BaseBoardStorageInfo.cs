using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kp_spz_klass
{
    class BaseBoardStrorageInfo
    {
        private readonly string caption;
        private readonly string product;
        private readonly string serialNumber;

        public string GetCaption() { return caption; }
        public string GetProduct() { return product; }
        public string GetSerialNumber() { return serialNumber; }

        public BaseBoardStrorageInfo(string caption, string product, string serialNumber)
        {
            if(!(caption.Equals("") || product.Equals("") || serialNumber.Equals("")))
            {
                this.caption = caption;
                this.product = product;
                this.serialNumber = serialNumber;
            }
            else
            {
                try
                {
                    throw new ArgumentException("Недопустимое значение при создании єкземпляра BaseBoardStrorageInfo.");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public override string ToString()
        {
            return "Caption: " + caption +
                "\nProduct: " + product +
                "\nSerial number: " + serialNumber;
        }
    }
}
