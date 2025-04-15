using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S0IPAF.Model.Util
{
    public interface IParser<T>
    {
        List<T> Parse(string[] lines);
    }
}
