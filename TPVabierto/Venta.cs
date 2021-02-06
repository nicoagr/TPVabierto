///
///
///        TPVABIERTO
///        Copyright 2019-2020, Nicolás Aguado
///        
///        Todos los derechos reservados
///
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace TPVabierto
{
    public partial class Venta : Form
    {
        internal string _tpvv = "TPVabierto - Venta";
        internal string _tpvt = "TPVabierto [Venta] - Ticket #00";
        internal string _conf = "Configuracion";

        public Venta()
        {
            InitializeComponent();

            empleado.Visible = false;
            string ide = empleado.Text;
            this.id.Visible = false;
            listaproductos.Visible = false;

            //Asignar cada categoria a un botón
            string cattemp = API.ComandodbConSalida("SELECT Nombre FROM Categorias");
            cattemp = cattemp.Replace("$", Environment.NewLine);
            int cuenta = 0;
            using (StringReader reader = new StringReader(cattemp))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    cuenta++;
                    if (cuenta == 1) { cat1btn.Text = linea.ToString(); cat1btn.Visible = true; }
                    if (cuenta == 2) { cat2btn.Text = linea.ToString(); cat2btn.Visible = true; }
                    if (cuenta == 3) { cat3btn.Text = linea.ToString(); cat3btn.Visible = true; }
                    if (cuenta == 4) { cat4btn.Text = linea.ToString(); cat4btn.Visible = true; }
                    if (cuenta == 5) { cat5btn.Text = linea.ToString(); cat5btn.Visible = true; }
                    if (cuenta == 6) { cat6btn.Text = linea.ToString(); cat6btn.Visible = true; }
                    if (cuenta == 7) { cat7btn.Text = linea.ToString(); cat7btn.Visible = true; }
                }
            }
            //Ocultar los botones de categorias para que no estorben
            if (cat1btn.Text == string.Empty) { cat1btn.Visible = false; }  //Esto no se debería ejecutar, pero por si acaso
            if (cat2btn.Text == string.Empty) { cat2btn.Visible = false; }
            if (cat3btn.Text == string.Empty) { cat3btn.Visible = false; }
            if (cat4btn.Text == string.Empty) { cat4btn.Visible = false; }
            if (cat5btn.Text == string.Empty) { cat5btn.Visible = false; }
            if (cat6btn.Text == string.Empty) { cat6btn.Visible = false; }
            if (cat7btn.Text == string.Empty) { cat7btn.Visible = false; }

            if (API.DeXsacaYdb("Tickets", "id", id.Text, "Pagado") != "false")
            {
                this.Hide();
            }

        }




        private void sistemaID(string Empleado)
        {
            // Dar un ID único al ticket
            int id = int.Parse(API.ComandodbConSalida("SELECT id FROM Tickets ORDER BY id DESC LIMIT 1")) + 1;


            //Asignar ID y crear archivos y titulos
            this.id.Text = id.ToString();
            this.Text = _tpvt + id.ToString() + " // " + API.LeerLineaEspecificaArchivo(_conf, 1) + " // " + Empleado;
            numticketxt.Text = "Ticket #00" + id.ToString() + " // " + Empleado;
            moneda.Text = API.LeerLineaEspecificaArchivo(_conf, 2);
            this.empleado.Text = Empleado;

            lista.Items.Clear();

        }

        internal void abrirTicketconID(int id, string Empleado)
        {
            // Operaciones Esteticas
            this.id.Text = id.ToString();
            this.Text = _tpvt + id.ToString() + " // " + API.LeerLineaEspecificaArchivo(_conf, 1) + " // " + Empleado;
            numticketxt.Text = "Ticket #00" + id.ToString() + " // " + Empleado;
            this.empleado.Text = Empleado;
            moneda.Text = API.LeerLineaEspecificaArchivo(_conf, 2);
            //Vaciar cache
            lista.Items.Clear();
            //Conseguir la lista de productos
            string productostemp = API.DeXsacaYdb("Tickets", "id", id.ToString(), "Productos");
            string productos = API.ArrayToStringEnNuevaLinea(API.ComasAString(productostemp));
            // Leer la lista linea por linea
            using (StringReader reader = new StringReader(productos))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    decimal precio = decimal.Parse(API.DeXsacaYdb("Productos", "Producto", linea, "Precio"));
                    int c = linea.Length;
                    int espacios = 20 - c;
                    string hueco = string.Concat(Enumerable.Repeat(" ", espacios));
                    // Añadir a las listas el precio
                    lista.Items.Add(linea + hueco + precio);
                    listaproductos.Items.Add(linea);
                    // Añadir uno a uno el precio
                    decimal subtotal = decimal.Add(precio, decimal.Parse(total.Text));
                    total.Text = subtotal.ToString();
                }
            }

            this.Show();

        }


        internal void asignarEmpleado(string Empleado)
        {
            sistemaID(Empleado);
            empleado.Text = Empleado;
            API.Comandodb("INSERT INTO Tickets (id, Empleado, Fecha, Productos, Subtotal, Pagado) values (" + this.id.Text + ", '" + empleado.Text + "', '" + DateTime.Now + "', '' , '', 'false')");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Cerrar ventana y volver a abrir la otra
            VentanaPrincipal v = new VentanaPrincipal();
            Error er = new Error();
            er.Close();
            Hide();
            v.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (decimal.Parse(total.Text) == 0) Error.Aviso("El importe a cobrar no puede ser cero!");
            else
            {
                API.Comandodb("UPDATE Tickets SET Subtotal = '" + total.Text + "' WHERE id = " + id.Text);
                this.Hide();
                Pago.Abrir(total.Text, id.Text, empleado.Text);
            }
        }

        private void idtxt_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = aceptaridbtn;
        }

        private void aceptaridbtn_Click(object sender, EventArgs e)
        {


            try
            {
                // Comprobar haber si es un numero
                long.Parse(idtxt.Text);

                // Bloquear textbox para no meter nada mas antes de que haya sido procesado
                idtxt.Enabled = false;
                // Buscar en base de datos haber si está el id introducido
                if (API.BuscarenDB("Productos", "id", idtxt.Text) == true)
                {
                    //Conseguir valores

                    string producto = API.DeXsacaYdbNUM("Productos", "id", long.Parse(idtxt.Text), "Producto");
                    string precio = API.DeXsacaYdbNUM("Productos", "id", long.Parse(idtxt.Text), "Precio");

                    //Representar valores visualmente
                    decimal subtotal = decimal.Add(decimal.Parse(precio), decimal.Parse(total.Text));
                    total.Text = subtotal.ToString();

                    //Insertar producto en la lista, y añadirlo al lista virtual de solo productos
                    int c = producto.Length;
                    int espacios = 20 - c;
                    string hueco = string.Concat(Enumerable.Repeat(" ", espacios));
                    lista.Items.Add(producto + hueco + precio);
                    listaproductos.Items.Add(producto);

                    // Añadirlo a SQL
                    string cols = string.Join(",", listaproductos.Items.Cast<string>());
                    API.Comandodb("UPDATE Tickets SET Productos = '" + cols + "' WHERE id = " + id.Text); ;

                    // Para bajar la lista sola
                    lista.SelectedIndex = lista.Items.Count - 1;
                    lista.SelectedIndex = -1;


                    // Reactivar la textbox, una vez todo finalizado
                    idtxt.Enabled = true;
                    idtxt.Text = string.Empty;
                    idtxt.Focus();

                }
                // El focus llega cuando se le ha dado click al error
                else { Error.Aviso("El código introducido no se ha encontrado!"); idtxt.Enabled = true; idtxt.Text = string.Empty; }

            }
            catch { Error.Aviso("El código introducido no es un numero!"); idtxt.Enabled = true; idtxt.Text = string.Empty; }

        }


        private void Venta_Activated(object sender, System.EventArgs e)
        {
            idtxt.Focus();
        }

        private void catbtn_Click(object sender, EventArgs e)
        {
            //Limpiar todos los botones
            item1.Text = "";
            item2.Text = "";
            item3.Text = "";
            item4.Text = "";
            item5.Text = "";
            item6.Text = "";
            item7.Text = "";
            item8.Text = "";
            item9.Text = "";
            item10.Text = "";
            item11.Text = "";
            item12.Text = "";
            item13.Text = "";
            item14.Text = "";
            item15.Text = "";
            item16.Text = "";
            item17.Text = "";
            item18.Text = "";
            item19.Text = "";
            item20.Text = "";
            item21.Text = "";
            item22.Text = "";
            item23.Text = "";
            item24.Text = "";
            item25.Text = "";
            item26.Text = "";
            item27.Text = "";
            item28.Text = "";
            item29.Text = "";
            item30.Text = "";
            item31.Text = "";
            item32.Text = "";
            item33.Text = "";
            item34.Text = "";
            item35.Text = "";
            item36.Text = "";
            item37.Text = "";
            item38.Text = "";
            item39.Text = "";
            item40.Text = "";
            item41.Text = "";
            item42.Text = "";

            //Este condicional está por si se diese el caso de que se ha mostrado un boton de categoria inexistente
            if ((sender as Button).Text == string.Empty) { }
            else
            {

                // Sistema de generación de botones
                string productostemp = API.DeXsacaYdb("Categorias", "Nombre", (sender as Button).Text, "Productos");
                string productos = API.ArrayToStringEnNuevaLinea(API.ComasAString(productostemp));
                // Leer la lista linea por linea
                int cuenta = 0;
                using (StringReader reader = new StringReader(productos))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        cuenta++;
                        if (cuenta == 1) { item1.Text = linea.ToString(); item1.Visible = true; }
                        if (cuenta == 2) { item2.Text = linea.ToString(); item2.Visible = true;  }
                        if (cuenta == 3) { item3.Text = linea.ToString(); item3.Visible = true;  }
                        if (cuenta == 4) { item4.Text = linea.ToString(); item4.Visible = true;  }
                        if (cuenta == 5) { item5.Text = linea.ToString(); item5.Visible = true;  }
                        if (cuenta == 6) { item6.Text = linea.ToString(); item6.Visible = true;  }
                        if (cuenta == 7) { item7.Text = linea.ToString(); item7.Visible = true;  }
                        if (cuenta == 8) { item8.Text = linea.ToString(); item8.Visible = true;  }
                        if (cuenta == 9) { item9.Text = linea.ToString(); item9.Visible = true;  }
                        if (cuenta == 10) { item10.Text = linea.ToString(); item10.Visible = true;  }
                        if (cuenta == 11) { item11.Text = linea.ToString(); item11.Visible = true;  }
                        if (cuenta == 12) { item12.Text = linea.ToString(); item12.Visible = true;  }
                        if (cuenta == 13) { item13.Text = linea.ToString(); item13.Visible = true;  }
                        if (cuenta == 14) { item14.Text = linea.ToString(); item14.Visible = true;  }
                        if (cuenta == 15) { item15.Text = linea.ToString(); item15.Visible = true;  }
                        if (cuenta == 16) { item16.Text = linea.ToString(); item16.Visible = true;  }
                        if (cuenta == 17) { item17.Text = linea.ToString(); item17.Visible = true;  }
                        if (cuenta == 18) { item18.Text = linea.ToString(); item18.Visible = true;  }
                        if (cuenta == 19) { item19.Text = linea.ToString(); item19.Visible = true;  }
                        if (cuenta == 20) { item20.Text = linea.ToString(); item20.Visible = true;  }
                        if (cuenta == 21) { item21.Text = linea.ToString(); item21.Visible = true;  }
                        if (cuenta == 22) { item22.Text = linea.ToString(); item22.Visible = true;  }
                        if (cuenta == 23) { item23.Text = linea.ToString(); item23.Visible = true;  }
                        if (cuenta == 24) { item24.Text = linea.ToString(); item24.Visible = true;  }
                        if (cuenta == 25) { item25.Text = linea.ToString(); item25.Visible = true;  }
                        if (cuenta == 26) { item26.Text = linea.ToString(); item26.Visible = true;  }
                        if (cuenta == 27) { item27.Text = linea.ToString(); item27.Visible = true;  }
                        if (cuenta == 28) { item28.Text = linea.ToString(); item28.Visible = true;  }
                        if (cuenta == 29) { item29.Text = linea.ToString(); item29.Visible = true;  }
                        if (cuenta == 30) { item30.Text = linea.ToString(); item30.Visible = true;  }
                        if (cuenta == 31) { item31.Text = linea.ToString(); item31.Visible = true;  }
                        if (cuenta == 32) { item32.Text = linea.ToString(); item32.Visible = true;  }
                        if (cuenta == 33) { item33.Text = linea.ToString(); item33.Visible = true;  }
                        if (cuenta == 34) { item34.Text = linea.ToString(); item34.Visible = true;  }
                        if (cuenta == 35) { item35.Text = linea.ToString(); item35.Visible = true;  }
                        if (cuenta == 36) { item36.Text = linea.ToString(); item36.Visible = true;  }
                        if (cuenta == 37) { item37.Text = linea.ToString(); item37.Visible = true;  }
                        if (cuenta == 38) { item38.Text = linea.ToString(); item38.Visible = true;  }
                        if (cuenta == 39) { item39.Text = linea.ToString(); item39.Visible = true;  }
                        if (cuenta == 40) { item40.Text = linea.ToString(); item40.Visible = true;  }
                        if (cuenta == 41) { item41.Text = linea.ToString(); item41.Visible = true;  }
                        if (cuenta == 42) { item42.Text = linea.ToString(); item42.Visible = true;  }

                    }
                }

                //Poner invisibles todos los botones que no se hayan usado
                if (item1.Text == string.Empty) { item1.Visible = false; } 
                if (item2.Text == string.Empty) { item2.Visible = false; } 
                if (item3.Text == string.Empty) { item3.Visible = false; } 
                if (item4.Text == string.Empty) { item4.Visible = false; } 
                if (item5.Text == string.Empty) { item5.Visible = false; } 
                if (item6.Text == string.Empty) { item6.Visible = false; } 
                if (item7.Text == string.Empty) { item7.Visible = false; } 
                if (item8.Text == string.Empty) { item8.Visible = false; } 
                if (item9.Text == string.Empty) { item9.Visible = false; } 
                if (item10.Text == string.Empty) { item10.Visible = false; } 
                if (item11.Text == string.Empty) { item11.Visible = false; } 
                if (item12.Text == string.Empty) { item12.Visible = false; } 
                if (item13.Text == string.Empty) { item13.Visible = false; } 
                if (item14.Text == string.Empty) { item14.Visible = false; } 
                if (item15.Text == string.Empty) { item15.Visible = false; } 
                if (item16.Text == string.Empty) { item16.Visible = false; } 
                if (item17.Text == string.Empty) { item17.Visible = false; } 
                if (item18.Text == string.Empty) { item18.Visible = false; } 
                if (item19.Text == string.Empty) { item19.Visible = false; } 
                if (item20.Text == string.Empty) { item20.Visible = false; } 
                if (item21.Text == string.Empty) { item21.Visible = false; } 
                if (item22.Text == string.Empty) { item22.Visible = false; } 
                if (item23.Text == string.Empty) { item23.Visible = false; } 
                if (item24.Text == string.Empty) { item24.Visible = false; } 
                if (item25.Text == string.Empty) { item25.Visible = false; } 
                if (item26.Text == string.Empty) { item26.Visible = false; } 
                if (item27.Text == string.Empty) { item27.Visible = false; } 
                if (item28.Text == string.Empty) { item28.Visible = false; } 
                if (item29.Text == string.Empty) { item29.Visible = false; } 
                if (item30.Text == string.Empty) { item30.Visible = false; } 
                if (item31.Text == string.Empty) { item31.Visible = false; } 
                if (item32.Text == string.Empty) { item32.Visible = false; } 
                if (item33.Text == string.Empty) { item33.Visible = false; } 
                if (item34.Text == string.Empty) { item34.Visible = false; } 
                if (item35.Text == string.Empty) { item35.Visible = false; } 
                if (item36.Text == string.Empty) { item36.Visible = false; } 
                if (item37.Text == string.Empty) { item37.Visible = false; } 
                if (item38.Text == string.Empty) { item38.Visible = false; } 
                if (item39.Text == string.Empty) { item39.Visible = false; } 
                if (item40.Text == string.Empty) { item40.Visible = false; } 
                if (item41.Text == string.Empty) { item41.Visible = false; } 
                if (item42.Text == string.Empty) { item42.Visible = false; } 
            }
            idtxt.Focus();
        }


        internal static void CerrarVentanaVenta()
        {
            Pago p = new Pago();
            p.Close();
            Venta v = new Venta();
            p.FormClosed += new FormClosedEventHandler(v.Pago_FormClosed);
        }

        private void Pago_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void item_Click(object sender, EventArgs e)
        {

            // Sacar producto mediante placeholder
            string producto = (sender as Button).Text;
            if (producto == string.Empty) { }
            else
            {
                //Conseguir Precio, sumarlo y Añadir Producto
                decimal precio = decimal.Parse(API.DeXsacaYdb("Productos", "Producto", producto, "Precio"));
                decimal subtotal = decimal.Add(precio, decimal.Parse(total.Text));
                total.Text = subtotal.ToString();
                int c = producto.Length;
                int espacios = 20 - c;
                string hueco = string.Concat(Enumerable.Repeat(" ", espacios));

                // Añadir a las listas el precio
                lista.Items.Add(producto + hueco + precio);
                listaproductos.Items.Add(producto);

                // Añadirlo a SQL
                string cols = string.Join(",", listaproductos.Items.Cast<string>());
                API.Comandodb("UPDATE Tickets SET Productos = '" + cols + "' WHERE id = " + id.Text); ;

                // Para bajar la lista sola
                lista.SelectedIndex = lista.Items.Count - 1;
                lista.SelectedIndex = -1;
            }
            idtxt.Focus();
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            idtxt.Focus();
        }
    }
}
