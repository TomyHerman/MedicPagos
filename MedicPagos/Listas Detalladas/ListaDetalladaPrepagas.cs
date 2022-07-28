using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicPagos
{
    public partial class ListaDetalladaPrepagas : Form
    {
        Conexion cn = new Conexion();
        DataSet ds = new DataSet();
        MensajesErrores ms = new MensajesErrores();

        public ListaDetalladaPrepagas()
        {
            InitializeComponent();
        }

        public void actualizar()
        {
            ListBox_ListaPrepagasFinanz.Items.Clear();
            ListBox_ListaPrepagasFinanz.Enabled = true;

            dgv_ListaDetalle.ClearSelection();

            txt_Total.Text = "0,00";

            ds = cn.DevolverValor("Select Nombre from PrePagas");
            foreach (DataRow fila in ds.Tables[0].Rows)
                ListBox_ListaPrepagasFinanz.Items.Add(fila[0].ToString());
        }

        private void ListaDetalladaPrepagas_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void ListBox_ListaPrepagasFinanz_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CodOrden = 0;
            decimal CostoxOrden = 0;
            decimal Total = 0;

            txt_Total.Text = "0,00";

            if (ListBox_ListaPrepagasFinanz.SelectedIndex < 0)
            {
                ms.MensajeSeleccion();
            }
            else
            {
                dgv_ListaDetalle.DataSource = cn.devuelveTabla("select Cod_OrdenMedica AS 'Cod. Orden',Fecha_Hora AS 'Fecha',CONVERT (decimal(10,2), Total_Costo) AS 'Total $' from OrdenesMedicas, PrePagas where OrdenesMedicas.Cod_PrePaga = PrePagas.Cod_PrePaga and Nombre = '" + ListBox_ListaPrepagasFinanz.SelectedItem.ToString() + "' order by Fecha_Hora ASC");
                dgv_ListaDetalle.Columns[dgv_ListaDetalle.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                if (dgv_ListaDetalle.Rows.Count != 0)
                {
                    ds = cn.DevolverValor("Select Cod_OrdenMedica from OrdenesMedicas, PrePagas where OrdenesMedicas.Cod_PrePaga = PrePagas.Cod_PrePaga and Nombre = '" + ListBox_ListaPrepagasFinanz.SelectedItem.ToString() + "'");
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        CodOrden = Convert.ToInt16(fila[0]);
                        ds = cn.DevolverValor("Select CostoxEstudio from Detalle_OrdenesMedicas where Cod_OrdenMedica = '" + CodOrden + "'");
                        foreach (DataRow fila1 in ds.Tables[0].Rows)
                        {
                            CostoxOrden = Convert.ToDecimal(fila1[0]);
                            Total = Total + CostoxOrden;
                        }
                        txt_Total.Text = Total.ToString("N2");
                    }
                }
            }
        }
    }
}
