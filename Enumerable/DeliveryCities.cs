using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable
{
    public class DeliveryCities : IEnumerable<string>
    {
        public IEnumerator<string> GetEnumerator()
        {
            yield return  "Bangalore";
            yield return  "Kolkata";
            yield return   "Mumbai";

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

       
    }
}
