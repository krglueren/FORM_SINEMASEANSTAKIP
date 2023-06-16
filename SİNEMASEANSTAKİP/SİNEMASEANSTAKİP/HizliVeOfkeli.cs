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
    public partial class HizliVeOfkeli : Form
    {
        public HizliVeOfkeli()
        {
            InitializeComponent();
        }

        public int Width { get; set; }

        private void HizliVeOfkeli_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 350;
            DataGridViewColumn columnn = dataGridView1.Columns[1];
            columnn.Width = 350;
            DataGridViewColumn columnnn = dataGridView1.Columns[2];
            columnnn.Width = 126;

            var context = new MOVIETICKETSEntities1();
            var hzll = context.hzlvefkl.ToList();

            var bindingList = new BindingList<hzlvefkl>(hzll);
            bindingSource1 = new BindingSource(bindingList, null);
            dataGridView1.DataSource = bindingSource1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "AL")
            {
                HzlVKoltukSecimi gnc = new HzlVKoltukSecimi();
                gnc.a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                gnc.b = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                gnc.Show();
                this.Hide();
                var context = new MOVIETICKETSEntities1();
                var hzl = context.hzlvefkl.ToList();

                var bindingList = new BindingList<hzlvefkl>(hzl);
                bindingSource1 = new BindingSource(bindingList, null);
                dataGridView1.DataSource = bindingSource1;
            }
        }
    }
}
