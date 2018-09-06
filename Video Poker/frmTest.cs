using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azara_Video_Poker
{
    public partial class frmTest : Form
    {
        
        public frmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPoker what = new frmPoker();
            
            what.Update();
            what.BackColor = Color.Green;
            this.BackColor = Color.Green;

        }
    }
}
