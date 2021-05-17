using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTaxi
{
    /// <summary>
    /// Base class for object that should know it latitude.
    /// </summary>
    abstract class ObjectWithLatitude
    {
        /// <summary>
        /// Object Latitude
        /// </summary>
        public cLatitude Latitude { get; set; }
        /// <summary>
        /// Basic Constructor
        /// </summary>
        public ObjectWithLatitude()
        {

        }
        /// <summary>
        /// Extended Constructor. 
        /// </summary>
        /// <param name="Latitude">Object latitude</param>
        public ObjectWithLatitude(cLatitude Latitude):this()
        {
            this.Latitude = Latitude;
        }
    }
}
