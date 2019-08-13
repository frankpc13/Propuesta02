using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Propuesta2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["frank"].ConnectionString);

        public void getClientList()
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter("Usp_lista_cliente", connection))
            {
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataSet dataSet = new DataSet())
                {
                    adapter.Fill(dataSet, "Clientes");
                    comboBoxClient.ValueMember = "idCliente";
                    comboBoxClient.DisplayMember = "NombreCompañia";
                    comboBoxClient.DataSource = dataSet.Tables["Clientes"];
                }
            }
        }
        public void FilterOrderByClient(String code)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter("Usp_lista_pedidos_por_cliente2", connection))
            {
                adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                adapter.SelectCommand.Parameters.AddWithValue("@idCliente", code);
                using (DataSet dataSet = new DataSet())
                {
                    adapter.Fill(dataSet, "Pedidos");
                    dataGridPedido.DataSource = dataSet.Tables["Pedidos"];
                    labelTotalPedidos.Text = dataSet.Tables["Pedidos"].Rows.Count.ToString();
                }
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getClientList();
        }

        private void ButtonCheck_Click(object sender, EventArgs e)
        {
            String id = comboBoxClient.SelectedValue.ToString();
            FilterOrderByClient(id);
        }
    }
}
