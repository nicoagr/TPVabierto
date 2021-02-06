///
///
///        TPVABIERTO
///        Copyright 2019-2020, Nicolás Aguado
///        
///        Todos los derechos reservados
///
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using GemBox.Document;
using System.Linq;

namespace TPVabierto
{
    public partial class Pago : Form
    {
        internal string _conf = "Configuracion";

        public Pago()
        {
            InitializeComponent();
        }

        internal static void Abrir(string subtotal, string id, string trabajador)
        {          
            Pago p = new Pago();
            p.idlabel.Visible = false;
            p.empleado.Visible = false;
            p.label1.Visible = false;

            p.idlabel.Text = id;
            p.empleado.Text = trabajador;
            p.Text = "TPVabierto [Venta] - Pago - Ticket #00" + id;

            p.ignorar1.Text = "Modulo de pago - Ticket #00" + id;

            p.total.Text = subtotal;
            p.ShowDialog();
        }

        private void cerrarimg_Click(object sender, EventArgs e)
        {
            Hide();
            Venta v = new Venta();
            v.abrirTicketconID(int.Parse(idlabel.Text), empleado.Text);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            cantidadtxt.AppendText("1");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cantidadtxt.AppendText("2");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cantidadtxt.AppendText("3");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            cantidadtxt.AppendText("4");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            cantidadtxt.AppendText("5");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            cantidadtxt.AppendText("6");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            cantidadtxt.AppendText("7");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            cantidadtxt.AppendText("8");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            cantidadtxt.AppendText("9");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            cantidadtxt.AppendText("0");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            cantidadtxt.AppendText(",");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            cantidadtxt.Clear();
            cambiogrande.Text = "0,00";
            cambio.Text = "0,00";
        }

        private void cantidadtxt_TextChanged(object sender, EventArgs e)
        {
            if (API.ComprobarSiHayLetras(cantidadtxt.Text))
            {
                cantidadtxt.Text = cantidadtxt.Text.Remove(cantidadtxt.Text.Length - 1);
            }
            else
            {
                if (cantidadtxt.Text != string.Empty)
                {
                    if (cantidadtxt.Text == ",") cantidadtxt.Text = "0,";
                    decimal c = decimal.Subtract(decimal.Parse(cantidadtxt.Text), decimal.Parse(total.Text));
                    cambio.Text = c.ToString();
                    cambiogrande.Text = cantidadtxt.Text;
                }
                else
                {
                    cantidadtxt.Clear();
                    cambiogrande.Text = "0,00";
                    cambio.Text = "0,00";
                }
            }        
        }

        private void Pago_Load(object sender, EventArgs e)
        {
            cantidadtxt.Focus();

            billete1btn.Text = API.LeerLineaEspecificaArchivo(_conf, 3) + " " + API.LeerLineaEspecificaArchivo(_conf, 2);
            billete2btn.Text = API.LeerLineaEspecificaArchivo(_conf, 4) + " " + API.LeerLineaEspecificaArchivo(_conf, 2);
            billete3btn.Text = API.LeerLineaEspecificaArchivo(_conf, 5) + " " + API.LeerLineaEspecificaArchivo(_conf, 2);
            billete4btn.Text = API.LeerLineaEspecificaArchivo(_conf, 6) + " " + API.LeerLineaEspecificaArchivo(_conf, 2);
            billete5btn.Text = API.LeerLineaEspecificaArchivo(_conf, 7) + " " + API.LeerLineaEspecificaArchivo(_conf, 2);

        }

        private void billete1btn_Click(object sender, EventArgs e)
        {
            string billete1 = API.LeerLineaEspecificaArchivo(_conf, 3);
            string b1d = billete1 + ",00";
            decimal d = decimal.Add(decimal.Parse(cambiogrande.Text), decimal.Parse(b1d));
            cambiogrande.Text = d.ToString();
            decimal c = decimal.Subtract(d, decimal.Parse(total.Text)); 
            cambio.Text = c.ToString();
            
        }

        private void billete2btn_Click(object sender, EventArgs e)
        {
            string billete2 = API.LeerLineaEspecificaArchivo(_conf, 4);
            decimal d = decimal.Add(decimal.Parse(cambiogrande.Text), decimal.Parse(billete2));
            cambiogrande.Text = d.ToString();
            decimal c = decimal.Subtract(d, decimal.Parse(total.Text));
            cambio.Text = c.ToString();
        }

        private void billete3btn_Click(object sender, EventArgs e)
        {
            string billete3 = API.LeerLineaEspecificaArchivo(_conf, 5);
            decimal d = decimal.Add(decimal.Parse(cambiogrande.Text), decimal.Parse(billete3));
            cambiogrande.Text = d.ToString();
            decimal c = decimal.Subtract(d, decimal.Parse(total.Text));
            cambio.Text = c.ToString();
        }

        private void billete4btn_Click(object sender, EventArgs e)
        {
            string billete4 = API.LeerLineaEspecificaArchivo(_conf, 6);
            decimal d = decimal.Add(decimal.Parse(cambiogrande.Text), decimal.Parse(billete4));
            cambiogrande.Text = d.ToString();
            decimal c = decimal.Subtract(d, decimal.Parse(total.Text));
            cambio.Text = c.ToString();
        }

        private void billete5btn_Click(object sender, EventArgs e)
        {
            string billete5 = API.LeerLineaEspecificaArchivo(_conf, 7);
            decimal d = decimal.Add(decimal.Parse(cambiogrande.Text), decimal.Parse(billete5));
            cambiogrande.Text = d.ToString();
            decimal c = decimal.Subtract(d, decimal.Parse(total.Text));
            cambio.Text = c.ToString();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            // Marcar el ticket como pagado
            API.Comandodb("UPDATE Tickets SET Pagado = '" + total.Text + "' WHERE id = " + idlabel.Text);

            pictureBox13.Visible = false;
            tarjeta.Visible = false;
            label1.Visible = true;
            Application.DoEvents();

            imprimirTicket(idlabel.Text);

            //Cerrar las ventanas y abrir un nuevo ticket
            if ( API.LeerLineaEspecificaArchivo(_conf, 8) == "nuevo")
            {
                // Abrir Nuevo Ticket
                Venta.CerrarVentanaVenta();
                this.Close();
                SeleccionEmpleado.Inicio();
            }
            else
            {
                VentanaPrincipal v = new VentanaPrincipal();
                Venta.CerrarVentanaVenta();
                v.Show();
                this.Close();

            }
           
        }

        private void Pago_FormClosed(object sender, FormClosedEventArgs e)
        {
            Venta v = new Venta();
            v.Close();
        }

        private void tarjeta_Click(object sender, EventArgs e)
        {
            // Marcar el ticket como pagado
            API.Comandodb("UPDATE Tickets SET Pagado = 'Tarjeta' WHERE id = " + idlabel.Text);

            pictureBox13.Visible = false;
            tarjeta.Visible = false;
            label1.Visible = true;
            Application.DoEvents();

            imprimirTicket(idlabel.Text);

            //Cerrar las ventanas y abrir un nuevo ticket
            if (API.LeerLineaEspecificaArchivo(_conf, 8) == "nuevo")
            {
                // Abrir Nuevo Ticket
                Venta.CerrarVentanaVenta();
                this.Close();
                SeleccionEmpleado.Inicio();
            }
            else
            {
                VentanaPrincipal v = new VentanaPrincipal();
                Venta.CerrarVentanaVenta();
                v.Show();
                this.Close();

            }
        }

        internal void imprimirTicket(string iddelticketaimprimir)
        {
            if (!Directory.Exists("Tickets")) Directory.CreateDirectory("Tickets");


            string textoproductos = string.Empty;

            Pago p = new Pago();
            string productostemp = API.DeXsacaYdb("Tickets", "id", iddelticketaimprimir, "Productos");
            string productos = API.ArrayToStringEnNuevaLinea(API.ComasAString(productostemp));
            // Leer la lista linea por linea
            using (StringReader reader = new StringReader(productos))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    decimal precio = decimal.Parse(API.DeXsacaYdb("Productos", "Producto", linea, "Precio"));
                    int espacios = 30 - linea.ToCharArray().Count();
                    string hueco = string.Concat(Enumerable.Repeat(" ", espacios));

                    if (textoproductos == string.Empty) textoproductos = linea + hueco + precio;
                    else textoproductos = textoproductos + Environment.NewLine + linea + hueco + precio;
                }
            }


            // Generar Texto
            string texto = 
                "---------------------------------" +
                Environment.NewLine +
                API.LeerLineaEspecificaArchivo(_conf, 1) + 
                Environment.NewLine +
                "---------------------------------" +
                Environment.NewLine +
                textoproductos +
                Environment.NewLine +
                "---------------------------------" +
                Environment.NewLine +
                "Muchas gracias por su confianza" +
                Environment.NewLine +
                "---------------------------------"

                ;


            ComponentInfo.SetLicense("FREE-LIMITED-KEY");

            // Create a new empty document.
            var document = new DocumentModel();

            // Add document content.
            document.Sections.Add(
                    new Section(document,
                    new Paragraph(document, texto)));

            // Save the generated document as PDF file.
            document.Save("Tickets/" + idlabel.Text + ".pdf");

        }
    }
}
