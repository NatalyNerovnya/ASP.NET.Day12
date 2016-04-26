using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public abstract class CheckParametrs
    {
        public void CheckRef(object obj)
        {
            if(ReferenceEquals(obj, null))
                throw new ArgumentNullException();
        }
    }
}
