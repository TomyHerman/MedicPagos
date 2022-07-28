namespace MedicPagos
{
    partial class Validacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Validacion));
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.lb_pass1 = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.txt_Contraseña2 = new System.Windows.Forms.TextBox();
            this.lb_pass2 = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.toolTip_Datos = new System.Windows.Forms.ToolTip(this.components);
            this.lb_Contador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contraseña.Location = new System.Drawing.Point(211, 113);
            this.txt_Contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Contraseña.MaxLength = 8;
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.Size = new System.Drawing.Size(153, 22);
            this.txt_Contraseña.TabIndex = 2;
            this.toolTip_Datos.SetToolTip(this.txt_Contraseña, "8 caracteres como maximo");
            this.txt_Contraseña.Enter += new System.EventHandler(this.txt_Contraseña_Enter);
            this.txt_Contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Contraseña_KeyPress);
            // 
            // lb_pass1
            // 
            this.lb_pass1.AutoSize = true;
            this.lb_pass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass1.Location = new System.Drawing.Point(89, 116);
            this.lb_pass1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_pass1.Name = "lb_pass1";
            this.lb_pass1.Size = new System.Drawing.Size(102, 16);
            this.lb_pass1.TabIndex = 31;
            this.lb_pass1.Text = "CONTRASEÑA";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.Location = new System.Drawing.Point(211, 62);
            this.txt_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Usuario.MaxLength = 15;
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(153, 22);
            this.txt_Usuario.TabIndex = 1;
            this.txt_Usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Usuario_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "USUARIO";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(49, 194);
            this.btn_Aceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(165, 48);
            this.btn_Aceptar.TabIndex = 4;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseMnemonic = false;
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(261, 194);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(165, 48);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseMnemonic = false;
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(267, 287);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "© Diseñado por Tomás Herman";
            this.toolTip_Datos.SetToolTip(this.label8, "                Tomás Herman\r\n- Técnico Electrónico\r\n- Técnico Superior en Progra" +
        "mación\r\nEmail: tomy_herman@hotmail.com\r\nTel: +541131153272");
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titulo.ForeColor = System.Drawing.Color.Maroon;
            this.lb_Titulo.Location = new System.Drawing.Point(120, 22);
            this.lb_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(0, 16);
            this.lb_Titulo.TabIndex = 38;
            this.lb_Titulo.Visible = false;
            // 
            // txt_Contraseña2
            // 
            this.txt_Contraseña2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Contraseña2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contraseña2.Location = new System.Drawing.Point(211, 148);
            this.txt_Contraseña2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Contraseña2.MaxLength = 8;
            this.txt_Contraseña2.Name = "txt_Contraseña2";
            this.txt_Contraseña2.PasswordChar = '*';
            this.txt_Contraseña2.Size = new System.Drawing.Size(153, 22);
            this.txt_Contraseña2.TabIndex = 3;
            this.toolTip_Datos.SetToolTip(this.txt_Contraseña2, "8 caracteres como maximo");
            this.txt_Contraseña2.Visible = false;
            // 
            // lb_pass2
            // 
            this.lb_pass2.AutoSize = true;
            this.lb_pass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass2.Location = new System.Drawing.Point(124, 151);
            this.lb_pass2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_pass2.Name = "lb_pass2";
            this.lb_pass2.Size = new System.Drawing.Size(67, 16);
            this.lb_pass2.TabIndex = 40;
            this.lb_pass2.Text = "REPETIR";
            this.lb_pass2.Visible = false;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(49, 217);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(165, 48);
            this.btn_Guardar.TabIndex = 41;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseMnemonic = false;
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Visible = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // lb_Contador
            // 
            this.lb_Contador.AutoSize = true;
            this.lb_Contador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Contador.ForeColor = System.Drawing.Color.Maroon;
            this.lb_Contador.Location = new System.Drawing.Point(309, 22);
            this.lb_Contador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Contador.Name = "lb_Contador";
            this.lb_Contador.Size = new System.Drawing.Size(0, 16);
            this.lb_Contador.TabIndex = 42;
            this.lb_Contador.Visible = false;
            // 
            // Validacion
            // 
            this.AcceptButton = this.btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(477, 306);
            this.ControlBox = false;
            this.Controls.Add(this.lb_Contador);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txt_Contraseña2);
            this.Controls.Add(this.lb_pass2);
            this.Controls.Add(this.lb_Titulo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.lb_pass1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(493, 345);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(493, 345);
            this.Name = "Validacion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validacion";
            this.Load += new System.EventHandler(this.Validacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.Label lb_pass1;
        public System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_Titulo;
        public System.Windows.Forms.TextBox txt_Contraseña2;
        private System.Windows.Forms.Label lb_pass2;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.ToolTip toolTip_Datos;
        private System.Windows.Forms.Label lb_Contador;
    }
}