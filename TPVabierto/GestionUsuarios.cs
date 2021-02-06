///
///
///        TPVABIERTO
///        Copyright 2019-2020, Nicolás Aguado
///        
///        Todos los derechos reservados
///

using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TPVabierto
{
    public partial class GestionUsuarios : Form
    {
        internal string _txtgesus = "TPVabierto [Gestion] - Empleados";
        public GestionUsuarios()
        {
            InitializeComponent();
            Text = _txtgesus;
            actualizarTabla();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            VentanaPrincipal v = new VentanaPrincipal();
            Hide();
            v.Show();
        }

        private void anadirusuariobtn_Click(object sender, EventArgs e)
        {
            if (anadirusuariotxt.Text == string.Empty) MessageBox.Show("El campo 'empleado' no puede estar en blanco!", _txtgesus, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            // La siguiente linea nunca deberia ejecutarse, pero está por si acaso
            else if (lista.Items.Count > 7) MessageBox.Show("Hay un máximo de 8 empleados!", _txtgesus, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int numeroempleado = int.Parse(API.ComandodbConSalida("SELECT id FROM Usuarios ORDER BY id DESC LIMIT 1")) + 1;
                API.Comandodb("INSERT INTO Usuarios(id, Nombre) values('" + numeroempleado + "', '" + anadirusuariotxt.Text + "')");
            }
            anadirusuariotxt.Text = "";
            actualizarTabla();
            anadirusuariotxt.Focus();
        }

        internal void actualizarTabla()
        {
            // Limpiar lista
            lista.Items.Clear();
            dropdown.Items.Clear();

            //Obtener items de la lista
            string usuarios = API.ComandodbConSalida("SELECT Nombre FROM Usuarios");
            usuarios = usuarios.Replace("$", Environment.NewLine);

            using (StringReader reader = new StringReader(usuarios))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    lista.Items.Add("  " + linea);
                    dropdown.Items.Add(linea);
                }
            }

            //Comprobar cuantos usuarios hay para quitar o poner los botones
            if (lista.Items.Count > 7) { anadirusuariotxt.Enabled = false; anadirusuariobtn.Enabled = false; }
            else { anadirusuariotxt.Enabled = true; anadirusuariobtn.Enabled = true; }
            if (lista.Items.Count < 2) { quitarusbtn.Enabled = false; dropdown.Enabled = false; }
            else { quitarusbtn.Enabled = true; dropdown.Enabled = true; }
        }

        private void quitarusbtn_Click(object sender, EventArgs e)
        {
            if (dropdown.Text == string.Empty) MessageBox.Show("Selecciona un empleado para quitar!", _txtgesus, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar al empleado <" + dropdown.Text + ">?", _txtgesus, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    API.Comandodb("DELETE FROM Usuarios WHERE Nombre='" + dropdown.Text + "'");
                }

            }
            actualizarTabla();
            dropdown.Text = "<Escoge>";
        }


        private void dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            AcceptButton = quitarusbtn;
        }

        private void anadirusuariotxt_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = anadirusuariobtn;
            
        }
    }
}
