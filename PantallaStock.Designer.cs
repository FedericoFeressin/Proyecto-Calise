namespace Proyecto_Calise
{
    partial class PantallaStock
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
            this.Panel_Stock = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_Categoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_Nom = new System.Windows.Forms.TextBox();
            this.BTN_Buscar_Stock = new FontAwesome.Sharp.IconButton();
            this.TXT_SubCate = new System.Windows.Forms.TextBox();
            this.BTN_Regreso = new FontAwesome.Sharp.IconButton();
            this.Panel_Stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Stock
            // 
            this.Panel_Stock.BackColor = System.Drawing.Color.White;
            this.Panel_Stock.Controls.Add(this.BTN_Regreso);
            this.Panel_Stock.Controls.Add(this.dataGridView1);
            this.Panel_Stock.Controls.Add(this.tableLayoutPanel1);
            this.Panel_Stock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Stock.Location = new System.Drawing.Point(0, 0);
            this.Panel_Stock.Name = "Panel_Stock";
            this.Panel_Stock.Size = new System.Drawing.Size(1092, 631);
            this.Panel_Stock.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1086, 565);
            this.dataGridView1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66594F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66594F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66594F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66594F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66594F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.67031F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.TXT_Categoria, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TXT_Nom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BTN_Buscar_Stock, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.TXT_SubCate, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(62, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1030, 45);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(631, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 45);
            this.label3.TabIndex = 4;
            this.label3.Text = "SubCategoría:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_Categoria
            // 
            this.TXT_Categoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_Categoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Categoria.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Categoria.Location = new System.Drawing.Point(474, 8);
            this.TXT_Categoria.Name = "TXT_Categoria";
            this.TXT_Categoria.Size = new System.Drawing.Size(151, 29);
            this.TXT_Categoria.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(317, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoría:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_Nom
            // 
            this.TXT_Nom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_Nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Nom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Nom.Location = new System.Drawing.Point(160, 8);
            this.TXT_Nom.Name = "TXT_Nom";
            this.TXT_Nom.Size = new System.Drawing.Size(151, 29);
            this.TXT_Nom.TabIndex = 1;
            // 
            // BTN_Buscar_Stock
            // 
            this.BTN_Buscar_Stock.BackColor = System.Drawing.Color.Chartreuse;
            this.BTN_Buscar_Stock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Buscar_Stock.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.BTN_Buscar_Stock.IconColor = System.Drawing.Color.Black;
            this.BTN_Buscar_Stock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Buscar_Stock.IconSize = 34;
            this.BTN_Buscar_Stock.Location = new System.Drawing.Point(945, 3);
            this.BTN_Buscar_Stock.Name = "BTN_Buscar_Stock";
            this.BTN_Buscar_Stock.Size = new System.Drawing.Size(82, 39);
            this.BTN_Buscar_Stock.TabIndex = 6;
            this.BTN_Buscar_Stock.UseVisualStyleBackColor = false;
            // 
            // TXT_SubCate
            // 
            this.TXT_SubCate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_SubCate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_SubCate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_SubCate.Location = new System.Drawing.Point(788, 8);
            this.TXT_SubCate.Name = "TXT_SubCate";
            this.TXT_SubCate.Size = new System.Drawing.Size(151, 29);
            this.TXT_SubCate.TabIndex = 5;
            // 
            // BTN_Regreso
            // 
            this.BTN_Regreso.FlatAppearance.BorderSize = 0;
            this.BTN_Regreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Regreso.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            this.BTN_Regreso.IconColor = System.Drawing.Color.Black;
            this.BTN_Regreso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Regreso.IconSize = 32;
            this.BTN_Regreso.Location = new System.Drawing.Point(3, 3);
            this.BTN_Regreso.Name = "BTN_Regreso";
            this.BTN_Regreso.Size = new System.Drawing.Size(56, 45);
            this.BTN_Regreso.TabIndex = 2;
            this.BTN_Regreso.UseVisualStyleBackColor = true;
            // 
            // PantallaStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1092, 631);
            this.Controls.Add(this.Panel_Stock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PantallaStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PantallaStock";
            this.Panel_Stock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Stock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TXT_SubCate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_Categoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_Nom;
        private FontAwesome.Sharp.IconButton BTN_Buscar_Stock;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton BTN_Regreso;
    }
}