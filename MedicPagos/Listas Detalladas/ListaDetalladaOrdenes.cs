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
    public partial class ListaDetalladaOrdenes : Form
    {
        //DateTime fechaHoy = DateTime.Now;
        Conexion cn = new Conexion();
        DataSet ds = new DataSet();
        MensajesErrores ms = new MensajesErrores();

        public ListaDetalladaOrdenes()
        {
            InitializeComponent();
        }

        private void ListaDetallada_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        public void actualizar()
        {
            /*ComboB_filtroMes.Items.Clear();
            ComboB_filtroMes.Items.Insert(0, "Seleccionar");
            ComboB_filtroMes.Items.Insert(1, "Enero");
            ComboB_filtroMes.Items.Insert(2, "Febrero");
            ComboB_filtroMes.Items.Insert(3, "Marzo");
            ComboB_filtroMes.Items.Insert(4, "Abril");
            ComboB_filtroMes.Items.Insert(5, "Mayo");
            ComboB_filtroMes.Items.Insert(6, "Junio");
            ComboB_filtroMes.Items.Insert(7, "Julio");
            ComboB_filtroMes.Items.Insert(8, "Agosto");
            ComboB_filtroMes.Items.Insert(9, "Septiembre");
            ComboB_filtroMes.Items.Insert(10, "Octubre");
            ComboB_filtroMes.Items.Insert(11, "Noviembre");
            ComboB_filtroMes.Items.Insert(12, "Diciembre");*/

            dgv_ListaOrdenes.DataSource = null;
            dgv_DetalleOrden.DataSource = null;

            ActualizarPrepaga();

            CheckB_Particulares.Enabled = false;
            CheckB_Particulares.Checked = false;

            ComboB_filtroMes.SelectedIndex = 0;

            txt_TotalLista.Text = "0,00";
            txt_TotalDetalle.Text = "0,00";
        }

        private void ActualizarPrepaga()
        {
            ComboB_PrePaga.Items.Clear();
            ComboB_PrePaga.Enabled = false;

            ComboB_PrePaga.Items.Insert(0, "Seleccionar");
            ComboB_PrePaga.SelectedIndex = 0;

            ds = cn.DevolverValor("Select Nombre from PrePagas");
            foreach (DataRow fila in ds.Tables[0].Rows)
                ComboB_PrePaga.Items.Add(fila[0].ToString());
        }

        private void ComboB_filtroMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal CostoxOrden = 0;
            decimal Total = 0;
            //int month = fechaHoy.Month;

            dgv_DetalleOrden.DataSource = null;
            dgv_ListaOrdenes.DataSource = null;
            txt_TotalLista.Text = "0,00";
            txt_TotalDetalle.Text = "0,00";

            if (CheckB_Particulares.Checked == true) // PARTICULARES
            {
                ActualizarPrepaga();

                dgv_ListaOrdenes.DataSource = cn.devuelveTabla("select Cod_OrdenMedica AS 'Cod. Orden',Apellido AS 'Medico',DNI_Paciente AS 'DNI Paciente',Fecha_Hora AS 'Fecha',CONVERT (decimal(10,2), Total_Costo) AS 'Total $' from OrdenesMedicas OM,Medicos M where Cod_PrePaga IS NULL and OM.Cod_Medico = M.Cod_Medico and Fecha_Mes = '" + ComboB_filtroMes.SelectedIndex + "' order by Fecha_Hora ASC");
                dgv_ListaOrdenes.Columns[dgv_ListaOrdenes.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                if (dgv_ListaOrdenes.Rows.Count != 0)
                {
                    ds = cn.DevolverValor("select Total_Costo from OrdenesMedicas where Fecha_Mes = '" + ComboB_filtroMes.SelectedIndex + "' and Cod_PrePaga IS NULL");
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        CostoxOrden = Convert.ToDecimal(fila[0]);
                        Total = Total + CostoxOrden;
                    }
                    txt_TotalLista.Text = Total.ToString("N2");
                }
            }
            else if(ComboB_PrePaga.SelectedIndex > 0) // PREPAGAS
            {
                ComboB_PrePaga.Enabled = true;
                CheckB_Particulares.Checked = false;

                ds = cn.DevolverValor("select Cod_Prepaga from PrePagas where Nombre = '" + ComboB_PrePaga.SelectedItem + "'");
                foreach (DataRow fila in ds.Tables[0].Rows)
                    txt_CodPre.Text = Convert.ToString(fila[0]);

                dgv_ListaOrdenes.DataSource = cn.devuelveTabla("select Cod_OrdenMedica AS 'Cod. Orden',Apellido AS 'Medico',DNI_Paciente AS 'DNI Paciente',Fecha_Hora AS 'Fecha',CONVERT (decimal(10,2), Total_Costo) AS 'Total $' from OrdenesMedicas,Medicos where Cod_PrePaga = '" + txt_CodPre.Text + "' and OrdenesMedicas.Cod_Medico = Medicos.Cod_Medico and Fecha_Mes = '" + ComboB_filtroMes.SelectedIndex + "' order by Fecha_Hora ASC");
                dgv_ListaOrdenes.Columns[dgv_ListaOrdenes.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                if (dgv_ListaOrdenes.Rows.Count >= 0)
                {
                    ds = cn.DevolverValor("select Total_Costo from OrdenesMedicas where Fecha_Mes = '" + ComboB_filtroMes.SelectedIndex + "' and Cod_PrePaga = '" + txt_CodPre.Text + "'");
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        CostoxOrden = Convert.ToDecimal(fila[0]);
                        Total = Total + CostoxOrden;
                    }
                    txt_TotalLista.Text = Total.ToString("N2");
                }
            }
            else // TODOS
            {
                ActualizarPrepaga();

                ComboB_PrePaga.Enabled = true;
                CheckB_Particulares.Enabled = true;

                dgv_ListaOrdenes.DataSource = cn.devuelveTabla("select Cod_OrdenMedica AS 'Cod. Orden',Apellido AS 'Medico',DNI_Paciente AS 'DNI Paciente',Fecha_Hora AS 'Fecha',CONVERT (decimal(10,2), Total_Costo) AS 'Total $' from OrdenesMedicas OM,Medicos M where OM.Cod_Medico = M.Cod_Medico and Fecha_Mes = '" + ComboB_filtroMes.SelectedIndex + "' order by Fecha_Hora ASC");
                dgv_ListaOrdenes.Columns[dgv_ListaOrdenes.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                if (ComboB_filtroMes.SelectedIndex > 0)
                {
                    ds = cn.DevolverValor("select Total_Costo from OrdenesMedicas where Fecha_Mes = '" + ComboB_filtroMes.SelectedIndex + "'");
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        CostoxOrden = Convert.ToDecimal(fila[0]);
                        Total = Total + CostoxOrden;
                    }
                    txt_TotalLista.Text = Total.ToString("N2");
                }
                else
                {
                    actualizar();
                }
            }
        }

        private void cb_PrePaga_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal CostoxOrden = 0;
            decimal Total = 0;
            //int month = fechaHoy.Month;

            dgv_DetalleOrden.DataSource = null;
            txt_TotalLista.Text = "0,00";
            txt_TotalDetalle.Text = "0,00";

            if(ComboB_PrePaga.SelectedIndex > 0)
            {
                ds = cn.DevolverValor("select Cod_Prepaga from PrePagas where Nombre = '" + ComboB_PrePaga.SelectedItem + "'");
                foreach (DataRow fila in ds.Tables[0].Rows)
                    txt_CodPre.Text = Convert.ToString(fila[0]);

                dgv_ListaOrdenes.DataSource = null;
                dgv_ListaOrdenes.DataSource = cn.devuelveTabla("select Cod_OrdenMedica AS 'Cod. Orden',Apellido AS 'Medico',DNI_Paciente AS 'DNI Paciente',Fecha_Hora AS 'Fecha',CONVERT (decimal(10,2), Total_Costo) AS 'Total $' from OrdenesMedicas,Medicos where Cod_PrePaga = '" + txt_CodPre.Text + "' and OrdenesMedicas.Cod_Medico = Medicos.Cod_Medico and Fecha_Mes = '" + ComboB_filtroMes.SelectedIndex + "' order by Fecha_Hora ASC");
                dgv_ListaOrdenes.Columns[dgv_ListaOrdenes.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                if (dgv_ListaOrdenes.Rows.Count != 0)
                {
                    ds = cn.DevolverValor("select Total_Costo from OrdenesMedicas where Fecha_Mes = '" + ComboB_filtroMes.SelectedIndex + "' and Cod_PrePaga = '" + txt_CodPre.Text + "'");
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        CostoxOrden = Convert.ToDecimal(fila[0]);
                        Total = Total + CostoxOrden;
                    }
                    txt_TotalLista.Text = Total.ToString("N2");
                }
            }
            else if (ComboB_filtroMes.SelectedIndex > 0)
            {
                dgv_ListaOrdenes.DataSource = cn.devuelveTabla("select Cod_OrdenMedica AS 'Cod. Orden',Apellido AS 'Medico',DNI_Paciente AS 'DNI Paciente',Fecha_Hora AS 'Fecha',CONVERT (decimal(10,2), Total_Costo) AS 'Total $' from OrdenesMedicas OM,Medicos M where OM.Cod_Medico = M.Cod_Medico and Fecha_Mes = '" + ComboB_filtroMes.SelectedIndex + "' order by Fecha_Hora ASC");
                dgv_ListaOrdenes.Columns[dgv_ListaOrdenes.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                ds = cn.DevolverValor("select Total_Costo from OrdenesMedicas where Fecha_Mes = '" + ComboB_filtroMes.SelectedIndex + "'");
                foreach (DataRow fila in ds.Tables[0].Rows)
                {
                    CostoxOrden = Convert.ToDecimal(fila[0]);
                    Total = Total + CostoxOrden;
                }
                txt_TotalLista.Text = Total.ToString("N2");
            }
        }

        private void CheckB_Particulares_CheckedChanged(object sender, EventArgs e)
        {
            decimal CostoxOrden = 0;
            decimal Total = 0;

            dgv_ListaOrdenes.DataSource = null;
            dgv_DetalleOrden.DataSource = null;
            txt_TotalLista.Text = "0,00";
            txt_TotalDetalle.Text = "0,00";

            if (CheckB_Particulares.Checked == true)
            {
                ActualizarPrepaga();

                dgv_ListaOrdenes.DataSource = cn.devuelveTabla("select Cod_OrdenMedica AS 'Cod. Orden',Apellido AS 'Medico',DNI_Paciente AS 'DNI Paciente',Fecha_Hora AS 'Fecha',CONVERT (decimal(10,2), Total_Costo) AS 'Total $' from OrdenesMedicas OM,Medicos M where Cod_PrePaga IS NULL and OM.Cod_Medico = M.Cod_Medico and Fecha_Mes = '" + ComboB_filtroMes.SelectedIndex + "' order by Fecha_Hora ASC");
                dgv_ListaOrdenes.Columns[dgv_ListaOrdenes.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                if (dgv_ListaOrdenes.Rows.Count != 0)
                {
                    ds = cn.DevolverValor("select Total_Costo from OrdenesMedicas where Fecha_Mes = '" + ComboB_filtroMes.SelectedIndex + "' and Cod_PrePaga IS NULL");
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        CostoxOrden = Convert.ToDecimal(fila[0]);
                        Total = Total + CostoxOrden;
                    }
                    txt_TotalLista.Text = Total.ToString("N2");
                }
                else
                {
                    txt_TotalLista.Text = "0,00";
                }
            }
            else if (CheckB_Particulares.Checked == false)
            {
                ActualizarPrepaga();
                ComboB_PrePaga.Enabled = true;

                dgv_ListaOrdenes.DataSource = cn.devuelveTabla("select Cod_OrdenMedica AS 'Cod. Orden',Apellido AS 'Medico',DNI_Paciente AS 'DNI Paciente',Fecha_Hora AS 'Fecha',CONVERT (decimal(10,2), Total_Costo) AS 'Total $' from OrdenesMedicas OM,Medicos M where OM.Cod_Medico = M.Cod_Medico and Fecha_Mes = '" + ComboB_filtroMes.SelectedIndex + "' order by Fecha_Hora ASC");
                dgv_ListaOrdenes.Columns[dgv_ListaOrdenes.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                if (dgv_ListaOrdenes.Rows.Count != 0)
                {
                    ds = cn.DevolverValor("select Total_Costo from OrdenesMedicas where Fecha_Mes = '" + ComboB_filtroMes.SelectedIndex + "'");
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        CostoxOrden = Convert.ToDecimal(fila[0]);
                        Total = Total + CostoxOrden;
                    }
                    txt_TotalLista.Text = Total.ToString("N2");
                }
            }
            else
            {
                actualizar();
            }
        }

        private void Dgv_ListaOrdenes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            decimal CostoxEstudio = 0;
            decimal Total = 0;

            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex >= 0)
            {
                // Se toma la fila seleccionada
                DataGridViewRow row = dgv_ListaOrdenes.Rows[e.RowIndex];
                // Se selecciona la celda del checkbox
                DataGridViewCheckBoxCell cellSelecion = row.Cells["dgv_CheckBoxListOrdenes"] as DataGridViewCheckBoxCell;

                if (cellSelecion.Value == null)
                    cellSelecion.Value = false;
                switch (cellSelecion.Value.ToString())
                {
                    case "True":
                        {
                            cellSelecion.Value = false;

                            dgv_DetalleOrden.DataSource = null;
                            txt_TotalDetalle.Text = "0,00";

                            break;
                        }
                    case "False":
                        {
                            cellSelecion.Value = true;

                            //SOLO SE PUEDE SELECCIONAR UN SOLO CHECKBOX
                            foreach (DataGridViewRow row1 in dgv_ListaOrdenes.Rows)
                            {
                                if (Convert.ToBoolean(row1.Cells[0].Value) == true)
                                {
                                    row1.Cells[0].Value = false;
                                    cellSelecion.Value = true;
                                    //dgv_DetalleOrden.DataSource = null;
                                    //txt_TotalDetalle.Text = "0,00";
                                }
                            }

                            dgv_DetalleOrden.DataSource = cn.devuelveTabla("select Nro_Linea AS 'Nro. Linea',Nombre_Estudio AS 'Estudio',CONVERT (decimal(10,2), CostoxEstudio) AS 'Costo $' from Detalle_OrdenesMedicas where Cod_OrdenMedica = '" + row.Cells[1].Value.ToString() + "' order by Nro_Linea ASC");
                            dgv_DetalleOrden.Columns[dgv_DetalleOrden.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                            ds = cn.DevolverValor("select CostoxEstudio from Detalle_OrdenesMedicas where Cod_OrdenMedica = '" + row.Cells[1].Value.ToString() + "'");
                            foreach (DataRow fila in ds.Tables[0].Rows)
                            {
                                CostoxEstudio = Convert.ToDecimal(fila[0].ToString());
                                Total = Total + CostoxEstudio;
                            }
                            txt_TotalDetalle.Text = Total.ToString("N2");

                            break;
                        }
                }
            }
        }

        private void dgv_ListaOrdenes_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgv_DetalleOrden.DataSource = null;
            txt_TotalDetalle.Text = "0,00";
        }

       
    }
}