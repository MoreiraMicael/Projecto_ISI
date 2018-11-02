using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_ISI
{
    class Refeicao
    {
        public Refeicao(string restaurante, string item, string quantidade, string calorias)
        {
            this.Restaurante = restaurante;
            this.Item = item;
            this.Quantidade = quantidade;
            this.Calorias = calorias;

        }

        public string Restaurante { get; }
        public string Item { get; }
        public string Quantidade { get; }
        public string Calorias { get; }

        public override string ToString()
        {
            return Restaurante + "\t" + Item + "\t" + Quantidade + "\t" + Calorias;
        }
    }
}
