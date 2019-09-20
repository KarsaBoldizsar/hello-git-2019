using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGItApp {
    class Program {
        static void Main(string[] args) {

            //Console.WriteLine("My first git project!");
            //Console.WriteLine("Press ENTER to exit");

            List<int> lista = new List<int>();

            int eddig = 10;
            int legnagyobb = 0;
            int legkisebb = 999999999;

            Console.WriteLine("Kérem adja meg hány számot szeretne megadni: ");
            eddig = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < eddig; i++) {
                Console.WriteLine("Kérem adjon meg egy számot: ");
                int szam = Convert.ToInt32(Console.ReadLine());
                lista.Add(szam);
                
            }

            
            for (int i = 0; i < lista.Count; i++) {
                if (lista[i]>legnagyobb) {
                    legnagyobb = lista[i];
                }
                if (lista[i]<legkisebb) {
                    legkisebb = lista[i];
                }
            }

            

            Console.WriteLine("A legnagyobb szám a {0}", legnagyobb);
            Console.WriteLine("A legkisebb szám a {0}", legkisebb);







        }
    }
}
