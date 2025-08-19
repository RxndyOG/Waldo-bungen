// See https://aka.ms/new-console-template for more information

// Variablen


using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;

bool isTrue = true;

        int number = 42;
        long bigNumber = 1234567890L; // L am Ende für long
        float pi = 3.14f;
        double euler = 2.71828;

        char letter = 'A';
        string greeting = "Hello, World!";

        var dynamicVariable = "I can change type"; // die variable erkennt automatiscvh den Typ und kann später geändert werden also zb zu einem int, hat keine nullable variante

        // die Oben angegebenen Variablen sind unterstrichen weil sie
        //    theoretisch NULL sein könnten, wenn man will das sie genau null sind gibt man ein ? dazu
        //      
        // ist egal in meisten fällen aber ist wichtig bei WPF also beim projekt für ObvservableCollection (Observable Collection ist basically eine Array aber die weiß wenn sie sich verändert)

        bool? isTrueNullable = null; // Nullable bool

        int? nullableNumber = null; // Nullable int
        long? nullableBigNumber = null; // Nullable long
        float? nullablePi = null; // Nullable float
        double? nullableEuler = null; // Nullable double

        char? nullableLetter = null; // Nullable char
        string? nullableGreeting = null; // Nullable string

        // wenn man eine Int zu einemstring machen möchte oder einen float zu string geht das mit casting

        int numberToString = 123;
        float floatToint = 3.14f;

        int floatInt = (int)floatToint; // Casting float to int
                                        // oder
        int floatInt2 = Convert.ToInt32(floatToint); // besser aber ist hier nicht notwendig

        string numberAsString = numberToString.ToString(); // Int to String
                                                           // oder
        string numberAsString2 = Convert.ToString(numberToString); // das selbe nur schaut besser aus

        // andere möglichkeiten sind

        //  Convert.ToString(myInt))
        //  Convert.ToDouble(myInt))
        //  Convert.ToInt32(myDouble))
        //  Convert.ToString(myBool)
        // etc...

        // User input:
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine() ?? "Guest"; // ^wenn nichts eingegeben wird, wird "Guest" verwendet
                                            // !!! ReadLine() gibt immer einen String zurück !!! muss für zahlen convertiert werden
        Console.WriteLine($"Hello, {userName}!"); // String Interpolation

// Operatoren
// Adition 
int sum = number + 10;
        // Subtraktion
        int difference = number - 10;
        // Multiplikation
        float product = number * 2;
        // Division
        float quotient = (float)number / 2; // Casting für float Division
                                            // Modulo 
        int remainder = number % 10;

        // Vergleichsoperatoren
        bool isEqual = number == 42; // Gleich
        bool isNotEqual = number != 42; // Ungleich
        bool isGreater = number > 40; // Größer als
        bool isLess = number < 50; // Kleiner als
        bool isGreaterOrEqual = number >= 42; // Größer oder gleich
        bool isLessOrEqual = number <= 42; // Kleiner oder gleich
                                           // Logische Operatoren
        bool andCondition = isTrue && (number > 40); // UND
        bool orCondition = isTrue || (number < 40); // ODER
        bool notCondition = !isTrue; // NICHT
                                     // weitere Operatoren
                                     // Inkrement ++
                                     // Dekrement --
                                     // oder 
                                     // +=, -=, *=, /=, %=
                                     // etc..


        // ausgabe

        Console.WriteLine("Variable ausgabe:" + sum);
        Console.WriteLine(difference);
        Console.WriteLine("addition:" + (2 + 5));

        Console.Write("Hello");
        Console.WriteLine(", World!"); //ausgabe mit Zeilenumbruch

// arrays funktionieren wie in c++
// also du kannst sie normal erstellen oder mit einem datentyp

int[] numbersArray = new int[5] {1,2,3,4,5}; // Array mit 5 Elementen
//oder
Array stringArray = new string[] { "Hello", "World" }; // Array mit Strings

// auf elemente kannst du zugreifen wie in c

Console.WriteLine(numbersArray[0]); // Zugriff auf das erste Element
// oder
Console.WriteLine(stringArray.GetValue(0)); // Zugriff auf das erste Element in einem Array

// wenn du daten reinschreiben möchtest kannst du das so machen
numbersArray[0] = 10; // Setze das erste Element auf 10
// oder
stringArray.SetValue("New Value", 0); // Setze das erste Element auf "New Value"
//ist wieder das selbe wie in c++

// wenn du die länge des arrays wissen möchtest kannst du das so machen
Console.WriteLine("Array length: " + numbersArray.Length); // Gibt die Länge des Arrays aus

// wenn du es sortieren muss
Array.Sort(numbersArray); // Sortiert das Array in aufsteigender Reihenfolge

// 2d arrays sind auch möglich
int[,] twoDArray = new int[2, 3] // 2 Zeilen und 3 Spalten
{
    { 1, 2, 3 },
    { 4, 5, 6 }
};

// andere datenstructurensidn zb
// List<> ist ein vector in c++
// Dictionary<> ist ein map in c++
// HashSet<> ist ein set in c++
// Stack<> ist ein stack in c++
// Queue<> ist ein queue in c++
// Tuple<> ist ein tuple in python
// ObservableCollection<> ist eine spezielle Collection für WPF und MVVM Pattern





