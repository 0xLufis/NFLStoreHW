using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace S0IPAF.Model.Jersey
{
    class JerseyStorageEnumerator : IEnumerator<Jersey>
    {
        private JerseyStorage storage;
        private int index;

        public JerseyStorageEnumerator(JerseyStorage storage)
        {
            this.storage = storage;
            this.index = -1;
        }

        public Jersey Current => storage.GetAll().ElementAt(index);

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            index++;
            return index < storage.GetAll().Count();
        }

        public void Reset()
        {
            index = -1;
        }
    }

}
