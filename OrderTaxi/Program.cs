using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTaxi
{
    /// <summary>
    /// Main console class
    /// </summary>
    partial class Program
    {
        /// <summary>
        /// Main function. Is ivoked when process start
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                List<cTaxi> TaxiList = new List<cTaxi>();
                List<cOrder> OrderList = new List<cOrder>();
                InitializeTaxiList(TaxiList);
                do
                {
                    DisplaySystemStatus(TaxiList);
                } while (TaxiList.Where(a => a.IsFree == true).Count() > 0 &&
                     Order(TaxiList, OrderList));
            }
            catch(Exception Ex)
            {
                string ExMessage = Ex.Message;
                while(Ex.InnerException!=null)
                {
                    Ex = Ex.InnerException;
                    ExMessage += Ex.Message;
                }
                Console.WriteLine(String.Format(ExceptionFormatMessage, ExMessage));
            }
            Console.WriteLine(GoodbayMsg);
            Console.ReadLine();
        }

        /// <summary>
        /// Function of taking taxi orders
        /// </summary>
        /// <param name="TaxiList">List of all available cabs</param>
        /// <param name="OrderList">List of orders</param>
        /// <returns>True if order was made, False if user no longer wont to order taxi</returns>
        private static bool Order(List<cTaxi> TaxiList, List<cOrder> OrderList)
        {
            //Ask user if he wont to order a Taxi
            string WantToOrder=AskUser<string>(OrderAsk,a=> NoYesArr.Contains(a,StringComparer.OrdinalIgnoreCase));
            
            if (NoYesArr[Convert.ToInt16(false)].Equals(WantToOrder, StringComparison.OrdinalIgnoreCase))
                return false; //Answer was No
            else
            {
                //Answer was Yes
                //Create new Order
                cOrder NewOrder = new cOrder()
                {
                    Latitude = new cLatitude(AskUser<int>(LatitudeXAsk, IsLatitudeNumber),//Ask user X Axe latitude
                                             AskUser<int>(LatitudeYAsk, IsLatitudeNumber))//Ask user Y Axe latitude
                };
                //Calculate user distance to all taxis
                var TaxiDistance = (from taxi in TaxiList
                                    where taxi.IsFree
                                    let dist = taxi.Latitude - NewOrder.Latitude
                                    select new
                                    {
                                        Distance = dist,
                                        Taxi = taxi

                                    });
                //Pick nearest taxi
                var NearestTaxi = TaxiDistance.Where(a => a.Distance == TaxiDistance.Min(b => b.Distance)).SingleOrDefault();
                //NearestTaxi should always be diferent than null, but... 
                if (NearestTaxi != null)
                {
                    //Asign taxi reference to order
                    NewOrder.OrderedTaxi = NearestTaxi.Taxi;
                    //Set Taxi IsFree property to false
                    NearestTaxi.Taxi.IsFree = false;
                    //Add order to order list
                    OrderList.Add(NewOrder);
                    //Anounce new order :)
                    Console.WriteLine(String.Format(AnounceOrderMsg, NearestTaxi.Taxi.Latitude.X, NearestTaxi.Taxi.Latitude.Y, NearestTaxi.Distance));
                    return true;
                }else
                  return false;
            }
        }
       
    }
}
