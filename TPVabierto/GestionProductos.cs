///
///
///        TPVABIERTO
///        Copyright 2019-2020, Nicolás Aguado
///        
///        Todos los derechos reservados
///


using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TPVabierto
{
    public partial class GestionProductos : Form
    {
        internal string _txtgespr = "TPVabierto [Gestion] - Productos";
        internal string _pr = "Productos.txt";
        public GestionProductos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            VentanaPrincipal v = new VentanaPrincipal();
            Hide();
            v.Show();
        }

        private void anadirusuariotxt_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = anadirusuariobtn;
        }

        internal void actualizarTabla()
        {
            // Actualizar Tabla
            try
            {
                // Adaptadores y definiciones diversas
                lista.Items.Clear();
                dropdown.Items.Clear();
                SQLiteConnection conn = new SQLiteConnection(("Data Source=Datos.sqlite;Version=3;"));
                conn.Open();
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Productos", conn);
                DataSet ds = new DataSet();
                
                da.Fill(ds, "Productos");
                dataGridView1.DataSource = ds.Tables[0];

                // Ajustar desplegables
                //dropdown1.DisplayMember = "Nombre";
                //dropdown1.ValueMember = "Nombre";
                //dropdown1.DataSource = ds3.Tables[0];
                //dropdown2.DisplayMember = "Nombre";
                //dropdown2.ValueMember = "Nombre";
                //dropdown2.DataSource = ds3.Tables[0];

                // Redimensionar columnas
                DataGridViewColumn column3 = dataGridView1.Columns[2];
                column3.Width = 55;
                conn.Close();

                //Extraer todas las categorías y almacenarlas en una string
                string Categorias = API.ComandodbConSalida("SELECT Nombre FROM Categorias");
                Categorias = Categorias.Replace("$", Environment.NewLine);
                //Leer una por una las categorias
                using (StringReader reader = new StringReader(Categorias))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        //Esto de los puntos es simplemente cosmetico, para mostrar/ocutar los dos puntos en la lista de categorias
                        string puntos = "";
                        if (checkBox1.Checked == true) { puntos = " :"; }
                        dropdown.Items.Add(linea);
                        lista.Items.Add("-----------------");
                        lista.Items.Add(linea + puntos);

                        //Solo poner los productos en la lista si la checkbox está marcada
                        if (checkBox1.Checked == true)
                        {
                            //Extraer todos los productos y almacenarlos en una string
                            string productos = API.DeXsacaYdb("Categorias", "Nombre", linea, "Productos");
                            productos = productos.Replace(",", Environment.NewLine);
                            productos = productos.Replace("$", Environment.NewLine);
                            //Leer uno por uno los productos
                            using (StringReader reader2 = new StringReader(productos))
                            {
                                string linea2;
                                while ((linea2 = reader2.ReadLine()) != null)
                                {
                                    lista.Items.Add("  " + linea2);
                                }
                            }
                        }                        

                        lista.Items.Add("-----------------");
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TPVabierto - Error SQLite", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            // Bloquear categoria cuando solo queda una
            if (API.TotalLineasDB("Categorias") == 1)
            {
                quitarcatbtn.Enabled = false;
                dropdown.Enabled = false;
            }
            else
            {
                quitarcatbtn.Enabled = true;
                dropdown.Enabled = true;
            }
            if (API.TotalLineasDB("Categorias") == 7)
            {
                anadircatbtn.Enabled = false;
                categoriatxt.Enabled = false;
            }
            else
            {
                anadircatbtn.Enabled = true;
                categoriatxt.Enabled = true;
            }

        }


        private void anadirusuariobtn_Click(object sender, EventArgs e)
        {

            // Formatos incorrectos, etc
            if (idtxt.Text == "") { MessageBox.Show("Error - Todos los campos tienen que estar rellenados!", _txtgespr, MessageBoxButtons.OK, MessageBoxIcon.Stop); goto Fin; }
            if (productotxt.Text == "") { MessageBox.Show("Error - Todos los campos tienen que estar rellenados!", _txtgespr, MessageBoxButtons.OK, MessageBoxIcon.Stop); goto Fin; }
            if (preciotxt.Text == "") { MessageBox.Show("Error - Todos los campos tienen que estar rellenados!", _txtgespr, MessageBoxButtons.OK, MessageBoxIcon.Stop); goto Fin; }
            try { long.Parse(idtxt.Text); } catch { MessageBox.Show("Error - Formato incorrecto (Código)", _txtgespr, MessageBoxButtons.OK, MessageBoxIcon.Stop); goto Fin; }
            try { decimal.Parse(preciotxt.Text); } catch { MessageBox.Show("Error - Formato incorrecto (Precio)", _txtgespr, MessageBoxButtons.OK, MessageBoxIcon.Stop); goto Fin; }
            if (!API.BuscarenDB("Categorias", "Nombre", anadirprcattxt.Text)) { MessageBox.Show("Error - No se ha encontrado la categoría", _txtgespr, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); goto Fin; }


                /// Ver si está repetido el id
                try
            {

                actualizarTabla();
                    if (API.BuscarenDB("Productos", "id", idtxt.Text) == true)
                    {
                        MessageBox.Show("El código ya existe en la base de datos!", _txtgespr, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                    API.Comandodb("INSERT INTO Productos(id, Producto, Precio, Categoria) values('" + idtxt.Text + "', '" + productotxt.Text + "', '" + preciotxt.Text + "', '" + anadirprcattxt.Text + "')");

                    // Procesar el añadir el producto a la base de datos de categorías
                        // Si el texto está vacio, no procesar nada de comas y meterlo directamente
                    if (API.DeXsacaYdb("Categorias", "Nombre", anadirprcattxt.Text, "Productos") == string.Empty)
                    {
                        API.Comandodb("UPDATE Categorias SET Productos = '" + productotxt.Text + "' WHERE Nombre = '" + anadirprcattxt.Text + "'");
                    }
                    else
                        // En cambio, si no está vacio, procesar, añadir comas, etc..
                    {
                        string[] sincomas = API.StringToArray(API.DeXsacaYdb("Categorias", "Nombre", anadirprcattxt.Text, "Productos"));
                        string[] productoaanadir = API.StringToArray(productotxt.Text); ;
                        int array1OriginalLength = sincomas.Length;
                        Array.Resize(ref sincomas, array1OriginalLength + productoaanadir.Length);
                        Array.Copy(productoaanadir, 0, sincomas, array1OriginalLength, productoaanadir.Length);

                        API.Comandodb("UPDATE Categorias SET Productos = '" + string.Join(",", sincomas) + "' WHERE Nombre = '" + anadirprcattxt.Text + "'");
                    }

                }
                actualizarTabla();
                idtxt.Clear();
                productotxt.Clear();
                preciotxt.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TPVabierto - Error de Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        Fin:;
        }


        private void quitarusbtn_Click(object sender, EventArgs e)
        {
            if (quitarpr.Text == string.Empty) MessageBox.Show("El campo no puede estar en blanco!", _txtgespr, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (API.BuscarenDB("Productos", "id", quitarpr.Text) == true)
                {
                    DialogResult result = MessageBox.Show("Realmente quieres borrar el producto?", _txtgespr, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)                  
                    {
                        // Buscar el producto y quitarlo de categorias en SQL
                        string catproducto = API.DeXsacaYdb("Productos", "id", quitarpr.Text, "Categoria");
                        string producto = API.DeXsacaYdb("Productos", "id", quitarpr.Text, "Producto");
                        string concomas = API.DeXsacaYdb("Categorias", "Nombre", catproducto, "Productos");
                        concomas = concomas.Replace("," + producto, string.Empty);
                        API.Comandodb("UPDATE Categorias SET Productos = '" + concomas + "' WHERE Nombre = '" + catproducto + "'");
                        //Fallback para poder eliminar el primer producto de cada categoría
                        concomas = concomas.Replace(producto, string.Empty);
                        API.Comandodb("UPDATE Categorias SET Productos = '" + concomas + "' WHERE Nombre = '" + catproducto + "'");

                        //Quitarlo de la tabla "Productos" en SQL
                        API.Comandodb("DELETE FROM Productos WHERE id = '" + quitarpr.Text + "'");
                        //Limpiar texto y re-focusear
                        quitarpr.Clear();
                        pictureBox1.Focus();
                    }

                }
                else MessageBox.Show("Error - No se ha encontrado el ID introducido en la base de datos", _txtgespr, MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
            }
            actualizarTabla();
        }

        private void quitarpr_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = quitarusbtn;
        }

        private void GestionProductos_Load(object sender, EventArgs e)
        {
            this.Activated += AfterLoading;
        }

        private void AfterLoading(object sender, EventArgs e)
        {
            this.Activated -= AfterLoading;
            actualizarTabla();
        }

        private void quitarcatbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Realmente quieres borrar la categoría? Esto eliminará todos los productos que estén en la categoría. Esta acción es irreversible.", _txtgespr, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                if (API.BuscarenDB("Categorias", "Nombre", dropdown.Text))
                {
                    try
                    {
                        //Leer todos los productos que hay en la categoría, e ir uno por uno eliminándolos
                        string productos = API.DeXsacaYdb("Categorias", "Nombre", dropdown.Text, "Productos");
                        productos = productos.Replace(",", Environment.NewLine);
                        productos = productos.Replace("$", Environment.NewLine);
                        //Leer uno por uno los productos
                        using (StringReader reader2 = new StringReader(productos))
                        {
                            string linea;
                            while ((linea = reader2.ReadLine()) != null)
                            {
                                API.Comandodb("DELETE FROM Productos WHERE Producto = '" + linea + "'");
                            }
                        }

                        //Eliminar la categoría
                        API.Comandodb("DELETE FROM Categorias WHERE Nombre = '" + dropdown.Text + "'");
                    }
                    catch(Exception ex) { MessageBox.Show("Error SQLite, por favor, ponte en contacto con el soporte técnico. Código de error: " + ex.Message, _txtgespr, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); }
                    
                }
                //Este comando nunca se debería ejecutar, está aquí por si acaso
                else { MessageBox.Show("Error - No se ha encontrado la categoría", _txtgespr, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); }
            }
            actualizarTabla();
        }

        private void anadircatbtn_Click(object sender, EventArgs e)
        {
            if (API.BuscarenDB("Categorias", "Nombre", categoriatxt.Text)) { MessageBox.Show("Esta categoría ya existe!", _txtgespr, MessageBoxButtons.OK, MessageBoxIcon.Error); goto Fin; }
            if (categoriatxt.Text == string.Empty) { MessageBox.Show("El campo no puede estar en blanco!", _txtgespr, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); goto Fin; }
            API.Comandodb("INSERT INTO Categorias(Nombre, Productos) values('" + categoriatxt.Text +"', '')");
            actualizarTabla();
        Fin:;
        }

        private void categoriatxt_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = anadircatbtn;
        }

        private void dropdown_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = quitarcatbtn;
        }

        private void anadirprcattxt_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = anadirusuariobtn;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            actualizarTabla();
        }
    }
}
