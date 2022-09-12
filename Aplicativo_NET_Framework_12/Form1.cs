using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO; // Biblioteca que permite manipular arquivos do dispositivo.

namespace Aplicativo_NET_Framework_12
{

    public partial class frm_sistema_loja_de_roupas : Form
    {

        public frm_sistema_loja_de_roupas()
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

            // Configurando as colunas de valores monetários:

            dgv_registros.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv_registros.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv_registros.Columns[4].DefaultCellStyle.Format = "###,###,##0.00";

            dgv_registros.Columns[5].DefaultCellStyle.Format = "###,###,##0.00";

        }

        private void btn_importar_arquivo_Click(object sender, EventArgs e)
        {

            dgv_registros.RowCount = 0;

            /* O motivo de declararmos que o nome do arquivo é igual a "em branco" é porquê,
             * senão fizermos isso, quando o explorador de arquivos for acionado, o nome
             * que virá por padrão será o name do componente OpenFileDialog. Para evitar isso,
             * declaramos que o nome do arquivo é igual a "em branco". */

            ofd_arquivo.FileName = "";

            // Acionando o Explorador de Arquivos.

            ofd_arquivo.ShowDialog();

            if(ofd_arquivo.FileName != "")
            {

                /* A variável "arquivo" serve para armazenar todo o conteúdo contido dentro do
                 * arquivo escolhido pelo usuário. */

                StreamReader arquivo = File.OpenText(ofd_arquivo.FileName);

                /* A variável "linha_arquivo" serve para ler cada linha, do arquivo escolhido, uma a uma,
                 * e então fazer o tratamento ordenado dentro da estrutura de repetição abaixo. */

                String linha_arquivo;

                while ((linha_arquivo = arquivo.ReadLine()) != null)
                {

                    /* Usamos a propriedade Split para fazer uma separação. No exemplo
                     * adiante estamos dizendo que uma linha deverá ser lida e para cada ";" deverá ocorrer
                     * uma sepação do texto. Em seguida definimos que cada separação refere-se a um campo do
                     * DataGridView e então o adicionamos nele. */

                    string[] campos = linha_arquivo.Split('/');

                    string id = campos[0];

                    string ean = campos[1];

                    string produto = campos[2];

                    double valor_compra = double.Parse(campos[3]);

                    double valor_venda = double.Parse(campos[4]);

                    string estoque = campos[5];

                    // Adicionando uma nova linha ao DataGridView.

                    /* Não é utilizado o método ".ToString("C")" para formatar os valores monetários,
                     * pois isso ocasionaria um erro na hora de formatarmos esses valores para double,
                     * devido ao fato de que ao usarmos esse método, são adicionados cifrões aos valores,
                     * que não serão interpretados na hora da conversão, gerando um erro quase impossível
                     * de se encontrar. */

                    dgv_registros.Rows.Add(false, id, ean, produto, valor_compra, valor_venda, estoque);

                    /* Camisa: vestimenta social que possui gola e botões.
                     * Camiseta: diferente da camisa não é considerada uma vestimenta social, mas sim,
                     * tradicional.
                     * Blusa: vestimenta usada em clima ameno, serve mais para estilo social
                     * do que para aquecer.
                     * Casaco: vestimenta usada para aquecer.
                     * Jaqueta: é basicamente igual ao casaco, mas, geralmente é utilizada de forma que a parte
                     * frontal fique aberta. */

                }

                // A condição só será verdadeira, se o número de linhas do DataGridView for maior que 0.

                if (dgv_registros.RowCount > 0)
                {

                    // Vasculhando as linhas do DataGridView.

                    foreach(DataGridViewRow linha_dgv in dgv_registros.Rows)
                    {

                        // Definindo que a cor da fonte deve ser branca.

                        linha_dgv.DefaultCellStyle.ForeColor = Color.White;

                        if (Convert.ToDouble(linha_dgv.Cells[4].Value) > Convert.ToDouble(linha_dgv.Cells[5].Value))
                        {

                            // Definindo que a cor de fundo, da linha, deve ser vermelha.

                            linha_dgv.DefaultCellStyle.BackColor = Color.DarkRed;

                        }

                        else if(Convert.ToDouble(linha_dgv.Cells[4].Value) == Convert.ToDouble(linha_dgv.Cells[5].Value))
                        {

                            // Definindo que a cor de fundo, da linha, deve ser cinza.

                            linha_dgv.DefaultCellStyle.BackColor = Color.DimGray;

                        }

                        else
                        {

                            // Definindo que a cor de fundo, da linha, deve ser verde.

                            linha_dgv.DefaultCellStyle.BackColor = Color.DarkGreen;

                        }

                        /* Vermelho: Se o valor de compra for maior que o valor de venda.
                         * Cinza: Se o valor de compra for igual ao valor de venda.
                         * Verde:Se o valor de compra for menor que o valor de venda. */

                    }

                }

            }

        }

        private void btn_marcar_todos_Click(object sender, EventArgs e)
        {

            // A condição só será verdadeira, se o número de linhas do DataGridView for maior que 0.

            if (dgv_registros.RowCount > 0)
            {

                // Vasculhando as linhas do DataGridView.

                foreach (DataGridViewRow linha in dgv_registros.Rows)
                {

                    // Definindo que o valor da célula, da primeira coluna, é igual a true (marcado).

                    linha.Cells[0].Value = true;

                }

            }

        }

        private void btn_desmarcar_todos_Click(object sender, EventArgs e)
        {

            // A condição só será verdadeira, se o número de linhas do DataGridView for maior que 0.

            if(dgv_registros.RowCount > 0)
            {

                // Vasculhando as linhas do DataGridView.

                foreach (DataGridViewRow linha in dgv_registros.Rows)
                {

                    // Definindo que o valor da célula, da primeira coluna, é igual a false (desmarcado).

                    linha.Cells[0].Value = false;

                }

            }

        }

        private void btn_aplicar_percentual_Click(object sender, EventArgs e)
        {



        }

        private void btn_excluir_itens_selecionados_Click(object sender, EventArgs e)
        {



        }

        private void btn_informacoes_Click(object sender, EventArgs e)
        {



        }

        private void dgv_registros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // A condição só será verdadeira, se o número de linhas do DataGridView for maior que 0.

            if (dgv_registros.RowCount > 0)
            {

                /* A seguir especificamos que, a condição só será verdadeira, se a célula clicada
                 * pertencer a primeira coluna, ou seja, a coluna CheckBox. */

                if (dgv_registros.CurrentCell.ColumnIndex.Equals(0))
                {

                    /* Definindo que, se a célula CheckBox estiver desmarcada, ela deverá ser marcada. */

                    if (dgv_registros.CurrentCell.Value.Equals(false))
                    {

                        dgv_registros.CurrentCell.Value = true;

                    }

                    /* Definindo que, se a célula CheckBox não estiver desmarcada, ela deverá ser
                     * desmarcada. */

                    else
                    {

                        dgv_registros.CurrentCell.Value = false;

                    }

                }

            }

        }

        private void nup_percentual_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Impedindo que o usuário pressione algo além de teclas numéricas, teclas de controle e vírgulas.

            if(e.KeyChar.Equals(char.Parse(",")) || char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {

                e.Handled = false;

            }

            else
            {

                e.Handled = true;

            }

        }

    }

}
