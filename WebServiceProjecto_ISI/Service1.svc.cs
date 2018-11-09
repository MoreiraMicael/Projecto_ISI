using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Hosting;
using System.Xml;

namespace WebServiceProjecto_ISI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private static string FILEPATH;
        public Service1()
        {
            FILEPATH = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "App_Data",
            "refeicoes.xml");
        }
        public List<Refeicao> GetRefeicoes()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(FILEPATH);
            List<Refeicao> refeicoes = new List<Refeicao>();
            XmlNodeList refeicaoNodes = doc.SelectNodes("/refeicoes/refeicao");
            foreach (XmlNode refeicaoNode in refeicaoNodes)
            {
                XmlNode restauranteNode = refeicaoNode.SelectSingleNode("restaurante");
                XmlNode itemNode = refeicaoNode.SelectSingleNode("item");
                XmlNode quantidadeNode = refeicaoNode.SelectSingleNode("quantidade");
                XmlNode caloriasNode = refeicaoNode.SelectSingleNode("calorias");

                Refeicao book = new Refeicao(
                restauranteNode.InnerText,
                itemNode.InnerText,
                quantidadeNode.InnerText,
                caloriasNode.InnerText
                );
                refeicoes.Add(book);
            }
            return refeicoes;
        }
    }
}
