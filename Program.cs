// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

using ClassWork0921;

var osztaly = new szamologep();
var osztaly2 = new szamologep2();

while (true) { 
    Console.WriteLine("ö - összeadás / k - kivonás / o - osztás / sz - szorzás");
    string c = Console.ReadLine();

    if (c == "ö")
        osztaly.összeg();
    else if (c == "k")
        osztaly.kivonas();
    else if (c == "sz")
        osztaly2.szorz();
    else if (c == "o")
        osztaly2.osztas();
    else if (c == "ki")
        break;
    Console.WriteLine("");
}