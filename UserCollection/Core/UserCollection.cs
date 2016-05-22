using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserCollection.Core
{
    public class UserCollection: IEnumerable, IEnumerator
    {

        private int position = -1;

        private Element[] ElementsArray = null;

        public UserCollection()
        {
            ElementsArray = new Element[4];
            ElementsArray[0] = new Element("a", 1, 10);
            ElementsArray[1] = new Element("b", 2, 20);
            ElementsArray[2] = new Element("c", 3, 30);
            ElementsArray[3] = new Element("d", 4, 40);

        }

        public IEnumerator GetEnumerator()
        {
            return this as IEnumerator;
        }

        public bool MoveNext()
        {
            if (position < ElementsArray.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current { get { return ElementsArray[position]; } }
    }
}
