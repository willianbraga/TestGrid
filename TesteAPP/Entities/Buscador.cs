using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteAPP.Entities
{
    public class Buscador : IBuscador
    {
        public List<string> GetResultado(string criterio)
        {
            List<string> esportes = new List<string> { "Futebol", "Voleibol", "Basquetebol", "Natação", "Rugby", "Handebol" };
            List<string> resultado = new List<string>();
            resultado = (from esp in esportes where esp.EndsWith(criterio) select esp).ToList();
            return resultado;
        }
    }
    public class BuscadorTimes : IBuscador
    {
        public List<string> GetResultado(string criterio)
        {
            List<string> times = new List<string> { "Santos", "Palmeiras", "Vasco", "Coritiba", "Bahia" };
            List<string> resultado = new List<string>();
            resultado = (from esp in times where esp.StartsWith(criterio) select esp).ToList();
            return resultado;
        }
    }
}