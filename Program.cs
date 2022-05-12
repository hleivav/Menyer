// See https://aka.ms/new-console-template for more information

createMainMenu();

void createMainMenu()
{
    int userImput; 
    do 
    { 
        Console.WriteLine("Välkommen till huvudmenyn.\nNavigera i menyn genom att välja en siffra för varje funktion som önskas:\n 1- Biobesök \n 2- Loopa en text \n 3- Tredje ordet \n 0- Avsluta" );
         userImput = int.Parse(Console.ReadLine());

        switch (userImput)
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
                Console.WriteLine("Försök igen"); //ifall man skriver annat än de val som finns i menyn.
                break; 
        }
    } while (userImput != 0);
}

void menuChoise3()
{
    Console.WriteLine("Skriv en fras som består av minst tre ord och det tredje ordet kommer att skrivas ut.");
    string userPhrase = Console.ReadLine();
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
}

void menuChoice2()
{
    Console.WriteLine("Skriv en godtycklig text, så kommer den att upprepas tio gånger. ");
    string userText = Console.ReadLine();
    string finalText = ""; 
    for(int j = 1; j <= 10; j++)
    {
        finalText += userText;
    }
    Console.WriteLine(finalText);
}

void menuChoice1()
{
    Console.Write("Ange antal biljetter:");
    int NoOfTickets = int.Parse(Console.ReadLine()); //validera att man bara skickar siffror
    int totalAmount = 0;
    int visitorAge = 0; 
    for (int i = 1;i <= NoOfTickets; i++)
    {
        Console.Write("Ange åldern på besökaren: ");
        visitorAge = int.Parse(Console.ReadLine()); //validera att man bara skickar siffror
        if (visitorAge < 5 && visitorAge > 100)
        {
            totalAmount += 0; 
        }
        if (visitorAge < 20 && visitorAge > 4)
        {
            totalAmount += 80; 
        }
        if (visitorAge > 21 && visitorAge < 63)
        {
            totalAmount += 120;
        }
        if (visitorAge > 64 && visitorAge <= 100)
        {
            totalAmount += 90; 
        }
    }
    
    if (NoOfTickets < 1)
    {
        Console.WriteLine("Försök igen. ");
    }else
    {
        Console.WriteLine($"Kostnaden för den/de {NoOfTickets} besökare blir {totalAmount}");
    }
    
}