namespace MedicPagos
{
    partial class ListaDetalladaPrepagas
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
            this.dgv_ListaDetalle = new System.Windows.Forms.DataGridView();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.ListBox_ListaPrepagasFinanz = new System.Windows.Forms.ListBox();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListaDetalle
            // 
            this.dgv_ListaDetalle.AllowUserToAddRows = false;
            this.dgv_ListaDetalle.AllowUserToDeleteRows = false;
            this.dgv_ListaDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_ListaDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ListaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaDetalle.Location = new System.Drawing.Point(221, 58);
            this.dgv_ListaDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_ListaDetalle.Name = "dgv_ListaDetalle";
            this.dgv_ListaDetalle.RowHeadersVisible = false;
            this.dgv_ListaDetalle.Size = new System.Drawing.Size(356, 206);
            this.dgv_ListaDetalle.TabIndex = 33;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(218, 38);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(51, 16);
            this.label31.TabIndex = 34;
            this.label31.Text = "Detalle";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(13, 16);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(119, 16);
            this.label32.TabIndex = 6;
            this.label32.Text = "Lista de PrePagas";
            // 
            // ListBox_ListaPrepagasFinanz
            // 
            this.ListBox_ListaPrepagasFinanz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ListBox_ListaPrepagasFinanz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_ListaPrepagasFinanz.FormattingEnabled = true;
            this.ListBox_ListaPrepagasFinanz.ItemHeight = 15;
            this.ListBox_ListaPrepagasFinanz.Location = new System.Drawing.Point(16, 36);
            this.ListBox_ListaPrepagasFinanz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListBox_ListaPrepagasFinanz.Name = "ListBox_ListaPrepagasFinanz";
            this.ListBox_ListaPrepagasFinanz.Size = new System.Drawing.Size(179, 334);
            this.ListBox_ListaPrepagasFinanz.TabIndex = 35;
            this.ListBox_ListaPrepagasFinanz.SelectedIndexChanged += new System.EventHandler(this.ListBox_ListaPrepagasFinanz_SelectedIndexChanged);
            // 
            // txt_Total
            // 
            this.txt_Total.Enabled = false;
            this.txt_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total.Location = new System.Drawing.Point(455, 271);
            this.txt_Total.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(121, 22);
            this.txt_Total.TabIndex = 22;
            this.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(339, 274);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(108, 16);
            this.label33.TabIndex = 21;
            this.label33.Text = "Total facturado $";
            // 
            // ListaDetalladaPrepagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(633, 388);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.dgv_ListaDetalle);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.ListBox_ListaPrepagasFinanz);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(649, 427);
            this.MinimumSize = new System.Drawing.Size(649, 427);
            this.Name = "ListaDetalladaPrepagas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Detallada";
            this.Load += new System.EventHandler(this.ListaDetalladaPrepagas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListaDetalle;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        public System.Windows.Forms.ListBox ListBox_ListaPrepagasFinanz;
    }
}