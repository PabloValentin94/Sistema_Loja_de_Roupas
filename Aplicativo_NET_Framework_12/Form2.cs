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

    public partial class frm_informacoes : Form
    {
        public frm_informacoes(double gastos, double lucro, double quantia_liquida)
        {

            // Inicializando o formulário.

            InitializeComponent();

            // Criando uma linha de validação.

            if(gastos != 0 && lucro != 0 && quantia_liquida != 0)
            {

                // Alterando os valores das labels.

                lbl_gastos_resultado.Text = gastos.ToString("C");

                lbl_lucro_resultado.Text = lucro.ToString("C");

                lbl_quantia_liquida_resultado.Text = quantia_liquida.ToString("C");

                // Formatando a cor da label "Quantia Líquida Resultado", com base em uma condição.

                if (gastos > lucro)
                {

                    // Se os gastos forem maiores do que o lucro, então a label ficará vermelha.

                    lbl_quantia_liquida_resultado.ForeColor = Color.Red;

                }

                else if (gastos == lucro)
                {

                    // Se os gastos forem iguais ao lucro, então a label ficará preta.

                    lbl_quantia_liquida_resultado.ForeColor = Color.Black;

                }

                else
                {

                    // Se os gastos forem menores do que o lucro, então a label ficará verde.

                    lbl_quantia_liquida_resultado.ForeColor = Color.Green;

                }

            }

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {

            // Fechando o formulário.

            this.Close();

        }

    }

}
