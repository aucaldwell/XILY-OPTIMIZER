using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XILY_OPTIMIZER
{
    public partial class Clean_up : Form
    {
        public Clean_up()
        {
            InitializeComponent();
        }

        private void Clean_up_Load(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
