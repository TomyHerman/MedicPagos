using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MedicPagos
{
    public partial class PantallaPrincipal : Form
    {
        Conexion cn = new Conexion();
        DataSet ds = new DataSet();
        MensajesErrores ms = new MensajesErrores();

        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BaseMedicPagos;Integrated Security=True");
        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
        //cmd.CommandType = System.Data.CommandType.Text;

        public PantallaPrincipal()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-ES"); 
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            Validar();
        }

        public void Validar()
        {
            Validacion form = new Validacion();
            abrirFormularioHijo(form);
        }

        public void abrirFormularioHijo(Form form)
        {
            //frm.MdiParent = this;
            form.ShowDialog();
            //frm.MdiParent = this;
            //this.Hide();

            actualizarOrdenes();
            actualizarEstudios();
            actualizarPrepagas();
            actualizarMedicos();
            actualizarPacientes();
        }

        public void Tiempo_Tick(object sender, EventArgs e)
        {
            l_hora.Text = DateTime.Now.ToString("HH:mm");
        }

        public void actualizarOrdenes()
        {
            CheckB_ord_Particular.Checked = false;

            txt_ord_NroOrdenMedica.Clear();

            dgv_ord_Estudios.DataSource = null;

            txt_ord_ApelliMedico.Clear();
            txt_ord_ApelliMedico.Text = "Ingrese apellido";
            txt_ord_ApelliMedico.ForeColor = SystemColors.GrayText;

            txt_ord_DNIpaciente.Clear();
            txt_ord_DNIpaciente.Text = "Ingrese DNI";
            txt_ord_DNIpaciente.ForeColor = SystemColors.GrayText;

            txt_ord_NomPaciente.Clear();
            txt_ord_ApellidoPaciente.Clear();

            btn_ord_BuscarPaciente.Enabled = true;
            btn_ord_BuscarPaciente.Visible = true;

            txt_ord_Total.Text = "0,00";

            //ds = cn.DevolverValor("SELECT CONVERT (date, SYSDATETIME())");
            //foreach (DataRow fila in ds.Tables[0].Rows)
            //    txt_ord_Fecha.Text = fila[0].ToString();

            //txt_ord_Fecha.Text = fechaHoy.ToString();
            //txt_ord_Hora.Text = fechaHoy.TimeOfDay.ToString("hh:mm");
            //txt_ord_Hora.Text = DateTime.Now.ToString("hh:mm");

            //ds = cn.DevolverValor("SELECT CONVERT (time, SYSDATETIME())");
            //foreach (DataRow fila in ds.Tables[0].Rows)
            //    txt_ord_Hora.Text = fila[0].ToString();

            l_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            l_hora.Text = DateTime.Now.ToString("HH:mm");

            ComboB_ord_PrePaga.Items.Clear();
            ComboB_ord_PrePaga.Items.Insert(0, "Seleccionar");
            ComboB_ord_PrePaga.SelectedIndex = 0;

            ds = cn.DevolverValor("Select Nombre from PrePagas");
            foreach (DataRow fila in ds.Tables[0].Rows)
                ComboB_ord_PrePaga.Items.Add(fila[0].ToString());

            ds = cn.DevolverValor("SELECT count(Cod_OrdenMedica) + 1 FROM OrdenesMedicas");
            foreach (DataRow fila in ds.Tables[0].Rows)
                txt_ord_NroOrdenMedica.Text = fila[0].ToString();
        }

        public void actualizarEstudios()
        {
            ComboB_estu_PrePaga.Items.Clear();
            ComboB_estu_PrePaga.Enabled = false;

            CheckB_estu_Particular.Enabled = true;
            CheckB_estu_Prepagas.Enabled = true;

            CheckB_estu_Particular.Checked = false;
            CheckB_estu_Prepagas.Checked = false;

            txt_estu_Nombre.Clear();
            txt_estu_Nombre.Enabled = false;

            txt_estu_CostoParti.Clear();
            txt_estu_CostoParti.Enabled = false;

            txt_estu_CostoPre.Clear();
            txt_estu_CostoPre.Enabled = false;

            txt_estu_Codigo.Clear();
            txt_estu_Codigo.Enabled = false;

            txt_estu_Nomenclador.Clear();
            txt_estu_Nomenclador.Enabled = false;

            btn_estu_Modificar.Enabled = false;
            btn_estu_Modificar.Visible = true;

            btn_estu_GuardarModif.Enabled = false;
            btn_estu_GuardarModif.Visible = false;

            btn_estu_Eliminar.Enabled = false;
            btn_estu_Eliminar.Visible = true;

            btn_estu_Cancelar.Enabled = false;
            btn_estu_Cancelar.Visible = false;

            btn_estu_Agregar.Enabled = true;

            dgv_estu_ListaEstu.Enabled = true;
            dgv_estu_ListaEstu.DataSource = null;
            dgv_estu_ListaEstu.DataSource = cn.devuelveTabla("SELECT Cod_Estudio as 'Cod. Estudio', Nombre FROM Estudios ORDER BY Nombre ASC");
            if (dgv_estu_ListaEstu.Columns.Count > 0)
            {
                dgv_estu_ListaEstu.Columns[dgv_estu_ListaEstu.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public void actualizarPrepagas()
        {
            ListBox_ListaPrepagas.Items.Clear();
            ListBox_ListaPrepagas.Enabled = true;

            btn_pre_ListaDetallada.Enabled = true;

            txt_pre_Nombre.Clear();
            txt_pre_Nombre.Enabled = false;

            txt_pre_CantEstudios.Clear();
            txt_pre_CantEstudios.Enabled = false;

            txt_pre_Codigo.Clear();
            txt_pre_Codigo.Enabled = false;

            txt_pre_ValorCosto.Clear();
            txt_pre_ValorCosto.Enabled = false;

            btn_pre_Agregar.Enabled = true;

            btn_pre_Modificar.Enabled = false;
            btn_pre_Modificar.Visible = true;

            btn_pre_GuardarModif.Enabled = false;
            btn_pre_GuardarModif.Visible = false;

            btn_pre_Guardar.Enabled = false;
            btn_pre_Guardar.Visible = false;

            btn_pre_Eliminar.Enabled = false;
            btn_pre_Eliminar.Visible = true;

            btn_pre_Cancelar.Enabled = false;
            btn_pre_Cancelar.Visible = false;

            lb_prepaga.Visible = false;
            radioB_pre_Suma.Visible = false;
            radioB_pre_Suma.Checked = false;

            radioB_pre_Multi.Visible = false;
            radioB_pre_Multi.Checked = false;

            ds = cn.DevolverValor("Select Nombre from PrePagas");
            foreach (DataRow fila in ds.Tables[0].Rows)
                ListBox_ListaPrepagas.Items.Add(fila[0].ToString());
        }

        public void actualizarMedicos()
        {
            txt_med_Apellido.Clear();

            txt_med_TotalOrdenes.Text = "0";
            txt_med_TotalEstudios.Text = "0";
            txt_med_TotalFactu.Text = "0,00";
            txt_med_TotalDetalle.Text = "0,00";

            btn_med_Agregar.Enabled = true;
            btn_med_Agregar.Visible = true;

            btn_med_Modificar.Enabled = false;
            btn_med_Modificar.Visible = true;

            dgv_med_OrdenesList.DataSource = null;
            dgv_med_DetalleOrden.DataSource = null;

            dgv_med_ListaMedic.DataSource = null;
            dgv_med_ListaMedic.DataSource = cn.devuelveTabla("SELECT Apellido, Nombre FROM Medicos ORDER BY Apellido ASC");
            if (dgv_med_ListaMedic.Columns.Count > 0)
            {
                dgv_med_ListaMedic.Columns[dgv_med_ListaMedic.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            
        }

        public void actualizarPacientes()
        {
            txt_paci_DNI.Clear();
            txt_paci_Nombre.Clear();
            txt_paci_Apellido.Clear();
            txt_paci_Telefono.Clear();

            txt_paci_DNI.Enabled = true;
            btn_paci_Buscar.Enabled = true;

            btn_paci_Agregar.Enabled = true;
            btn_paci_Agregar.Visible = true;

            btn_paci_Modificar.Enabled = false;
            btn_paci_Modificar.Visible = true;

            txt_paci_Nombre.Enabled = false;
            txt_paci_Apellido.Enabled = false;
            txt_paci_Telefono.Enabled = false;

            btn_paci_Guardar.Enabled = false;
            btn_paci_Guardar.Visible = false;

            btn_paci_ModifGuardar.Enabled = false;
            btn_paci_ModifGuardar.Visible = false;

            btn_paci_Cancelar.Enabled = false;
            btn_paci_Cancelar.Visible = false;

            dgv_paci_Estudios.DataSource = null;

            txt_paci_TotalFact.Text = "0,00";
        }

        public static DialogResult InputBox(string title, string promptText, ref string apellido, ref string nombre)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox Apellido = new TextBox();
            TextBox Nombre = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();
            MensajesErrores ms = new MensajesErrores();

            form.Text = title;
            Nombre.Text = "Nombre";
            if (promptText == "Paciente")
            {
                label.Text = promptText;
                Apellido.Text = "Apellido";
            }
            else
            {
                label.Text = promptText;
                Apellido.Text = apellido;
            }

            buttonOk.Text = "Aceptar";
            buttonCancel.Text = "Cancelar";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(30, 20, 372, 13);
            Apellido.SetBounds(32, 36, 200, 20);
            Nombre.SetBounds(165, 36, 200, 20);
            buttonOk.SetBounds(159, 72, 75, 23);
            buttonCancel.SetBounds(259, 72, 75, 23);

            label.AutoSize = true;
            Apellido.Anchor = Apellido.Anchor | AnchorStyles.Right;
            Nombre.Anchor = Nombre.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, Apellido, Nombre, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();

            if (apellido == "")
            {
                Apellido.Text = "Apellido";
                apellido = Apellido.Text;
            }
            else
            {
                apellido = Apellido.Text;
                nombre = Nombre.Text;
            }

            if(buttonCancel.DialogResult == DialogResult.Cancel)
            {
                return dialogResult;
            }
            else if(Nombre.Text == "Nombre" || Apellido.Text == "Apellido")
            {
                ms.MensajeCompletarCampos();
            }
            else
            {
                nombre = Nombre.Text;
                return dialogResult;
            }
            return dialogResult;
        }

        private void tc_MedicPagos_Selected(object sender, TabControlEventArgs e)
        {
            l_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            l_hora.Text = DateTime.Now.ToString("HH:mm");

            ds = cn.DevolverValor("SELECT count(Cod_OrdenMedica) + 1 FROM OrdenesMedicas");
            foreach (DataRow fila in ds.Tables[0].Rows)
                txt_ord_NroOrdenMedica.Text = fila[0].ToString();

            //actualizarOrdenesBasico();
            actualizarEstudios();
            actualizarPrepagas();
            actualizarMedicos();
            actualizarPacientes();
        }

        private void PantallaPrincipal_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DialogResult x = MessageBox.Show("¿Desea salir?", "Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (x == DialogResult.Yes)
            {
                try
                {
                    conexion.Open();
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "BACKUP DATABASE BaseMedicPagos TO DISK = 'C:\\BK-BaseDatos\\mydbBackUp.bak'";
                    cmd.Connection = conexion;
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
                catch
                {
                    MessageBox.Show("No se realizo el Backup", "Error Backup ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.ExitThread();
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
/////////////////////////////** ORDENES **/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btn_ord_BuscarPaciente_Click(object sender, EventArgs e)
        {
            string aux = null;
            string nombre = null;
            string apellido = null;

            txt_ord_ApellidoPaciente.Text = "";
            txt_ord_NomPaciente.Text = "";

            if (txt_ord_DNIpaciente.Text != "Ingrese DNI")
            {
                ds = cn.DevolverValor("select DNI from Pacientes where DNI = '" + txt_ord_DNIpaciente.Text + "'");
                foreach (DataRow fila in ds.Tables[0].Rows)
                    aux = fila[0].ToString();
                if (aux == null)
                {
                    ms.MensajeNoExisteAgre();

                    if (InputBox("Registro paciente", "Paciente", ref apellido, ref nombre) == DialogResult.OK)
                    {
                        if (apellido == "" || nombre == "" || apellido == null || nombre == null)
                        {
                            ms.MensajeNoAgrego();
                        }
                        else if (apellido == "Apellido" || nombre == "Nombre")
                        {
                            ms.MensajeNoAgrego();
                        }
                        else
                        {
                            txt_ord_ApellidoPaciente.Text = apellido;
                            txt_ord_NomPaciente.Text = nombre;

                            ord_GuardarPaciente();
                        }
                    }
                }
                else
                {
                    ds = cn.DevolverValor("select Nombre,Apellido from Pacientes where DNI = '" + txt_ord_DNIpaciente.Text + "'");
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        txt_ord_NomPaciente.Text = fila[0].ToString();
                        txt_ord_ApellidoPaciente.Text = fila[1].ToString();
                    }
                }
            }
            else
            {
                ms.MensajeCompletarCampos();
            }
        }

        private void ComboB_ord_PrePaga_SelectedIndexChanged(object sender, EventArgs e)
        {

            dgv_ord_Estudios.DataSource = null;
            dgv_ord_Estudios.DataSource = cn.devuelveTabla("Select E.Nombre,CONVERT (decimal(10,2), EP.CostoPrepaga) AS 'Costo $' from EstudiosxPrepagas EP,PrePagas P, Estudios E where P.Nombre= '" + ComboB_ord_PrePaga.SelectedItem.ToString() + "' and P.Cod_PrePaga = EP.Cod_PrePaga and E.Cod_Estudio = EP.Cod_Estudio");
            if (dgv_ord_Estudios.Columns.Count > 0)
            {
                dgv_ord_Estudios.Columns[dgv_ord_Estudios.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            txt_ord_Total.Text = "0,00";
        }

        private void BorrarPrepaga()
        {
            ComboB_ord_PrePaga.Items.Clear();
            ComboB_ord_PrePaga.Enabled = false;

            ComboB_ord_PrePaga.Items.Insert(0, "Seleccionar");
            ComboB_ord_PrePaga.SelectedIndex = 0;

            ds = cn.DevolverValor("Select Nombre from PrePagas");
            foreach (DataRow fila in ds.Tables[0].Rows)
                ComboB_ord_PrePaga.Items.Add(fila[0].ToString());
        }

        private void cB_ord_Particular_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckB_ord_Particular.Checked == true)
            {
                dgv_ord_Estudios.DataSource = null;
                BorrarPrepaga();

                dgv_ord_Estudios.DataSource = cn.devuelveTabla("Select Nombre,CONVERT (decimal(10,2), CostoParticular) AS 'Costo $' from EstudiosParticulares EP inner join Estudios E on EP.Cod_Estudio = E.Cod_Estudio");
                dgv_ord_Estudios.Columns[dgv_ord_Estudios.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                txt_ord_Total.Text = "0,00";
            }
            else
            {
                dgv_ord_Estudios.DataSource = null;
                BorrarPrepaga();
                ComboB_ord_PrePaga.Enabled = true;

                txt_ord_Total.Text = "0,00";
            }
        }

        private void dgv_ord_Estudios_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_ord_Estudios.Rows)
            {
                DataGridViewCheckBoxCell cellSelecion = row.Cells["dgv_ord_CheckBoxEstudios"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(cellSelecion.Value))
                {
                    cellSelecion.Value = false;
                }
            }
            txt_ord_Total.Text = "0,00";
        }

        private void dgv_ord_Estudios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal total = 0;

            if (e.RowIndex == -1)
                return;

            // Se toma la fila seleccionada
            DataGridViewRow row1 = dgv_ord_Estudios.Rows[e.RowIndex];

            DataGridViewCheckBoxCell cellSelecion = row1.Cells["dgv_ord_CheckBoxEstudios"] as DataGridViewCheckBoxCell;

            if (cellSelecion.Value == null)
                cellSelecion.Value = false;
            switch (cellSelecion.Value.ToString())
            {
                case "True": // RESTA
                    {
                        cellSelecion.Value = false;

                        decimal Total = 0;

                        foreach (DataGridViewRow row in dgv_ord_Estudios.Rows)
                        {
                            bool chequeo = Convert.ToBoolean(row.Cells[0].Value);
                            if (chequeo == true)
                            {
                                Total += Convert.ToDecimal(row.Cells["Costo $"].Value);
                            }
                            txt_ord_Total.Text = Total.ToString("N2");
                        }
                        break;
                    }
                case "False": // SUMA
                    {
                        cellSelecion.Value = true;

                        foreach (DataGridViewRow row in dgv_ord_Estudios.Rows)
                        {
                            bool chequeo = Convert.ToBoolean(row.Cells[0].Value);
                            if (chequeo == true)
                            {
                                total += Convert.ToDecimal(row.Cells["Costo $"].Value);
                            }
                            txt_ord_Total.Text = total.ToString("N2");
                        }
                        break;
                    }
            }
        }

        private void btn_ord_Guardar_Click(object sender, EventArgs e)
        {
            DateTime fechaHoy = DateTime.Now;

            int Cod_PrePaga = 0;
            int Cod_Medico = 0;

            int Cod_Estudio = 0;
            string NombreEstudio = null;
            decimal CostoxEstudio = 0;
            decimal ValorCosto = 0;
            int NNmaspor = 0;
            decimal Nomenclador_Nacional = 0;
            decimal CostoEstudioPrepaga = 0;

            decimal CostoxOrden = 0;
            decimal Total = 0;

            string aux = null;
            string aux1 = null;

            string nombre = null;
            string apellido = null;

            if (txt_ord_ApelliMedico.Text == "Ingrese apellido" || txt_ord_DNIpaciente.Text == "Ingrese DNI" || txt_ord_Total.Text == "0")
            {
                ms.MensajeCompletarCampos();
            }
            else
            {
                ds = cn.DevolverValor("select Cod_Medico from Medicos where Apellido = '" + txt_ord_ApelliMedico.Text + "'");
                foreach (DataRow fila in ds.Tables[0].Rows)
                    aux = fila[0].ToString();
                if (aux == null)
                {
                    ms.MensajeNoExisteAgre();

                    apellido = txt_ord_ApelliMedico.Text;
                    if (InputBox("Registro medico", "Medico", ref apellido, ref nombre) == DialogResult.OK)
                    {
                        if (apellido == "" || nombre == "" || apellido == null || nombre == null)
                        {
                            ms.MensajeNoAgrego();
                        }
                        else if (apellido == "Apellido" || nombre == "Nombre")
                        {
                            ms.MensajeNoAgrego();
                        }
                        else
                        {
                            aux = "S";

                            txt_ord_ApelliMedico.Text = apellido;
                            txt_ord_NombreMedico.Text = nombre;

                            ord_GuardarMedico();
                        }
                    }
                    else
                    {
                        ms.MensajeNoAgrego();
                    }
                }
                else
                {
                    aux = "S";
                }

                ds = cn.DevolverValor("select DNI from Pacientes where DNI =  '" + txt_ord_DNIpaciente.Text + "'");
                foreach (DataRow fila in ds.Tables[0].Rows)
                    aux1 = fila[0].ToString();
                if (aux1 == null)
                {
                    ms.MensajeNoExisteAgre();

                    if (InputBox("Registro paciente", "Paciente", ref apellido, ref nombre) == DialogResult.OK)
                    {
                        if (apellido == "" || nombre == "" || apellido == null || nombre == null)
                        {
                            ms.MensajeNoAgrego();
                        }
                        else if (apellido == "Apellido" || nombre == "Nombre")
                        {
                            ms.MensajeNoAgrego();
                        }
                        else
                        {
                            aux1 = "S";

                            txt_ord_ApellidoPaciente.Text = apellido;
                            txt_ord_NomPaciente.Text = nombre;

                            ord_GuardarPaciente();
                        }
                    }
                    else
                    {
                        ms.MensajeNoAgrego();
                    }
                }
                else
                {
                    aux1 = "S";
                }

                if (aux != null && aux1 != null)
                {
                    ds = cn.DevolverValor("select Cod_Medico from Medicos where Apellido = '" + txt_ord_ApelliMedico.Text + "'");
                    foreach (DataRow fila in ds.Tables[0].Rows)
                        Cod_Medico = Convert.ToInt32(fila[0].ToString());

                    //int day = fechaHoy.Day;
                    //dia.Text = day.ToString();

                    int month = fechaHoy.Month;
                    //mes.Text = month.ToString();

                    //int year = fechaHoy.Year;
                    //año.Text = year.ToString();

                    /*ds = cn.DevolverValor("SELECT CONVERT (time(0), SYSDATETIME())");
                    foreach (DataRow fila in ds.Tables[0].Rows)
                        hour = fila[0].ToString();*/

                    if (CheckB_ord_Particular.Checked == false) // ESTUDIOS PREPAGAS
                    {
                        if(ComboB_ord_PrePaga.SelectedItem.ToString() != "Seleccionar")
                        {
                            if (txt_ord_Total.Text != "0,00")
                            {
                                int i = 0;
                                ds = cn.DevolverValor("select Cod_PrePaga from PrePagas where Nombre = '" + ComboB_ord_PrePaga.SelectedItem + "'");
                                foreach (DataRow fila in ds.Tables[0].Rows)
                                    Cod_PrePaga = Convert.ToInt32(fila[0].ToString());

                                conexion.Open();
                                cmd.CommandText = "INSERT OrdenesMedicas(Cod_OrdenMedica,Cod_PrePaga,Cod_Medico,DNI_Paciente,Fecha_Hora,Fecha_Mes) VALUES ('" + txt_ord_NroOrdenMedica.Text + "','" + Cod_PrePaga + "','" + Cod_Medico + "','" + txt_ord_DNIpaciente.Text + "','" + fechaHoy + "','" + month + "')";
                                cmd.Connection = conexion;
                                cmd.ExecuteNonQuery();
                                conexion.Close();

                                foreach (DataGridViewRow row in dgv_ord_Estudios.Rows)
                                {
                                    DataGridViewCheckBoxCell cellSelecion = row.Cells["dgv_ord_CheckBoxEstudios"] as DataGridViewCheckBoxCell;
                                    if (Convert.ToBoolean(cellSelecion.Value))
                                    {
                                        ds = cn.DevolverValor("select E.Cod_Estudio,E.Nombre,EP.CostoPrepaga,P.ValorCosto,P.NNmaspor from Estudios E,EstudiosxPrepagas EP,PrePagas P where E.Nombre = '" + row.Cells[1].Value.ToString() + "' and EP.Cod_PrePaga = '" + Cod_PrePaga + "' and EP.Cod_PrePaga = P.Cod_PrePaga and E.Cod_Estudio=EP.Cod_Estudio");
                                        foreach (DataRow fila in ds.Tables[0].Rows)
                                        {
                                            i++;

                                            Cod_Estudio = Convert.ToInt32(fila[0]);
                                            txt_ord_CodEstudio.Text = Cod_Estudio.ToString();

                                            NombreEstudio = fila[1].ToString();
                                            CostoxEstudio = Convert.ToDecimal(fila[2]);
                                            ValorCosto = Convert.ToDecimal(fila[3]);
                                            NNmaspor = Convert.ToInt32(fila[4]);
                                        }

                                        ds = cn.DevolverValor("select Nomenclador_Nacional from Estudios where Nombre = '" + row.Cells[1].Value.ToString() + "'");
                                        foreach (DataRow fila in ds.Tables[0].Rows)
                                        {
                                            Nomenclador_Nacional = Convert.ToDecimal(fila[0]);
                                        }
                                        if (NNmaspor == 1)
                                        {
                                            CostoEstudioPrepaga = Nomenclador_Nacional + ValorCosto;
                                        }
                                        else if (NNmaspor == 2)
                                        {
                                            CostoEstudioPrepaga = Nomenclador_Nacional * ValorCosto;
                                        }

                                        conexion.Open();
                                        cmd.CommandText = "INSERT Detalle_OrdenesMedicas(Nro_Linea,Cod_OrdenMedica,Cod_Estudio,Nombre_Estudio,CostoxEstudio) VALUES ('" + i + "','" + txt_ord_NroOrdenMedica.Text + "','" + Cod_Estudio + "','" + NombreEstudio + "','" + (Convert.ToDecimal(CostoxEstudio)).ToString().Replace(',', '.') + "')";
                                        cmd.Connection = conexion;
                                        cmd.ExecuteNonQuery();
                                        conexion.Close();
                                    }
                                }

                                if (txt_ord_Total.Text != "0,00")
                                {
                                    ds = cn.DevolverValor("select CostoxEstudio from Detalle_OrdenesMedicas where Cod_OrdenMedica = '" + txt_ord_NroOrdenMedica.Text + "'");
                                    foreach (DataRow fila in ds.Tables[0].Rows)
                                    {
                                        CostoxOrden = Convert.ToDecimal(fila[0]);
                                        Total = Total + CostoxOrden;
                                    }

                                    conexion.Open();
                                    cmd.CommandText = "UPDATE OrdenesMedicas set Total_Costo = '" + (decimal.Parse(txt_ord_Total.Text)).ToString().Replace(',', '.') + "' where Cod_OrdenMedica = '" + txt_ord_NroOrdenMedica.Text + "'";
                                    cmd.Connection = conexion;
                                    cmd.ExecuteNonQuery();
                                    conexion.Close();

                                    ms.MensajeGuardar();
                                    actualizarOrdenes();
                                }
                                else
                                {
                                    ms.MensajeSeleccion();
                                }
                            }
                            else
                            {
                                ms.MensajeSeleccion();
                            }
                        }
                        else
                        {
                            ms.MensajeSeleccion();
                        }
                    }
                    else // ESTUDIOS PARTICULARES
                    {
                        if (txt_ord_Total.Text != "0,00")
                        {
                            conexion.Open();
                            cmd.CommandText = "INSERT OrdenesMedicas(Cod_OrdenMedica,Cod_Medico,DNI_Paciente,Fecha_Hora,Fecha_Mes) VALUES ('" + txt_ord_NroOrdenMedica.Text + "','" + Cod_Medico + "','" + txt_ord_DNIpaciente.Text + "','" + fechaHoy + "','" + month + "')";
                            cmd.Connection = conexion;
                            cmd.ExecuteNonQuery();
                            conexion.Close();

                            int i = 0;
                            foreach (DataGridViewRow row in dgv_ord_Estudios.Rows)
                            {
                                DataGridViewCheckBoxCell cellSelecion = row.Cells["dgv_ord_CheckBoxEstudios"] as DataGridViewCheckBoxCell;
                                if (Convert.ToBoolean(cellSelecion.Value))
                                {
                                    ds = cn.DevolverValor("select E.Cod_Estudio,E.Nombre,EP.CostoParticular from Estudios E inner join EstudiosParticulares EP on E.Nombre = '" + row.Cells[1].Value.ToString() + "' and E.Cod_Estudio = EP.Cod_Estudio");
                                    foreach (DataRow fila in ds.Tables[0].Rows)
                                    {
                                        i++;

                                        Cod_Estudio = Convert.ToInt32(fila[0]);
                                        txt_ord_CodEstudio.Text = Cod_Estudio.ToString();

                                        NombreEstudio = fila[1].ToString();
                                        CostoxEstudio = Convert.ToDecimal(fila[2]);
                                    }

                                    conexion.Open();
                                    cmd.CommandText = "INSERT Detalle_OrdenesMedicas(Nro_Linea,Cod_OrdenMedica,Cod_Estudio,Nombre_Estudio,CostoxEstudio) VALUES ('" + i + "','" + txt_ord_NroOrdenMedica.Text + "','" + Cod_Estudio + "','" + NombreEstudio + "','" + (Convert.ToDecimal(CostoxEstudio)).ToString().Replace(',', '.') + "')";
                                    cmd.Connection = conexion;
                                    cmd.ExecuteNonQuery();
                                    conexion.Close();
                                }
                            }

                            if (txt_ord_Total.Text != "0,00")
                            {
                                ds = cn.DevolverValor("select CostoxEstudio from Detalle_OrdenesMedicas where Cod_OrdenMedica = '" + txt_ord_NroOrdenMedica.Text + "'");
                                foreach (DataRow fila in ds.Tables[0].Rows)
                                {
                                    CostoxOrden = Convert.ToDecimal(fila[0]);
                                    Total = Total + CostoxOrden;
                                }

                                conexion.Open();
                                cmd.CommandText = "UPDATE OrdenesMedicas set Total_Costo = '" + (decimal.Parse(txt_ord_Total.Text)).ToString().Replace(',', '.') + "' where Cod_OrdenMedica = '" + txt_ord_NroOrdenMedica.Text + "'";
                                cmd.Connection = conexion;
                                cmd.ExecuteNonQuery();
                                conexion.Close();

                                ms.MensajeGuardar();
                                actualizarOrdenes();
                            }
                            else
                            {
                                ms.MensajeSeleccion();
                            }
                        }
                        else
                        {
                            ms.MensajeSeleccion();
                        }
                    }
                }
                else
                {
                    ms.MensajeNoGuardar();
                }
            }
        }

        public void ord_GuardarPaciente()
        {
            string aux = null;

            if (txt_ord_DNIpaciente.Text == "")
            {
                ms.MensajeCompletarCampos();
            }
            else
            {
                ds = cn.DevolverValor("select DNI from Pacientes where DNI = '" + txt_ord_DNIpaciente.Text + "'");
                foreach (DataRow fila in ds.Tables[0].Rows)
                    aux = fila[0].ToString();
                if (aux == null)
                {
                    conexion.Open();
                    cmd.CommandText = "INSERT Pacientes (DNI,Apellido,Nombre) VALUES ('" + txt_ord_DNIpaciente.Text + "','" + txt_ord_ApellidoPaciente.Text + "','" + txt_ord_NomPaciente.Text + "')";
                    cmd.Connection = conexion;
                    cmd.ExecuteNonQuery();
                    conexion.Close();

                    ms.MensajeAgregar();
                }
                else
                {
                    ms.MensajeExiste();
                }
            }
        }

        public void ord_GuardarMedico()
        {
            string aux = null;
            int CodMedico = 0;

            if (txt_ord_ApelliMedico.Text == "" || txt_ord_NombreMedico.Text == "")
            {
                ms.MensajeCompletarCampos();
            }
            else
            {
                ds = cn.DevolverValor("Select Cod_Medico from Medicos where Apellido = '" + txt_ord_ApelliMedico.Text + "' and Nombre = '" + txt_ord_NombreMedico.Text + "'");
                foreach (DataRow fila in ds.Tables[0].Rows)
                    aux = fila[0].ToString();
                if (aux == null)
                {
                    ds = cn.DevolverValor("SELECT count(Cod_Medico) + 1 FROM Medicos");
                    foreach (DataRow fila in ds.Tables[0].Rows)
                        CodMedico = Convert.ToInt16(fila[0]);

                    conexion.Open();
                    cmd.CommandText = "INSERT Medicos(Cod_Medico,Apellido,Nombre) VALUES ('" + CodMedico + "','" + txt_ord_ApelliMedico.Text + "','" + txt_ord_NombreMedico.Text + "')";
                    cmd.Connection = conexion;
                    cmd.ExecuteNonQuery();
                    conexion.Close();

                    ms.MensajeAgregar();
                }
                else
                {
                    ms.MensajeExiste();
                }
            }
        }
    
        private void txt_ord_ApelliMedico_Leave(object sender, EventArgs e)
        {
            if (txt_ord_ApelliMedico.Text.Length == 0)
            {
                txt_ord_ApelliMedico.Text = "Ingrese apellido";
                txt_ord_ApelliMedico.ForeColor = SystemColors.GrayText;
            }
        }

        private void txt_ord_ApelliMedico_Enter(object sender, EventArgs e)
        {
            if (txt_ord_ApelliMedico.Text == "Ingrese apellido")
            {
                txt_ord_ApelliMedico.Text = "";
                txt_ord_ApelliMedico.ForeColor = SystemColors.WindowText;
            }
        }

        private void txt_ord_DNIpaciente_Leave(object sender, EventArgs e)
        {
            if (txt_ord_DNIpaciente.Text.Length == 0)
            {
                txt_ord_DNIpaciente.Text = "Ingrese DNI";
                txt_ord_DNIpaciente.ForeColor = SystemColors.GrayText;
            }
        }

        private void txt_ord_DNIpaciente_Enter(object sender, EventArgs e)
        {
            if (txt_ord_DNIpaciente.Text == "Ingrese DNI")
            {
                txt_ord_DNIpaciente.Text = "";
                txt_ord_DNIpaciente.ForeColor = SystemColors.WindowText;
            }
        }

        private void txt_ord_ApelliMedico_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_ord_DNIpaciente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_ord_ListaDetalle_Click(object sender, EventArgs e)
        {
            ListaDetalladaOrdenes form = new ListaDetalladaOrdenes();
            abrirFormularioHijo(form);
        }
////////////////////////////** ESTUDIOS **//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void CheckB_estu_Particular_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckB_estu_Particular.Checked == true)  // cuando esta tildado el CheckBox, PARTICULARES
            {
                txt_estu_Nombre.Clear();
                txt_estu_Nombre.Enabled = false;

                txt_estu_CostoParti.Clear();
                txt_estu_CostoParti.Enabled = false;

                txt_estu_CostoPre.Clear();
                txt_estu_CostoPre.Enabled = false;

                txt_estu_Codigo.Clear();
                txt_estu_Codigo.Enabled = false;

                txt_estu_Nomenclador.Clear();
                txt_estu_Nomenclador.Enabled = false;

                btn_estu_Modificar.Enabled = false;
                btn_estu_Eliminar.Enabled = false;

                btn_estu_Agregar.Enabled = true;

                ComboB_estu_PrePaga.Items.Clear();
                ComboB_estu_PrePaga.Enabled = false;

                CheckB_estu_Prepagas.Checked = false;

                dgv_estu_ListaEstu.DataSource = null;
                dgv_estu_ListaEstu.DataSource = cn.devuelveTabla("Select E.Cod_Estudio, Nombre from EstudiosParticulares EP inner join Estudios E on EP.Cod_Estudio = E.Cod_Estudio");
                dgv_estu_ListaEstu.Columns[dgv_estu_ListaEstu.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                txt_estu_Nombre.Clear();
                txt_estu_Nombre.Enabled = false;

                txt_estu_CostoParti.Clear();
                txt_estu_CostoParti.Enabled = false;

                txt_estu_CostoPre.Clear();
                txt_estu_CostoPre.Enabled = false;

                txt_estu_Codigo.Clear();
                txt_estu_Codigo.Enabled = false;

                txt_estu_Nomenclador.Clear();
                txt_estu_Nomenclador.Enabled = false;

                btn_estu_Modificar.Enabled = false;
                btn_estu_Eliminar.Enabled = false;

                dgv_estu_ListaEstu.DataSource = null;
                dgv_estu_ListaEstu.DataSource = cn.devuelveTabla("select Cod_Estudio, Nombre from Estudios");
                dgv_estu_ListaEstu.Columns[dgv_estu_ListaEstu.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void CheckB_estu_Prepagas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckB_estu_Prepagas.Checked == true)  // cuando esta tildado el CheckBox, PREPAGAS
            {
                btn_estu_Agregar.Enabled = false;

                txt_estu_Nombre.Clear();
                txt_estu_Nombre.Enabled = false;

                txt_estu_CostoParti.Clear();
                txt_estu_CostoParti.Enabled = false;

                txt_estu_CostoPre.Clear();
                txt_estu_CostoPre.Enabled = false;

                txt_estu_Codigo.Clear();
                txt_estu_Codigo.Enabled = false;

                txt_estu_Nomenclador.Clear();
                txt_estu_Nomenclador.Enabled = false;

                btn_estu_Modificar.Enabled = false;
                btn_estu_Eliminar.Enabled = false;

                ComboB_estu_PrePaga.Items.Clear();
                ComboB_estu_PrePaga.Enabled = true;

                ComboB_estu_PrePaga.Items.Insert(0, "Seleccionar");
                ComboB_estu_PrePaga.SelectedIndex = 0;

                CheckB_estu_Particular.Checked = false;

                dgv_estu_ListaEstu.DataSource = null;

                ds = cn.DevolverValor("Select Nombre from PrePagas");
                foreach (DataRow fila in ds.Tables[0].Rows)
                    ComboB_estu_PrePaga.Items.Add(fila[0].ToString());
            }
            else
            {
                btn_estu_Agregar.Enabled = true;

                txt_estu_Nombre.Clear();
                txt_estu_Nombre.Enabled = false;

                txt_estu_CostoParti.Clear();
                txt_estu_CostoParti.Enabled = false;

                txt_estu_CostoPre.Clear();
                txt_estu_CostoPre.Enabled = false;

                txt_estu_Codigo.Clear();
                txt_estu_Codigo.Enabled = false;

                txt_estu_Nomenclador.Clear();
                txt_estu_Nomenclador.Enabled = false;

                btn_estu_Modificar.Enabled = false;
                btn_estu_Eliminar.Enabled = false;

                ComboB_estu_PrePaga.Items.Clear();
                ComboB_estu_PrePaga.Enabled = false;

                dgv_estu_ListaEstu.Enabled = true;
                dgv_estu_ListaEstu.DataSource = null;
                dgv_estu_ListaEstu.DataSource = cn.devuelveTabla("select Cod_Estudio, Nombre from Estudios");
                dgv_estu_ListaEstu.Columns[dgv_estu_ListaEstu.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void ComboB_estu_PrePaga_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboB_estu_PrePaga.SelectedItem.ToString() == "Seleccionar")
            {
                txt_estu_Nombre.Clear();
                txt_estu_Nombre.Enabled = false;

                txt_estu_CostoParti.Clear();
                txt_estu_CostoParti.Enabled = false;

                txt_estu_CostoPre.Clear();
                txt_estu_CostoPre.Enabled = false;

                txt_estu_Codigo.Clear();
                txt_estu_Codigo.Enabled = false;

                txt_estu_Nomenclador.Clear();
                txt_estu_Nomenclador.Enabled = false;

                btn_estu_Modificar.Enabled = false;
                btn_estu_Eliminar.Enabled = false;

                dgv_estu_ListaEstu.Enabled = false;
            }
            else
            {
                btn_estu_Agregar.Enabled = true;

                dgv_estu_ListaEstu.Enabled = true;
                dgv_estu_ListaEstu.DataSource = null;
                dgv_estu_ListaEstu.DataSource = cn.devuelveTabla("Select E.Cod_Estudio, E.Nombre from Estudios E,EstudiosxPrepagas EP,PrePagas P where P.Nombre= '" + ComboB_estu_PrePaga.SelectedItem.ToString() + "' and P.Cod_PrePaga = EP.Cod_PrePaga and E.Cod_Estudio = EP.Cod_Estudio");
                dgv_estu_ListaEstu.Columns[dgv_estu_ListaEstu.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dgv_estu_ListaEstu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            decimal ValorCosto = 0;
            int NNmaspor = 0;
            decimal Nomenclador_Nacional = 0;
            decimal CostoPrepaga = 0;
            string nombre = null;

            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex >= 0)
            {
                // Se toma la fila seleccionada
                DataGridViewRow row = dgv_estu_ListaEstu.Rows[e.RowIndex];
                // Se selecciona la celda del checkbox
                DataGridViewCheckBoxCell cellSelecion = row.Cells["dgv_estu_CheckBoxEstudios"] as DataGridViewCheckBoxCell;

                if (cellSelecion.Value == null)
                        cellSelecion.Value = false;
                switch (cellSelecion.Value.ToString())
                {
                    case "True":
                        {
                            cellSelecion.Value = false;

                            txt_estu_Nombre.Clear();
                            txt_estu_Nombre.Enabled = false;

                            txt_estu_CostoParti.Clear();
                            txt_estu_CostoParti.Enabled = false;

                            txt_estu_CostoPre.Clear();
                            txt_estu_CostoPre.Enabled = false;

                            txt_estu_Codigo.Clear();
                            txt_estu_Codigo.Enabled = false;

                            txt_estu_Nomenclador.Clear();
                            txt_estu_Nomenclador.Enabled = false;

                            btn_estu_Modificar.Enabled = false;
                            btn_estu_Eliminar.Enabled = false;

                            break;
                        }
                    case "False":
                        {
                            cellSelecion.Value = true;

                            // SOLO SE PUEDE SELECCIONAR UN SOLO CHECKBOX
                            foreach (DataGridViewRow row1 in dgv_estu_ListaEstu.Rows)
                            {
                                if (Convert.ToBoolean(row1.Cells[0].Value) == true)
                                {
                                    row1.Cells[0].Value = false;
                                    cellSelecion.Value = true;
                                }
                            }

                            if (CheckB_estu_Particular.Checked == true && CheckB_estu_Prepagas.Checked == false) // ESTUDIOS PARTICULARES
                            {
                                ds = cn.DevolverValor("select nombre from Estudios where Cod_Estudio = '" + row.Cells[1].Value.ToString() + "'");
                                foreach (DataRow fila in ds.Tables[0].Rows)
                                    txt_estu_Nombre.Text = fila[0].ToString();

                                ds = cn.DevolverValor("Select EP.Cod_Estudio,CostoParticular,Nomenclador_Nacional from EstudiosParticulares EP, Estudios E where E.Nombre = '" + txt_estu_Nombre.Text + "' and EP.Cod_Estudio = '" + row.Cells[1].Value.ToString() + "'");
                                foreach (DataRow fila in ds.Tables[0].Rows)
                                {
                                    txt_estu_Codigo.Text = Convert.ToInt32(fila[0]).ToString();
                                    txt_estu_CostoParti.Text = Convert.ToDecimal(fila[1]).ToString("N2");
                                    txt_estu_Nomenclador.Text = Convert.ToDecimal(fila[2]).ToString("N2");
                                }
                                txt_estu_CostoPre.Text = "0,00";
                            }
                            else if (CheckB_estu_Prepagas.Checked == true && CheckB_estu_Particular.Checked == false) // ESTUDIOS PREPAGAS
                            {
                                ds = cn.DevolverValor("select nombre from Estudios where Cod_Estudio = '" + row.Cells[1].Value.ToString() + "'");
                                foreach (DataRow fila in ds.Tables[0].Rows)
                                    txt_estu_Nombre.Text = fila[0].ToString();

                                ds = cn.DevolverValor("Select EP.Cod_Estudio,Nomenclador_Nacional,ValorCosto,NNmaspor from EstudiosxPrepagas EP, Estudios E, PrePagas P where E.Nombre = '" + txt_estu_Nombre.Text + "' and P.Cod_PrePaga = EP.Cod_PrePaga and EP.Cod_Estudio = '" + row.Cells[1].Value.ToString() + "' and EP.Cod_PrePaga = '" + ComboB_estu_PrePaga.SelectedIndex + "'");
                                foreach (DataRow fila in ds.Tables[0].Rows)
                                {
                                    txt_estu_Codigo.Text = Convert.ToInt32(fila[0]).ToString();
                                    txt_estu_Nomenclador.Text = Convert.ToDecimal(fila[1]).ToString("N2");
                                    Nomenclador_Nacional = Convert.ToDecimal(fila[1]);
                                    ValorCosto = Convert.ToDecimal(fila[2]);
                                    NNmaspor = Convert.ToInt32(fila[3]);
                                }

                                if (NNmaspor == 1)
                                {
                                    CostoPrepaga = Nomenclador_Nacional + ValorCosto;
                                }
                                else if (NNmaspor == 2)
                                {
                                    CostoPrepaga = Nomenclador_Nacional * ValorCosto;
                                }
                                txt_estu_CostoPre.Text = CostoPrepaga.ToString("N2");
                                txt_estu_CostoParti.Text = "0,00";
                            }
                            else if (CheckB_estu_Prepagas.Checked == false && CheckB_estu_Particular.Checked == false) // TODOS LOS ESTUDIOS
                            {
                                ds = cn.DevolverValor("select nombre from Estudios where Cod_Estudio = '" + row.Cells[1].Value.ToString() + "'");
                                foreach (DataRow fila in ds.Tables[0].Rows)
                                    nombre = fila[0].ToString();
                                txt_estu_Nombre.Text = nombre.Trim();

                                ds = cn.DevolverValor("select Cod_Estudio,Nomenclador_Nacional from Estudios where Nombre = '" + txt_estu_Nombre.Text + "' and Cod_Estudio = '" + row.Cells[1].Value.ToString() + "'");
                                foreach (DataRow fila in ds.Tables[0].Rows)
                                {
                                    txt_estu_Codigo.Text = Convert.ToInt32(fila[0]).ToString();
                                    txt_estu_Nomenclador.Text = Convert.ToDecimal(fila[1]).ToString("N2");
                                }
                                txt_estu_CostoPre.Text = "0,00";
                                txt_estu_CostoParti.Text = "0,00";
                            }
                            btn_estu_Modificar.Enabled = true;
                            btn_estu_Eliminar.Enabled = true;

                            break;
                        }
                }
            }
        }

        private void dgv_estu_ListaEstu_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_estu_Nombre.Clear();
            txt_estu_Nombre.Enabled = false;

            txt_estu_CostoParti.Clear();
            txt_estu_CostoParti.Enabled = false;

            txt_estu_CostoPre.Clear();
            txt_estu_CostoPre.Enabled = false;

            txt_estu_Codigo.Clear();
            txt_estu_Codigo.Enabled = false;

            txt_estu_Nomenclador.Clear();
            txt_estu_Nomenclador.Enabled = false;

            btn_estu_Modificar.Enabled = false;
            btn_estu_Eliminar.Enabled = false;
        }

        private void btn_estu_Agregar_Click(object sender, EventArgs e)
        {
            if (CheckB_estu_Particular.Checked == true && CheckB_estu_Prepagas.Checked == false)  // PARTICULARES
            {
                AgregarEstudio form = new AgregarEstudio();
                    form.CheckB_Particulares.Checked = true;
                abrirFormularioHijo(form);
            }
            else if (CheckB_estu_Prepagas.Checked == true && CheckB_estu_Particular.Checked == false)  // PREPAGAS
            {
                AgregarEstudio form = new AgregarEstudio();
                    form.CheckB_Prepagas.Checked = true;
                    form.txt_Prepaga.Text = this.ComboB_estu_PrePaga.SelectedItem.ToString();
                abrirFormularioHijo(form);
            }
            else
            {
                AgregarEstudio form = new AgregarEstudio();
                abrirFormularioHijo(form);
            }
        }

        private void btn_estu_Modificar_Click(object sender, EventArgs e)
        {
            if (dgv_estu_ListaEstu.SelectedCells == null)
            {
                ms.MensajeSeleccion();
            }
            else
            {
                if(CheckB_estu_Particular.Checked == true && CheckB_estu_Prepagas.Checked == false) // ESTUDIOS PARTICULARES
                {
                    txt_estu_CostoParti.Enabled = true;

                    btn_estu_Modificar.Enabled = false;
                    btn_estu_Modificar.Visible = false;

                    btn_estu_GuardarModif.Enabled = true;
                    btn_estu_GuardarModif.Visible = true;
                    btn_estu_GuardarModif.Location = new Point(353, 361);

                    btn_estu_Eliminar.Enabled = false;
                    btn_estu_Eliminar.Visible = false;

                    btn_estu_Agregar.Enabled = false;

                    btn_estu_Cancelar.Enabled = true;
                    btn_estu_Cancelar.Visible = true;
                    btn_estu_Cancelar.Location = new Point(580, 361);

                    dgv_estu_ListaEstu.Enabled = false;
                    CheckB_estu_Particular.Enabled = false;
                    CheckB_estu_Prepagas.Enabled = false;
                    ComboB_estu_PrePaga.Enabled = false;

                }
                else if (CheckB_estu_Prepagas.Checked == true && CheckB_estu_Particular.Checked == false)// ESTUDIOS PREPAGAS
                {
                    txt_estu_Nomenclador.Enabled = true;

                    btn_estu_Modificar.Enabled = false;
                    btn_estu_Modificar.Visible = false;

                    btn_estu_GuardarModif.Enabled = true;
                    btn_estu_GuardarModif.Visible = true;
                    btn_estu_GuardarModif.Location = new Point(353, 361);

                    btn_estu_Eliminar.Enabled = false;
                    btn_estu_Eliminar.Visible = false;

                    btn_estu_Agregar.Enabled = false;

                    btn_estu_Cancelar.Enabled = true;
                    btn_estu_Cancelar.Visible = true;
                    btn_estu_Cancelar.Location = new Point(580, 361);

                    dgv_estu_ListaEstu.Enabled = false;
                    CheckB_estu_Particular.Enabled = false;
                    CheckB_estu_Prepagas.Enabled = false;
                    ComboB_estu_PrePaga.Enabled = false;
                }
                else
                {
                    txt_estu_Nombre.Enabled = true;
                    txt_estu_Nomenclador.Enabled = true;

                    btn_estu_Modificar.Enabled = false;
                    btn_estu_Modificar.Visible = false;

                    btn_estu_GuardarModif.Enabled = true;
                    btn_estu_GuardarModif.Visible = true;
                    btn_estu_GuardarModif.Location = new Point(353, 361);

                    btn_estu_Eliminar.Enabled = false;
                    btn_estu_Eliminar.Visible = false;

                    btn_estu_Agregar.Enabled = false;

                    btn_estu_Cancelar.Enabled = true;
                    btn_estu_Cancelar.Visible = true;
                    btn_estu_Cancelar.Location = new Point(580, 361);

                    dgv_estu_ListaEstu.Enabled = false;
                    CheckB_estu_Particular.Enabled = false;
                    CheckB_estu_Prepagas.Enabled = false;
                    ComboB_estu_PrePaga.Enabled = false;
                }
            }
        }

        private void txt_estu_Nomenclador_KeyUp(object sender, KeyEventArgs e)
        {
            decimal ValorCosto = 0;
            int NNmaspor = 0;
            decimal Nomenclador_Nacional = 0;
            decimal Costo = 0;

           ds = cn.DevolverValor("select ValorCosto, NNmaspor from PrePagas where Cod_PrePaga = '" + ComboB_estu_PrePaga.SelectedIndex + "'");
            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                ValorCosto = Convert.ToDecimal(fila[0]);
                NNmaspor = Convert.ToInt32(fila[1]);
            }

            if (txt_estu_Nomenclador.TextLength > 0)
            {
                Nomenclador_Nacional = Convert.ToDecimal(txt_estu_Nomenclador.Text);
            }

            if (NNmaspor == 1)
            {
                Costo = Nomenclador_Nacional + ValorCosto;
            }
            else if (NNmaspor == 2)
            {
                Costo = Nomenclador_Nacional * ValorCosto;
            }
            txt_estu_CostoPre.Text = Costo.ToString("N2");
        }

        private void btn_estu_GuardarModif_Click(object sender, EventArgs e)
        {
            if (txt_estu_Nombre.Text == "" || txt_estu_CostoParti.Text == "" || txt_estu_Nomenclador.Text == "")
            {
                ms.MensajeCompletarCampos();
            }
            else if (CheckB_estu_Particular.Checked == true && CheckB_estu_Prepagas.Checked == false) // ESTUDIOS PARTICULARES
            {
                conexion.Open();
                cmd.CommandText = "UPDATE EstudiosParticulares set CostoParticular = '" + (decimal.Parse(txt_estu_CostoParti.Text)).ToString().Replace(',', '.') + "' where Cod_Estudio = '" + txt_estu_Codigo.Text + "'";
                cmd.Connection = conexion;
                cmd.ExecuteNonQuery();
                conexion.Close();

                ms.MensajeModificar();
                actualizarEstudios();
            }
            else if (CheckB_estu_Prepagas.Checked == true && CheckB_estu_Particular.Checked == false) // ESTUDIOS PREPAGAS
            {
                conexion.Open();
                cmd.CommandText = "UPDATE Estudios set Nomenclador_Nacional = '" + (decimal.Parse(txt_estu_Nomenclador.Text)).ToString().Replace(',', '.') + "' where Cod_Estudio = '" + txt_estu_Codigo.Text + "'";
                cmd.Connection = conexion;
                cmd.ExecuteNonQuery();

                cmd.CommandText = "UPDATE EstudiosxPrepagas set CostoPrepaga = '" + (decimal.Parse(txt_estu_CostoPre.Text)).ToString().Replace(',', '.') + "' where Cod_Estudio = '" + txt_estu_Codigo.Text + "'";
                cmd.Connection = conexion;
                cmd.ExecuteNonQuery();
                conexion.Close();

                ms.MensajeModificar();
                actualizarEstudios();
            }
            else if (CheckB_estu_Prepagas.Checked == false && CheckB_estu_Particular.Checked == false) // TODOS LOS ESTUDIOS
            {
                conexion.Open();
                cmd.Connection = conexion;
                cmd.CommandText = "UPDATE Estudios set Nombre = '" + txt_estu_Nombre.Text + "'" + ",Nomenclador_Nacional = '" + (decimal.Parse(txt_estu_Nomenclador.Text)).ToString().Replace(',', '.') + "' where Cod_Estudio = '" + txt_estu_Codigo.Text + "'";
                cmd.ExecuteNonQuery();
                conexion.Close();

                ms.MensajeModificar();
                actualizarEstudios();
            }
        }

        private void txt_estu_Nombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_estu_Eliminar_Click(object sender, EventArgs e)
        {
            string aux = null;

            if(dgv_estu_ListaEstu.SelectedCells == null)
            {
                ms.MensajeSeleccion();
            }
            else
            {
                DialogResult x = MessageBox.Show("     ¿Esta seguro?", "Eliminar Estudio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (x == DialogResult.Yes)
                {
                    if (CheckB_estu_Particular.Checked == true && CheckB_estu_Prepagas.Checked == false) // ESTUDIOS PARTICULARES
                    {
                        conexion.Open();
                        cmd.CommandText = "DELETE FROM EstudiosParticulares WHERE Cod_Estudio = '" + txt_estu_Codigo.Text + "'";
                        cmd.Connection = conexion;
                        cmd.ExecuteNonQuery();
                        conexion.Close();

                        ms.MensajeEliminar();
                        actualizarEstudios();
                    }
                    else if (CheckB_estu_Prepagas.Checked == true && CheckB_estu_Particular.Checked == false) // ESTUDIOS PREPAGAS
                    {
                        conexion.Open();
                        cmd.CommandText = "DELETE FROM EstudiosxPrepagas WHERE Cod_Estudio = '" + txt_estu_Codigo.Text + "' and Cod_PrePaga = '" + ComboB_estu_PrePaga.SelectedIndex + "'";
                        cmd.Connection = conexion;
                        cmd.ExecuteNonQuery();
                        conexion.Close();

                        ms.MensajeEliminar();
                        actualizarEstudios();
                    }
                    else if (CheckB_estu_Prepagas.Checked == false && CheckB_estu_Particular.Checked == false) // TODOS LOS ESTUDIOS
                    {
                        ds = cn.DevolverValor("select * from EstudiosParticulares where Cod_Estudio = '" + txt_estu_Codigo.Text + "'");
                        foreach (DataRow fila in ds.Tables[0].Rows)
                            aux = fila[0].ToString();
                            if (aux == null)
                            {
                                ds = cn.DevolverValor("select * from EstudiosxPrepagas where Cod_Estudio = '" + txt_estu_Codigo.Text + "'");
                                foreach (DataRow fila2 in ds.Tables[0].Rows)
                                    aux = fila2[0].ToString();
                                    if (aux == null)
                                    {
                                        conexion.Open();
                                        cmd.CommandText = "DELETE FROM Estudios WHERE Cod_Estudio = '" + txt_estu_Codigo.Text + "'";
                                        cmd.Connection = conexion;
                                        cmd.ExecuteNonQuery();
                                        conexion.Close();

                                        ms.MensajeEliminar();
                                        actualizarEstudios();
                                    }
                                    else
                                    {
                                        ms.MensajeNoEliminar();
                                    }
                            }
                            else
                            {
                                ms.MensajeNoEliminar();
                            }
                    }
                }
                else
                {
                    actualizarEstudios();
                }
            }
        }

        private void btn_estu_Cancelar_Click(object sender, EventArgs e)
        {
            actualizarEstudios();
        }
////////////////////////////** PREPAGAS **//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void ListBox_ListaPrepagas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = null;

            if (ListBox_ListaPrepagas.SelectedIndex < 0)
            {
                ms.MensajeSeleccion();
            }
            else
            {
                nombre = ListBox_ListaPrepagas.SelectedItem.ToString();
                txt_pre_Nombre.Text = nombre.Trim(); // Trim() saca espacios en blanco

                ds = cn.DevolverValor("SELECT cod_prepaga,ValorCosto FROM prepagas WHERE nombre = '" + txt_pre_Nombre.Text + "'");
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    txt_pre_Codigo.Text = fila[0].ToString();
                    txt_pre_ValorCosto.Text = Convert.ToDecimal(fila[1]).ToString("N2");
                }
                
                ds = cn.DevolverValor("SELECT count(cod_estudio) FROM EstudiosxPrepagas WHERE cod_prepaga = '" + txt_pre_Codigo.Text + "'");
                foreach (DataRow fila in ds.Tables[0].Rows)
                    txt_pre_CantEstudios.Text = fila[0].ToString();

                btn_pre_Modificar.Enabled = true;
                btn_pre_Eliminar.Enabled = true;
            }
        }

        private void btn_pre_ListaDetallada_Click(object sender, EventArgs e)
        {
            ListaDetalladaPrepagas form = new ListaDetalladaPrepagas();
            abrirFormularioHijo(form);
        }

        private void btn_pre_Agregar_Click(object sender, EventArgs e)
        {
            int aux = 1;
            int cant = 0;

            ListBox_ListaPrepagas.Enabled = false;

            btn_pre_ListaDetallada.Enabled = false;

            txt_pre_Nombre.Clear();
            txt_pre_Nombre.Enabled = true;
            txt_pre_Nombre.ReadOnly = false;

            txt_pre_ValorCosto.Clear();
            txt_pre_ValorCosto.Enabled = true;
            txt_pre_ValorCosto.ReadOnly = false;

            txt_pre_CantEstudios.Text = "0";

            btn_pre_Agregar.Enabled = false;

            btn_pre_Modificar.Enabled = false;
            btn_pre_Modificar.Visible = false;

            btn_pre_Guardar.Enabled = true;
            btn_pre_Guardar.Visible = true;
            btn_pre_Guardar.Location = new Point(475, 250);

            btn_pre_Eliminar.Enabled = false;
            btn_pre_Eliminar.Visible = false;

            btn_pre_Cancelar.Enabled = true;
            btn_pre_Cancelar.Visible = true;
            btn_pre_Cancelar.Location = new Point(709, 250);

            lb_prepaga.Visible = true;
            radioB_pre_Suma.Visible = true;
            radioB_pre_Multi.Visible = true;

            ds = cn.DevolverValor("select count(Cod_PrePaga) from PrePagas");
            foreach (DataRow fila in ds.Tables[0].Rows)
                cant = Convert.ToInt32(fila[0]);

            if(cant >= 0)
            {
                int i = 1;
                while (aux != 0)
                {
                    ds = cn.DevolverValor("SELECT Cod_PrePaga FROM PrePagas where Cod_PrePaga = '" + i + "'");
                    foreach (DataRow fila in ds.Tables[0].Rows)
                        txt_pre_CodAux.Text = fila[0].ToString();
                    if (txt_pre_CodAux.Text == "")
                    {
                        txt_pre_Codigo.Text = i.ToString();
                        aux = 0;
                    }
                    i++;
                    txt_pre_CodAux.Clear();
                }
            }
        }

        private void btn_pre_Modificar_Click(object sender, EventArgs e)
        {
            txt_pre_Nombre.Enabled = true;
            txt_pre_ValorCosto.Enabled = true;

            ListBox_ListaPrepagas.Enabled = false;

            btn_pre_ListaDetallada.Enabled = false;

            btn_pre_Agregar.Enabled = false;

            btn_pre_Modificar.Enabled = false;
            btn_pre_Modificar.Visible = false;

            btn_pre_GuardarModif.Enabled = true;
            btn_pre_GuardarModif.Visible = true;
            btn_pre_GuardarModif.Location = new Point(475, 250);

            btn_pre_Eliminar.Enabled = false;
            btn_pre_Eliminar.Visible = false;

            btn_pre_Cancelar.Enabled = true;
            btn_pre_Cancelar.Visible = true;
            btn_pre_Cancelar.Location = new Point(709, 250);
        }

        private void btn_pre_Eliminar_Click(object sender, EventArgs e)
        {
            string aux = null;

            ds = cn.DevolverValor("select Cod_Estudio from EstudiosxPrepagas where Cod_PrePaga = '" + txt_pre_Codigo.Text + "'");
            foreach (DataRow fila in ds.Tables[0].Rows)
                aux = fila[0].ToString();
            if (aux == null)
            {
                DialogResult x = MessageBox.Show("     ¿Esta seguro?", "Eliminar Estudio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (x == DialogResult.Yes)
                {
                    conexion.Open();
                    cmd.CommandText = "DELETE FROM PrePagas WHERE Nombre = '" + txt_pre_Nombre.Text + "' AND Cod_PrePaga = '" + txt_pre_Codigo.Text + "'";
                    cmd.Connection = conexion;
                    cmd.ExecuteNonQuery();
                    conexion.Close();

                    ms.MensajeEliminar();
                    actualizarPrepagas();
                }
                else
                {
                    actualizarPrepagas();
                }
            }
            else
            {
                ms.MensajeNoEliminar();
                actualizarPrepagas();
            }
        }

        private void btn_pre_GuardarModif_Click(object sender, EventArgs e)
        {
            if (txt_pre_Nombre.Text == "" || txt_pre_ValorCosto.Text == "")
            {
                ms.MensajeCompletarCampos();
            }
            else
            {
                conexion.Open();
                cmd.CommandText = "UPDATE PrePagas set Nombre = '" + txt_pre_Nombre.Text + "', ValorCosto = '" + (decimal.Parse(txt_pre_ValorCosto.Text)).ToString().Replace(',', '.') + "' where cod_prepaga = '" + txt_pre_Codigo.Text + "'";
                cmd.Connection = conexion;
                cmd.ExecuteNonQuery();
                conexion.Close();

                ms.MensajeModificar();
                actualizarPrepagas();
            }
        }

        private void btn_pre_Guardar_Click(object sender, EventArgs e)
        {
            string aux = null;
            int SumaMulti = 0;

            if (txt_pre_Nombre.Text == "" || txt_pre_ValorCosto.Text == "" || radioB_pre_Multi.Checked == false && radioB_pre_Suma.Checked == false)
            {
                ms.MensajeCompletarCampos();
            }
            else
            {
                if (radioB_pre_Suma.Checked == true)
                {
                    SumaMulti = 1;
                }
                else
                {
                    SumaMulti = 2;
                }

                ds = cn.DevolverValor("select Nombre from PrePagas where Nombre = '" + txt_pre_Nombre.Text + "'");
                foreach (DataRow fila in ds.Tables[0].Rows)
                    aux = fila[0].ToString();
                if (aux == null)
                {
                    conexion.Open();
                    cmd.CommandText = "INSERT PrePagas(Cod_PrePaga,Nombre,ValorCosto,NNmaspor) VALUES ('" + txt_pre_Codigo.Text + "','" + txt_pre_Nombre.Text + "','" + (decimal.Parse(txt_pre_ValorCosto.Text)).ToString().Replace(',', '.') + "','" + SumaMulti + "')";
                    cmd.Connection = conexion;
                    cmd.ExecuteNonQuery();
                    conexion.Close();

                    ms.MensajeAgregar();
                    actualizarPrepagas();
                }
                else
                {
                    ms.MensajeExiste();
                    actualizarPrepagas();
                }
            }
        }

        private void txt_pre_Nombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_pre_ValorCosto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_pre_Cancelar_Click(object sender, EventArgs e)
        {
            actualizarPrepagas();
        }
////////////////////////////** MEDICOS **///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btn_med_Agregar_Click(object sender, EventArgs e)
        {
            AgregarModificarMedico form = new AgregarModificarMedico();
            abrirFormularioHijo(form);
        }

        private void dgv_med_ListaMedic_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            decimal CostoxEstudio = 0;
            decimal Total = 0;

            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex >= 0)
            {
                // Se toma la fila seleccionada
                DataGridViewRow row = dgv_med_ListaMedic.Rows[e.RowIndex];
                // Se selecciona la celda del checkbox
                DataGridViewCheckBoxCell cellSelecion = row.Cells["dgv_med_CheckBoxListMedic"] as DataGridViewCheckBoxCell;

                if (cellSelecion.Value == null)
                    cellSelecion.Value = false;
                switch (cellSelecion.Value.ToString())
                {
                    case "True":
                        {
                            cellSelecion.Value = false;

                            txt_med_TotalOrdenes.Text = "0";
                            txt_med_TotalEstudios.Text = "0";

                            btn_med_Modificar.Enabled = false;

                            dgv_med_OrdenesList.DataSource = null;
                            dgv_med_DetalleOrden.DataSource = null;

                            txt_med_TotalFactu.Text = "0";
                            txt_med_TotalDetalle.Text = "0";

                            break;
                        }
                    case "False":
                        {
                            cellSelecion.Value = true;

                            btn_med_Modificar.Enabled = true;

                            // SOLO SE PUEDE SELECCIONAR UN SOLO CHECKBOX
                            foreach (DataGridViewRow row1 in dgv_med_ListaMedic.Rows)
                            {
                                if (Convert.ToBoolean(row1.Cells[0].Value) == true)
                                {
                                    row1.Cells[0].Value = false;
                                    cellSelecion.Value = true;

                                    dgv_med_DetalleOrden.DataSource = null;
                                }
                            }

                            ds = cn.DevolverValor("select Cod_Medico from Medicos where Apellido = '" + row.Cells[1].Value.ToString() + "'");
                            foreach (DataRow fila in ds.Tables[0].Rows)
                                txt_med_CodMedico.Text = fila[0].ToString();

                            dgv_med_OrdenesList.DataSource = cn.devuelveTabla("select DISTINCT OM.Cod_OrdenMedica as 'Cod. Orden', OM.DNI_Paciente as 'DNI Paciente', Om.Fecha_Hora as 'Fecha', CONVERT (decimal(10,2), OM.Total_Costo) as 'Total' from OrdenesMedicas OM, Medicos M where  OM.Cod_Medico = '" + txt_med_CodMedico.Text + "'");
                            dgv_med_OrdenesList.Columns[dgv_med_OrdenesList.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                            ds = cn.DevolverValor("select Total_Costo from OrdenesMedicas where Cod_Medico = '" + txt_med_CodMedico.Text + "'");
                            foreach (DataRow fila in ds.Tables[0].Rows)
                            {
                                CostoxEstudio = Convert.ToDecimal(fila[0]);
                                Total = Total + CostoxEstudio;
                            }
                            txt_med_TotalFactu.Text = Total.ToString("N2");

                            ds = cn.DevolverValor("select COUNT(Cod_OrdenMedica) from OrdenesMedicas where Cod_Medico = '" + txt_med_CodMedico.Text + "'");
                            foreach (DataRow fila in ds.Tables[0].Rows)
                                txt_med_TotalOrdenes.Text = fila[0].ToString();

                            ds = cn.DevolverValor("SELECT count(cod_estudio) FROM Detalle_OrdenesMedicas DO, OrdenesMedicas O where DO.Cod_OrdenMedica = O.Cod_OrdenMedica and Cod_Medico = '" + txt_med_CodMedico.Text + "'");
                            foreach (DataRow fila in ds.Tables[0].Rows)
                                txt_med_TotalEstudios.Text = fila[0].ToString();

                            break;
                        }
                }
            }
        }

        private void dgv_med_ListaMedic_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv_med_OrdenesList.DataSource = null;
            dgv_med_DetalleOrden.DataSource = null;

            btn_med_Modificar.Enabled = false;

            txt_med_TotalFactu.Text = "0";
            txt_med_TotalDetalle.Text = "0";
        }

        private void dgv_med_OrdenesList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            decimal CostoxEstudio = 0;
            decimal Total = 0;

            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex >= 0)
            {
                // Se toma la fila seleccionada
                DataGridViewRow row = dgv_med_OrdenesList.Rows[e.RowIndex];
                // Se selecciona la celda del checkbox
                DataGridViewCheckBoxCell cellSelecion = row.Cells["dgv_med_CheckBoxListOrdenesMedic"] as DataGridViewCheckBoxCell;

                if (cellSelecion.Value == null)
                    cellSelecion.Value = false;
                switch (cellSelecion.Value.ToString())
                {
                    case "True":
                        {
                            cellSelecion.Value = false;
                            dgv_med_DetalleOrden.DataSource = null;
                            txt_med_TotalDetalle.Text = "0";

                            break;
                        }
                    case "False":
                        {
                            cellSelecion.Value = true;

                            // SOLO SE PUEDE SELECCIONAR UN SOLO CHECKBOX
                            foreach (DataGridViewRow row1 in dgv_med_OrdenesList.Rows)
                            {
                                if (Convert.ToBoolean(row1.Cells[0].Value) == true)
                                {
                                    row1.Cells[0].Value = false;
                                    cellSelecion.Value = true;
                                }
                            }

                            dgv_med_DetalleOrden.DataSource = cn.devuelveTabla("select Nro_Linea AS 'Nro. Linea',Nombre_Estudio AS 'Estudio',CONVERT (decimal(10,2), CostoxEstudio) AS 'Costo $' from Detalle_OrdenesMedicas where Cod_OrdenMedica = '" + row.Cells[1].Value.ToString() + "' order by Nro_Linea ASC");
                            dgv_med_DetalleOrden.Columns[dgv_med_DetalleOrden.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                            ds = cn.DevolverValor("select CostoxEstudio from Detalle_OrdenesMedicas where Cod_OrdenMedica = '" + row.Cells[1].Value.ToString() + "'");
                            foreach (DataRow fila in ds.Tables[0].Rows)
                            {
                                CostoxEstudio = Convert.ToDecimal(fila[0]);
                                Total = Total + CostoxEstudio;
                            }
                            txt_med_TotalDetalle.Text = Total.ToString("N2");

                            break;
                        }
                }
            }
        }

        private void dgv_med_OrdenesList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv_med_DetalleOrden.DataSource = null;
            txt_med_TotalDetalle.Text = "0";
        }

        private void btn_med_Modificar_Click(object sender, EventArgs e)
        {
            ds = cn.DevolverValor("SELECT Apellido, Nombre FROM Medicos WHERE Cod_Medico = '" + txt_med_CodMedico.Text + "'");
            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                txt_med_Apellido.Text = fila[0].ToString();
                txt_med_Nombre.Text = fila[1].ToString();
            }

            AgregarModificarMedico form = new AgregarModificarMedico();
            form.txt_Apellido.Text = this.txt_med_Apellido.Text;
            form.txt_Nombre.Text = this.txt_med_Nombre.Text;
            form.txt_CodMedico.Text = this.txt_med_CodMedico.Text;

            abrirFormularioHijo(form);
        }

////////////////////////////** PACIENTES **//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btn_paci_Buscar_Click(object sender, EventArgs e)
        {
            string aux = null;

            string nombre = null;
            string apellido = null;
            string telefono = null;

            decimal CostoxOrden = 0;
            decimal Total = 0;

            if (txt_paci_DNI.Text != "")
            {
                ds = cn.DevolverValor("select DNI from Pacientes where DNI = '" + txt_paci_DNI.Text + "'");
                foreach (DataRow fila in ds.Tables[0].Rows)
                    aux = fila[0].ToString();
                if (aux == null)
                {
                    ms.MensajeNoExisteAgre();

                    txt_paci_Nombre.Clear();
                    txt_paci_Apellido.Clear();
                    txt_paci_Telefono.Clear();

                    txt_paci_DNI.Enabled = true;
                    txt_paci_Nombre.Enabled = true;
                    txt_paci_Apellido.Enabled = true;
                    txt_paci_Telefono.Enabled = true;

                    btn_paci_Buscar.Enabled = false;

                    btn_paci_Agregar.Enabled = false;
                    btn_paci_Agregar.Visible = false;

                    btn_paci_Modificar.Enabled = false;
                    btn_paci_Modificar.Visible = false;

                    btn_paci_Guardar.Enabled = true;
                    btn_paci_Guardar.Visible = true;
                    btn_paci_Guardar.Location = new Point(697, 62);

                    btn_paci_Cancelar.Enabled = true;
                    btn_paci_Cancelar.Visible = true;
                    btn_paci_Cancelar.Location = new Point(697, 135);

                    dgv_paci_Estudios.DataSource = null;

                    txt_paci_TotalFact.Text = "0,00";
                }
                else
                {
                    btn_paci_Modificar.Enabled = true;

                    ds = cn.DevolverValor("select Nombre,Apellido,Telefono from Pacientes where DNI = '" + txt_paci_DNI.Text + "'");
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        nombre = fila[0].ToString();
                        txt_paci_Nombre.Text = nombre.Trim();

                        apellido = fila[1].ToString();
                        txt_paci_Apellido.Text = apellido.Trim();

                        telefono = fila[2].ToString();
                        txt_paci_Telefono.Text = telefono.Trim();
                    }

                    dgv_paci_Estudios.DataSource = cn.devuelveTabla("select Detalle_OrdenesMedicas.Cod_OrdenMedica AS 'Cod. Orden',Nro_Linea AS 'Nro. Linea',Nombre_Estudio AS 'Nombre',Fecha_Hora AS 'Fecha',CONVERT (decimal(10,2), CostoxEstudio) AS 'Costo $' from Detalle_OrdenesMedicas, OrdenesMedicas where DNI_Paciente = '" + txt_paci_DNI.Text + "' and OrdenesMedicas.Cod_OrdenMedica = Detalle_OrdenesMedicas.Cod_OrdenMedica order by Fecha_Hora ASC");
                    dgv_paci_Estudios.Columns[dgv_paci_Estudios.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    if (dgv_paci_Estudios.Rows.Count != 0)
                    {
                        ds = cn.DevolverValor("select CostoxEstudio from OrdenesMedicas,Detalle_OrdenesMedicas where DNI_Paciente = '" + txt_paci_DNI.Text + "' and OrdenesMedicas.Cod_OrdenMedica = Detalle_OrdenesMedicas.Cod_OrdenMedica");
                        foreach (DataRow fila in ds.Tables[0].Rows)
                        {
                            CostoxOrden = Convert.ToDecimal(fila[0]);
                            Total = Total + CostoxOrden;
                        }
                        txt_paci_TotalFact.Text = Total.ToString("N2");
                    }
                    else
                    {
                        MessageBox.Show("No hay estudios realizados", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                ms.MensajeCompletarCampos();
            }
        }

        private void btn_paci_Agregar_Click(object sender, EventArgs e)
        {
            string aux = null;

            ds = cn.DevolverValor("select Nombre,Apellido,Telefono from Pacientes where DNI = '" + txt_paci_DNI.Text + "'");
            foreach (DataRow fila in ds.Tables[0].Rows)
                aux = fila[0].ToString();
            if (aux != null)
            {
                actualizarPacientes();

                txt_paci_DNI.Enabled = true;
                txt_paci_Nombre.Enabled = true;
                txt_paci_Apellido.Enabled = true;
                txt_paci_Telefono.Enabled = true;

                btn_paci_Buscar.Enabled = false;

                btn_paci_Agregar.Enabled = false;
                btn_paci_Agregar.Visible = false;

                btn_paci_Modificar.Enabled = false;
                btn_paci_Modificar.Visible = false;

                btn_paci_Guardar.Enabled = true;
                btn_paci_Guardar.Visible = true;
                btn_paci_Guardar.Location = new Point(697, 62);

                btn_paci_Cancelar.Enabled = true;
                btn_paci_Cancelar.Visible = true;
                btn_paci_Cancelar.Location = new Point(697, 135);
            }
            else
            {
                txt_paci_Nombre.Clear();
                txt_paci_Apellido.Clear();
                txt_paci_Telefono.Clear();

                txt_paci_Nombre.Enabled = true;
                txt_paci_Apellido.Enabled = true;
                txt_paci_Telefono.Enabled = true;

                btn_paci_Buscar.Enabled = false;

                btn_paci_Agregar.Enabled = false;
                btn_paci_Agregar.Visible = false;

                btn_paci_Modificar.Enabled = false;
                btn_paci_Modificar.Visible = false;

                btn_paci_Guardar.Enabled = true;
                btn_paci_Guardar.Visible = true;
                btn_paci_Guardar.Location = new Point(697, 62);

                btn_paci_Cancelar.Enabled = true;
                btn_paci_Cancelar.Visible = true;
                btn_paci_Cancelar.Location = new Point(697, 135);
            }
        }

        private void btn_paci_Modificar_Click(object sender, EventArgs e)
        {
            txt_paci_DNI.Enabled = false;
            txt_paci_Nombre.Enabled = true;
            txt_paci_Apellido.Enabled = true;
            txt_paci_Telefono.Enabled = true;

            btn_paci_Buscar.Enabled = false;

            btn_paci_Agregar.Enabled = false;
            btn_paci_Agregar.Visible = false;

            btn_paci_Modificar.Enabled = false;
            btn_paci_Modificar.Visible = false;

            btn_paci_ModifGuardar.Enabled = true;
            btn_paci_ModifGuardar.Visible = true;
            btn_paci_ModifGuardar.Location = new Point(697, 62);

            btn_paci_Cancelar.Enabled = true;
            btn_paci_Cancelar.Visible = true;
            btn_paci_Cancelar.Location = new Point(697, 135);

            dgv_paci_Estudios.DataSource = null;

            txt_paci_TotalFact.Text = "0,00";
        }

        private void btn_paci_ModifGuardar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            cmd.CommandText = "UPDATE Pacientes set DNI = '" + txt_paci_DNI.Text + "', Nombre = '" + txt_paci_Nombre.Text + "', Apellido = '" + txt_paci_Apellido.Text + "', Telefono = '" + txt_paci_Telefono.Text + "' where DNI = '" + txt_paci_DNI.Text + "'";
            cmd.Connection = conexion;
            cmd.ExecuteNonQuery();
            conexion.Close();

            ms.MensajeModificar();
            actualizarPacientes();
        }

        private void btn_paci_Guardar_Click(object sender, EventArgs e)
        {
            string aux = null;

            if (txt_paci_DNI.Text == "" || txt_paci_Nombre.Text == "" || txt_paci_Apellido.Text == "")
            {
                ms.MensajeCompletarCampos();
            }
            else
            {
                ds = cn.DevolverValor("select DNI from Pacientes where DNI = '" + txt_paci_DNI.Text + "'");
                foreach (DataRow fila in ds.Tables[0].Rows)
                    aux = fila[0].ToString();
                if (aux == null)
                {
                    conexion.Open();
                    cmd.CommandText = "INSERT Pacientes(DNI,Nombre,Apellido,Telefono) VALUES ('" + txt_paci_DNI.Text + "','" + txt_paci_Nombre.Text + "','" + txt_paci_Apellido.Text + "','" + txt_paci_Telefono.Text + "')";
                    cmd.Connection = conexion;
                    cmd.ExecuteNonQuery();
                    conexion.Close();

                    ms.MensajeAgregar();
                    actualizarPacientes();
                }
                else
                {
                    ms.MensajeExiste();
                    actualizarPacientes();
                }
            }
        }

        private void txt_paci_DNI_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_paci_Nombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_paci_Apellido_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_paci_Telefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_paci_Cancelar_Click(object sender, EventArgs e)
        {
            actualizarPacientes();
        }
    }
}
