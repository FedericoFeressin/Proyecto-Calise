using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Calise
{
    public partial class PantallaCategoria : Form
    {
        public PantallaCategoria()
        {
            InitializeComponent();

            // Registrar el evento del botón Cancelar
            this.BTN_Cancelar.Click += BTN_Cancelar_Click;
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario y devolver DialogResult.Cancel para quienes lo abran con ShowDialog
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
