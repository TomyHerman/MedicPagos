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
    public partial class AgregarModificarMedico : Form
    {
        Conexion cn = new Conexion();
        DataSet ds = new DataSet();

        MensajesErrores ms = new MensajesErrores();

        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BaseMedicPagos;Integrated Security=True");
        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        //cmd.CommandType = System.Data.CommandType.Text;

        public AgregarModificarMedico()
        {
            InitializeComponent();
        }

        private void AgregarMedico_Load(object sender, EventArgs e)
        {
            string apellido = null;
            string nombre = null;

            if (txt_Apellido.Text == "")
            {
                btn_GuarModificar.Enabled = false;
                btn_GuarModificar.Visible = false;

                btn_Guardar.Enabled = true;
                btn_Guardar.Visible = true;
            }
            else
            {
                apellido = txt_Apellido.Text;
                txt_Apellido.Text = apellido.Trim();

                nombre = txt_Nombre.Text;
                txt_Nombre.Text = nombre.Trim();

                btn_Guardar.Enabled = false;
                btn_Guardar.Visible = false;

                btn_GuarModificar.Enabled = true;
                btn_GuarModificar.Visible = true;
                btn_GuarModificar.Location = new Point(524, 64);
            }
        }

        private void btn_GuarModificar_Click(object sender, EventArgs e)
        {
            string aux = null;

            if (txt_Apellido.Text == "" || txt_Nombre.Text == "")
            {
                ms.MensajeCompletarCampos();
            }
            else
            {
                ds = cn.DevolverValor("Select Cod_Medico from Medicos where Apellido = '" + txt_Apellido.Text + "'");
                foreach (DataRow fila in ds.Tables[0].Rows)
                    aux = fila[0].ToString();
                if (aux != null)
                {
                    DialogResult x = MessageBox.Show("Ya EXISTE un Medico con ese apellido. ¿Desea modificarlo igual?", "Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (x == DialogResult.Yes)
                    {
                        conexion.Open();
                        cmd.CommandText = "UPDATE Medicos set Apellido = '" + txt_Apellido.Text + "', Nombre = '" + txt_Nombre.Text + "' where Cod_Medico = '" + txt_CodMedico.Text + "'";
                        cmd.Connection = conexion;
                        cmd.ExecuteNonQuery();
                        conexion.Close();

                        ms.MensajeModificar();
                        this.Close();
                    }
                    else
                    {
                        ms.MensajeNoAgrego();
                        this.Close();
                    }
                }
                else
                {
                    conexion.Open();
                    cmd.CommandText = "UPDATE Medicos set Apellido = '" + txt_Apellido.Text + "', Nombre = '" + txt_Nombre.Text + "' where Cod_Medico = '" + txt_CodMedico.Text + "'";
                    cmd.Connection = conexion;
                    cmd.ExecuteNonQuery();
                    conexion.Close();

                    ms.MensajeModificar();
                    this.Close();
                }
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string aux = null;
            int CodMedico = 0;

            if (txt_Apellido.Text == "" || txt_Nombre.Text == "")
            {
                ms.MensajeCompletarCampos();
            }
            else
            {
                ds = cn.DevolverValor("Select Cod_Medico from Medicos where Apellido = '" + txt_Apellido.Text + "'");
                foreach (DataRow fila in ds.Tables[0].Rows)
                    aux = fila[0].ToString();
                if (aux == null)
                {
                    ds = cn.DevolverValor("SELECT count(Cod_Medico) + 1 FROM Medicos");
                    foreach (DataRow fila in ds.Tables[0].Rows)
                        CodMedico = Convert.ToInt32(fila[0]);

                    conexion.Open();
                    cmd.CommandText = "INSERT Medicos(Cod_Medico,Apellido,Nombre) VALUES ('" + CodMedico + "','" + txt_Apellido.Text + "','" + txt_Nombre.Text + "')";
                    cmd.Connection = conexion;
                    cmd.ExecuteNonQuery();
                    conexion.Close();

                    ms.MensajeAgregar();
                    this.Close();
                }
                else
                {
                    DialogResult x = MessageBox.Show("Ya EXISTE un Medico con ese apellido. ¿Desea agregarlo igual?", "Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (x == DialogResult.Yes)
                    {
                        ds = cn.DevolverValor("SELECT count(Cod_Medico) + 1 FROM Medicos");
                        foreach (DataRow fila in ds.Tables[0].Rows)
                            CodMedico = Convert.ToInt32(fila[0]);

                        conexion.Open();
                        cmd.CommandText = "INSERT Medicos(Cod_Medico,Apellido,Nombre) VALUES ('" + CodMedico + "','" + txt_Apellido.Text + "','" + txt_Nombre.Text + "')";
                        cmd.Connection = conexion;
                        cmd.ExecuteNonQuery();
                        conexion.Close();

                        ms.MensajeAgregar();
                        this.Close();
                    }
                    else
                    {
                        ms.MensajeNoAgrego();
                        this.Close();
                    }
                }
            }
        }

        private void txt_Apellido_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
