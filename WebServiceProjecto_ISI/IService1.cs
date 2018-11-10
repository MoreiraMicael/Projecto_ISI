using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebServiceProjecto_ISI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/Refeicoes")]
        [Description("Gets all the Refeicoes.")]
        List<Refeicao> GetRefeicoes();
    }

    [DataContract]
    public class Refeicao
    {

        public Refeicao(string Restaurante, string Item, string Quantidade, string Calorias)
        {
            this.Restaurante = Restaurante;
            this.Item = Item;
            this.Quantidade = Quantidade;
            this.Calorias = Calorias;
        }

        [DataMember]
        public string Restaurante { get; set; }
        [DataMember]
        public string Item { get; set; }
        [DataMember]
        public string Quantidade { get; set; }
        [DataMember]
        public string Calorias { get; set; }

        public override string ToString()
        {
            string Refeicao = string.Empty;
            Refeicao += "Restaurante: " + Restaurante + Environment.NewLine;
            Refeicao += "Item: " + Item + Environment.NewLine;
            Refeicao += "Quantidade: " + Quantidade + Environment.NewLine;
            Refeicao += "Calorias: " + Calorias + Environment.NewLine;
            return Refeicao;
        }
    }

}
