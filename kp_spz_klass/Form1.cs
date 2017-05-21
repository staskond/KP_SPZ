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

                if (GetConfig.Equals(HardWare) && !(GetLicenseFile.GetValue("Key").ToString().Equals("")))
                {
                    MessageBox.Show(("License Key\n" + GetLicenseFile.GetValue("Key").ToString()), "Уведомление", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("License unactive!", "Уведомление", MessageBoxButtons.OK);
                    OpenErrorWindow();
                    
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
