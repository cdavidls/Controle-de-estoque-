using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCategoria
    {
        //Ésta classe vai ficar responsavel por interagir com a interface. Ela ira pegar os dados da interface verificar as regras de negocios e caso esteja tudo ok ela ira chamar a classe DAL e execultar as operações no banco.
        //Essa classe possuira todos os metodos existentes na classe DALCategoria pois como ela ira interagir com a tela e depois execultar os comandos no banco ela tera que ter tambem um incluir, alterar, excluir, localizar, etc. alem do construtor.

        private DALConexao conexao;
        public BLLCategoria(DALConexao cx)//metodo construtor.
        {
            this.conexao = cx;
        }
        //Agora criar os metodos da classe DAL incluir, alterar, excluir etc.
        public void Incluir(ModeloCategoria modelo)
        {
            //Essas informações são capturadas da tela e verificadas se corretas seram gravadas no banco.

            //Condição para ver se o usuario forneceu a categoria.
            if(modelo.CatNome.Trim().Length == 0)//Aqui é tirado os espaços em branco e contado quantos caracteres tem, se o numero for zero ele cai neste if.
            {
                throw new Exception("O nome da categoria é obrigatorio!");
            }
            //se não cair nesse if ele vem para cá onde vai tornar todo o texto digitado em letras maiusculas.
            modelo.CatNome = modelo.CatNome.ToUpper();

            //se passar pela verificação ele cria o objeto DALCategoria conexao que recebe a conexão que vem do dado privado la em cima, e chama o metodo incluir.
            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloCategoria modelo)
        {
            //O metodo alterar é a mesma coisa que o incluir por isso sem comentarios Aqui a diferença é que chama o metodo alterar e verfica se o codigo é igual a zero.

            //Se o codigo for menor ou igual a zero não vao ter como alterar porque ele precisa do codigo.
            if(modelo.Catcod <= 0)
            {
                throw new Exception("O código da categoria é obrigatorio!");
            }
            if (modelo.CatNome.Trim().Length == 0)
            {
                throw new Exception("O nome da categoria é obrigatorio!");
            }
            
            modelo.CatNome = modelo.CatNome.ToUpper();

            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Alterar(modelo);//Aqui chama o alterar no lugar do incluir.
        }
        public void Excluir(int codigo)
        {
            //O excluir não vai precisar de nem uma validação pois ele so vai receber o código se o codigo não existir ele nao vai excluir nada.
            DALCategoria DALobj = new DALCategoria(conexao);
            DALobj.Excluir(codigo);//Basta apenas ter o codigo e chamar o excluir. 
        }
        public DataTable Localizar(String valor)
        {
            //O localizar é a mesma coisa que o excluir basta chama-ló.
            DALCategoria DALobj = new DALCategoria(conexao);
            return DALobj.Localizar(valor);//Aqui tem que ter um return para ele retornar a tabela.
        }
        public ModeloCategoria CarregaModeloCategoria(int codigo)
        {
            //A mesma coisa que o localizar.
            DALCategoria DALobj = new DALCategoria(conexao);
            return DALobj.CarregaModeloCategoria(codigo);
        }
    }
}
