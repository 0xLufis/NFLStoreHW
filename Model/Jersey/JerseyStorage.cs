using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace S0IPAF.Model.Jersey
{
    class JerseyStorage : IEnumerable<Jersey>
    {
        public List<Jersey> jerseys;
        public JerseyStorage()
        {
            jerseys = new List<Jersey>();
        }
        public void Add(Jersey jersey)
        {
            jerseys.Add(jersey);
        }
        public void Remove(Jersey jersey)
        {
            jerseys.Remove(jersey);
        }
        public IEnumerable<Jersey> GetAll()
        {
            return jerseys;
        }

        public void AddRange(IEnumerable<Jersey> newItems)
        {
            jerseys.AddRange(newItems);
        }

        public IEnumerator<Jersey> GetEnumerator()
        {
            return new JerseyStorageEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void ForEach(Action<Jersey> action)
        {
            foreach (var jersey in jerseys)
            {
                action(jersey);
            }
        }
        public void ForEach(IEnumerable<Jersey> jerseys, Action<Jersey> action)
        {
            foreach (var jersey in jerseys)
            {
                action(jersey);
            }
        }

        public Jersey GetByID(int id) 
        {
            foreach (var jersey in jerseys)
            {
                if (id == jersey.ID)
                {
                    return jersey;
                }
            }
            return null;
        }

    }

}
