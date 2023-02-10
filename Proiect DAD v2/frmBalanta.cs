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
    public partial class frmBalanta : Form
    {
        DADEntities ctx = new DADEntities();

        public frmBalanta()
        {
            InitializeComponent();
        }

        private void Balanta_Load(object sender, EventArgs e)
        {
            this.BalantaVerificare2_ResultBindingSource.DataSource = ctx.BalantaVerificare2().ToList();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMeniu Meniu = new frmMeniu();
            this.Hide();
            Meniu.Show();
        }
    }
}
