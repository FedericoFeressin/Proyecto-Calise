namespace Proyecto_Calise
{
    partial class PantallaCategoria
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
            this.Panel_Cate = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TXT_Descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CMB_Nom_Cate = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_Cancelar = new FontAwesome.Sharp.IconButton();
            this.BTN_Agregar_Cat = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Panel_Cate.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Cate
            // 
            this.Panel_Cate.Controls.Add(this.tableLayoutPanel1);
            this.Panel_Cate.Controls.Add(this.tableLayoutPanel2);
            this.Panel_Cate.Controls.Add(this.label3);
            this.Panel_Cate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Cate.Location = new System.Drawing.Point(0, 0);
            this.Panel_Cate.Name = "Panel_Cate";
            this.Panel_Cate.Size = new System.Drawing.Size(740, 354);
            this.Panel_Cate.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TXT_Descripcion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CMB_Nom_Cate, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 94);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(716, 140);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // TXT_Descripcion
            // 
            this.TXT_Descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_Descripcion.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Descripcion.Location = new System.Drawing.Point(361, 88);
            this.TXT_Descripcion.Name = "TXT_Descripcion";
            this.TXT_Descripcion.Size = new System.Drawing.Size(352, 33);
            this.TXT_Descripcion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 70);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CMB_Nom_Cate
            // 
            this.CMB_Nom_Cate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CMB_Nom_Cate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_Nom_Cate.FormattingEnabled = true;
            this.CMB_Nom_Cate.Location = new System.Drawing.Point(361, 34);
            this.CMB_Nom_Cate.Name = "CMB_Nom_Cate";
            this.CMB_Nom_Cate.Size = new System.Drawing.Size(352, 33);
            this.CMB_Nom_Cate.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BTN_Cancelar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTN_Agregar_Cat, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(144, 251);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(449, 70);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.BackColor = System.Drawing.Color.Red;
            this.BTN_Cancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Cancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Cancelar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.BTN_Cancelar.IconColor = System.Drawing.Color.Black;
            this.BTN_Cancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Cancelar.Location = new System.Drawing.Point(227, 3);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(219, 64);
            this.BTN_Cancelar.TabIndex = 1;
            this.BTN_Cancelar.Text = "Cancelar";
            this.BTN_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Cancelar.UseVisualStyleBackColor = false;
            this.BTN_Cancelar.Click += new System.EventHandler(this.BTN_Cancelar_Click);
            // 
            // BTN_Agregar_Cat
            // 
            this.BTN_Agregar_Cat.BackColor = System.Drawing.Color.LimeGreen;
            this.BTN_Agregar_Cat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Agregar_Cat.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Agregar_Cat.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.BTN_Agregar_Cat.IconColor = System.Drawing.Color.Black;
            this.BTN_Agregar_Cat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Agregar_Cat.IconSize = 28;
            this.BTN_Agregar_Cat.Location = new System.Drawing.Point(3, 3);
            this.BTN_Agregar_Cat.Name = "BTN_Agregar_Cat";
            this.BTN_Agregar_Cat.Size = new System.Drawing.Size(218, 64);
            this.BTN_Agregar_Cat.TabIndex = 0;
            this.BTN_Agregar_Cat.Text = "Agregar";
            this.BTN_Agregar_Cat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Agregar_Cat.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Agregar nueva categoría";
            // 
            // PantallaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(740, 354);
            this.Controls.Add(this.Panel_Cate);
            this.MaximizeBox = false;
            this.Name = "PantallaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaCategoria";
            this.Panel_Cate.ResumeLayout(false);
            this.Panel_Cate.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Cate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TXT_Descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconButton BTN_Cancelar;
        private FontAwesome.Sharp.IconButton BTN_Agregar_Cat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CMB_Nom_Cate;
    }
}