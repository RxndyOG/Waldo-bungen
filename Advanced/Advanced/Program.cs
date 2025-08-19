// See https://aka.ms/new-console-template for more information


// if statement ist wie in c

using System.Reflection.Metadata.Ecma335;

bool condition = true;

if (condition)
{
    // wenn das statement stimmt
}
else if (!condition)
{
    // wenn es nicht stimt
}
else
{
    // etwas komplet anderes
}

// switch statement
// kann auch mit strings arbeiten

string? abfrage = "Hallo";
switch (abfrage)
{
    case "Hallo":
        // wenn abfrage "Hallo" ist
        break;
    case "World":
        // wenn abfrage "world" ist
        break;       // break statememt bricht das switchstatement ab
    case "Hallo2":
    // wenn es kein break gibt dann wird der code weiter ausgeführt
    // also das von null wird auch ausgeführt

    //wird ausgeführt, wenn abfrage "Hallo2" ist
    case null:
            
        // wird ebenfalls ausgeführt bei Hallo2

        break;
    default:   // wenn nichts stimmt wird das ausgeführt
        break;
}

// while loop wie in c

int i = 0;
// while loops testen zuerst die Bedingung und führen dann den Code aus
while (i < 5) // solange i kleiner als 5 ist wird es wiederholt
{
    Console.WriteLine(i);
    i++;
}         // i endet mit 4
// also i ist 0,1,2,3,4

int h = 0;
// do while loops führen zuerst den code aus und dann testen sie die Bedingung
do
{
    h++;
    Console.WriteLine(h);
    // h endet mit 5
    // also h ist 1,2,3,4,5
} while (h<5);

// for loop ist auch wie in c
for (int j = 0; j < 5; j++)
{
    Console.WriteLine(j);
} // j endet mit 4
  // also j ist 0,1,2,3,4

// foreach loop ist neu zu c# und ist gut wenn du nicht weißt wie viele items in einer array sind zb
Array testArray = new int[] { 1, 2, 3, 4, 5 };

foreach (var x in testArray)
{

    Console.WriteLine(x);
    // x ist 1,2,3,4,5
}

// wenn du aus einem loop ausbrechen willst benutzt man break und wenn du eine Iteration überspringen willst benutzt du continue
int g = 0;
while (g<10) 
{ 
    if (g == 5)
    {
        // wenn g 5 ist wird die Iteration übersprungen
        g++;
        continue; // überspringt den Rest des Codes in der Schleife und geht zur nächsten Iteration
    }
    g++;
    Console.WriteLine(g);
    if (g == 7)
    {
        break; // wenn g 7 ist wird die Schleife abgebrochen
    }
}

// alle variablen in c# auser die basics sind klassen
// c# macht eigentlich alles mit klassen

// der grund warum die instazierung oben ist und nicht unten ist weil wir es hier ohne namespace machen ansonsten muss die dekleration darüber sein
// klasse für später
Person person = new Person("Max", 25); // Instanziierung der Klasse Person

person.Vorstellung(); // Aufruf der Methode Vorstellung der Klasse Person

person.Name = "Moritz"; // Zugriff auf die Property Name der Klasse Person

person.Vorstellung();

class Person
{

    private string _name; // Private Variable für den Namen
    private int _alter; // Private Variable für das Alter

    public string Name { 
        get { return _name; } 
        set { _name = value; } 
    } // Property mit Getter und Setter

    public int Alter { get; set; } // Property mit Getter und Setter
    public Person(string name, int alter) // Konstruktor
    {
        _name = name;
        _alter = alter;
    }
    public void Vorstellung() // Methode
    {
        Console.WriteLine($"Hallo, ich bin {_name} und ich bin {_alter} Jahre alt.");
    }
}
