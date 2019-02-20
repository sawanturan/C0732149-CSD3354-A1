using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732149_CSD3354_A1
{
    class Program
    {
       public static void Main()
        {
            UsingRecursion.CalculateRecursively(3, 6);
        }
    }
   
class UsingRecursion
        {
            // Create an application which 
            // calculates the sum of all the numbers from n to m recursively:
           
          public static int CalculateRecursively(int n, int m)
            {
                int sum = n;

                if (n < m)
                {
                    n++;
                    return sum += CalculateRecursively(n, m);
                }
                return sum;
            }
         

        }

        class CountrySide
        {
            // Create the LinkedList to reflect the Map in the PowerPoint Instructions
            Village Maeland;
            Village Helmholtz;
            Village Alst;
            Village Wessig;
            Village Badden;
            Village Uster;
            Village Schvenig;


            class Village
            {
                public Village(string _villageName, bool _isAHere)
                {
                    isAstrildgeHere = _isAHere;
                    VillageName = _villageName;
                }

                public Village west;
                public Village east;
                public string VillageName;
                public int distanceToWestVillage;
                public int distanceToEastVillage;
                public bool isAstrildgeHere;
            }
        }
    }


