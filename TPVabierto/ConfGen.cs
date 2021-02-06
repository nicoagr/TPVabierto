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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPVabierto
{
    public partial class ConfGen : Form
    {
        internal string _conf = "Configuracion";
        internal string _tpvc = "TPVabierto [Configuración General]";

        public ConfGen()
        {
            InitializeComponent();
        }

        private void cerrarsin_Click(object sender, EventArgs e)
        {
            VentanaPrincipal v = new VentanaPrincipal();
            Hide();
            v.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está a punto de cambiar datos clave que influirán en las facturas, tickets, estadísticas y más. Los cambios no afectan a los tickets cerrados y a las facturas ya creadas." +
                "Se aplicarán los cambios inmediatamente, ¿Desea continuar?", _tpvc, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                File.Delete(_conf);
                API.CrearArchivo(_conf);
                API.AgregarAArchivo(textBox1.Text, _conf);
                API.AgregarAArchivo(monedadropdown.Text, _conf);
                API.AgregarAArchivo(billete1txt.Text, _conf);
                API.AgregarAArchivo(billete2txt.Text, _conf);
                API.AgregarAArchivo(billete3txt.Text, _conf);
                API.AgregarAArchivo(billete4txt.Text, _conf);
                API.AgregarAArchivo(billete5txt.Text, _conf);
                if (checkBox1.Checked == true) { API.AgregarAArchivo("nuevo", _conf); } else { API.AgregarAArchivo("menu", _conf); }

                VentanaPrincipal v = new VentanaPrincipal();
                this.Hide();
                v.Show();
            }
            else { }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = button1;
        }

        private void ConfGen_Load(object sender, EventArgs e)
        {
            textBox1.Text = API.LeerLineaEspecificaArchivo(_conf, 1);
            monedadropdown.Text = API.LeerLineaEspecificaArchivo(_conf, 2);


            billete1txt.Text = API.LeerLineaEspecificaArchivo(_conf, 3);
            billete2txt.Text = API.LeerLineaEspecificaArchivo(_conf, 4);
            billete3txt.Text = API.LeerLineaEspecificaArchivo(_conf, 5);
            billete4txt.Text = API.LeerLineaEspecificaArchivo(_conf, 6);
            billete5txt.Text = API.LeerLineaEspecificaArchivo(_conf, 7);

            if (API.LeerLineaEspecificaArchivo(_conf, 8) == "nuevo") { checkBox1.Checked = true; checkBox2.Checked = false; } else { checkBox1.Checked = false; checkBox2.Checked = true; }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void billete1txt_TextChanged(object sender, EventArgs e)
        {
            if (API.ComprobarSiHayLetras(billete1txt.Text)) { MessageBox.Show("Letras no permitidas en el campo billetes", _tpvc, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1); billete1txt.Clear(); }
        }

        private void billete2txt_TextChanged(object sender, EventArgs e)
        {
            if (API.ComprobarSiHayLetras(billete2txt.Text)) { MessageBox.Show("Letras no permitidas en el campo billetes", _tpvc, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1); billete2txt.Clear(); }
        }

        private void billete3txt_TextChanged(object sender, EventArgs e)
        {
            if (API.ComprobarSiHayLetras(billete3txt.Text)) { MessageBox.Show("Letras no permitidas en el campo billetes", _tpvc, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1); billete3txt.Clear(); }
        }

        private void billete4txt_TextChanged(object sender, EventArgs e)
        {
            if (API.ComprobarSiHayLetras(billete4txt.Text)) { MessageBox.Show("Letras no permitidas en el campo billetes", _tpvc, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1); billete4txt.Clear(); }
        }

        private void billete5txt_TextChanged(object sender, EventArgs e)
        {
            if (API.ComprobarSiHayLetras(billete5txt.Text)) { MessageBox.Show("Letras no permitidas en el campo billetes", _tpvc, MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1); billete5txt.Clear(); }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) { checkBox2.Checked = false; }
            if (checkBox1.Checked == false) { checkBox2.Checked = true; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true) { checkBox1.Checked = false; }
            if (checkBox2.Checked == false) { checkBox1.Checked = true; }
        }
    }
}
