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
    public partial class frmConsultaSubCategoria : Form
    {
        public int codigo = 0;
        public frmConsultaSubCategoria()
        {
            InitializeComponent();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLSubCategoria bll = new BLLSubCategoria(cx);
            DgvDados.DataSource = bll.Localizar(txtValor.Text);
        }

        private void frmConsultaSubCategoria_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
            DgvDados.Columns[0].HeaderText = "Código da Subcategoria";
            DgvDados.Columns[0].Width = 200;
            DgvDados.Columns[1].HeaderText = "SubCategoria";
            DgvDados.Columns[1].Width = 200;
            DgvDados.Columns[2].HeaderText = "Código da Categoria";
            DgvDados.Columns[2].Width = 150;
            DgvDados.Columns[3].HeaderText = "Nome da Categoria";
            DgvDados.Columns[3].Width = 200;
        }

        private void DgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(DgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
