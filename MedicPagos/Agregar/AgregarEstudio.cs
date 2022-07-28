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
    public partial class AgregarEstudio : Form
    {
        Conexion cn = new Conexion();
        DataSet ds = new DataSet();

        MensajesErrores ms = new MensajesErrores();

        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BaseMedicPagos;Integrated Security=True");
        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

        public AgregarEstudio()
        {
            InitializeComponent();
        }

        private void AgregarEstudio_Load(object sender, EventArgs e)
        {
            BorrarEstudios();
        }

        public void actualizarEstudios()
        {
            ComboB_Estudios.Visible = false;

            CheckB_Particulares.Enabled = true;
            CheckB_Particulares.Checked = false;

            CheckB_Prepagas.Enabled = true;
            CheckB_Prepagas.Checked = false;

            txt_Nombre.Clear();
            txt_Nombre.Visible = true;

            txt_CostoEstu.Clear();
            txt_CostoEstu.Text = "0,00";

            txt_Nomenclador.Clear();

            txt_CodEstudio.Clear();
            txt_CodEstudio.Enabled = true;

            btn_Volver.Enabled = true;
            btn_Volver.Visible = true;

            btn_Cancelar.Enabled = false;
            btn_Cancelar.Visible = false;

            ComboB_PrePaga.Items.Clear();
            ComboB_PrePaga.Enabled = false;
        }
        
        public void BorrarEstudios()
        {
            int Cod_prepaga = 0;

            if(CheckB_Particulares.Checked == true && CheckB_Prepagas.Checked == false) // PARTICULARES
            {
                txt_Nombre.Enabled = false;
                ComboB_Estudios.Visible = true;
                ComboB_Estudios.Location = new Point(93, 41);

                CheckB_Prepagas.Checked = false;

                txt_Prepaga.Visible = false;

                ComboB_PrePaga.Items.Clear();
                ComboB_PrePaga.Enabled = false;

                txt_CodEstudio.Enabled = false;
            }
            else if (CheckB_Prepagas.Checked == true && CheckB_Particulares.Checked == false) // PREPAGAS
            {
                txt_Nombre.Visible = false;

                CheckB_Particulares.Checked = false;

                ComboB_PrePaga.Items.Clear();
                ComboB_PrePaga.Enabled = false;
                ComboB_PrePaga.Visible = false;

                txt_Prepaga.Visible = true;
                txt_Prepaga.Location = new Point(300, 25);

                ds = cn.DevolverValor("select Cod_PrePaga from Prepagas where Nombre = '" + txt_Prepaga.Text + "'");
                foreach (DataRow fila in ds.Tables[0].Rows)
                    Cod_prepaga = Convert.ToInt32(fila[0]);

                ComboB_Estudios.Enabled = true;
                ComboB_Estudios.Visible = true;
                ComboB_Estudios.Location = new Point(93, 41);

                ComboB_Estudios.Items.Clear();

                ComboB_Estudios.Items.Insert(0, "Seleccionar");
                ComboB_Estudios.SelectedIndex = 0;

                ds = cn.DevolverValor("select E.Nombre from Estudios E where not exists (select Cod_Estudio from EstudiosxPrepagas EP where e.Cod_Estudio = Ep.Cod_Estudio and Cod_PrePaga = '" + Cod_prepaga + "')");
                foreach (DataRow fila in ds.Tables[0].Rows)
                    ComboB_Estudios.Items.Add(fila[0].ToString());

                txt_CodEstudio.Clear();
                txt_CodEstudio.Enabled = false;
            }
            else
            {
                txt_Prepaga.Visible = false;

                ComboB_Estudios.Visible = false;

                CheckB_Particulares.Enabled = true;
                CheckB_Particulares.Checked = false;

                CheckB_Prepagas.Enabled = true;
                CheckB_Prepagas.Checked = false;

                txt_Nombre.Clear();
                txt_Nombre.Visible = true;

                txt_CostoEstu.Clear();
                txt_CostoEstu.Text = "0,00";

                txt_Nomenclador.Clear();

                txt_CodEstudio.Clear();
                txt_CodEstudio.Enabled = true;
                
                btn_Volver.Enabled = true;
                btn_Volver.Visible = true;

                btn_Cancelar.Enabled = false;
                btn_Cancelar.Visible = false;

                ComboB_PrePaga.Items.Clear();
                ComboB_PrePaga.Enabled = false;
                ComboB_PrePaga.Visible = true;
            }
        }

        private void CheckB_Particulares_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckB_Particulares.Checked == true) // PARTICULARES
            {
                txt_Nombre.Visible = false;

                CheckB_Prepagas.Checked = false;

                txt_Nomenclador.Enabled = false;

                txt_CostoEstu.Clear();
                txt_CostoEstu.Text = "0,00";
                txt_CostoEstu.Enabled = true;

                txt_CodEstudio.Enabled = false;

                btn_Volver.Enabled = false;
                btn_Volver.Visible = false;

                btn_Cancelar.Enabled = true;
                btn_Cancelar.Visible = true;
                btn_Cancelar.Location = new Point(373, 247);

                ComboB_Estudios.Items.Clear();
                ComboB_Estudios.Visible = true;
                ComboB_Estudios.Enabled = true;
                ComboB_Estudios.Location = new Point(93, 41);
                ComboB_Estudios.Items.Insert(0, "Seleccionar");
                ComboB_Estudios.SelectedIndex = 0;

                ds = cn.DevolverValor("select E.Nombre from Estudios E where not exists (select Cod_Estudio from EstudiosParticulares EP where e.Cod_Estudio = Ep.Cod_Estudio)");
                foreach (DataRow fila in ds.Tables[0].Rows)
                    ComboB_Estudios.Items.Add(fila[0].ToString());
            }
            else
            {
                CheckB_Particulares.Checked = false;

                CheckB_Prepagas.Enabled = true;

                txt_Nombre.Enabled = true;
                txt_Nombre.Visible = true;

                btn_Volver.Enabled = true;
                btn_Volver.Visible = true;

                btn_Cancelar.Enabled = false;
                btn_Cancelar.Visible = false;

                ComboB_PrePaga.Items.Clear();

                txt_Nomenclador.Enabled = true;

                txt_CostoEstu.Clear();
                txt_CostoEstu.Enabled = false;
                txt_CostoEstu.Text = "0,00";

                ComboB_Estudios.Items.Clear();
                ComboB_Estudios.Visible = false;
                ComboB_Estudios.Enabled = false;

                txt_CodEstudio.Clear();
                txt_CodEstudio.Enabled = true;
            }
        }

        private void CheckB_Prepagas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckB_Prepagas.Checked == true) // PREPAGAS
            {
                CheckB_Particulares.Checked = false;

                txt_Nombre.Visible = false;
                txt_Nombre.Enabled = false;

                /*txt_Prepaga.Enabled = false;
                txt_Prepaga.Visible = false;*/

                ComboB_Estudios.Items.Clear();
                ComboB_Estudios.Enabled = false;
                ComboB_Estudios.Visible = true;
                ComboB_Estudios.Location = new Point(93, 41);

                txt_CostoEstu.Clear();
                txt_CostoEstu.Enabled = false;
                txt_CostoEstu.Text = "0,00";

                txt_CodEstudio.Enabled = false;
                txt_Nomenclador.Enabled = false;

                btn_Volver.Enabled = false;
                btn_Volver.Visible = false;

                btn_Cancelar.Enabled = true;
                btn_Cancelar.Visible = true;
                btn_Cancelar.Location = new Point(373, 247);

                ComboB_PrePaga.Items.Clear();
                ComboB_PrePaga.Enabled = true;
                ComboB_PrePaga.Visible = true;

                ComboB_PrePaga.Items.Insert(0, "Seleccionar");
                ComboB_PrePaga.SelectedIndex = 0;

                ds = cn.DevolverValor("Select Nombre from PrePagas");
                foreach (DataRow fila in ds.Tables[0].Rows)
                    ComboB_PrePaga.Items.Add(fila[0].ToString());
            }
            else
            {
                CheckB_Prepagas.Checked = false;

                ComboB_PrePaga.Items.Clear();
                ComboB_PrePaga.Enabled = false;
                ComboB_PrePaga.Visible = true;

                txt_Prepaga.Enabled = false;
                txt_Prepaga.Visible = false;

                ComboB_Estudios.Visible = false;

                btn_Volver.Enabled = true;
                btn_Volver.Visible = true;

                btn_Cancelar.Enabled = false;
                btn_Cancelar.Visible = false;

                txt_Nombre.Visible = true;
                txt_Nombre.Enabled = true;

                txt_CodEstudio.Clear();
                txt_CodEstudio.Enabled = true;

                txt_Nomenclador.Clear();
                txt_Nomenclador.Enabled = true;

                txt_CostoEstu.Clear();
                txt_CostoEstu.Enabled = false;
                txt_CostoEstu.Text = "0,00";
            }
        }

        private void ComboB_PrePaga_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboB_PrePaga.SelectedItem.ToString() == "Seleccionar")
            {
                txt_Nombre.Visible = false;
                txt_Nombre.Enabled = false;

                ComboB_Estudios.Enabled = false;
                ComboB_Estudios.Visible = true;
                ComboB_Estudios.Location = new Point(93, 41);

                txt_Prepaga.Visible = false;

                txt_CodEstudio.Clear();
                txt_CodEstudio.Enabled = false;
            }
            else
            {
                txt_CostoEstu.Clear();
                txt_CostoEstu.Enabled = false;
                txt_CostoEstu.Text = "0,00";

                txt_Nombre.Visible = false;
                txt_Nombre.Enabled = false;

                txt_Nomenclador.Enabled = true;
                txt_CodEstudio.Enabled = false;

                btn_Volver.Enabled = false;
                btn_Volver.Visible = false;

                btn_Cancelar.Enabled = true;
                btn_Cancelar.Visible = true;
                btn_Cancelar.Location = new Point(373, 247);

                /*txt_Prepaga.Visible = true;
                txt_Prepaga.Location = new Point(70, 33);*/

                ComboB_Estudios.Enabled = true;
                ComboB_Estudios.Visible = true;
                ComboB_Estudios.Location = new Point(93, 41);

                ComboB_Estudios.Items.Clear();

                ComboB_Estudios.Items.Insert(0, "Seleccionar");
                ComboB_Estudios.SelectedIndex = 0;

                ds = cn.DevolverValor("select E.Nombre from Estudios E where not exists (select Cod_Estudio from EstudiosxPrepagas EP where e.Cod_Estudio = Ep.Cod_Estudio and Cod_PrePaga = '" + ComboB_PrePaga.SelectedIndex + "')");
                foreach (DataRow fila in ds.Tables[0].Rows)
                    ComboB_Estudios.Items.Add(fila[0].ToString());
            }
        }

        private void ComboB_Estudios_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal ValorCosto = 0;
            int NNmaspor = 0;
            decimal Nomenclador_Nacional = 0;
            decimal CostoPrepaga = 0;

            if (CheckB_Prepagas.Checked == true) // PREPAGAS
            {
                if (ComboB_Estudios.SelectedItem.ToString() == "Seleccionar")
                {
                    txt_CodEstudio.Clear();
                    txt_CodEstudio.Enabled = false;

                    txt_Nomenclador.Clear();
                    txt_Nomenclador.Enabled = false;

                    txt_CostoEstu.Enabled = false;
                }
                else
                {
                    txt_Nomenclador.Clear();
                    txt_Nomenclador.Enabled = false;

                    txt_CostoEstu.Enabled = false;

                    if(txt_Prepaga.Visible == false)
                    {
                        ds = cn.DevolverValor("Select ValorCosto, NNmaspor from PrePagas where Nombre = '" + ComboB_PrePaga.SelectedItem.ToString() + "'");
                        foreach (DataRow fila in ds.Tables[0].Rows)
                        {
                            ValorCosto = Convert.ToDecimal(fila[0]);
                            NNmaspor = Convert.ToInt32(fila[1]);
                        }
                    }
                    else
                    {
                        ds = cn.DevolverValor("Select ValorCosto, NNmaspor from PrePagas where Nombre = '" + txt_Prepaga.Text + "'");
                        foreach (DataRow fila in ds.Tables[0].Rows)
                        {
                            ValorCosto = Convert.ToDecimal(fila[0]);
                            NNmaspor = Convert.ToInt32(fila[1]);
                        }
                    }

                    ds = cn.DevolverValor("select Cod_Estudio, Nomenclador_Nacional from Estudios where Nombre = '" + ComboB_Estudios.SelectedItem.ToString() + "'");
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        txt_CodEstudio.Text = Convert.ToString(fila[0].ToString());
                        txt_Nomenclador.Text = Convert.ToDecimal(fila[1]).ToString("N2");

                        Nomenclador_Nacional = Convert.ToDecimal(fila[1]);
                    }

                    if (NNmaspor == 1)
                    {
                        CostoPrepaga = Nomenclador_Nacional + ValorCosto;
                    }
                    else if (NNmaspor == 2)
                    {
                        CostoPrepaga = Nomenclador_Nacional * ValorCosto;
                    }
                    txt_CostoEstu.Text = CostoPrepaga.ToString("N2");
                }
            }
            else if (CheckB_Particulares.Checked == true) // PARTICULARES
            {
                if (ComboB_Estudios.SelectedItem.ToString() == "Seleccionar")
                {
                    txt_CodEstudio.Clear();
                    txt_CodEstudio.Enabled = false;

                    txt_CostoEstu.Enabled = false;
                }
                else
                {
                    txt_CostoEstu.Enabled = true;

                    ds = cn.DevolverValor("select Cod_Estudio from Estudios where Nombre = '" + ComboB_Estudios.SelectedItem.ToString() + "'");
                    foreach (DataRow fila in ds.Tables[0].Rows)
                        txt_CodEstudio.Text = Convert.ToString(fila[0].ToString());
                }
            }
        }

        private void txt_Nomenclador_KeyUp(object sender, KeyEventArgs e)
        {
            decimal ValorCosto = 0;
            int NNmaspor = 0;
            decimal Nomenclador_Nacional = 0;
            decimal Costo = 0;

            ds = cn.DevolverValor("select ValorCosto, NNmaspor from PrePagas where Cod_PrePaga = '" + ComboB_PrePaga.SelectedIndex + "'+1");
            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                ValorCosto = Convert.ToDecimal(fila[0]);
                NNmaspor = Convert.ToInt32(fila[1]);
            }

            if (txt_Nomenclador.TextLength > 0)
            {
                Nomenclador_Nacional = Convert.ToDecimal(txt_Nomenclador.Text);
            }

            if (NNmaspor == 1)
            {
                Costo = Nomenclador_Nacional + ValorCosto;
            }
            else if (NNmaspor == 2)
            {
                Costo = Nomenclador_Nacional * ValorCosto;
            }
           txt_CostoEstu.Text = Costo.ToString("N2");
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string aux = null;
            string aux2 = null;
            string aux3 = null;
            string aux4 = null;
            int Cod_PrePaga = 0;

            cmd.CommandType = System.Data.CommandType.Text;

            if (CheckB_Particulares.Checked == true && CheckB_Prepagas.Checked == false) // ESTUDIOS PARTICULARES
            {
                if (ComboB_Estudios.SelectedIndex == 0 || txt_CostoEstu.Text == "" || txt_CostoEstu.Text == "" || txt_CodEstudio.Text == "")
                {
                    ms.MensajeCompletarCampos();
                }
                else
                {
                    ds = cn.DevolverValor("Select Cod_Estudio from EstudiosParticulares where Cod_Estudio = '" + txt_CodEstudio.Text + "'");
                    foreach (DataRow fila in ds.Tables[0].Rows)
                        aux = fila[0].ToString();
                    if (aux == null)
                    {
                        ds = cn.DevolverValor("Select Cod_Estudio from Estudios where Cod_Estudio = '" + txt_CodEstudio.Text + "'");
                        foreach (DataRow fila in ds.Tables[0].Rows)
                            aux2 = fila[0].ToString();
                        if (aux2 != null)
                        {
                            if(txt_CostoEstu.Text != "0,00")
                            {
                                conexion.Open();
                                cmd.CommandText = "INSERT EstudiosParticulares (Cod_Estudio,CostoParticular) VALUES ('" + txt_CodEstudio.Text + "','" + (decimal.Parse(txt_CostoEstu.Text)).ToString().Replace(',', '.') + "')";
                                cmd.Connection = conexion;
                                cmd.ExecuteNonQuery();
                                conexion.Close();

                                ms.MensajeAgregar();
                                actualizarEstudios();
                            }
                            else
                            {
                                MessageBox.Show("No tiene costo $", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            ms.MensajeNoExisteEstu();
                        }
                    }
                    else
                    {
                        ms.MensajeExiste();
                        txt_CodEstudio.Clear();
                        ComboB_Estudios.Items.Clear();
                    }
                }
            }
            else if (CheckB_Prepagas.Checked == true && CheckB_Particulares.Checked == false) // ESTUDIOS PREPAGAS
            {
                if (ComboB_Estudios.SelectedIndex == 0 || txt_Nomenclador.Text == "" || txt_CodEstudio.Text == "")
                {
                    ms.MensajeCompletarCampos();
                }
                else
                {
                    if (txt_Prepaga.Visible == true)
                    {
                        ds = cn.DevolverValor("select Cod_PrePaga from PrePagas where Nombre = '" + txt_Prepaga.Text + "'");
                        foreach (DataRow fila in ds.Tables[0].Rows)
                            Cod_PrePaga = Convert.ToInt32(fila[0].ToString());

                        ds = cn.DevolverValor("Select Cod_Estudio from EstudiosxPrepagas where Cod_PrePaga = '" + Cod_PrePaga + "' and Cod_Estudio = '" + txt_CodEstudio.Text + "'");
                        foreach (DataRow fila in ds.Tables[0].Rows)
                            aux3 = fila[0].ToString();
                        if (aux3 == null)
                        {
                            ds = cn.DevolverValor("Select Cod_Estudio from Estudios where Cod_Estudio = '" + txt_CodEstudio.Text + "'");
                            foreach (DataRow fila in ds.Tables[0].Rows)
                                aux4 = fila[0].ToString();
                            if (aux4 != null)
                            {
                                if (txt_CostoEstu.Text != "0,00")
                                {
                                    conexion.Open();
                                    cmd.CommandText = "INSERT EstudiosxPrepagas (Cod_Estudio,Cod_PrePaga,CostoPrepaga) VALUES ('" + txt_CodEstudio.Text + "','" + Cod_PrePaga + "','" + (decimal.Parse(txt_CostoEstu.Text)).ToString().Replace(',', '.') + "')";
                                    cmd.Connection = conexion;
                                    cmd.ExecuteNonQuery();
                                    conexion.Close();

                                    ms.MensajeAgregar();
                                    actualizarEstudios();
                                }
                                else
                                {
                                    MessageBox.Show("No tiene costo $", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                ms.MensajeNoExisteEstu();
                            }
                        }
                        else
                        {
                            ms.MensajeExiste();
                            txt_CodEstudio.Clear();
                        }
                    }
                    else
                    {
                        ds = cn.DevolverValor("select Cod_PrePaga from PrePagas where Nombre = '" + ComboB_PrePaga.SelectedItem.ToString() + "'");
                        foreach (DataRow fila in ds.Tables[0].Rows)
                            Cod_PrePaga = Convert.ToInt32(fila[0].ToString());

                        ds = cn.DevolverValor("Select Cod_Estudio from EstudiosxPrepagas where Cod_PrePaga = '" + Cod_PrePaga + "' and Cod_Estudio = '" + txt_CodEstudio.Text + "'");
                        foreach (DataRow fila in ds.Tables[0].Rows)
                            aux3 = fila[0].ToString();
                        if (aux3 == null)
                        {
                            ds = cn.DevolverValor("Select Cod_Estudio from Estudios where Cod_Estudio = '" + txt_CodEstudio.Text + "'");
                            foreach (DataRow fila in ds.Tables[0].Rows)
                                aux4 = fila[0].ToString();
                            if (aux4 != null)
                            {
                                if (txt_CostoEstu.Text != "0,00")
                                {
                                    conexion.Open();
                                    cmd.CommandText = "INSERT EstudiosxPrepagas (Cod_Estudio,Cod_PrePaga,CostoPrepaga) VALUES ('" + txt_CodEstudio.Text + "','" + Cod_PrePaga + "','" + (decimal.Parse(txt_CostoEstu.Text)).ToString().Replace(',', '.') + "')";
                                    cmd.Connection = conexion;
                                    cmd.ExecuteNonQuery();
                                    conexion.Close();

                                    ms.MensajeAgregar();
                                    actualizarEstudios();
                                }
                                else
                                {
                                    MessageBox.Show("No tiene costo $", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                ms.MensajeNoExisteEstu();
                            }
                        }
                        else
                        {
                            ms.MensajeExiste();
                            txt_CodEstudio.Clear();
                        }
                    }
                }
            }
            else if (CheckB_Particulares.Checked == false && CheckB_Prepagas.Checked == false) // TODOS LOS ESTUDIOS
            {
                ds = cn.DevolverValor("Select Cod_Estudio from Estudios where Cod_Estudio = '" + txt_CodEstudio.Text + "'");
                foreach (DataRow fila in ds.Tables[0].Rows)
                    aux = fila[0].ToString();
                if (aux == null)
                {
                    if (txt_Nombre.Text == "" || txt_Nomenclador.Text == "" || txt_CostoEstu.Text == "" || txt_CodEstudio.Text == "")
                    {
                        ms.MensajeCompletarCampos();
                    }
                    else
                    {
                        conexion.Open();
                        cmd.CommandText = "INSERT Estudios (Cod_Estudio,Nombre,Nomenclador_Nacional) VALUES ('" + txt_CodEstudio.Text + "','" + txt_Nombre.Text + "','" + (decimal.Parse(txt_Nomenclador.Text)).ToString().Replace(',', '.') + "')";
                        cmd.Connection = conexion;
                        cmd.ExecuteNonQuery();
                        conexion.Close();

                        ms.MensajeAgregar();
                        actualizarEstudios();
                    }
                }
                else
                {
                    ms.MensajeExiste();
                    txt_CodEstudio.Clear();
                }
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
                e.Handled = false;
            }
        }

        private void txt_CodEstudio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) //Al pulsar letras
            {
                e.Handled = true; //false se acepta, true no se acepta
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

        private void txt_CostoEstu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) //Al pulsar letras
            {
                e.Handled = true; //false se acepta, true no se acepta
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
                e.Handled = false;
            }
        }

        private void txt_Nomenclador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) //Al pulsar letras
            {
                e.Handled = true; //false se acepta, true no se acepta
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
                e.Handled = false;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            CheckB_Particulares.Checked = false;

            CheckB_Prepagas.Checked = false;

            txt_Nombre.Clear();
            txt_CostoEstu.Clear();
            txt_Nomenclador.Clear();
            txt_CodEstudio.Clear();

            txt_Nombre.Enabled = true;

            txt_Nomenclador.Enabled = true;
            txt_CodEstudio.Enabled = true;

            btn_Volver.Enabled = true;
            btn_Volver.Visible = true;

            btn_Cancelar.Enabled = false;
            btn_Cancelar.Visible = false;

            txt_CostoEstu.Text = "0,00";

            ComboB_PrePaga.Items.Clear();
            ComboB_PrePaga.Enabled = false;
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
