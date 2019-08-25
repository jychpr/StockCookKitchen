using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CekBahanMakanan
{
    public partial class AksiResep : Form
    {
        public enum Mode { Tambah, Edit }
        Mode mode;
        public AksiResep()
        {
            InitializeComponent();
            mode = Mode.Tambah;
            lblAksiResep.Text = "Tambah Resep";
            btnHapus.Hide();
        }

        public AksiResep(int a)
        {
            InitializeComponent();
            mode = Mode.Tambah;
            lblAksiResep.Text = "Edit Resep";
            btnHapus.Enabled = true;
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
