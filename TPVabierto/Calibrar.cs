using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPVabierto
{
    public partial class Calibrar : Form
    {
        public Calibrar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = comprobarbtn;
        }

        private void Calibrar_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void comprobarbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "4040000000021") { MessageBox.Show("Lector Compatible!", "TPVabierto [Configuracion]", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1); }
            else { MessageBox.Show("Lector NO Compatible!", "TPVabierto [Configuracion]", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); }
        }
    }
}
