namespace MedicPagos
{
    partial class ListaDetalladaOrdenes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_ListaAulas = new System.Windows.Forms.Label();
            this.dgv_ListaOrdenes = new System.Windows.Forms.DataGridView();
            this.dgv_CheckBoxListOrdenes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgv_DetalleOrden = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TotalLista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TotalDetalle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboB_filtroMes = new System.Windows.Forms.ComboBox();
            this.Lb_a_NroAula = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckB_Particulares = new System.Windows.Forms.CheckBox();
            this.label46 = new System.Windows.Forms.Label();
            this.ComboB_PrePaga = new System.Windows.Forms.ComboBox();
            this.txt_CodPre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaOrdenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetalleOrden)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_ListaAulas
            // 
            this.label_ListaAulas.AutoSize = true;
            this.label_ListaAulas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ListaAulas.Location = new System.Drawing.Point(42, 75);
            this.label_ListaAulas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ListaAulas.Name = "label_ListaAulas";
            this.label_ListaAulas.Size = new System.Drawing.Size(165, 16);
            this.label_ListaAulas.TabIndex = 6;
            this.label_ListaAulas.Text = "Lista de Ordenes Medicas";
            // 
            // dgv_ListaOrdenes
            // 
            this.dgv_ListaOrdenes.AllowUserToAddRows = false;
            this.dgv_ListaOrdenes.AllowUserToDeleteRows = false;
            this.dgv_ListaOrdenes.AllowUserToResizeColumns = false;
            this.dgv_ListaOrdenes.AllowUserToResizeRows = false;
            this.dgv_ListaOrdenes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_ListaOrdenes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ListaOrdenes.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListaOrdenes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ListaOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_ListaOrdenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_CheckBoxListOrdenes});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ListaOrdenes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ListaOrdenes.EnableHeadersVisualStyles = false;
            this.dgv_ListaOrdenes.Location = new System.Drawing.Point(45, 95);
            this.dgv_ListaOrdenes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_ListaOrdenes.Name = "dgv_ListaOrdenes";
            this.dgv_ListaOrdenes.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_ListaOrdenes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ListaOrdenes.RowHeadersVisible = false;
            this.dgv_ListaOrdenes.RowHeadersWidth = 15;
            this.dgv_ListaOrdenes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_ListaOrdenes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ListaOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListaOrdenes.Size = new System.Drawing.Size(656, 182);
            this.dgv_ListaOrdenes.TabIndex = 16;
            this.dgv_ListaOrdenes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dgv_ListaOrdenes_CellMouseClick);
            this.dgv_ListaOrdenes.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ListaOrdenes_ColumnHeaderMouseClick);
            // 
            // dgv_CheckBoxListOrdenes
            // 
            this.dgv_CheckBoxListOrdenes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CheckBoxListOrdenes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_CheckBoxListOrdenes.HeaderText = "";
            this.dgv_CheckBoxListOrdenes.Name = "dgv_CheckBoxListOrdenes";
            this.dgv_CheckBoxListOrdenes.ReadOnly = true;
            this.dgv_CheckBoxListOrdenes.Width = 5;
            // 
            // dgv_DetalleOrden
            // 
            this.dgv_DetalleOrden.AllowUserToAddRows = false;
            this.dgv_DetalleOrden.AllowUserToDeleteRows = false;
            this.dgv_DetalleOrden.AllowUserToResizeColumns = false;
            this.dgv_DetalleOrden.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_DetalleOrden.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_DetalleOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_DetalleOrden.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_DetalleOrden.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DetalleOrden.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_DetalleOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_DetalleOrden.EnableHeadersVisualStyles = false;
            this.dgv_DetalleOrden.Location = new System.Drawing.Point(16, 318);
            this.dgv_DetalleOrden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_DetalleOrden.Name = "dgv_DetalleOrden";
            this.dgv_DetalleOrden.ReadOnly = true;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_DetalleOrden.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_DetalleOrden.RowHeadersVisible = false;
            this.dgv_DetalleOrden.RowHeadersWidth = 15;
            this.dgv_DetalleOrden.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_DetalleOrden.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_DetalleOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DetalleOrden.Size = new System.Drawing.Size(457, 129);
            this.dgv_DetalleOrden.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 298);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Detalle de la Orden";
            // 
            // txt_TotalLista
            // 
            this.txt_TotalLista.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_TotalLista.Enabled = false;
            this.txt_TotalLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalLista.Location = new System.Drawing.Point(597, 284);
            this.txt_TotalLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TotalLista.MaxLength = 8;
            this.txt_TotalLista.Name = "txt_TotalLista";
            this.txt_TotalLista.Size = new System.Drawing.Size(103, 22);
            this.txt_TotalLista.TabIndex = 42;
            this.txt_TotalLista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 287);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Total facturado $";
            // 
            // txt_TotalDetalle
            // 
            this.txt_TotalDetalle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_TotalDetalle.Enabled = false;
            this.txt_TotalDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalDetalle.Location = new System.Drawing.Point(369, 453);
            this.txt_TotalDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TotalDetalle.MaxLength = 8;
            this.txt_TotalDetalle.Name = "txt_TotalDetalle";
            this.txt_TotalDetalle.Size = new System.Drawing.Size(103, 22);
            this.txt_TotalDetalle.TabIndex = 44;
            this.txt_TotalDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 456);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Total de la orden $";
            // 
            // ComboB_filtroMes
            // 
            this.ComboB_filtroMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboB_filtroMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboB_filtroMes.FormattingEnabled = true;
            this.ComboB_filtroMes.IntegralHeight = false;
            this.ComboB_filtroMes.Items.AddRange(new object[] {
            "Seleccionar",
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.ComboB_filtroMes.Location = new System.Drawing.Point(60, 20);
            this.ComboB_filtroMes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboB_filtroMes.Name = "ComboB_filtroMes";
            this.ComboB_filtroMes.Size = new System.Drawing.Size(153, 24);
            this.ComboB_filtroMes.TabIndex = 46;
            this.ComboB_filtroMes.SelectedIndexChanged += new System.EventHandler(this.ComboB_filtroMes_SelectedIndexChanged);
            // 
            // Lb_a_NroAula
            // 
            this.Lb_a_NroAula.AutoSize = true;
            this.Lb_a_NroAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_a_NroAula.Location = new System.Drawing.Point(18, 23);
            this.Lb_a_NroAula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lb_a_NroAula.Name = "Lb_a_NroAula";
            this.Lb_a_NroAula.Size = new System.Drawing.Size(34, 16);
            this.Lb_a_NroAula.TabIndex = 45;
            this.Lb_a_NroAula.Text = "Mes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckB_Particulares);
            this.groupBox1.Controls.Add(this.label46);
            this.groupBox1.Controls.Add(this.ComboB_PrePaga);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(259, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(443, 66);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // CheckB_Particulares
            // 
            this.CheckB_Particulares.AutoSize = true;
            this.CheckB_Particulares.Enabled = false;
            this.CheckB_Particulares.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckB_Particulares.Location = new System.Drawing.Point(317, 25);
            this.CheckB_Particulares.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckB_Particulares.Name = "CheckB_Particulares";
            this.CheckB_Particulares.Size = new System.Drawing.Size(98, 20);
            this.CheckB_Particulares.TabIndex = 48;
            this.CheckB_Particulares.Text = "Particulares";
            this.CheckB_Particulares.UseVisualStyleBackColor = true;
            this.CheckB_Particulares.CheckedChanged += new System.EventHandler(this.CheckB_Particulares_CheckedChanged);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(23, 26);
            this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(68, 16);
            this.label46.TabIndex = 31;
            this.label46.Text = "Prepagas";
            // 
            // ComboB_PrePaga
            // 
            this.ComboB_PrePaga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboB_PrePaga.Enabled = false;
            this.ComboB_PrePaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboB_PrePaga.FormattingEnabled = true;
            this.ComboB_PrePaga.IntegralHeight = false;
            this.ComboB_PrePaga.Location = new System.Drawing.Point(99, 22);
            this.ComboB_PrePaga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboB_PrePaga.Name = "ComboB_PrePaga";
            this.ComboB_PrePaga.Size = new System.Drawing.Size(169, 24);
            this.ComboB_PrePaga.TabIndex = 2;
            this.ComboB_PrePaga.SelectedIndexChanged += new System.EventHandler(this.cb_PrePaga_SelectedIndexChanged);
            // 
            // txt_CodPre
            // 
            this.txt_CodPre.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_CodPre.Enabled = false;
            this.txt_CodPre.Location = new System.Drawing.Point(700, 453);
            this.txt_CodPre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_CodPre.Name = "txt_CodPre";
            this.txt_CodPre.Size = new System.Drawing.Size(12, 22);
            this.txt_CodPre.TabIndex = 48;
            this.txt_CodPre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_CodPre.Visible = false;
            // 
            // ListaDetalladaOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(717, 481);
            this.Controls.Add(this.txt_CodPre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ComboB_filtroMes);
            this.Controls.Add(this.Lb_a_NroAula);
            this.Controls.Add(this.txt_TotalDetalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TotalLista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_DetalleOrden);
            this.Controls.Add(this.dgv_ListaOrdenes);
            this.Controls.Add(this.label_ListaAulas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(733, 520);
            this.MinimumSize = new System.Drawing.Size(733, 520);
            this.Name = "ListaDetalladaOrdenes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listas Detalladas";
            this.Load += new System.EventHandler(this.ListaDetallada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaOrdenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetalleOrden)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ListaAulas;
        private System.Windows.Forms.DataGridView dgv_ListaOrdenes;
        private System.Windows.Forms.DataGridView dgv_DetalleOrden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TotalLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TotalDetalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboB_filtroMes;
        private System.Windows.Forms.Label Lb_a_NroAula;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CheckB_Particulares;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.ComboBox ComboB_PrePaga;
        private System.Windows.Forms.TextBox txt_CodPre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_CheckBoxListOrdenes;
    }
}