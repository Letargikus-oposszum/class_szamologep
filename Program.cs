using ClassWork0921;

var calculator = new Calculator();

while (true) { 
    Console.WriteLine("ö - összeadás / k - kivonás / o - osztás / sz - szorzás / szar - másodfokú");
    string operation = Console.ReadLine();

    switch (operation)
    {
        case "ö":
            calculator.Összeg();
            break;

        case "k":
            calculator.kivonas();
            break;

        case "sz":
            calculator.szorz();
            break;

        case "o":
            calculator.osztas();
            break;

        case "szar":
            calculator.masodfok();
            break;

        case "ki":
            Environment.Exit(0);
            break;
    }   

    Console.WriteLine("");
}