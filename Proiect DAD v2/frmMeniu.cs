using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_DAD_v2
{
    public partial class frmMeniu : Form
    {
        public frmMeniu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmConturi Conturi = new frmConturi();
            this.Hide();
            Conturi.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRulaje Rulaje = new frmRulaje();
            this.Hide();
            Rulaje.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmBalanta Balanta = new frmBalanta();
            this.Hide();
            Balanta.Show();
        }
    }
}
