using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCategoria
    {//Classe que vai representar a tabela categoria no banco.

        public ModeloCategoria()
        {
            this.Catcod = 0;
            this.CatNome = "";
        }

        public ModeloCategoria(int catcod, String nome)
        {
            this.Catcod = catcod;
            this.CatNome = nome;
        }

        private int cat_cod;
        public int Catcod
        {
            get { return this.cat_cod; }
            set { this.cat_cod = value; }
        }
        private String cat_Nome;
        public String CatNome
        {
            get { return this.cat_Nome; }
            set { this.cat_Nome = value; }
        }
    }
}
