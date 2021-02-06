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
using System.IO;

namespace TPVabierto
{
    public partial class SeleccionEmpleado : Form
    {

        public SeleccionEmpleado()
        {
            InitializeComponent();
            Text = "TPVabierto [Venta] - Seleccion de Empleado - Nuevo Ticket";
            //Solución para convertir los empleados de string a array, estan separados por $
            //con lo cual simplemente hacemos que string[] se forme separando por $
            string tempempleados = API.ComandodbConSalida("SELECT Nombre FROM Usuarios");
            string[] empleados = new string[] {""};
            empleados = tempempleados.Split('$');

            int lineastot = API.TotalLineasDB("Usuarios");
            if (lineastot > 4)
            {
                Size = new Size(685, 408);
                volverimg.Location = new Point(13, 125);
                for (var i = 0; i < empleados.Length; i += 1)
                {
                    var line = empleados[i];
                    int x = 115 * i;
                    if (i > 3)
                    {
                        Button btnf = new Button();
                        btnf.Font = new Font("Arial", 17);
                        btnf.Location = new Point(180 + x - 460, 200);
                        btnf.Name = line;
                        btnf.Size = new Size(109, 100);
                        btnf.TabIndex = 7;
                        btnf.Text = line;
                        btnf.UseVisualStyleBackColor = true;
                        btnf.Click += (sender, args) =>
                        {
                            Venta v = new Venta();
                            v.asignarEmpleado(line);
                            Hide();
                            v.Show();
                        };
                        Controls.Add(btnf);
                    }
                    else
                    {
                        Button btn = new Button();
                        btn.Font = new Font("Arial", 17);
                        btn.Location = new Point(180 + x, 55);
                        btn.Name = line;
                        btn.Size = new Size(109, 100);
                        btn.TabIndex = 7;
                        btn.Text = line;
                        btn.UseVisualStyleBackColor = true;
                        btn.Click += (sender, args) =>
                        {
                            Venta v = new Venta();
                            v.asignarEmpleado(line);
                            Hide();
                            v.Show();
                        };
                        Controls.Add(btn);
                    }

                }
            }
            else
            {
                Size = new Size(685, 266);
                volverimg.Location = new Point(30, 53);
                for (var i = 0; i < empleados.Length; i += 1)
                {
                    var line = empleados[i];
                    int x = 115 * i;

                    Button btn = new Button();
                    btn.Font = new Font("Arial", 17);
                    btn.Location = new Point(180 + x, 55);
                    btn.Name = line;
                    btn.Size = new Size(109, 100);
                    btn.TabIndex = 7;
                    btn.Text = line;
                    btn.UseVisualStyleBackColor = true;
                    btn.Click += (sender, args) =>
                    {
                        Venta v = new Venta();
                        v.asignarEmpleado(line);
                        Hide();
                        v.Show();
                    };
                    Controls.Add(btn);
                }
            }

        }

        internal static void Inicio()
        {
            int lineastot = API.TotalLineasDB("Usuarios");
            if (lineastot == 1)
            {
                Venta v = new Venta();
                v.asignarEmpleado(API.ComandodbConSalida("SELECT Nombre FROM Usuarios"));
                v.Show();
            }
            else
            {
                SeleccionEmpleado s = new SeleccionEmpleado();
                s.Show();
            }
        }


        private void volverimg_Click(object sender, EventArgs e)
        {
            Hide();
            VentanaPrincipal v = new VentanaPrincipal();
            v.Show();
        }
    }
}
