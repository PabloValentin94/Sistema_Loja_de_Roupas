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

        double gastos = 0;

        double lucro = 0;

        double quantia_liquida = 0;

        public frm_sistema_loja_de_roupas()
        {

            // Inicializando o formulário.

            InitializeComponent();

            // Zerando o valor do NumericUpDown "Percentual".

            nup_percentual.Value = 0;

            // Desabilitando componentes desnecessários, em um primeiro momento.

            btn_legenda.Enabled = false;

            btn_marcar_todos.Enabled = false;

            btn_desmarcar_todos.Enabled = false;

            btn_informacoes.Enabled = false;

            btn_aplicar_percentual.Enabled = false;

            nup_percentual.Enabled = false;

            btn_excluir_itens_selecionados.Enabled = false;

        }

        private void frm_sistema_loja_Load(object sender, EventArgs e)
        {

            // Definindo as colunas do DataGridView.

            dgv_registros.Columns.Insert(0, new DataGridViewCheckBoxColumn());
            dgv_registros.Columns.Insert(1, new DataGridViewTextBoxColumn());
            dgv_registros.Columns.Insert(2, new DataGridViewTextBoxColumn());
            dgv_registros.Columns.Insert(2, new DataGridViewTextBoxColumn());
            dgv_registros.Columns.Insert(4, new DataGridViewTextBoxColumn());
            dgv_registros.Columns.Insert(5, new DataGridViewTextBoxColumn());
            dgv_registros.Columns.Insert(6, new DataGridViewTextBoxColumn());

            // Renomeando as colunas do DataGridView.

            dgv_registros.Columns[0].Name = "OK";
            dgv_registros.Columns[1].Name = "ID";
            dgv_registros.Columns[2].Name = "EAN";
            dgv_registros.Columns[3].Name = "Produto";
            dgv_registros.Columns[4].Name = "Valor de Compra";
            dgv_registros.Columns[5].Name = "Valor de Venda";
            dgv_registros.Columns[6].Name = "Estoque";

            // Configurando o DataGridView.

            dgv_registros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgv_registros.ReadOnly = true;

            dgv_registros.AllowUserToAddRows = false;

            dgv_registros.AllowUserToDeleteRows = false;

            dgv_registros.AllowUserToOrderColumns = true;

            // Configurando as colunas de valores monetários.

            dgv_registros.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv_registros.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv_registros.Columns[4].DefaultCellStyle.Format = "###,###,##0.00";

            dgv_registros.Columns[5].DefaultCellStyle.Format = "###,###,##0.00";

        }

        private void btn_importar_arquivo_Click(object sender, EventArgs e)
        {

            dgv_registros.RowCount = 0;

            /* Zerando as variáveis globais (isso garante que,caso o usuário abra outro arquivo, os antigos valores dessas variáveis serão
             * descartados e substituidos pelos novos valores a serem calculados. */

            gastos = 0;

            lucro = 0;

            quantia_liquida = 0;

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

                    /* Camisa. vestimenta social que possui gola e botões.
                     * Camiseta. diferente da camisa não é considerada uma vestimenta social, mas sim,
                     * tradicional.
                     * Blusa. vestimenta usada em clima ameno, serve mais para estilo social
                     * do que para aquecer.
                     * Casaco. vestimenta usada para aquecer.
                     * Jaqueta. é basicamente igual ao casaco, mas, geralmente é utilizada de forma que a parte
                     * frontal fique aberta. */

                }

                // A condição só será verdadeira, se o número de linhas do DataGridView for maior que 0.

                if(dgv_registros.RowCount > 0)
                {

                    // Vasculhando as linhas do DataGridView.

                    foreach(DataGridViewRow linha_dgv in dgv_registros.Rows)
                    {

                        double preco_compra = Convert.ToDouble(linha_dgv.Cells[4].Value);

                        double preco_venda = Convert.ToDouble(linha_dgv.Cells[5].Value);

                        // Definindo que a cor da fonte deve ser branca.

                        linha_dgv.DefaultCellStyle.ForeColor = Color.White;

                        if(preco_compra > preco_venda)
                        {

                            // Definindo que a cor de fundo, da linha, deve ser vermelha.

                            linha_dgv.DefaultCellStyle.BackColor = Color.DarkRed;

                        }

                        else if(preco_compra == preco_venda)
                        {

                            // Definindo que a cor de fundo, da linha, deve ser cinza.

                            linha_dgv.DefaultCellStyle.BackColor = Color.DimGray;

                        }

                        else
                        {

                            // Definindo que a cor de fundo, da linha, deve ser verde.

                            linha_dgv.DefaultCellStyle.BackColor = Color.DarkGreen;

                        }

                        /* Vermelho. Se o valor de compra for maior que o valor de venda.
                         * Cinza. Se o valor de compra for igual ao valor de venda.
                         * Verde.Se o valor de compra for menor que o valor de venda. */

                        // Calculando o gasto total.

                        gastos += preco_compra;

                        // Calculando o lucro bruto.

                        lucro += preco_venda;

                        linha_dgv.Cells[0].Value = false;

                    }

                    // Calculando o lucro líquido.

                    quantia_liquida = lucro - gastos;

                    // Reabilitando os botões necessários.

                    btn_legenda.Enabled = true;

                    btn_marcar_todos.Enabled = true;

                    btn_desmarcar_todos.Enabled = true;

                    btn_informacoes.Enabled = true;

                    btn_excluir_itens_selecionados.Enabled = true;

                }

            }

        }

        private void btn_legenda_Click(object sender, EventArgs e)
        {

            // Acionando o formulário de legenda.

            new frm_legenda().Show();

        }

        private void btn_marcar_todos_Click(object sender, EventArgs e)
        {

            // A condição só será verdadeira, se o número de linhas do DataGridView for maior que 0.

            if(dgv_registros.RowCount > 0)
            {

                // Vasculhando as linhas do DataGridView.

                foreach(DataGridViewRow linha in dgv_registros.Rows)
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

                foreach(DataGridViewRow linha in dgv_registros.Rows)
                {

                    // Definindo que o valor da célula, da primeira coluna, é igual a false (desmarcado).

                    linha.Cells[0].Value = false;

                }

            }

        }

        private void btn_aplicar_percentual_Click(object sender, EventArgs e)
        {

            /* O componente já defini o mínimo e o máximo por padrão, mas não é muito confiável, por isso, foi criada
             * esta condição, que serve como uma segunda linha de validação.
             * Se a condição for verdadeira, o sistema fará o processo especificado abaixo, senão, retornará
             * uma mensagem de erro para o usuário, como é mostrado mais adiante. */

            /* Observação importante: após fazer alguns testes, percebeu-se que os valores de mínimo e máximo do NumericUpDown "Porcentagem"
             * não devem ser usados em uma estrutura de decisão que envolva dados do sistema. Eles só devem servir como "chão" e "teto".
             * Por esse exato motivo que o primeiro valor da estrutura é maior do que o mínimo (maior do que 0) e o segundo, menor ou igual
             * ao máximo menos um (101 - 1 = 100), ou seja, o máximo só serviu de base para a condição, mas não é usado diretamente.
             * Erro encontrado: o valor do NumericUpDown não atendia a condição da estrutura, mas mesmo assim o sistema prosseguia. */

            if(nup_percentual.Value > nup_percentual.Minimum && nup_percentual.Value <= (nup_percentual.Maximum - 1))
            {

                // Calculando o valor a ser adicionado na célula.

                double valor_adicionado = Convert.ToDouble(dgv_registros.CurrentCell.Value) * (Convert.ToDouble(nup_percentual.Value) / 100);

                /* Calculando o novo valor da célula que será alterada (valor atual +
                 * [valor atual * [valor do NumericUpDown "Percentual" / 100]]). */

                double valor_venda_atualizado = Convert.ToDouble(dgv_registros.CurrentCell.Value) + valor_adicionado;

                // Alterando o valor da célula.

                dgv_registros.CurrentCell.Value = valor_venda_atualizado;

                // Recalculando lucro bruto.

                lucro += valor_adicionado;

                // Recalculando lucro líquido.

                quantia_liquida = lucro - gastos;

                // Zerando o valor do NumericUpDown "Percentual".

                nup_percentual.Value = 0;

                // Desabilitando os componentes.

                btn_aplicar_percentual.Enabled = false;

                nup_percentual.Enabled = false;

                // Acionando uma mensagem de sucesso na tela do usuário.

                MessageBox.Show("Valor alterado com sucesso.", "Aviso!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            // O mínimo é usado, mas a estrutura não possui nenhum dado do sistema, apenas uma mensagem de aviso para o usuário.

            else if(nup_percentual.Value == 0)
            {

                // Acionando uma mensagem de aviso na tela do usuário.

                MessageBox.Show("Percentual igual a 0! Valor não alterado.", "Aviso!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            else
            {

                // Zerando o valor do NumericUpDown "Percentual".

                nup_percentual.Value = 0;

                // Acionando uma mensagem de erro na tela do usuário.

                MessageBox.Show("Insira um valor de percentual válido.", "Atenção!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btn_excluir_itens_selecionados_Click(object sender, EventArgs e)
        {

            // A condição só será verdadeira, se o número de linhas do DataGridView for maior que 0.

            if(dgv_registros.RowCount > 0)
            {

                // Vasculhando as linhas do DataGridView.

                for(int i = dgv_registros.RowCount - 1; i >= 0; i--)
                {

                    // Se a CheckBox da linha estiver marcada, então a condição será verdadeira.

                    if (Convert.ToBoolean(dgv_registros.Rows[i].Cells[0].Value) == true)
                    {

                        // Recalculando os gastos.

                        gastos -= Convert.ToDouble(dgv_registros.Rows[i].Cells[4].Value);

                        // Recalculando o lucro bruto.

                        lucro -= Convert.ToDouble(dgv_registros.Rows[i].Cells[5].Value);

                        // Excluindo a linha atual do DataGridView.

                        dgv_registros.Rows.RemoveAt(dgv_registros.Rows[i].Index);

                    }

                }

                // Recalculando o lucro líquido.

                quantia_liquida = lucro - gastos;

                MessageBox.Show("Item(ns) excluído(s) com sucesso.", "Aviso!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void btn_informacoes_Click(object sender, EventArgs e)
        {

            // Acionando o formulário de informações.

            new frm_informacoes(gastos, lucro, quantia_liquida).Show();

        }

        private void dgv_registros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // A condição só será verdadeira, se o número de linhas do DataGridView for maior que 0.

            if(dgv_registros.RowCount > 0)
            {

                /* A seguir especificamos que, a condição só será verdadeira, se a célula clicada
                 * pertencer a primeira coluna, ou seja, a coluna CheckBox. */

                if(dgv_registros.CurrentCell.ColumnIndex == 0)
                {

                    /* Definindo que, se a célula CheckBox estiver desmarcada, ela deverá ser marcada. */

                    if(Convert.ToBoolean(dgv_registros.CurrentCell.Value) == false)
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

        // Método que será acionado quando o usuário digitar no NumericUpDown "Percentual".

        private void nup_percentual_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Impedindo que o usuário pressione algo além de teclas numéricas, teclas de controle e vírgulas.

            if(e.KeyChar == char.Parse(",") || char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {

                // Desativando a digitação.

                e.Handled = false;

            }

            else
            {

                // Reativando a digitação.

                e.Handled = true;

            }

        }

        // Método que será acionado quando o usuário clicar no DataGridView.

        private void dgv_registros_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // A condição só será verdadeira, se o número de linhas do DataGridView for maior que 0.

            if(dgv_registros.RowCount > 0)
            {

                /* Se a celula clicada pertencer a coluna "Valor de Venda", então o botão "Aplicar Percentual" e o
                 * NumericUpDown "Percentual" serão reativados. */

                if(dgv_registros.CurrentCell.ColumnIndex == 5)
                {

                    // Reativando componentes.

                    btn_aplicar_percentual.Enabled = true;

                    nup_percentual.Enabled = true;

                }

                /* Se a celula clicada não pertencer a coluna "Valor de Venda", então o botão "Aplicar Percentual" e o
                 * NumericUpDown "Percentual" serão desativados. */

                else
                {

                    // Desativando componentes.

                    btn_aplicar_percentual.Enabled = false;

                    nup_percentual.Enabled = false;

                }

            }

        }

    }

}
