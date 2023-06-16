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
    public partial class GalaksininKoruyuculari3 : Form
    {
        public GalaksininKoruyuculari3()
        {
            InitializeComponent();
        }

        private void GalaksininKoruyuculari3_Load(object sender, EventArgs e)
        {
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = 350;
            DataGridViewColumn columnn = dataGridView1.Columns[1];
            columnn.Width = 350;
            DataGridViewColumn columnnn = dataGridView1.Columns[2];
            columnnn.Width = 126;

            var context = new MOVIETICKETSEntities1();
            var galaksikoru = context.galaksi.ToList();

            var bindingList = new BindingList<galaksi>(galaksikoru);
            bindingSource1 = new BindingSource(bindingList, null);
            dataGridView1.DataSource = bindingSource1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "AL")
            {
                GalaksininKorKoltukSecimi gnc = new GalaksininKorKoltukSecimi();
                gnc.a = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                gnc.b = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                gnc.Show();
                this.Hide();
                var context = new MOVIETICKETSEntities1();
                var Galaks = context.galaksi.ToList();

                var bindingList = new BindingList<galaksi>(Galaks);
                bindingSource1 = new BindingSource(bindingList, null);
                dataGridView1.DataSource = bindingSource1;
            }
        }
    }
}
