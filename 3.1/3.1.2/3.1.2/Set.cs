using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _3._1._2
{
    public class Set : ArrayList
    {
        public override int Add(object value)
        {
            if (base.Contains(value))
                return 0;
            else
                return base.Add(value);
        }
    }
}
