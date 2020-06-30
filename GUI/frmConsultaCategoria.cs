using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaCategoria : Form
    {
        public int codigo = 0;
        public frmConsultaCategoria()
        {
            InitializeComponent();
        }
        private void btLocalizar_Click(object sender, EventArgs e)
        {
            //botao loccalizar busca no banco as informaçoes e coloca no grid.
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);
            DgvDados.DataSource = bll.Localizar(txtValor.Text);
        }

        private void frmConsultaCategoria_Load(object sender, EventArgs e)
        {
            //para carregar as informaçoes no grid quando o formulario for aberto.
            btLocalizar_Click(sender, e);

            //mudar no grid o cat_cod e cat_nome.
            DgvDados.Columns[0].HeaderText = "Código"; //muda o nome da celula cat_cod.
            DgvDados.Columns[0].Width = 60; //muda o tamanho da celula do codigo.
            DgvDados.Columns[1].HeaderText = "Categoria";
            DgvDados.Columns[1].Width = 650;
        }

        private void DgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //para pegar o codigo da linha que for clicada 2 vezes e fechar o formulario.
            if(e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(DgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
