// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

using ClassWork0921;
Console.WriteLine("Működik");
var osztaly = new szamologep();
var osztaly2 = new szamologep2();

while (true) { 
    Console.WriteLine("ö - összeadás / k - kivonás / o - osztás / sz - szorzás / szar - másodfokú");
    string c = Console.ReadLine();

    /*
    if (c == "ö")
        osztaly.összeg();
    else if (c == "k")
        osztaly.kivonas();
    else if (c == "sz")
        osztaly2.szorz();
    else if (c == "o")
        osztaly2.osztas();
    else if (c == "szar")
        osztaly.masodfok();
    else if (c == "ki")
        break;
    */
    switch (c)
    {
        case "ö":
            osztaly.összeg();
            break;

        case "k":
            osztaly.kivonas();
            break;

        case "sz":
            osztaly2.szorz();
            break;

        case "o":
            osztaly2.osztas();
            break;

        case "szar":
            osztaly.masodfok();
            break;

        case "ki":
            Environment.Exit(0);
            break;
    }   

    Console.WriteLine("");
}