using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
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
                HardWareInfo GetConfig;
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

                RegistryKey LicenseInfo = Registry.CurrentUser;
                RegistryKey GetLicenseFile = LicenseInfo.OpenSubKey("KP_SPZ_V29");

                GetConfig = new HardWareInfo(GetLicenseFile.GetValue("HDDserialNumber").ToString(),
                    GetLicenseFile.GetValue("ProcessorName").ToString(),
                    GetLicenseFile.GetValue("ProcessorID").ToString(),
                    GetLicenseFile.GetValue("VideoControllerId").ToString(),
                    GetLicenseFile.GetValue("BaseGoardSerialNumber").ToString(),
                    Convert.ToDateTime(GetLicenseFile.GetValue(("DateEnd"))));
                TripleDESCryptoServiceProvider TDES = new TripleDESCryptoServiceProvider();
                byte[] KeyArray = TDES.Key;
               // string bbb = aaa[4].ToString("X2");
                StringBuilder sb = new StringBuilder();
                for(int i = 0; i < KeyArray.Count(); i++)
                {
                    sb.Append(KeyArray[i].ToString("X2") + " ");
                }
                //    string HDDserialNumber,
                //string ProcessorName,
                //string ProcessorID,
                //string VideoControllerId,
                //string BaseGoardSerialNumber,
                //DateTime endDate)
                //BinaryFormatter formatter = new BinaryFormatter();
                //using (FileStream fsa = new FileStream("E:\\hardware.dat", FileMode.Open))
                //{
                //     newasd = (HardWareInfo)formatter.Deserialize(fsa);
                //}
                if (GetConfig.Equals(HardWare))
                {
                    MessageBox.Show(sb.ToString(), "Уведомление", MessageBoxButtons.OK);
                }
                else
                {
                    OpenErrorWindow();
                    MessageBox.Show("License unactive!", "Уведомление", MessageBoxButtons.OK);
                }
                GetLicenseFile.Close();

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
            catch (SerializationException ex)
            {
                OpenErrorWindow();
                MessageBox.Show("Failed to deserialize.", "Ошибка", MessageBoxButtons.OK);
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message, "Ошибка", MessageBoxButtons.OK);
                //OpenErrorWindow();
            }
            finally
            {
            }
        }
        private void OpenErrorWindow()
        {
            LicenseError ErrorForm = new LicenseError();
            ErrorForm.Owner = this;
            if (ErrorForm.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
