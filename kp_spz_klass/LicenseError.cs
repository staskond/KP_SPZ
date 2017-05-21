using System;
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
    public partial class LicenseError : Form
    {
        public LicenseError()
        {
            InitializeComponent();
            ExitProgram.Click += (object sender, EventArgs e) =>
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };
        }
    }
}
