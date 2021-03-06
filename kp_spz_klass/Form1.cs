﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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


            GenerateLicenceFile.Click += (object sender, EventArgs e) =>
            {
                try
                {
                    if (Convert.ToDateTime(EndDate.Text) <= DateTime.Today)
                    {
                        throw new ArgumentException("Дата не может быть меньше текующей!");
                    };
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
                        Convert.ToDateTime(EndDate.Text));

                    BinaryFormatter formatter = new BinaryFormatter();
                    FolderBrowserDialog Folder = new FolderBrowserDialog();
                    if (Folder.ShowDialog() == DialogResult.OK)
                    {

                        using (FileStream fs = new FileStream(Path.Combine(Folder.SelectedPath, "hardware.dat"), FileMode.OpenOrCreate))
                        {
                            formatter.Serialize(fs, HardWare);
                        }

                        MessageBox.Show("Файл-лицензия успешно сгенирирован!", "Успешно!", MessageBoxButtons.OK);
                    }
                }catch(ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
                }
            };
        }
    }
}
