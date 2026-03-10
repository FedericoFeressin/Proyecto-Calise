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
    public partial class PantallaProveedores : Form
    {
        public PantallaProveedores()
        {
            InitializeComponent();

            // Registrar evento de regreso
            this.BTN_Regreso.Click += BTN_Regreso_Click;

            // Registrar eventos básicos para botones de acción (placeholders)
            this.BTN_Alta.Click += BTN_Alta_Click;
            this.BTN_Modi.Click += BTN_Modi_Click;
            this.BTN_Baja.Click += BTN_Baja_Click;
        }
        #region Eventos clicks de los botones para funcionalidad

        private void BTN_Regreso_Click(object sender, EventArgs e)
        {
            // Intentar obtener el formulario principal a través de TopLevelControl
            var main = this.TopLevelControl as Screen_Principal;
            if (main != null)
            {
                main.ReturnToHome();
                return;
            }

            // Intentar recorrer los padres hasta encontrar Screen_Principal
            Control parent = this.Parent;
            while (parent != null && !(parent is Screen_Principal))
            {
                parent = parent.Parent;
            }

            if (parent is Screen_Principal sp)
            {
                sp.ReturnToHome();
            }
            else
            {
                // Último recurso: cerrar el formulario
                this.Close();
            }
        }


        #endregion

        #region Eventos Clicks de los botones para acciones de alta, baja y modificación (placeholders)
        private void BTN_Alta_Click(object sender, EventArgs e)
        {
            // implementar lógica de agregar proveedor
        }

        private void BTN_Modi_Click(object sender, EventArgs e)
        {
            // implementar lógica de modificar proveedor
        }

        private void BTN_Baja_Click(object sender, EventArgs e)
        {
            // implementar lógica de eliminar proveedor
        }


        #endregion



    }
}
