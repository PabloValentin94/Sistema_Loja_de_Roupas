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
        public frm_informacoes(string gastos, string lucro, string quantia_liquida)
        {

            InitializeComponent();

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {

            this.Close();

        }

    }

}
