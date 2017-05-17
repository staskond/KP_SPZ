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
        private readonly string numbersOfCores;
        private readonly string processorID;
        public string GetProcessorName() { return processorName; }
        public string GetNumbersOfCorec() { return numbersOfCores; }
        public string GetProcessorID() { return processorID; }

        public ProcessorStorageInfo(string processorName, string numbersOfCores, string processorId)
        {

        }
    }
}
