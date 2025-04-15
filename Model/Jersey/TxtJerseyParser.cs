using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S0IPAF.Model.Util;

namespace S0IPAF.Model.Jersey
{
    class TxtJerseyParser : IJerseyParser
    {
        public List<Jersey> Parse(string[] lines)
        {

            List<Jersey> jerseys = new List<Jersey>();
            foreach (string line in lines)
            {
                string[] parts = line.Split(';');
                if (parts.Length != 7)
                {
                    throw new FormatException($"Invalid line format: {line}");
                }
                string teamName = parts[0];
                string playerName = parts[1];
                int playerNumber = int.Parse(parts[2]);
                string size = parts[3];
                float bulkPrice = float.Parse(parts[4]);
                float retailPrice = float.Parse(parts[5]);
                string imageName = parts[6];
                jerseys.Add(new Jersey(teamName, playerName, playerNumber, size, bulkPrice, retailPrice, imageName));

            }
            return jerseys;
        }
    }
}
