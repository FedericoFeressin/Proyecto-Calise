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
    public partial class PantallaInventario : Form
    {
        public PantallaInventario()
        {
            InitializeComponent();

            // Registrar eventos de los botones
            this.BTN_Agregar_Cat.Click += BTN_Agregar_Cat_Click;
            this.BTN_Agregar_SubCat.Click += BTN_Agregar_SubCate_Click;
            // Registrar evento de regreso
            this.BTN_Regreso.Click += BTN_Regreso_Click;
        }

        #region Eventos Clicks de los botones para funcionalidad 

        private void BTN_Agregar_Cat_Click(object sender, EventArgs e)
        {
            // Abrir PantallaCategoria como diálogo modal
            using (var form = new PantallaCategoria())
            {
                form.ShowDialog(this);
            }
        }

        private void BTN_Agregar_SubCate_Click(object sender, EventArgs e)
        {
            // Abrir PantallaSubCategoria como diálogo modal
            using (var form = new PantallaSubCategoria())
            {
                form.ShowDialog(this);
            }
        }

        private void BTN_Regreso_Click(object sender, EventArgs e)
        {
            // Intentar obtener el formulario principal a través de TopLevelControl
            var main = this.TopLevelControl as Screen_Principal;
            if (main != null)
            {
                main.ReturnToHome();
            }
            else
            {
                // Intentar recorrer los forms padres hasta encontrar Screen_Principal
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
        }
        #endregion
    }
}
