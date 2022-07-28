using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MedicPagos
{
    public partial class Validacion : Form
    {
        Conexion cn = new Conexion();
        DataSet ds = new DataSet();
        MensajesErrores ms = new MensajesErrores();
        DateTime fechaHoy = DateTime.Now;

        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BaseMedicPagos;Integrated Security=True");
        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

        public Validacion()
        {
            InitializeComponent();
        }

        private void Validacion_Load(object sender, EventArgs e)
        {
            int Fecha_Año_ven = 0;
            int Fecha_Mes_ven = 0;
            int Fecha_Dia_ven = 0;
            int Contador = 0;
            bool Estado = false;

            txt_Usuario.Focus();
            txt_Usuario.Select();
            txt_Usuario.Focused.ToString();

            txt_Usuario.Focus();
            txt_Usuario.SelectionStart = txt_Usuario.Text.Length;

            cmd.CommandType = System.Data.CommandType.Text;

            ds = cn.DevolverValor("select Fecha_Dia,Fecha_Mes,Fecha_Año,Contador,Estado from Validaciones where ID = 1");
            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                Fecha_Dia_ven = Convert.ToInt32(fila[0]);
                Fecha_Mes_ven = Convert.ToInt32(fila[1]);
                Fecha_Año_ven = Convert.ToInt32(fila[2]);
                Contador = Convert.ToInt32(fila[3]);
                Estado = Convert.ToBoolean(fila[4]);
            }

            int dia_hoy = fechaHoy.Day;
            int mes_hoy = fechaHoy.Month;
            int año_hoy = fechaHoy.Year;

            if (Estado == true)
            {
                if (año_hoy == Fecha_Año_ven)
                {
                    if (mes_hoy >= Fecha_Mes_ven)
                    {
                        if (dia_hoy >= Fecha_Dia_ven)
                        {
                            if(Contador != 0)
                            {
                                ms.MensajeLinceVencida();
                                lb_Titulo.Visible = true;
                                //lb_Titulo.Location = new Point(123, 18);
                                lb_Titulo.Text = "LICENCIA VENCIDA, QUEDAN";

                                dia_hoy = dia_hoy - Fecha_Dia_ven;

                                lb_Contador.Visible = true;
                                lb_Contador.Text = dia_hoy.ToString() + " DIAS";

                                //btn_Aceptar.Enabled = false;
                                //txt_Usuario.Enabled = false;
                                //txt_Contraseña.Enabled = false;

                                conexion.Open();
                                //cmd.CommandText = "UPDATE Validaciones set Estado = 0 where ID = 1";
                                //cmd.Connection = conexion;
                                //cmd.ExecuteNonQuery();
                                //conexion.Close();

                                //conexion.Open();
                                cmd.CommandText = "UPDATE Validaciones set Contador = " + dia_hoy.ToString() + " where ID = 1";
                                cmd.Connection = conexion;
                                cmd.ExecuteNonQuery();
                                conexion.Close();
                            }
                            else if(Contador == 0)
                            {
                                conexion.Open();
                                cmd.CommandText = "UPDATE Validaciones set Estado = 0 where ID = 1";
                                cmd.Connection = conexion;
                                cmd.ExecuteNonQuery();
                                conexion.Close();
                            }
                        }
                    }
                }
            }
            else if (Estado == false)
            {
                ms.MensajeVencida();
                lb_Titulo.Visible = true;
                lb_Titulo.Location = new Point(123, 22);
                lb_Titulo.Text = "LICENCIA VENCIDA";

                /*if (Contador != 0)
                {
                    ms.MensajeLinceVencida();

                    lb_Titulo.Visible = true;
                    lb_Titulo.Text = "LICENCIA VENCIDA, QUEDAN";

                    dia = 30 - dia;

                    lb_Contador.Visible = true;
                    lb_Contador.Text = dia.ToString() + " DIAS";

                    conexion.Open();
                    cmd.CommandText = "UPDATE Validaciones set Contador = " + dia.ToString() + " where ID = 1";
                    cmd.Connection = conexion;
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
                else
                {
                    ms.MensajeVencida();
                    lb_Titulo.Visible = true;
                    lb_Titulo.Location = new Point(123, 18);
                    lb_Titulo.Text = "LICENCIA VENCIDA";
                }*/
            }
        }

        private void txt_Contraseña_Enter(object sender, EventArgs e)
        {
            string aux = null;
            string Contraseña = null;

            ds = cn.DevolverValor("select ID,contraseña from Usuarios where nombre = '" + txt_Usuario.Text + "'");
            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                aux = fila[0].ToString();
                Contraseña = Convert.ToString(fila[1]);

                if (aux == null)
                {
                    ms.MensajeNoExiste();

                    txt_Usuario.Clear();
                    txt_Contraseña.Clear();
                }
                else if (Contraseña.Trim() == "0") // Trim() saca espacios en blanco
                {
                    txt_Usuario.Enabled = false;

                    lb_Contador.Visible = false;

                    lb_Titulo.Visible = true;
                    lb_Titulo.Location = new Point(155, 22);
                    lb_Titulo.Text = "CAMBIAR CONTRASEÑA";

                    lb_pass2.Visible = true;
                    lb_pass1.Text = "NUEVA CONTRASEÑA";
                    lb_pass1.Location = new Point(39, 116);
                    txt_Contraseña2.Visible = true;

                    btn_Aceptar.Enabled = false;
                    btn_Aceptar.Visible = false;

                    btn_Guardar.Visible = true;
                    btn_Guardar.Location = new Point(49, 194);
                }
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            string Nombre = null;
            string Contraseña = null;

            ds = cn.DevolverValor("select Nombre from Usuarios where nombre = '" + txt_Usuario.Text + "'");
            foreach (DataRow fila in ds.Tables[0].Rows)
                Nombre = fila[0].ToString();
            if (Nombre == null)
            {
                ms.MensajeNoExiste();

                txt_Usuario.Clear();
                txt_Contraseña.Clear();
            }
            else if (txt_Contraseña.Text == "")
            {
                ms.MensajeCompletarCampos();
            }
            else
            {
                ds = cn.DevolverValor("select contraseña from Usuarios where nombre = '" + txt_Usuario.Text + "' and contraseña = '" + txt_Contraseña.Text + "'");
                foreach (DataRow fila in ds.Tables[0].Rows)
                    Contraseña = fila[0].ToString();
                if (Contraseña == null)
                {
                    MessageBox.Show("Contraseña INCORRECTA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //txt_Usuario.Clear();
                    txt_Contraseña.Clear();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string aux = null;
            int Contraseña = 0;

            cmd.CommandType = System.Data.CommandType.Text;

            ds = cn.DevolverValor("select ID,contraseña from Usuarios where nombre = '" + txt_Usuario.Text + "'");
            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                aux = fila[0].ToString();
                Contraseña = Convert.ToInt32(fila[1]);

                if (aux == null)
                {
                    ms.MensajeNoExiste();

                    //txt_Usuario.Clear();
                    txt_Contraseña.Clear();
                }
                else if (Contraseña == 0)
                {
                    lb_pass2.Visible = true;
                    txt_Contraseña2.Visible = true;
                    if (txt_Contraseña.Text == txt_Contraseña2.Text)
                    {
                        if(txt_Contraseña.Text != "" || txt_Contraseña2.Text != "")
                        {
                            conexion.Open();
                            cmd.CommandText = "UPDATE Usuarios set contraseña = '" + txt_Contraseña.Text + "' where ID = '" + aux + "'";
                            cmd.Connection = conexion;
                            cmd.ExecuteNonQuery();
                            conexion.Close();

                            ms.MensajeGuardar();
                            this.Close();
                        }
                        else
                        {
                            ms.MensajeCompletarCampos();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no son iguales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_Contraseña.Clear();
                        txt_Contraseña2.Clear();
                    }
                }
            }
        }

        private void txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) //Al pulsar letras
            {
                e.Handled = false; //false se acepta, true no se acepta
            }
            else if (Char.IsNumber(e.KeyChar)) //Al pulsar numeros
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar)) //Al pulsar teclas como Borrar y eso.
            {
                e.Handled = false;
            }
            else //Para todo lo demas
            {
                e.Handled = true;
            }
        }

        private void txt_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) //Al pulsar letras
            {
                e.Handled = false; //false se acepta, true no se acepta
            }
            else if (Char.IsNumber(e.KeyChar)) //Al pulsar numeros
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //Al pulsar teclas como Borrar y eso.
            {
                e.Handled = false;
            }
            else //Para todo lo demas
            {
                e.Handled = true;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if(lb_Titulo.Visible == true)
            {
                Application.ExitThread();
            }
            else
            {
                DialogResult x = MessageBox.Show("¿Desea salir?", "Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (x == DialogResult.Yes)
                {
                    Application.ExitThread();
                }
            }
        }
    }
}