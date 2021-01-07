using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient
{
    public partial class profilee : Form
    {
        public profilee()
        {
            InitializeComponent();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            patient p = new patient();
            
            p.Show();
            this.Hide();
        }
    }
}
