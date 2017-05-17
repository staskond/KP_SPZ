using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kp_spz_klass
{
    class ProcessorStorageInfo
    {
        private readonly string processorName;
        private readonly int numbersOfCores;
        private readonly string processorID;
        public string GetProcessorName() { return processorName; }
        public int GetNumbersOfCorec() { return numbersOfCores; }
        public string GetProcessorID() { return processorID; }

        public ProcessorStorageInfo(string processorName, int numbersOfCores, string processorID)
        {
            this.numbersOfCores = numbersOfCores;
            if (!(processorName.Equals("") || processorID.Equals(""))){
                this.processorID = processorID;
                this.processorName = processorName;
            }
            else
            {
                try
                {
                    throw new ArgumentException("Недопустимое значение при создании єкземпляра ProcessorStorageInfo.");
                }catch(ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
        public override string ToString()
        {
            return "Processor name: " + processorName + "\nNumber of cores: " + numbersOfCores + "\nProcessor ID: " + processorID;
        }
    }
}
