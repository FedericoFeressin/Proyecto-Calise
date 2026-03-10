namespace Proyecto_Calise
{
    partial class PantallaSubCategoria
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
            this.CMB_Cate_Existentes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_Descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CMB_SubCate = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_Cancelar = new FontAwesome.Sharp.IconButton();
            this.BTN_Agregar_SubCat = new FontAwesome.Sharp.IconButton();
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
            this.Panel_Cate.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CMB_Cate_Existentes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TXT_Descripcion, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CMB_SubCate, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 94);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(716, 140);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // CMB_Cate_Existentes
            // 
            this.CMB_Cate_Existentes.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_Cate_Existentes.FormattingEnabled = true;
            this.CMB_Cate_Existentes.Location = new System.Drawing.Point(361, 3);
            this.CMB_Cate_Existentes.Name = "CMB_Cate_Existentes";
            this.CMB_Cate_Existentes.Size = new System.Drawing.Size(352, 33);
            this.CMB_Cate_Existentes.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Categorías existentes:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TXT_Descripcion
            // 
            this.TXT_Descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXT_Descripcion.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Descripcion.Location = new System.Drawing.Point(361, 99);
            this.TXT_Descripcion.Name = "TXT_Descripcion";
            this.TXT_Descripcion.Size = new System.Drawing.Size(352, 33);
            this.TXT_Descripcion.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre SubCategoría:\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CMB_SubCate
            // 
            this.CMB_SubCate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMB_SubCate.FormattingEnabled = true;
            this.CMB_SubCate.Location = new System.Drawing.Point(361, 49);
            this.CMB_SubCate.Name = "CMB_SubCate";
            this.CMB_SubCate.Size = new System.Drawing.Size(352, 33);
            this.CMB_SubCate.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BTN_Cancelar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BTN_Agregar_SubCat, 0, 0);
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
            // BTN_Agregar_SubCat
            // 
            this.BTN_Agregar_SubCat.BackColor = System.Drawing.Color.LimeGreen;
            this.BTN_Agregar_SubCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Agregar_SubCat.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Agregar_SubCat.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.BTN_Agregar_SubCat.IconColor = System.Drawing.Color.Black;
            this.BTN_Agregar_SubCat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BTN_Agregar_SubCat.IconSize = 28;
            this.BTN_Agregar_SubCat.Location = new System.Drawing.Point(3, 3);
            this.BTN_Agregar_SubCat.Name = "BTN_Agregar_SubCat";
            this.BTN_Agregar_SubCat.Size = new System.Drawing.Size(218, 64);
            this.BTN_Agregar_SubCat.TabIndex = 0;
            this.BTN_Agregar_SubCat.Text = "Agregar";
            this.BTN_Agregar_SubCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Agregar_SubCat.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Agregar nueva SubCategoría";
            // 
            // PantallaSubCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 354);
            this.Controls.Add(this.Panel_Cate);
            this.Name = "PantallaSubCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaSubCategoria";
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
        private FontAwesome.Sharp.IconButton BTN_Agregar_SubCat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CMB_SubCate;
        private System.Windows.Forms.ComboBox CMB_Cate_Existentes;
        private System.Windows.Forms.Label label4;
    }
}