//OK Lui demander des actions en boucle 
//Changer la couleur de fond
//Changer la couleur de police
//Faire un beep

//Ce tableau contient toutes les couleurs possible de la console
using System.Security.Cryptography;

ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

Console.WriteLine("Bienvenue dans cette application de test de la classe console ! ");


bool closeApp = false;

while (!closeApp)
{
    Console.WriteLine("Que voulez-vous faire ?");
    Console.WriteLine("1 - Changer la couleur de police");
    Console.WriteLine("2 - Changer la couleur de fond");
    Console.WriteLine("3 - Faire un beep");
    Console.WriteLine("4 - Joue une musique");

    var reponse = Console.ReadLine();
    

    if(reponse == "1")
    {
        var choiceColor = GetChoiceColorUser();
        //Change la couleur de police
        Console.ForegroundColor = choiceColor;
    }
    else if(reponse == "2")
    {
        //Change la couleur de fond de police
        var choiceColor = GetChoiceColorUser();
        Console.BackgroundColor = choiceColor;
    }
    else if(reponse == "3")
    {
        Console.Beep();
    }
    else if (reponse == "4")
    {
        StarWarsMusic();
    }
    else
    {
            Console.WriteLine("Ce choix n'existe pas");
    }

    Console.Write("Voulez-vous continuer ? (O/N) : ");
    string continueAnswer = Console.ReadLine();
    if (continueAnswer == "N" || continueAnswer == "n")
    {
        closeApp= true;
    }
}

//Application se ferme

//Retourner l'index de la couleur voulu par rapport au tableau colors
ConsoleColor GetChoiceColorUser()
{
    Console.WriteLine("Quelle couleur voulez-vous choisir ?");

    for (int i = 0; i < colors.Length; i++)
    {
        Console.WriteLine(i + " - " + colors[i]);
    }

    Console.Write("Votre choix :");
    string indexChoisi = Console.ReadLine();
    int indexChoisiInt = Convert.ToInt32(indexChoisi);
    return colors[indexChoisiInt];
}


void StarWarsMusic()
{
    

    int c = 261;
    int d = 294;
    int e = 329;
    int f = 349;
    int g = 391;
    int gS = 415;
    int a = 440;
    int aS = 455;
    int b = 466;
    int cH = 523;
    int cSH = 554;
    int dH = 587;
    int dSH = 622;
    int eH = 659;
    int fH = 698;
    int fSH = 740;
    int gH = 784;
    int gSH = 830;
    int aH = 880;
    Console.Beep(a, 500);

    Console.Beep(a, 500);

    Console.Beep(a, 500);

    Console.Beep(f, 350);

    Console.Beep(cH, 150);

    centeredOutput("                    ███████╗████████╗ █████╗ ██████╗     ██╗    ██╗ █████╗ ██████╗ ███████");
    

    Console.Beep(a, 500);

    Console.Beep(f, 350);

    Console.Beep(cH, 150);

    Console.Beep(a, 1000);

    //first bit



    Console.Beep(eH, 500);

    Console.Beep(eH, 500);

    Console.Beep(eH, 500);

    Console.Beep(fH, 350);

    Console.Beep(cH, 150);

    centeredOutput("                    ██╔════╝╚══██╔══╝██╔══██╗██╔══██╗    ██║    ██║██╔══██╗██╔══██╗██╔════╝");
    

    Console.Beep(gS, 500);

    Console.Beep(f, 350);

    Console.Beep(cH, 150);

    Console.Beep(a, 1000);

    //second bit...



    Console.Beep(aH, 500);

    Console.Beep(a, 350);

    Console.Beep(a, 150);

    Console.Beep(aH, 500);

    Console.Beep(gSH, 250);

    Console.Beep(gH, 250);

    centeredOutput("                    ███████╗   ██║   ███████║██████╔╝    ██║ █╗ ██║███████║██████╔╝███████╗");
    

    Console.Beep(fSH, 125);

    Console.Beep(fH, 125);

    Console.Beep(fSH, 250);

    Task.Delay(250);

    Console.Beep(aS, 250);

    Console.Beep(dSH, 500);

    Console.Beep(dH, 250);

    Console.Beep(cSH, 250);

    //start of the interesting bit



    Console.Beep(cH, 125);

    Console.Beep(b, 125);

    Console.Beep(cH, 250);

    Task.Delay(250);
    centeredOutput("                    ╚════██║   ██║   ██╔══██║██╔══██╗    ██║███╗██║██╔══██║██╔══██╗╚════██║");
    

    Console.Beep(f, 125);

    Console.Beep(gS, 500);

    Console.Beep(f, 375);

    Console.Beep(a, 125);



    Console.Beep(cH, 500);

    Console.Beep(a, 375);

    Console.Beep(cH, 125);

    Console.Beep(eH, 1000);

    //more interesting stuff (this doesn't quite get it right somehow)



    Console.Beep(aH, 500);

    Console.Beep(a, 350);

    Console.Beep(a, 150);

    Console.Beep(aH, 500);

    Console.Beep(gSH, 250);

    Console.Beep(gH, 250);



    Console.Beep(fSH, 125);

    Console.Beep(fH, 125);

    Console.Beep(fSH, 250);

    Task.Delay(250);
    centeredOutput("                    ███████║   ██║   ██║  ██║██║  ██║    ╚███╔███╔╝██║  ██║██║  ██║███████║");
   

    Console.Beep(aS, 250);

    Console.Beep(dSH, 500);

    Console.Beep(dH, 250);

    Console.Beep(cSH, 250);

    //repeat... repeat



    Console.Beep(cH, 125);

    Console.Beep(b, 125);

    Console.Beep(cH, 250);

    Task.Delay(250);
    centeredOutput("                    ╚══════╝   ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝     ╚══╝╚══╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝");
    Console.Beep(f, 250);

    Console.Beep(gS, 500);

    Console.Beep(f, 375);

    Console.Beep(cH, 125);



    Console.Beep(a, 500);

    Console.Beep(f, 375);

    Console.Beep(c, 125);

    Console.Beep(a, 1000);

}




void centeredOutput(string input)
{
    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (input.Length / 2)) + "}", input));
}