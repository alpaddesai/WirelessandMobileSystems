using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WirelessandMobileSystems
{
    public partial class SensorNetworks : Form
    {
        public SensorNetworks()
        {
            InitializeComponent();
        }

        private void SensorNetworks_Load(object sender, EventArgs e)
        {

        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();

            axAcroPDF1.src = file.FileName;
        }
    }
}
