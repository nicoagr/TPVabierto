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
    public partial class AcabandoInstalacion : Form
    {
        public AcabandoInstalacion()
        {
            InitializeComponent(); 
        }

        private void AcabandoInstalacion_Load(object sender, EventArgs e)
        {
            this.Activated += AfterLoading;
        }

        private void AfterLoading(object sender, EventArgs e)
        {
            this.Activated -= AfterLoading;
            Application.DoEvents();
        }
    }
}
