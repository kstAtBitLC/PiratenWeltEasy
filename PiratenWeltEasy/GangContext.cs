using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratenWeltEasy {
    class GangContext {
        public string Name { get; set; }
        public int Id { get; set; }
        private Random zufallsGenerator = new Random ();

        private List<Pirat> piraten = new List<Pirat>();

        public void AddPirat (Pirat p) {
            p.Gang = this;
            piraten.Add (p);    
        }

        public void AddAnotherPirat () {
            Pirat p = new Pirat () { Id=zufallsGenerator.Next (0815, 1816), Name="0815 Pirat"};
            p.Gang = this;
            piraten.Add (p);
        }

        public void ZeigtEichIHrPiraten() {
            foreach ( Pirat pirat in piraten ) {
                Console.WriteLine (pirat.Name + " " + pirat.Id + " " + pirat.Gang.Name);
            }
        }

    }
}
