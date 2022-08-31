using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo_NET_Framework_12
{

    public partial class frm_sistema_loja : Form
    {

        public frm_sistema_loja()
        {

            InitializeComponent();

        }

        private void frm_sistema_loja_Load(object sender, EventArgs e)
        {

            // Definindo as colunas do DataGridView:

            dgv_registros.Columns.Insert(0, new DataGridViewCheckBoxColumn());
            dgv_registros.Columns.Insert(1, new DataGridViewTextBoxColumn());
            dgv_registros.Columns.Insert(2, new DataGridViewTextBoxColumn());
            dgv_registros.Columns.Insert(2, new DataGridViewTextBoxColumn());
            dgv_registros.Columns.Insert(4, new DataGridViewTextBoxColumn());
            dgv_registros.Columns.Insert(5, new DataGridViewTextBoxColumn());
            dgv_registros.Columns.Insert(6, new DataGridViewTextBoxColumn());

            // Renomeando as colunas do DataGridView:

            dgv_registros.Columns[0].Name = "OK";
            dgv_registros.Columns[1].Name = "ID";
            dgv_registros.Columns[2].Name = "EAN";
            dgv_registros.Columns[3].Name = "Produto";
            dgv_registros.Columns[4].Name = "Valor da Compra";
            dgv_registros.Columns[5].Name = "Valor da Venda";
            dgv_registros.Columns[6].Name = "Estoque";

            // Configurando o DataGridView:

            dgv_registros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgv_registros.ReadOnly = true;

            dgv_registros.AllowUserToAddRows = false;

            dgv_registros.AllowUserToDeleteRows = false;

            dgv_registros.AllowUserToOrderColumns = true;

            // Definindo as colunas de valores:

            dgv_registros.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv_registros.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv_registros.Columns[4].DefaultCellStyle.Format = "###,###,##0.00";

            dgv_registros.Columns[5].DefaultCellStyle.Format = "###,###,##0.00";

        }

        private void btn_importar_arquivo_Click(object sender, EventArgs e)
        {

            ofd_arquivo.FileName = "";

            ofd_arquivo.ShowDialog();

        }

    }

}
