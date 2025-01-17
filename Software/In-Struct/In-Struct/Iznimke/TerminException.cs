using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_Struct.Iznimke
{
    public class TerminException : ApplicationException
    {
        public string Poruka { get; set; }
        public TerminException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
