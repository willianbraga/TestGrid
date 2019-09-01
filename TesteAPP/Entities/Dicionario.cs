using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteAPP.Entities
{
    public class Dicionario
    {
        private string criterio = null;
        IBuscador procura = null;
        public List<string> Procurar(List<string> Lista)
        {
            BuscadorFactory factory = new BuscadorFactory();
            if (criterio.EndsWith(criterio))
            {
                procura = factory.getBuscador(BuscadorFactory.ESP);
            }
            else if (criterio.StartsWith(criterio))
            {
                procura = factory.getBuscador(BuscadorFactory.TIM);
            }
            return procura.GetResultado(criterio);
        }
        public Dicionario(string _criterio)
        {
            criterio = _criterio;
        }
    }
}