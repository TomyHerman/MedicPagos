namespace MedicPagos
{
    partial class AgregarModificarMedico
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
            this.btn_Volver = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_GuarModificar = new System.Windows.Forms.Button();
            this.txt_CodMedico = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Volver.Location = new System.Drawing.Point(524, 134);
            this.btn_Volver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(165, 46);
            this.btn_Volver.TabIndex = 54;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_Nombre);
            this.groupBox3.Controls.Add(this.txt_Apellido);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(27, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(451, 202);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalles del Medico";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(116, 112);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Nombre.MaxLength = 15;
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(221, 22);
            this.txt_Nombre.TabIndex = 22;
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellido.Location = new System.Drawing.Point(116, 69);
            this.txt_Apellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Apellido.MaxLength = 15;
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(221, 22);
            this.txt_Apellido.TabIndex = 21;
            this.txt_Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Apellido_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(35, 116);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 16);
            this.label19.TabIndex = 4;
            this.label19.Text = "Nombre";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(36, 73);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 16);
            this.label20.TabIndex = 3;
            this.label20.Text = "Apellido";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(524, 64);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(165, 46);
            this.btn_Guardar.TabIndex = 53;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_GuarModificar
            // 
            this.btn_GuarModificar.Enabled = false;
            this.btn_GuarModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuarModificar.Location = new System.Drawing.Point(524, 41);
            this.btn_GuarModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_GuarModificar.Name = "btn_GuarModificar";
            this.btn_GuarModificar.Size = new System.Drawing.Size(165, 43);
            this.btn_GuarModificar.TabIndex = 55;
            this.btn_GuarModificar.Text = "Guardar";
            this.btn_GuarModificar.UseVisualStyleBackColor = true;
            this.btn_GuarModificar.Visible = false;
            this.btn_GuarModificar.Click += new System.EventHandler(this.btn_GuarModificar_Click);
            // 
            // txt_CodMedico
            // 
            this.txt_CodMedico.Enabled = false;
            this.txt_CodMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_CodMedico.Location = new System.Drawing.Point(705, 213);
            this.txt_CodMedico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_CodMedico.MaxLength = 15;
            this.txt_CodMedico.Name = "txt_CodMedico";
            this.txt_CodMedico.Size = new System.Drawing.Size(12, 21);
            this.txt_CodMedico.TabIndex = 23;
            this.txt_CodMedico.Visible = false;
            // 
            // AgregarModificarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(719, 241);
            this.Controls.Add(this.txt_CodMedico);
            this.Controls.Add(this.btn_GuarModificar);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_Guardar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(735, 280);
            this.MinimumSize = new System.Drawing.Size(735, 280);
            this.Name = "AgregarModificarMedico";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medico";
            this.Load += new System.EventHandler(this.AgregarMedico_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btn_Guardar;
        public System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.Button btn_GuarModificar;
        public System.Windows.Forms.TextBox txt_CodMedico;
        public System.Windows.Forms.TextBox txt_Nombre;
    }
}