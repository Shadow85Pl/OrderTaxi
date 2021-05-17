using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTaxi
{
    /// <summary>
    /// Struct for latitude storage
    /// </summary>
    class cLatitude
    {
        #region Variable declaration
        private int _X;
        #endregion
        #region Getter & Seter methods declaration
        /// <summary>
        /// X axe declaration
        /// </summary>
        public int X
        {
            get
            {
                return _X;
            }
            set
            {
                _X = value;
            }
        }
        /// <summary>
        /// Y axe declaration
        /// </summary>
        public int Y
        {
            get;set;
        }
        #endregion
        #region Constructor declaration
        /// <summary>
        /// Basic constructor. All Properties are set to default values
        /// </summary>
        public cLatitude()
        {
            X = default(int);
            Y = default(int);
        }
        /// <summary>
        /// Exended constructr. Variables are set to specific values.
        /// </summary>
        /// <param name="X">X axe value</param>
        /// <param name="Y">Y axe value</param>
        public cLatitude(int X, int Y):this()
        {
            this.X = X;
            this.Y = Y;
        }
        #endregion
        /// <summary>
        /// Override operator "-", so u can get distance beetwean two points. Returned value allways would be greater than 0.
        /// </summary>
        /// <param name="FirstLatitude">First Latitude</param>
        /// <param name="SecondLatitude">Second Latitude</param>
        /// <returns></returns>
        public static double operator -(cLatitude FirstLatitude, cLatitude SecondLatitude)
        {
            return  Math.Abs(Math.Sqrt(
                Math.Pow(SecondLatitude.X - FirstLatitude.X, 2)
                + 
                Math.Pow(SecondLatitude.Y - FirstLatitude.Y, 2)
                ));
        }
    }
}
