using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratenWeltEasy {
    class Program {
        static void Main ( string [] args ) {
            Pirat p1 = new Pirat () { Id = 4711, Name = "Sebi Blaubart" };
            //Console.WriteLine (p1.Name + " " + p1.Id);
            GangContext gc1 = new GangContext () { Id=1,Name="Wolf Gang"};

            gc1.AddPirat (p1);
            gc1.AddAnotherPirat ();
            gc1.AddAnotherPirat ();

            gc1.ZeigtEichIHrPiraten ();

            GangContext gc2 = new GangContext () { Id = 2, Name = "Ab Gang" };
            for ( int i = 0 ; i < 15 ; i++ ) {
                gc2.AddAnotherPirat ();
            }

            gc2.ZeigtEichIHrPiraten ();

            Console.ReadLine ();
        }
    }
}
