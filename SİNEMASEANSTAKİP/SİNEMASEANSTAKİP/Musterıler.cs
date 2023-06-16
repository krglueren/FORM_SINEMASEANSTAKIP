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
    public partial class Musterıler : Form
    {
        public Musterıler()
        {
            InitializeComponent();
        }

        private void Musterıler_Load(object sender, EventArgs e)
        {
            var context = new MOVIETICKETSEntities1();
            var mstrlr = context.musteriler.ToList();

            var bindingList = new BindingList<musteriler>(mstrlr);
            bindingSource1 = new BindingSource(bindingList, null);
            dataGridView1.DataSource = bindingSource1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new MOVIETICKETSEntities1();
            var deger = int.Parse(textBox1.Text);
            var sil = context.musteriler.FirstOrDefault(x => x.Id == deger);
            context.musteriler.Remove(sil);
            context.SaveChanges();

            var gstr = context.musteriler.ToList();
            var bindingList = new BindingList<musteriler>(gstr);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
        }
    }
}
