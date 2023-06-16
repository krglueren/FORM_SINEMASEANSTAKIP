using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SİNEMASEANSTAKİP
{
    public partial class BelleVeSebastian : Form
    {
        public BelleVeSebastian()
        {
            InitializeComponent();
        }

        private void BelleVeSebastian_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 350;
            DataGridViewColumn columnn = dataGridView1.Columns[1];
            columnn.Width = 350;
            DataGridViewColumn columnnn = dataGridView1.Columns[2];
            columnnn.Width = 126;

            var context = new MOVIETICKETSEntities1();
            var belleVsb = context.belle.ToList();

            var bindingList = new BindingList<belle>(belleVsb);
            bindingSource1 = new BindingSource(bindingList, null);
            dataGridView1.DataSource = bindingSource1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "AL")
            {
                BelleVSbstKoltukSecimi gnc = new BelleVSbstKoltukSecimi();
                gnc.a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                gnc.b = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                gnc.Show();
                this.Hide();
                var context = new MOVIETICKETSEntities1();
                var bellev = context.belle.ToList();

                var bindingList = new BindingList<belle>(bellev);
                bindingSource1 = new BindingSource(bindingList, null);
                dataGridView1.DataSource = bindingSource1;
            }
        }
    }
}
