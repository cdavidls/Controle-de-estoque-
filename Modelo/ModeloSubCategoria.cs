using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloSubCategoria
    {
        public ModeloSubCategoria()//metodo construtor este nao é necessario pois a classe cria um metodo construtor se necessario, este metodo nao recebe parametos
        {
            //neste metodo ele vai so iniciar as propriedades.
            this.Catcod = 0;
            this.Scatcod = 0;
            this.ScatNome = "";
        }

        public ModeloSubCategoria(int scatcod, int catcod, String snome)//este metodo vai receber parametos.
        {
            this.Catcod = catcod;
            this.Scatcod = scatcod;
            this.ScatNome = snome;
        }

        //representa a tabela de subcategoria no banco.
        private int scat_cod;
        public int Scatcod
        {
            get { return this.scat_cod; }
            set { this.scat_cod = value; }
        }
        private int cat_cod;
        public int Catcod
        {
            get { return this.cat_cod; }
            set { this.cat_cod = value; }
        }
        private String scat_Nome;
        public String ScatNome
        {
            get { return this.scat_Nome; }
            set { this.scat_Nome = value; }
        }
    }
}
