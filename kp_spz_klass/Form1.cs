using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kp_spz_klass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            try
            {
                HardWareInfo newasd;
                GetHDDInfo HDDInf = new GetHDDInfo();
                HDDInf.GetDeviceInfo();
                GetProcessorInfo ProcessorInf = new GetProcessorInfo();
                ProcessorInf.GetDeviceInfo();
                GetVideoControllerInfo VideoControllerInf = new GetVideoControllerInfo();
                VideoControllerInf.GetDeviceInfo();
                GetBaseBoardInfo BaseBoardInf = new GetBaseBoardInfo();
                BaseBoardInf.GetDeviceInfo();
                HardWareInfo HardWare = new HardWareInfo(HDDInf.hddInfo[0].GetSerialNumber(),
                    ProcessorInf.processorInfo[0].GetProcessorName(),
                    ProcessorInf.processorInfo[0].GetProcessorID(),
                    VideoControllerInf.videoControllers[0].GetDeviceID(),
                    BaseBoardInf.baseBoard[0].GetSerialNumber(),
                    DateTime.Today);

                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fsa = new FileStream("E:\\hardware.dat", FileMode.Open))
                {
                     newasd = (HardWareInfo)formatter.Deserialize(fsa);
                }
                if (newasd.Equals(HardWare))
                {
                    MessageBox.Show("License active!", "Уведомление", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("License unactive!", "Уведомление", MessageBoxButtons.OK);
                }

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
            catch (SerializationException ex)
            {
                MessageBox.Show("Failed to deserialize.", "Ошибка", MessageBoxButtons.OK);
            }
            finally
            {
            }
        }
    }
}
