//OK Lui demander des actions en boucle 
//Changer la couleur de fond
//Changer la couleur de police
//Faire un beep

//Ce tableau contient toutes les couleurs possible de la console
using System.Security.Cryptography;

ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
Dictionary<string, int> octave = new Dictionary<string, int>()
    {
        {"A", 196},//sol
        {"Z", 220},//la
        {"E", 246},//si
        {"R", 261},//do
        {"T", 293},//re
        {"Y", 329},//mi
        {"U", 349},//fa
        {"I", 392},//sol
        {"O", 440 },//la
        {"P", 493} //si
    };


Console.WriteLine("Bienvenue dans cette application de test de la classe console ! ");


bool closeApp = false;

while (!closeApp)
{
    Console.WriteLine("Que voulez-vous faire ?");
    Console.WriteLine("1 - Changer la couleur de police");
    Console.WriteLine("2 - Changer la couleur de fond");
    Console.WriteLine("3 - Faire un beep");
    Console.WriteLine("4 - Joue une musique");
    Console.WriteLine("5 - Piano");
    Console.WriteLine("6 - Play music from string");
    //Au clair de la lune : rrrtytryttr    rrrtytryttr    ttttzz   treza   rrrtytryttr

    var reponse = Console.ReadLine();

    switch (reponse)
    {
        case "1" :
            var choiceColor = GetChoiceColorUser();
            //Change la couleur de police
            Console.ForegroundColor = choiceColor;
            break;
        case "2":
            //Change la couleur de fond de police
            var choiceColorTwo = GetChoiceColorUser();
            Console.BackgroundColor = choiceColorTwo;
            break;
        case "3":
            Console.Beep();
            break;
        case "4":
            StarWarsMusic();
            break;
        case "5":
            Console.WriteLine("Voici votre piano");
            Piano();
            break;
        case "6":
            Console.WriteLine("Entrez votre chaîne de caractères");
            string chaineAJouer = Console.ReadLine();
            PlayStringPiano(chaineAJouer);
            break;
        default:
            Console.WriteLine("Ce choix n'existe pas");
            break;
    }

    Console.Write("Voulez-vous continuer ? (O/N) : ");
    string continueAnswer = Console.ReadLine();
    if (continueAnswer == "N" || continueAnswer == "n")
    {
        closeApp= true;
    }
}

void PlayStringPiano(string chaineAJouer)
{
    //Récupérer chaque caractères de ma chaîne

    foreach (var lettre in chaineAJouer)
    {
        //Récupérer le consoleKey depuis un char
        if (lettre == ' ')
        {
            Thread.Sleep(200);
        }
        else
        {
            int frequence = octave[lettre.ToString().ToUpper()];
            Console.Beep(frequence, 200);
        }
    }
}


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

void Piano()
{
    bool continuePiano = true;

    Console.WriteLine("Vous pouvez utiliser les touches azertyuiop pour jouer de votre octave favorite");
    Console.WriteLine("Tapez sur la touche Esc pour quitter");
    while (continuePiano)
    {
        var noteUser = Console.ReadKey();
        var noteLettre = noteUser.Key.ToString();
        
        if(noteUser.Key == ConsoleKey.Escape)
        {
            continuePiano = false;
        }
        
        if (octave.ContainsKey(noteLettre))
        {
            Console.Beep(octave[noteLettre], 200);
        }
    }
    Console.WriteLine("");
}


void centeredOutput(string input)
{
    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (input.Length / 2)) + "}", input));
}
