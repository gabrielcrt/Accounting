using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
namespace Proiect_DAD_v2
{
    public partial class frmConturi : Form
    {
        DADEntities ctx = new DADEntities();
        public frmConturi()
        {
            InitializeComponent();
        }
        private void frmConturi_Load(object sender, EventArgs e)
        {
            ctx.Conts.Load();
            contBindingSource.DataSource = ctx.Conts.Local.ToBindingList();
        }

        private void contBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                contBindingSource.EndEdit();
                ctx.SaveChanges();
                contBindingSource.ResetBindings(false);
                MessageBox.Show("Datele introduse au fost salvate!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Datele introduse nu pot fi salvate! : [CAUZA]: " + ex.ToString());
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMeniu Meniu = new frmMeniu();
            this.Hide();
            Meniu.Show();
        }
    }
}
