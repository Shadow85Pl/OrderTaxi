using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTaxi
{
    /// <summary>
    /// Person Class 
    /// </summary>
    class cOrder: ObjectWithLatitude
    {
        public cTaxi OrderedTaxi { get; set; } = null;
    }
}
