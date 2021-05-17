using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTaxi
{
    /// <summary>
    /// Cab Class 
    /// </summary>
    class cTaxi: ObjectWithLatitude
    {
        #region Variable declaration

        /// <summary>
        /// Is Taxi avalible to order
        /// </summary>
        public bool IsFree { get; set; } = true;
        #endregion
        #region Constructors declaration
        /// <summary>
        /// Basic Taxi constructor
        /// </summary>
        public cTaxi():base()
        {
            
        }
        /// <summary>
        /// Extended constructor
        /// </summary>
        /// <param name="Latitude">Latitude where cab is</param>
        public cTaxi(cLatitude Latitude) : base(Latitude)
        {

        }
        #endregion
    }
}
