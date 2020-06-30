using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {//Devolve a string de conexao.
        public static String StringDeConexao
        {
            get
            {
                return @"Data Source=DESKTOP-HEP16I6\SQLEXPRESS;Initial Catalog=ControleDeEstoque;Integrated Security=True";
            }
        }
    }
}
