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
    public partial class Filmler : Form
    {
        public Filmler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var flm = new HizliVeOfkeli();
            flm.MdiParent = this.MdiParent;
            flm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var flm = new BirUmut();
            flm.MdiParent = this.MdiParent;
            flm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var flm = new BelleVeSebastian();
            flm.MdiParent = this.MdiParent;
            flm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var flm = new GalaksininKoruyuculari3();
            flm.MdiParent = this.MdiParent;
            flm.Show();
            this.Close();
        }

        private void Filmler_Load(object sender, EventArgs e)
        {

        }
    }
}
