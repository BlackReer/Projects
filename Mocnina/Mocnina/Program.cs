using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocnina
{

    /*
     *	       __          __                __            
     *	  ____/ /__ _   __/ /_  ____  ____  / /__ _________
     *	 / __  / _ \ | / / __ \/ __ \/ __ \/ //_// ___/_  /
     *	/ /_/ /  __/ |/ / /_/ / /_/ / /_/ / ,< _/ /__  / /_
     *	\__,_/\___/|___/_.___/\____/\____/_/|_(_)___/ /___/
     *                                                   
     *                                                           
     *      TUTORIÁLY  <>  DISKUZE  <>  KOMUNITA  <>  SOFTWARE
     * 
     *	Tento zdrojový kód je součástí tutoriálů na programátorské 
     *	sociální síti WWW.DEVBOOK.CZ	
     *	
     *	Kód můžete upravovat jak chcete, jen zmiňte odkaz 
     *	na www.devbook.cz :-) 
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo k umocnění: ");
            int a = int.Parse(Console.ReadLine());
            int vysledek = a * a;
            Console.WriteLine("Výsledek: " + vysledek);
            Console.ReadKey();
        }
    }
}
