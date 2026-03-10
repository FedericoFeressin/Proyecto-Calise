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
    public partial class Screen_Principal : Form
    {
        // Guarda el form hijo actualmente abierta
        private Form currentChildForm = null;

        // Guarda una copia de los controles iniciales del panel principal para restaurarlos al volver al inicio
        private Control[] initialPanelControls;

        public Screen_Principal()
        {
            InitializeComponent();

            // Capturar controles iniciales del panel (antes de agregar forms hijos)
            initialPanelControls = Panel_Princ.Controls.Cast<Control>().ToArray();
            // Registrar el evento del botón después de InitializeComponent
            this.BTN_Stock.Click += BTN_Stock_Click;
            this.BTN_Inicio.Click += BTN_Inicio_Click;
            this.BTN_Inventario.Click += BTN_Inventario_Click;
            this.BTN_Prov.Click += BTN_Prov_Click; // registrar evento para Proveedores
        }

        #region Eventos Clicks de los botones para funcionalidad

        private void BTN_Stock_Click(object sender, EventArgs e)
        {
            // Abre el form PantallaStock dentro del panel Panel_Princ
            OpenChildFormInPanel(new PantallaStock());
        }

        private void BTN_Inicio_Click(object sender, EventArgs e)
        {
            // Método público para volver al inicio
            ReturnToHome();
        }

        // Método público que otros formularios pueden llamar para volver al inicio
        public void ReturnToHome() // puede ser llamado desde forms hijos para volver al inicio
        {
            if (currentChildForm != null) 
            // Cierra el form hijo si existe y limpia el panel principal
            {
                currentChildForm.Close(); // Cierra el form para liberar recursos
                currentChildForm.Dispose(); // Libera los recursos asociados al form
                currentChildForm = null; // Limpia la referencia al form hijo actual
            }

            // Limpiar controles actuales
            Panel_Princ.Controls.Clear();

            // Restaurar los controles iniciales guardados (si existen)
            if (initialPanelControls != null && initialPanelControls.Length > 0)
            {
                Panel_Princ.Controls.AddRange(initialPanelControls); // Agrega los controles iniciales de nuevo al panel
                // Asegurar que queden visibles y al frente
                foreach (Control c in initialPanelControls) // Asegura que los controles iniciales estén visibles y al frente
                {
                    c.Visible = true;
                    c.BringToFront();
                }
            }
        }

        private void BTN_Inventario_Click(object sender, EventArgs e)
        {
            // Abre el form PantallaInventario dentro del panel Panel_Princ
            OpenChildFormInPanel(new PantallaInventario());
        }

        private void BTN_Prov_Click(object sender, EventArgs e)
        {
            // Abre el form PantallaProveedores dentro del panel Panel_Princ
            OpenChildFormInPanel(new PantallaProveedores());
        }

        // Método privado para abrir un form hijo dentro del panel principal, cerrando el anterior si existe
        private void OpenChildFormInPanel(Form childForm)
        {
            // Cerrar y liberar el form anterior si existe
            if (currentChildForm != null)
            {
                currentChildForm.Close(); // Cierra el form para liberar recursos
                currentChildForm.Dispose(); // Libera los recursos asociados al form
            }

            currentChildForm = childForm; // Actualiza la referencia al form hijo actual

            // Configurar el form para mostrarla en el panel
            childForm.TopLevel = false;                       // permite que se añada a un control
            childForm.FormBorderStyle = FormBorderStyle.None; // quitar borde para apariencia integrada
            childForm.Dock = DockStyle.Fill;                  // ocupar todo el panel

            // Para limpiar los controles previos si es necesario y añadir el nuevo form al panel  
            Panel_Princ.Controls.Clear();
            Panel_Princ.Controls.Add(childForm); // Añade el nuevo form al panel
            childForm.Show(); // Muestra el form hijo
            childForm.BringToFront(); // Asegura que el form hijo esté al frente
        }

        #endregion


    }
}
