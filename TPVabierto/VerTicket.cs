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
    public partial class VerTicket : Form
    {
        public VerTicket()
        {
            InitializeComponent();
            id.Visible = false;
            empleado.Visible = false;
            listaproductos.Visible = false;
            reabrir.Visible = false;
            ticketnumtxt.Visible = false;
            empleadotxt.Visible = false;
            fechatxt.Visible = false;
            totaltxt.Visible = false;
            totaltxt.Text = "00,00 " + API.LeerLineaEspecificaArchivo("Configuracion", 2);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            cantidadtxt.Clear();
        }

        private void cerrarimg_Click(object sender, EventArgs e)
        {
            VentanaPrincipal v = new VentanaPrincipal();
            v.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void cargarticketimg_Click(object sender, EventArgs e)
        {
            //Comprobar si el ticket esta en la base de datos
            if(API.BuscarenDB("Tickets","id",cantidadtxt.Text) == false) { Error.AvisoDialog("El ID introducido no está en la base de datos!"); }
            else
            {
                //Cuando SI esta, introducir datos básicos
                string vendedor = API.DeXsacaYdb("Tickets", "id", cantidadtxt.Text, "Empleado");
                id.Text = cantidadtxt.Text;
                ticketnumtxt.Text = "Ticket #00" + cantidadtxt.Text;
                fechatxt.Text = "Venta realizada el " + API.DeXsacaYdb("Tickets","id",cantidadtxt.Text, "Fecha");
                empleadotxt.Text = "Venta realizada por " + vendedor;
                empleado.Text = vendedor;
                //Hacer que se vean los datos básicos
                ticketnumtxt.Visible = true;
                empleadotxt.Visible = true;
                fechatxt.Visible = true;
                totaltxt.Visible = true;
                //Ocultar reabrir para solo mostrarlo si el ticket no ha sido cerrado
                reabrir.Visible = false;

                //Vaciar cache
                lista.Items.Clear();
                listaproductos.Items.Clear();
                //Importante cambiar el texto del total a sin moneda (no procesa bien el sumar x a "00,00 €")
                totaltxt.Text = "00,00";
                //Conseguir la lista de productos
                string productostemp = API.DeXsacaYdb("Tickets", "id", id.Text, "Productos");
                string productos = API.ArrayToStringEnNuevaLinea(API.ComasAString(productostemp));
                // Leer la lista linea por linea
                using (StringReader reader = new StringReader(productos))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        if (linea == "TPVabierto") { lista.Items.Add("TPVabierto       404,00"); }
                        else
                        {
                            decimal precio = decimal.Parse(API.DeXsacaYdb("Productos", "Producto", linea, "Precio"));
                            int c = linea.Length;
                            int espacios = 20 - c;
                            string hueco = string.Concat(Enumerable.Repeat(" ", espacios));
                            // Añadir a las listas el precio
                            lista.Items.Add(linea + hueco + precio);
                            listaproductos.Items.Add(linea);
                            decimal subtotal = decimal.Add(precio, decimal.Parse(totaltxt.Text));
                            totaltxt.Text = subtotal.ToString();
                        }
                    }
                }
                lista.Items.Add("----------------------------");
                if (API.DeXsacaYdb("Tickets", "id", id.Text, "Pagado") == "false") { lista.Items.Add("La venta no se ha"); lista.Items.Add("finalizado (pendiente)"); reabrir.Visible = true; }
                else if (API.DeXsacaYdb("Tickets", "id", id.Text, "Pagado") == totaltxt.Text) { lista.Items.Add("Pagado en efectivo"); }
                else if (API.DeXsacaYdb("Tickets", "id", id.Text, "Pagado") == "Tarjeta") { lista.Items.Add("Pagado con tarjeta"); }
                else if (API.DeXsacaYdb("Tickets", "id", id.Text, "Pagado") == "egg") { lista.Items.Add("Producto activado"); }
                else { lista.Items.Add("Método de pago desconocido"); }
                lista.Items.Add("----------------------------");
                totaltxt.Text = totaltxt.Text + " " + API.LeerLineaEspecificaArchivo("Configuracion", 2);

            }
            cantidadtxt.Clear();
        }

        private void reabrir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Venta v = new Venta();
            v.abrirTicketconID(int.Parse(id.Text), this.empleado.Text);
        }
    }
}
