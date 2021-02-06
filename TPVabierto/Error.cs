///
///
///        TPVABIERTO
///        Copyright 2019-2020, Nicolás Aguado
///        
///        Todos los derechos reservados
///

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
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal static void Aviso(string mensaje)
        {
            Error v = new Error();
            v.label2.Text = mensaje;
            v.Show();
        }

        internal static void AvisoDialog(string mensaje)
        {
            Error v = new Error();
            v.label2.Text = mensaje;
            v.ShowDialog();
        }
    }
}
