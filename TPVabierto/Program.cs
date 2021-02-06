///
///
///        TPVABIERTO
///        Copyright 2019-2020, Nicolás Aguado
///        
///        Todos los derechos reservados
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPVabierto
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new VentanaPrincipal());
            }
            catch (Exception e)    
            {
                /// Solo para tareas de depuracion
                 MessageBox.Show(e.ToString());
            }
            
        }

    }

}
