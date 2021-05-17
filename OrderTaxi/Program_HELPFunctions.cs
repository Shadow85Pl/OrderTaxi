using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTaxi
{
    /// <summary>
    /// Part of Main program class, with help functions
    /// </summary>
    partial class Program
    {

        /// <summary>
        /// Inityializing some Taxi data
        /// </summary>
        /// <param name="TaxiList">Reference to List<Taxi></param>
        private static void InitializeTaxiList(List<cTaxi> TaxiList)
        {
            //Basic way of initialize Taxi
            TaxiList.Add(new cTaxi(new cLatitude(3, 100)));
            //A bit difrent way, where i dont use extend constructor
            TaxiList.Add(new cTaxi()
            {
                Latitude = new cLatitude()
                {
                    X = 40,
                    Y = 3
                }
            });
            //Other initialization code
            TaxiList.Add(new cTaxi(new cLatitude(60, 80)));
            TaxiList.Add(new cTaxi(new cLatitude(0, 99)));
            TaxiList.Add(new cTaxi(new cLatitude(13, 24))
            {
                IsFree = false
            });
            TaxiList.Add(new cTaxi(new cLatitude(8, 21)));
            TaxiList.Add(new cTaxi(new cLatitude(3, 87)));
            TaxiList.Add(new cTaxi(new cLatitude(28, 28)));
        }
        /// <summary>
        /// Help function, to display system status.
        /// </summary>
        /// <param name="TaxiList">Taxi list</param>
        private static void DisplaySystemStatus(List<cTaxi> TaxiList)
        {
            Console.WriteLine(String.Format(SystemStatusInfo,
                TaxiList.Count(),
                TaxiList.Where(a => a.IsFree).Count(),
                TaxiList.Where(a => !a.IsFree).Count()
                ));
        }
        /// <summary>
        /// Function to ask questions. If answer is wrong type, it ask question one more time till it gets valid answer.  
        /// </summary>
        /// <typeparam name="T">Function return typer</typeparam>
        /// <param name="Question">Question to ask</param>
        /// <param name="AcceptableAnswer">Function checking is answer valid</param>
        /// <returns></returns>
        private static T AskUser<T>(string Question, Predicate<string> AcceptableAnswer)
        {
            String Answer;
            do
            {
                Console.Write(Question);
                Answer = Console.ReadLine();
                Answer = Answer.Trim();
            }
            while (!AcceptableAnswer(Answer));
            return (T)Convert.ChangeType(Answer, typeof(T));
        }
        /// <summary>
        /// Check if given string could be parsed as latitude (It must be an integer greater than 0).
        /// </summary>
        /// <param name="LatiutudePretender">String to parse as latitude</param>
        /// <returns>Logic value. True - given string can be parsed as latitude parameter, False - given string cannot be parsed as latitude parameter</returns>
        private static bool IsLatitudeNumber(string LatiutudePretender)
        {
            int res;
            return Int32.TryParse(LatiutudePretender, out res) && res >= 0;
        }
    }
}
