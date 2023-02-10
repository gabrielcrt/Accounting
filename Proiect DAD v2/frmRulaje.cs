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
    public partial class frmRulaje : Form
    {
        DADEntities ctx = new DADEntities();
        public frmRulaje()
        {
            InitializeComponent();
        }

        private void frmRulaje_Load(object sender, EventArgs e)
        {
            ctx.Operaties.Load();
            operatieBindingSource.DataSource = ctx.Operaties.Local.ToBindingList();
            /*ctx.Rulajes.Load();
            rulajesBindingSource.DataSource = ctx.Rulajes.Local.ToList();*/
            ctx.Conts.Load();
            contBindingSource.DataSource = ctx.Conts.Local.ToList();
        }

        private void operatieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                operatieBindingSource.EndEdit();
                ctx.SaveChanges();
                operatieBindingSource.ResetBindings(false);
                MessageBox.Show("Datele introduse au fost salvate!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datele introduse nu au fost salvate!");
            }

        }
        private void rulajesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMeniu Meniu = new frmMeniu();
            this.Hide();
            Meniu.Show();
        }
    }
    public class myBindingColl<T> : System.Collections.ObjectModel.ObservableCollection<T>
    {
    }
}
