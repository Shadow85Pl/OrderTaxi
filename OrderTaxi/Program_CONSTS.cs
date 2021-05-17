using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTaxi
{
    /// <summary>
    /// Part of main program class, where are stored Consts. It would be easier to translate program for other languages.
    /// </summary>
    partial class Program
    {
        private const string ExceptionFormatMessage = "Wystąpił błąd\n{0}";
        private const string SystemStatusInfo = "\nW systemie znajduje się {0} taksówek\nZ tego wolnych {1}\nZajętych {2}\n";
        private const string OrderAsk = "Czy chcesz zamówić taksówkę? (T/N) ";
        private const string LatitudeXAsk = "Podaj swoją pozycję w osi X (liczba naturalna) ";
        private const string LatitudeYAsk = "Podaj swoją pozycję w osi Y (liczba naturalna) ";
        private const string GoodbayMsg = "Dziękujemy za skorzystanie z naszego systemu. Do zobaczenia.";
        private const string AnounceOrderMsg = "Najbliższa taksówka Znajduje się na pozycji X:{0} Y:{1} w odległości {2:F2}.\nTaksówka została już wysłana, prosimy o cierpliwość.";
        private static readonly string[] NoYesArr =  { "N", "T" };
    }
}
