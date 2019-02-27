using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C0732149_CSD3353_A1

{

class RamRamji
{
public RamRamji(string note, int dist)
{
villageName = note; distanceTraveled = dist;
HowFarToGetBack = distanceTraveled;
}
public int HowFarToGetBack = 0;
private string villageName;
private int distanceTraveled;
public int getDistanceWalked() { return distanceTraveled; }
public string getVillageName() { return villageName; }
}



class RorBahi
{
private static RamRamji RamRamji;
public static bool FoundAstrilde = false;

public static List HugiJournal = new List();

public static int CalculateDistanceWalked()
{
int DistanceWalked = 0;

foreach (var je in HugiJournal)
{
//Console.ReadLine();
Console.WriteLine(" {0} -- {1} *** --- {2} ", je.getDistanceWalked(), je.getVillageName(), je.HowFarToGetBack);
DistanceWalked += je.getDistanceWalked() + je.HowFarToGetBack;
}
return DistanceWalked;
}
}

class CountrySide
{

/* 
* 
*/
static void Main()
{
CountrySide a = new CountrySide();
a.Run();
}

// Create the LinkedList to reflect the Map in the PowerPoint Instructions
Village Maeland;
Village Helmholtz;
Village Alst;
Village Wessig;
Village Badden;
Village Uster;
Village Schvenig;

public void TraverseVillages(Village CurrentVillage)
{
if (RorBahi.FoundAstrilde) return;


RorBahi.HugiJournal.Add(new RamRamji(CurrentVillage.VillageName, CurrentVillage.distanceFromPreviousVillage));
try
{

//Console.ReadLine();
Console.WriteLine("I am in {0}", CurrentVillage.VillageName);

if (CurrentVillage.isAstrildgeHere)
{
//Console.ReadLine();
Console.WriteLine("I found Dear Astrildge in {0}", CurrentVillage.VillageName);
Console.WriteLine("******* FEELING HAPPY!!! *******");
Console.WriteLine("Astrilde, I walked {0} vika to find you. Will you marry me?", RorBahi.CalculateDistanceWalked());
RorBahi.FoundAstrilde = true;
}
TraverseVillages(CurrentVillage.west);
TraverseVillages(CurrentVillage.east);


}
catch (NullReferenceException) { }





}

public void Run()
{
Alst = new Village("Alst", false);
Schvenig = new Village("Schvenig", false);
Wessig = new Village("Wessig", false);
Maeland = new Village("Maeland", false);
Helmholtz = new Village("helmholtz", false);
Uster = new Village("Uster", false);
Badden = new Village("Badden", true);

Alst.VillageSetup(0, Schvenig, Wessig);
Schvenig.VillageSetup(14, Maeland, Helmholtz);
Maeland.VillageSetup(9, null, Helmholtz);
Helmholtz.VillageSetup(28, null, null);
Wessig.VillageSetup(19, Uster, Badden);
Uster.VillageSetup(28, null, null);
Badden.VillageSetup(11, null, null);

this.TraverseVillages(Alst);
this.Announcement();
}

public void Announcement()
{
try
{

using (StreamReader sr = new StreamReader("U:/Users/732149/announcement.txt"))
{
string line;


while ((line = sr.ReadLine()) != null)
{
Console.WriteLine(line);
}
}
}
catch (Exception e)
{
//Console.ReadLine();
Console.WriteLine("The file could not be read:");
Console.WriteLine(e.Message);
}
}
}

class Village
{


public Village(string _villageName, bool _isAHere)
{
isAstrildgeHere = _isAHere;
VillageName = _villageName;
}
public void VillageSetup(int _prevVillageDist, Village _westVillage, Village _eastVillage)
{
east = _eastVillage;
west = _westVillage;
distanceFromPreviousVillage = _prevVillageDist;
}

public Village west;
public Village east;
public string VillageName;
public int distanceFromPreviousVillage;
public bool isAstrildgeHere;
}
}