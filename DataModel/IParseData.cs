using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S0IPAF.DataModel; 

namespace S0IPAF.DataModel
{
    interface IParseData
    {
        List<Item> ParseData(string sourceDataFilePath);
    }
}
