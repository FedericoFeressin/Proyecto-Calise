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
    public partial class PantallaStock : Form
    {
        public PantallaStock()
        {
            InitializeComponent();

            // Registrar evento de regreso
            this.BTN_Regreso.Click += BTN_Regreso_Click;
        }

        #region Eventos Clicks de los botones para funcionalidad

        private void BTN_Regreso_Click(object sender, EventArgs e)
        {
            // Intentar obtener el formulario principal a través de TopLevelControl
            var main = this.TopLevelControl as Screen_Principal; // Intentar obtener el formulario principal a través de TopLevelControl
            if (main != null) // Si se encontró el formulario principal, llamar al método para regresar a la pantalla principal
            {
                main.ReturnToHome(); // Llamar al método para regresar a la pantalla principal
            }
            else
            {
                // Intentar recorrer los forms padres hasta encontrar Screen_Principal
                Control parent = this.Parent; // Empezar con el form padre de inmediato
                while (parent != null && !(parent is Screen_Principal))
                {
                    parent = parent.Parent;
                }

                if (parent is Screen_Principal sp) // Si se encontró el formulario principal, llamar al método para regresar a la pantalla principal
                {
                    sp.ReturnToHome(); // Llamar al método para regresar a la pantalla principal
                }
                else
                {
                    // Último recurso: cerrar el formulario
                    this.Close();
                }
            }
        }

        #endregion

    }
}
