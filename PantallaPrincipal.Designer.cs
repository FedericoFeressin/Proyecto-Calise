namespace Proyecto_Calise
{
    partial class Screen_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu_Lateral = new System.Windows.Forms.Panel();
            this.Img_Calise = new FontAwesome.Sharp.IconPictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_Prov = new FontAwesome.Sharp.IconButton();
            this.BTN_Reportes = new FontAwesome.Sharp.IconButton();
            this.BTN_Usuarios = new FontAwesome.Sharp.IconButton();
            this.BTN_Inventario = new FontAwesome.Sharp.IconButton();
            this.BTN_Stock = new FontAwesome.Sharp.IconButton();
            this.BTN_Inicio = new FontAwesome.Sharp.IconButton();
            this.Header = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Ayuda = new FontAwesome.Sharp.IconButton();
            this.Panel_User = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_Usuario = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.Panel_Princ = new System.Windows.Forms.Panel();
            this.LBL_Prueba = new System.Windows.Forms.Label();
            this.Menu_Lateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Calise)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.Header.SuspendLayout();
            this.Panel_User.SuspendLayout();
            this.Panel_Princ.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_Lateral
            // 
            this.Menu_Lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.Menu_Lateral.Controls.Add(this.Img_Calise);
            this.Menu_Lateral.Controls.Add(this.tableLayoutPanel1);
            this.Menu_Lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu_Lateral.Location = new System.Drawing.Point(0, 0);
            this.Menu_Lateral.Margin = new System.Windows.Forms.Padding(2);
            this.Menu_Lateral.Name = "Menu_Lateral";
            this.Menu_Lateral.Size = new System.Drawing.Size(172, 681);
            this.Menu_Lateral.TabIndex = 0;
            // 
            // Img_Calise
            // 
            this.Img_Calise.BackColor = System.Drawing.Color.Transparent;
            this.Img_Calise.IconChar = FontAwesome.Sharp.IconChar.Zap;
            this.Img_Calise.IconColor = System.Drawing.Color.White;
            this.Img_Calise.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Img_Calise.IconSize = 138;
            this.Img_Calise.Location = new System.Drawing.Point(12, 12);
            this.Img_Calise.Name = "Img_Calise";
            this.Img_Calise.Size = new System.Drawing.Size(145, 138);
            this.Img_Calise.TabIndex = 1;
            this.Img_Calise.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.BTN_Prov, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Reportes, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Usuarios, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Inventario, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Stock, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Inicio, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 167);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(168, 325);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BTN_Prov
            // 
            this.BTN_Prov.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Prov.FlatAppearance.BorderSize = 0;
            this.BTN_Prov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Prov.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Prov.ForeColor = System.Drawing.Color.White;
            this.BTN_Prov.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.BTN_Prov.IconColor = System.Drawing.Color.White;
            this.BTN_Prov.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Prov.IconSize = 28;
            this.BTN_Prov.Location = new System.Drawing.Point(2, 272);
            this.BTN_Prov.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Prov.Name = "BTN_Prov";
            this.BTN_Prov.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BTN_Prov.Size = new System.Drawing.Size(164, 41);
            this.BTN_Prov.TabIndex = 5;
            this.BTN_Prov.Text = "Proveedores";
            this.BTN_Prov.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Prov.UseVisualStyleBackColor = true;
            // 
            // BTN_Reportes
            // 
            this.BTN_Reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Reportes.FlatAppearance.BorderSize = 0;
            this.BTN_Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Reportes.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Reportes.ForeColor = System.Drawing.Color.White;
            this.BTN_Reportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.BTN_Reportes.IconColor = System.Drawing.Color.White;
            this.BTN_Reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Reportes.IconSize = 28;
            this.BTN_Reportes.Location = new System.Drawing.Point(2, 218);
            this.BTN_Reportes.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Reportes.Name = "BTN_Reportes";
            this.BTN_Reportes.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BTN_Reportes.Size = new System.Drawing.Size(164, 41);
            this.BTN_Reportes.TabIndex = 4;
            this.BTN_Reportes.Text = "Reportes";
            this.BTN_Reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Reportes.UseVisualStyleBackColor = true;
            // 
            // BTN_Usuarios
            // 
            this.BTN_Usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Usuarios.FlatAppearance.BorderSize = 0;
            this.BTN_Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Usuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Usuarios.ForeColor = System.Drawing.Color.White;
            this.BTN_Usuarios.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.BTN_Usuarios.IconColor = System.Drawing.Color.White;
            this.BTN_Usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Usuarios.IconSize = 28;
            this.BTN_Usuarios.Location = new System.Drawing.Point(2, 164);
            this.BTN_Usuarios.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Usuarios.Name = "BTN_Usuarios";
            this.BTN_Usuarios.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BTN_Usuarios.Size = new System.Drawing.Size(164, 41);
            this.BTN_Usuarios.TabIndex = 3;
            this.BTN_Usuarios.Text = "Usuarios";
            this.BTN_Usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Usuarios.UseVisualStyleBackColor = true;
            // 
            // BTN_Inventario
            // 
            this.BTN_Inventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Inventario.FlatAppearance.BorderSize = 0;
            this.BTN_Inventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Inventario.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Inventario.ForeColor = System.Drawing.Color.White;
            this.BTN_Inventario.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.BTN_Inventario.IconColor = System.Drawing.Color.White;
            this.BTN_Inventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Inventario.IconSize = 28;
            this.BTN_Inventario.Location = new System.Drawing.Point(2, 110);
            this.BTN_Inventario.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Inventario.Name = "BTN_Inventario";
            this.BTN_Inventario.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BTN_Inventario.Size = new System.Drawing.Size(164, 41);
            this.BTN_Inventario.TabIndex = 2;
            this.BTN_Inventario.Text = "Inventario";
            this.BTN_Inventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Inventario.UseVisualStyleBackColor = true;
            // 
            // BTN_Stock
            // 
            this.BTN_Stock.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Stock.FlatAppearance.BorderSize = 0;
            this.BTN_Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Stock.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Stock.ForeColor = System.Drawing.Color.White;
            this.BTN_Stock.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.BTN_Stock.IconColor = System.Drawing.Color.White;
            this.BTN_Stock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Stock.IconSize = 28;
            this.BTN_Stock.Location = new System.Drawing.Point(2, 56);
            this.BTN_Stock.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Stock.Name = "BTN_Stock";
            this.BTN_Stock.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BTN_Stock.Size = new System.Drawing.Size(164, 41);
            this.BTN_Stock.TabIndex = 1;
            this.BTN_Stock.Text = "Stock";
            this.BTN_Stock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Stock.UseVisualStyleBackColor = true;
            // 
            // BTN_Inicio
            // 
            this.BTN_Inicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Inicio.FlatAppearance.BorderSize = 0;
            this.BTN_Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Inicio.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Inicio.ForeColor = System.Drawing.Color.White;
            this.BTN_Inicio.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.BTN_Inicio.IconColor = System.Drawing.Color.White;
            this.BTN_Inicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Inicio.IconSize = 28;
            this.BTN_Inicio.Location = new System.Drawing.Point(2, 2);
            this.BTN_Inicio.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Inicio.Name = "BTN_Inicio";
            this.BTN_Inicio.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BTN_Inicio.Size = new System.Drawing.Size(164, 41);
            this.BTN_Inicio.TabIndex = 0;
            this.BTN_Inicio.Text = "Inicio";
            this.BTN_Inicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Inicio.UseVisualStyleBackColor = true;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.Header.Controls.Add(this.label3);
            this.Header.Controls.Add(this.BTN_Ayuda);
            this.Header.Controls.Add(this.Panel_User);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(172, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(2);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1092, 50);
            this.Header.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(412, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Software Calise";
            // 
            // BTN_Ayuda
            // 
            this.BTN_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTN_Ayuda.IconChar = FontAwesome.Sharp.IconChar.CircleQuestion;
            this.BTN_Ayuda.IconColor = System.Drawing.Color.Black;
            this.BTN_Ayuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Ayuda.IconSize = 34;
            this.BTN_Ayuda.Location = new System.Drawing.Point(883, 8);
            this.BTN_Ayuda.Name = "BTN_Ayuda";
            this.BTN_Ayuda.Size = new System.Drawing.Size(52, 38);
            this.BTN_Ayuda.TabIndex = 1;
            this.BTN_Ayuda.UseVisualStyleBackColor = true;
            // 
            // Panel_User
            // 
            this.Panel_User.BackColor = System.Drawing.Color.White;
            this.Panel_User.Controls.Add(this.label1);
            this.Panel_User.Controls.Add(this.label2);
            this.Panel_User.Controls.Add(this.LBL_Usuario);
            this.Panel_User.Controls.Add(this.Titulo);
            this.Panel_User.Location = new System.Drawing.Point(938, 6);
            this.Panel_User.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_User.Name = "Panel_User";
            this.Panel_User.Size = new System.Drawing.Size(152, 40);
            this.Panel_User.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Administrador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(2, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rol:";
            // 
            // LBL_Usuario
            // 
            this.LBL_Usuario.AutoSize = true;
            this.LBL_Usuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Usuario.ForeColor = System.Drawing.Color.Black;
            this.LBL_Usuario.Location = new System.Drawing.Point(51, 2);
            this.LBL_Usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_Usuario.Name = "LBL_Usuario";
            this.LBL_Usuario.Size = new System.Drawing.Size(74, 17);
            this.LBL_Usuario.TabIndex = 1;
            this.LBL_Usuario.Text = "Juan Perez";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.Black;
            this.Titulo.Location = new System.Drawing.Point(2, 2);
            this.Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(59, 17);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Usuario:";
            // 
            // Panel_Princ
            // 
            this.Panel_Princ.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Princ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Panel_Princ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Princ.Controls.Add(this.LBL_Prueba);
            this.Panel_Princ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Princ.Location = new System.Drawing.Point(172, 50);
            this.Panel_Princ.Margin = new System.Windows.Forms.Padding(2);
            this.Panel_Princ.Name = "Panel_Princ";
            this.Panel_Princ.Size = new System.Drawing.Size(1092, 631);
            this.Panel_Princ.TabIndex = 2;
            // 
            // LBL_Prueba
            // 
            this.LBL_Prueba.AutoSize = true;
            this.LBL_Prueba.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Prueba.ForeColor = System.Drawing.Color.Black;
            this.LBL_Prueba.Location = new System.Drawing.Point(444, 257);
            this.LBL_Prueba.Name = "LBL_Prueba";
            this.LBL_Prueba.Size = new System.Drawing.Size(137, 47);
            this.LBL_Prueba.TabIndex = 0;
            this.LBL_Prueba.Text = "Prueba";
            // 
            // Screen_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Panel_Princ);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Menu_Lateral);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Screen_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Menu_Lateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Img_Calise)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.Panel_User.ResumeLayout(false);
            this.Panel_User.PerformLayout();
            this.Panel_Princ.ResumeLayout(false);
            this.Panel_Princ.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu_Lateral;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton BTN_Inicio;
        private System.Windows.Forms.Panel Panel_Princ;
        private FontAwesome.Sharp.IconButton BTN_Prov;
        private FontAwesome.Sharp.IconButton BTN_Reportes;
        private FontAwesome.Sharp.IconButton BTN_Usuarios;
        private FontAwesome.Sharp.IconButton BTN_Inventario;
        private FontAwesome.Sharp.IconButton BTN_Stock;
        private System.Windows.Forms.Panel Panel_User;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBL_Usuario;
        private System.Windows.Forms.Label Titulo;
        private FontAwesome.Sharp.IconButton BTN_Ayuda;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox Img_Calise;
        private System.Windows.Forms.Label LBL_Prueba;
    }
}

