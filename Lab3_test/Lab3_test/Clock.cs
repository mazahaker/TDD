using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_test
{
    public partial class Clock : Form
    {
        readonly Timer tik;
        public int hours { get; set; }
        public int minutes { get; set; }
        public int second { get; set; }

        public Clock()
        {
            tik = new Timer();
            InitializeComponent();
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            tik.Interval = 10000;
            tik.Tick += tmrShow_Tick;
            tik.Enabled = true;
        }

        private void tmrShow_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
