﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            GetHDDInfo sdf = new GetHDDInfo();
            sdf.GetDeviceInfo();
            GetProcessorInfo sdfs = new GetProcessorInfo();
            sdfs.GetDeviceInfo();
        }
    }
}
