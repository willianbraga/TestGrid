using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAPP.Entities
{
    interface IBuscador
    {
        List<string> GetResultado(string criterio);
    }
}
