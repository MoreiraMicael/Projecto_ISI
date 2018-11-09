using System.Collections.Generic;
using System.IO;
using System.Web.Hosting;
using System.Xml;

namespace WebServiceProjecto_ISI
{
    public class Service1 : IService1
    {
        private static string FILEPATH;

        public Service1()
        {
            FILEPATH = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "App_Data", "calorias_restaurante_1.txt");
        }

        public List<Refeicao> GetRefeicoes()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(FILEPATH);
            List<Refeicao> Refeicoes = new List<Refeicao>();
            XmlNodeList RefeicaoNodes = xmlDoc.SelectNodes("/Refeicoes/Refeicao");
            foreach (XmlNode RefeicaoNode in RefeicaoNodes)
            {
                XmlNode RestauranteNode = RefeicaoNode.SelectSingleNode("Restaurante");
                XmlNode ItemNode = RefeicaoNode.SelectSingleNode("Item");
                XmlNode QuantidadeNode = RefeicaoNode.SelectSingleNode("Quantidade");
                XmlNode CaloriasNode = RefeicaoNode.SelectSingleNode("Calorias");

                Refeicao book = new Refeicao(RestauranteNode.InnerText, ItemNode.InnerText, QuantidadeNode.InnerText, CaloriasNode.InnerText);
                Refeicoes.Add(book);
            }
            return Refeicoes;
        }
    }
}