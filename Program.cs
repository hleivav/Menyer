// See https://aka.ms/new-console-template for more information

//Vid programmets start anropas funktionen "createMainMenu"
//Varje menyval anropar en funktion: "menuChoice1..2..3"
//För att validera att användaren ska enbart ange siffror anropas från olika funktioner, funktionen "checkIfNumeric".

createMainMenu();

void createMainMenu()
{
    int userInput = 10; 
    do //Använder "Do while" då menyn ska visas minst en gång. 
        //Vilkoret för att loppa menyn är att variabeln "userInput" inte blir 0.
    { 
        Console.WriteLine("Välkommen till huvudmenyn.\nNavigera i menyn genom att välja en siffra för varje funktion som önskas:\n 1- Biobesök \n 2- Loopa en text \n 3- Tredje ordet \n 0- Avsluta" );
        //string strUserInput = Console.ReadLine();


        string? strUserInput = Console.ReadLine();
        
        if (checkIfNumeric(strUserInput)) //validerar att man bara skickar siffror
        {
            userInput = int.Parse(strUserInput);
        }

        switch (userInput)
        { 
            case 0:
                System.Environment.Exit(0);
                break;  
            case 1:
                menuChoice1();
                break;
            case 2:
                menuChoice2();
                break;
            case 3:
                menuChoise3();
                break; 
                default:
                Console.WriteLine("Fel val. Försök igen. ");
                break; 
        }
    } while (userInput != 0);
}

void menuChoice1()
{
    Console.Write("Ange antal biljetter:");
    string? strNoOfTickets = Console.ReadLine();
    if (checkIfNumeric(strNoOfTickets))
    {
        int NoOfTickets = int.Parse(strNoOfTickets); //validerar att man bara skickar siffror
        int totalAmount = 0;
        int visitorAge = 0;
        for (int i = 1; i <= NoOfTickets; i++)
        {
            Console.Write("Ange åldern på besökaren: ");
            string? strVisitorAge = Console.ReadLine();
            if (checkIfNumeric(strVisitorAge))
            {
                visitorAge = int.Parse(strVisitorAge); //validerar att man bara skickar siffror
                if (visitorAge < 5 && visitorAge > 100) //Jag vet att det här är inte nästlade ifsatser, men det hade blivit en d... gegga
                {
                    totalAmount += 0;
                }
                if (visitorAge < 20 && visitorAge > 4)
                {
                    totalAmount += 80;
                }
                if (visitorAge > 21 && visitorAge < 65)
                {
                    totalAmount += 120;
                }
                if (visitorAge > 64 && visitorAge <= 100)
                {
                    totalAmount += 90;
                }
            }
            else
            {
                Console.WriteLine("Se till att du bara anger siffror här: ");
                i = 0;
            }

        }

        if (NoOfTickets < 1)
        {
            Console.WriteLine("Försök igen. ");
        }
        else
        {
            Console.WriteLine($"Kostnaden för den/de {NoOfTickets} besökare blir {totalAmount}");
        }
    }
    else
    {
        Console.WriteLine("Se till att du bara skriver siffror här. ");
    }
}



void menuChoice2()
{
    Console.WriteLine("Skriv en godtycklig text, så kommer den att upprepas tio gånger. ");
    string? userText = Console.ReadLine();
    string finalText = "";
    for (int j = 1; j <= 10; j++)
    {
        finalText += j.ToString() + " - " + userText + " ";
    }
    Console.WriteLine(finalText);
}

void menuChoise3()
{
    Console.WriteLine("Skriv en fras som består av minst tre ord och det tredje ordet kommer att skrivas ut.");
    string? userPhrase = Console.ReadLine();
    string[] words = userPhrase.Split(' ');
    int wordCounter = 0; 

    foreach (var word in words)
    {
        if (word != "")
        {
             wordCounter++;
            if (wordCounter == 3)
            {
                System.Console.WriteLine($"{word}");
            }
        }
    }
    if (wordCounter < 3)
    {
        Console.WriteLine("Försöket misslyckades. Du ska skriva minst tre ord. "); 
    }
}

bool checkIfNumeric(string strToCheck)
{
    bool isNumeric;
    int x;
    isNumeric = int.TryParse(strToCheck, out x);
    return isNumeric;
}

