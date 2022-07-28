namespace MedicPagos
{
    partial class AgregarEstudio
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
            this.components = new System.ComponentModel.Container();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.gB_DetalleAula = new System.Windows.Forms.GroupBox();
            this.ComboB_Estudios = new System.Windows.Forms.ComboBox();
            this.txt_Nomenclador = new System.Windows.Forms.TextBox();
            this.txt_CodEstudio = new System.Windows.Forms.TextBox();
            this.txt_CostoEstu = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lb_CodEstudio = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboB_PrePaga = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip_Datos = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.CheckB_Prepagas = new System.Windows.Forms.CheckBox();
            this.CheckB_Particulares = new System.Windows.Forms.CheckBox();
            this.txt_Prepaga = new System.Windows.Forms.TextBox();
            this.gB_DetalleAula.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.Location = new System.Drawing.Point(373, 247);
            this.btn_Volver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(139, 48);
            this.btn_Volver.TabIndex = 8;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(129, 247);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(139, 48);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // gB_DetalleAula
            // 
            this.gB_DetalleAula.Controls.Add(this.ComboB_Estudios);
            this.gB_DetalleAula.Controls.Add(this.txt_Nomenclador);
            this.gB_DetalleAula.Controls.Add(this.txt_CodEstudio);
            this.gB_DetalleAula.Controls.Add(this.txt_CostoEstu);
            this.gB_DetalleAula.Controls.Add(this.txt_Nombre);
            this.gB_DetalleAula.Controls.Add(this.lb_CodEstudio);
            this.gB_DetalleAula.Controls.Add(this.label14);
            this.gB_DetalleAula.Controls.Add(this.label4);
            this.gB_DetalleAula.Controls.Add(this.label1);
            this.gB_DetalleAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.gB_DetalleAula.Location = new System.Drawing.Point(4, 70);
            this.gB_DetalleAula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gB_DetalleAula.Name = "gB_DetalleAula";
            this.gB_DetalleAula.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gB_DetalleAula.Size = new System.Drawing.Size(635, 158);
            this.gB_DetalleAula.TabIndex = 55;
            this.gB_DetalleAula.TabStop = false;
            // 
            // ComboB_Estudios
            // 
            this.ComboB_Estudios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboB_Estudios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboB_Estudios.FormattingEnabled = true;
            this.ComboB_Estudios.IntegralHeight = false;
            this.ComboB_Estudios.Location = new System.Drawing.Point(93, 12);
            this.ComboB_Estudios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboB_Estudios.Name = "ComboB_Estudios";
            this.ComboB_Estudios.Size = new System.Drawing.Size(244, 24);
            this.ComboB_Estudios.TabIndex = 65;
            this.ComboB_Estudios.Visible = false;
            this.ComboB_Estudios.SelectedIndexChanged += new System.EventHandler(this.ComboB_Estudios_SelectedIndexChanged);
            // 
            // txt_Nomenclador
            // 
            this.txt_Nomenclador.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Nomenclador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nomenclador.Location = new System.Drawing.Point(248, 103);
            this.txt_Nomenclador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Nomenclador.MaxLength = 6;
            this.txt_Nomenclador.Name = "txt_Nomenclador";
            this.txt_Nomenclador.Size = new System.Drawing.Size(79, 22);
            this.txt_Nomenclador.TabIndex = 5;
            this.txt_Nomenclador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip_Datos.SetToolTip(this.txt_Nomenclador, "Utilice coma. Ej: 3,4");
            this.txt_Nomenclador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nomenclador_KeyPress);
            this.txt_Nomenclador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Nomenclador_KeyUp);
            // 
            // txt_CodEstudio
            // 
            this.txt_CodEstudio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_CodEstudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodEstudio.Location = new System.Drawing.Point(520, 41);
            this.txt_CodEstudio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_CodEstudio.MaxLength = 6;
            this.txt_CodEstudio.Name = "txt_CodEstudio";
            this.txt_CodEstudio.Size = new System.Drawing.Size(85, 22);
            this.txt_CodEstudio.TabIndex = 4;
            this.txt_CodEstudio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_CodEstudio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CodEstudio_KeyPress);
            // 
            // txt_CostoEstu
            // 
            this.txt_CostoEstu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_CostoEstu.Enabled = false;
            this.txt_CostoEstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CostoEstu.Location = new System.Drawing.Point(464, 103);
            this.txt_CostoEstu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_CostoEstu.MaxLength = 6;
            this.txt_CostoEstu.Name = "txt_CostoEstu";
            this.txt_CostoEstu.Size = new System.Drawing.Size(84, 22);
            this.txt_CostoEstu.TabIndex = 5;
            this.txt_CostoEstu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip_Datos.SetToolTip(this.txt_CostoEstu, "Utilice coma. Ej: 3,4");

            this.txt_CostoEstu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CostoEstu_KeyPress);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(93, 41);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Nombre.MaxLength = 30;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(244, 22);
            this.txt_Nombre.TabIndex = 3;

            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // lb_CodEstudio
            // 
            this.lb_CodEstudio.AutoSize = true;
            this.lb_CodEstudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CodEstudio.Location = new System.Drawing.Point(404, 44);
            this.lb_CodEstudio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_CodEstudio.Name = "lb_CodEstudio";
            this.lb_CodEstudio.Size = new System.Drawing.Size(108, 16);
            this.lb_CodEstudio.TabIndex = 62;
            this.lb_CodEstudio.Text = "Cod. del estudio:";

            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(403, 106);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 16);
            this.label14.TabIndex = 58;
            this.label14.Text = "Costo $";

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 60;
            this.label4.Text = "Nomenclador Nacional";

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nombre:";

            // 
            // ComboB_PrePaga
            // 
            this.ComboB_PrePaga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboB_PrePaga.Enabled = false;
            this.ComboB_PrePaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboB_PrePaga.FormattingEnabled = true;
            this.ComboB_PrePaga.IntegralHeight = false;
            this.ComboB_PrePaga.Location = new System.Drawing.Point(300, 25);
            this.ComboB_PrePaga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComboB_PrePaga.Name = "ComboB_PrePaga";
            this.ComboB_PrePaga.Size = new System.Drawing.Size(169, 24);
            this.ComboB_PrePaga.TabIndex = 1;
            this.ComboB_PrePaga.SelectedIndexChanged += new System.EventHandler(this.ComboB_PrePaga_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(344, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "Prepagas";

            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Enabled = false;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(373, 265);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(139, 48);
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Visible = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.CheckB_Prepagas);
            this.groupBox7.Controls.Add(this.CheckB_Particulares);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox7.Location = new System.Drawing.Point(4, 1);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(279, 65);
            this.groupBox7.TabIndex = 64;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Filtros";
            // 
            // CheckB_Prepagas
            // 
            this.CheckB_Prepagas.AutoSize = true;
            this.CheckB_Prepagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckB_Prepagas.Location = new System.Drawing.Point(154, 26);
            this.CheckB_Prepagas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckB_Prepagas.Name = "CheckB_Prepagas";
            this.CheckB_Prepagas.Size = new System.Drawing.Size(87, 20);
            this.CheckB_Prepagas.TabIndex = 52;
            this.CheckB_Prepagas.Text = "Prepagas";
            this.CheckB_Prepagas.UseVisualStyleBackColor = true;
            this.CheckB_Prepagas.CheckedChanged += new System.EventHandler(this.CheckB_Prepagas_CheckedChanged);
            // 
            // CheckB_Particulares
            // 
            this.CheckB_Particulares.AutoSize = true;
            this.CheckB_Particulares.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckB_Particulares.Location = new System.Drawing.Point(28, 26);
            this.CheckB_Particulares.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CheckB_Particulares.Name = "CheckB_Particulares";
            this.CheckB_Particulares.Size = new System.Drawing.Size(98, 20);
            this.CheckB_Particulares.TabIndex = 51;
            this.CheckB_Particulares.Text = "Particulares";
            this.CheckB_Particulares.UseVisualStyleBackColor = true;
            this.CheckB_Particulares.CheckedChanged += new System.EventHandler(this.CheckB_Particulares_CheckedChanged);
            // 
            // txt_Prepaga
            // 
            this.txt_Prepaga.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Prepaga.Enabled = false;
            this.txt_Prepaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Prepaga.Location = new System.Drawing.Point(300, 48);
            this.txt_Prepaga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Prepaga.MaxLength = 30;
            this.txt_Prepaga.Name = "txt_Prepaga";
            this.txt_Prepaga.Size = new System.Drawing.Size(169, 22);
            this.txt_Prepaga.TabIndex = 63;
            this.txt_Prepaga.Visible = false;

            // 
            // AgregarEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(643, 310);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.txt_Prepaga);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.gB_DetalleAula);
            this.Controls.Add(this.ComboB_PrePaga);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(659, 349);
            this.MinimumSize = new System.Drawing.Size(659, 349);
            this.Name = "AgregarEstudio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Estudio";
            this.Load += new System.EventHandler(this.AgregarEstudio_Load);
            this.gB_DetalleAula.ResumeLayout(false);
            this.gB_DetalleAula.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.GroupBox gB_DetalleAula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_CodEstudio;
        private System.Windows.Forms.ToolTip toolTip_Datos;
        private System.Windows.Forms.Button btn_Cancelar;
        public System.Windows.Forms.ComboBox ComboB_PrePaga;
        public System.Windows.Forms.TextBox txt_Nomenclador;
        public System.Windows.Forms.TextBox txt_CodEstudio;
        public System.Windows.Forms.TextBox txt_CostoEstu;
        public System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.GroupBox groupBox7;
        public System.Windows.Forms.TextBox txt_Prepaga;
        public System.Windows.Forms.CheckBox CheckB_Prepagas;
        public System.Windows.Forms.CheckBox CheckB_Particulares;
        public System.Windows.Forms.ComboBox ComboB_Estudios;
    }
}