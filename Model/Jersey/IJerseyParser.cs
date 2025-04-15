using S0IPAF.Model.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S0IPAF.Model.Jersey
{
    internal interface IJerseyParser : IParser<Jersey>
    {
       new List<Jersey> Parse(string[] lines); 
    }
}
