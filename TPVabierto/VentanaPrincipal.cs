///
///
///        TPVABIERTO
///        Copyright 2019-2020, Nicolás Aguado
///        
///        Todos los derechos reservados
///

using System;
using System.IO;
using System.Windows.Forms;
using TPVabierto;
using System.Net;
using System.Data.SQLite;

namespace TPVabierto
{
    public partial class VentanaPrincipal : Form
    {

        internal string _conf = "Configuracion";
        public VentanaPrincipal()
        {
            InitializeComponent();

            ///// Finalizando instalacion abajo
            if (!File.Exists(_conf))
            {
                API.CrearArchivo(_conf);
                API.AgregarAArchivo("EmpresaEjemplo", _conf);
                API.AgregarAArchivo("€", _conf);
                API.AgregarAArchivo("1", _conf);
                API.AgregarAArchivo("2", _conf);
                API.AgregarAArchivo("5", _conf);
                API.AgregarAArchivo("10", _conf);
                API.AgregarAArchivo("20", _conf);
                API.AgregarAArchivo("menu", _conf);
                

            }

            if (!Directory.Exists("x86\\"))
            {
                AcabandoInstalacion a = new AcabandoInstalacion();
                a.Show();
            Retry:
                if ((System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable()))
                {
                    WebClient w = new WebClient();
                    Directory.CreateDirectory("x86");
                    Directory.CreateDirectory("x64");

                    w.DownloadFile("https://dl.polinomio.net/librerias/x86/SQLite.Interop.dll", "x86\\SQLite.Interop.dll");
                    w.DownloadFile("https://dl.polinomio.net/librerias/x64/SQLite.Interop.dll", "x64\\SQLite.Interop.dll");
                    a.Hide();

                }
                else
                {
                    DialogResult result = MessageBox.Show("Por favor, conectate a internet para descargar los archivos restantes", "TPVabierto - Instalación", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Cancel) Environment.Exit(0);
                    if (result == DialogResult.Retry) goto Retry;
                }

                
            }

            if (File.Exists("Datos.sqlite")) { }
            else
            {
                AcabandoInstalacion a = new AcabandoInstalacion();
                a.Show();
                if (!File.Exists("Inslock"))
                {
                    API.CrearArchivo("Inslock");
                    System.Diagnostics.Process.Start(Application.ExecutablePath);
                    Close();
                }
                
                SQLiteConnection.CreateFile("Datos.sqlite");
                API.Comandodb("CREATE TABLE Tickets (id int, Empleado varchar(255), Fecha varchar(255), Productos MEDIUMTEXT, Subtotal int, Pagado TINYTEXT)");
                API.Comandodb("CREATE TABLE Productos (id BIGINT, Producto MEDIUMTEXT, Precio varchar(255), Categoria varchar(255))");
                API.Comandodb("CREATE TABLE Categorias (Nombre varchar(255), Productos MEDIUMTEXT)");
                API.Comandodb("CREATE TABLE Usuarios (id int, Nombre varchar(255))");

                API.Comandodb("INSERT INTO Usuarios (id, Nombre) values('1', 'Nico')");
                API.Comandodb("INSERT INTO Usuarios (id, Nombre) values('2', 'Marta')");
                API.Comandodb("INSERT INTO Usuarios (id, Nombre) values('3', 'Raúl')");
                API.Comandodb("INSERT INTO Usuarios (id, Nombre) values('4', 'Ana')");
                API.Comandodb("INSERT INTO Tickets (id, Empleado, Fecha, Productos, Subtotal, Pagado) values('0', 'Aplicaciones Octocero', '" + DateTime.Now + "', 'TPVabierto', '404,00', 'egg')");
                API.Comandodb("INSERT INTO Productos(id, Producto, Precio, Categoria) values('1', 'Calculadora', '4,50', 'Oficina')");
                API.Comandodb("INSERT INTO Productos(id, Producto, Precio, Categoria) values('2', 'Bolígrafo', '0,40', 'Oficina')");
                API.Comandodb("INSERT INTO Productos(id, Producto, Precio, Categoria) values('3', 'Goma', '1,50', 'Oficina')");
                API.Comandodb("INSERT INTO Productos(id, Producto, Precio, Categoria) values('4', 'Rotulador', '2,50', 'Oficina')");
                API.Comandodb("INSERT INTO Productos(id, Producto, Precio, Categoria) values('5', 'Pack de folios', '0,99', 'Oficina')");
                API.Comandodb("INSERT INTO Productos(id, Producto, Precio, Categoria) values('4005808801039', 'Nivea Creme', '3,20', 'Parafarmacia')");
                API.Comandodb("INSERT INTO Productos(id, Producto, Precio, Categoria) values('8714789968551', 'Desodorante SX', '2,20', 'Parafarmacia')");
                API.Comandodb("INSERT INTO Productos(id, Producto, Precio, Categoria) values('8410436249256', 'Espuma Afeitar', '4,80', 'Parafarmacia')");
                API.Comandodb("INSERT INTO Productos(id, Producto, Precio, Categoria) values('3600540581655', 'Gomina Fructis', '1,75', 'Parafarmacia')");
                API.Comandodb("INSERT INTO Productos(id, Producto, Precio, Categoria) values('4084500569140', 'Laca Pantene', '5,60', 'Parafarmacia')");
                API.Comandodb("INSERT INTO Productos(id, Producto, Precio, Categoria) values('8480000441232', 'Cera Hacendado', '2,50', 'Parafarmacia')");
                API.Comandodb("INSERT INTO Categorias(Nombre, Productos) values('Oficina', 'Calculadora,Bolígrafo,Goma,Rotulador,Pack de folios')");
                API.Comandodb("INSERT INTO Categorias(Nombre, Productos) values('Parafarmacia', 'Nivea Creme,Desodorante SX,Espuma Afeitar,Gomina Fructis,Laca Pantene,Cera Hacendado')");
                a.Hide();
            }

            

            /// Procesos iniciales
            label2.Text = "Aplicaciones Octocero // " + API.LeerLineaEspecificaArchivo(_conf, 1);
            nuevoticketbtn.Focus();

        }


        private void usuariosbtn_Click(object sender, EventArgs e)
        {
            GestionUsuarios g = new GestionUsuarios();
            Hide();
            g.ShowDialog();
        }

        private void productosbtn_Click(object sender, EventArgs e)
        {
            Hide();
            GestionProductos g = new GestionProductos();
            g.Show();
        }

        private void iniciarimagen_Click(object sender, EventArgs e)
        {
            Hide();
            SeleccionEmpleado.Inicio();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void confgenbtn_Click(object sender, EventArgs e)
        {
            Hide();
            ConfGen v = new ConfGen();
            v.ShowDialog();
            
        }

        private void calibrarbtn_Click(object sender, EventArgs e)
        {
            Calibrar c = new Calibrar();
            c.ShowDialog();
        }

        private void nuevoticketbtn_Click(object sender, EventArgs e)
        {
            Hide();
            SeleccionEmpleado.Inicio();
        }

        private void verticket_Click(object sender, EventArgs e)
        {
            Hide();
            VerTicket vt = new VerTicket();
            vt.Show();
        }
    }
}
