namespace Proyecto_Calise
{
    partial class PantallaInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_Inventario = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_Regreso = new FontAwesome.Sharp.IconButton();
            this.BTN_Agregar_Cat = new FontAwesome.Sharp.IconButton();
            this.BTN_Agregar_SubCat = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_Baja = new FontAwesome.Sharp.IconButton();
            this.BTN_Modi = new FontAwesome.Sharp.IconButton();
            this.BTN_Alta = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CMB_SubCate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_Stock_Inve = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_Nom_Inve = new System.Windows.Forms.TextBox();
            this.CMB_Categoria = new System.Windows.Forms.ComboBox();
            this.CMB_Prov = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Panel_Inventario.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Inventario
            // 
            this.Panel_Inventario.Controls.Add(this.panel2);
            this.Panel_Inventario.Controls.Add(this.panel1);
            this.Panel_Inventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Inventario.Location = new System.Drawing.Point(0, 0);
            this.Panel_Inventario.Name = "Panel_Inventario";
            this.Panel_Inventario.Size = new System.Drawing.Size(1092, 631);
            this.Panel_Inventario.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(555, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 607);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(522, 601);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.BTN_Regreso);
            this.panel1.Controls.Add(this.BTN_Agregar_Cat);
            this.panel1.Controls.Add(this.BTN_Agregar_SubCat);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 607);
            this.panel1.TabIndex = 0;
            // 
            // BTN_Regreso
            // 
            this.BTN_Regreso.FlatAppearance.BorderSize = 0;
            this.BTN_Regreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Regreso.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            this.BTN_Regreso.IconColor = System.Drawing.Color.Black;
            this.BTN_Regreso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Regreso.IconSize = 32;
            this.BTN_Regreso.Location = new System.Drawing.Point(11, 23);
            this.BTN_Regreso.Name = "BTN_Regreso";
            this.BTN_Regreso.Size = new System.Drawing.Size(56, 45);
            this.BTN_Regreso.TabIndex = 8;
            this.BTN_Regreso.UseVisualStyleBackColor = true;
            // 
            // BTN_Agregar_Cat
            // 
            this.BTN_Agregar_Cat.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Agregar_Cat.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BTN_Agregar_Cat.IconColor = System.Drawing.Color.Green;
            this.BTN_Agregar_Cat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Agregar_Cat.IconSize = 28;
            this.BTN_Agregar_Cat.Location = new System.Drawing.Point(468, 184);
            this.BTN_Agregar_Cat.Name = "BTN_Agregar_Cat";
            this.BTN_Agregar_Cat.Size = new System.Drawing.Size(44, 43);
            this.BTN_Agregar_Cat.TabIndex = 7;
            this.BTN_Agregar_Cat.UseVisualStyleBackColor = false;
            // 
            // BTN_Agregar_SubCat
            // 
            this.BTN_Agregar_SubCat.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Agregar_SubCat.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BTN_Agregar_SubCat.IconColor = System.Drawing.Color.Green;
            this.BTN_Agregar_SubCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Agregar_SubCat.IconSize = 28;
            this.BTN_Agregar_SubCat.Location = new System.Drawing.Point(468, 255);
            this.BTN_Agregar_SubCat.Name = "BTN_Agregar_SubCat";
            this.BTN_Agregar_SubCat.Size = new System.Drawing.Size(44, 43);
            this.BTN_Agregar_SubCat.TabIndex = 6;
            this.BTN_Agregar_SubCat.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.BTN_Baja, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTN_Modi, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTN_Alta, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 507);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(519, 58);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // BTN_Baja
            // 
            this.BTN_Baja.BackColor = System.Drawing.Color.Red;
            this.BTN_Baja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Baja.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Baja.ForeColor = System.Drawing.Color.Black;
            this.BTN_Baja.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.BTN_Baja.IconColor = System.Drawing.Color.Black;
            this.BTN_Baja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Baja.IconSize = 24;
            this.BTN_Baja.Location = new System.Drawing.Point(349, 3);
            this.BTN_Baja.Name = "BTN_Baja";
            this.BTN_Baja.Size = new System.Drawing.Size(167, 52);
            this.BTN_Baja.TabIndex = 2;
            this.BTN_Baja.Text = "Eliminar";
            this.BTN_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Baja.UseVisualStyleBackColor = false;
            // 
            // BTN_Modi
            // 
            this.BTN_Modi.BackColor = System.Drawing.Color.SteelBlue;
            this.BTN_Modi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Modi.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Modi.ForeColor = System.Drawing.Color.Black;
            this.BTN_Modi.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.BTN_Modi.IconColor = System.Drawing.Color.Black;
            this.BTN_Modi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Modi.IconSize = 24;
            this.BTN_Modi.Location = new System.Drawing.Point(176, 3);
            this.BTN_Modi.Name = "BTN_Modi";
            this.BTN_Modi.Size = new System.Drawing.Size(167, 52);
            this.BTN_Modi.TabIndex = 1;
            this.BTN_Modi.Text = "Modificar";
            this.BTN_Modi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Modi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Modi.UseVisualStyleBackColor = false;
            // 
            // BTN_Alta
            // 
            this.BTN_Alta.BackColor = System.Drawing.Color.LimeGreen;
            this.BTN_Alta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Alta.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Alta.ForeColor = System.Drawing.Color.Black;
            this.BTN_Alta.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.BTN_Alta.IconColor = System.Drawing.Color.Black;
            this.BTN_Alta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Alta.IconSize = 24;
            this.BTN_Alta.Location = new System.Drawing.Point(3, 3);
            this.BTN_Alta.Name = "BTN_Alta";
            this.BTN_Alta.Size = new System.Drawing.Size(167, 52);
            this.BTN_Alta.TabIndex = 0;
            this.BTN_Alta.Text = "Agregar";
            this.BTN_Alta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Alta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Alta.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(104, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(331, 45);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ingreso de productos";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CMB_SubCate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TXT_Stock_Inve, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TXT_Nom_Inve, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CMB_Categoria, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CMB_Prov, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(43, 98);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(419, 356);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // CMB_SubCate
            // 
            this.CMB_SubCate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CMB_SubCate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_SubCate.FormattingEnabled = true;
            this.CMB_SubCate.Location = new System.Drawing.Point(212, 161);
            this.CMB_SubCate.Name = "CMB_SubCate";
            this.CMB_SubCate.Size = new System.Drawing.Size(204, 33);
            this.CMB_SubCate.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 72);
            this.label5.TabIndex = 8;
            this.label5.Text = "Proveedor:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_Stock_Inve
            // 
            this.TXT_Stock_Inve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_Stock_Inve.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Stock_Inve.Location = new System.Drawing.Point(212, 234);
            this.TXT_Stock_Inve.Name = "TXT_Stock_Inve";
            this.TXT_Stock_Inve.Size = new System.Drawing.Size(204, 29);
            this.TXT_Stock_Inve.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 71);
            this.label4.TabIndex = 6;
            this.label4.Text = "Stock:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 71);
            this.label3.TabIndex = 4;
            this.label3.Text = "SubCategoría:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 71);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoría:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_Nom_Inve
            // 
            this.TXT_Nom_Inve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_Nom_Inve.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Nom_Inve.Location = new System.Drawing.Point(212, 21);
            this.TXT_Nom_Inve.Name = "TXT_Nom_Inve";
            this.TXT_Nom_Inve.Size = new System.Drawing.Size(204, 29);
            this.TXT_Nom_Inve.TabIndex = 1;
            // 
            // CMB_Categoria
            // 
            this.CMB_Categoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CMB_Categoria.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_Categoria.FormattingEnabled = true;
            this.CMB_Categoria.Location = new System.Drawing.Point(212, 90);
            this.CMB_Categoria.Name = "CMB_Categoria";
            this.CMB_Categoria.Size = new System.Drawing.Size(204, 33);
            this.CMB_Categoria.TabIndex = 10;
            // 
            // CMB_Prov
            // 
            this.CMB_Prov.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CMB_Prov.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_Prov.FormattingEnabled = true;
            this.CMB_Prov.Location = new System.Drawing.Point(212, 305);
            this.CMB_Prov.Name = "CMB_Prov";
            this.CMB_Prov.Size = new System.Drawing.Size(204, 29);
            this.CMB_Prov.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(3, 460);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(519, 10);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(3, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(519, 10);
            this.panel3.TabIndex = 0;
            // 
            // PantallaInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 631);
            this.Controls.Add(this.Panel_Inventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PantallaInventario";
            this.Panel_Inventario.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Inventario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_Nom_Inve;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_Stock_Inve;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton BTN_Baja;
        private FontAwesome.Sharp.IconButton BTN_Modi;
        private FontAwesome.Sharp.IconButton BTN_Alta;
        private FontAwesome.Sharp.IconButton BTN_Agregar_SubCat;
        private FontAwesome.Sharp.IconButton BTN_Agregar_Cat;
        private System.Windows.Forms.ComboBox CMB_SubCate;
        private System.Windows.Forms.ComboBox CMB_Categoria;
        private FontAwesome.Sharp.IconButton BTN_Regreso;
        private System.Windows.Forms.ComboBox CMB_Prov;
    }
}