bool Fine = false;
while (!Fine)
{
    Console.WriteLine("Vuoi una difficoltà ( facile [f], medio [m] o difficile [d])? Oppure un tema (animali [a], città [c], oggetti [o])?");
    string risp = Console.ReadLine();

    string parola = "";
    char[] parolaI;
    int Punteggio = 0;
    bool Alastor = false;
    Random g = new Random();

    while (Alastor == false)
    {
        if (risp == "f")
        {
            string filePath = "Parole_Facili.txt";
            string[] linee = File.ReadAllLines(filePath);
            int r = g.Next(linee.Length);
            parola = linee[r];
            Alastor = true;
        }
        else if (risp == "m")
        {
            string filePath = "Parole_Medie.txt";
            string[] linee = File.ReadAllLines(filePath);
            int r = g.Next(linee.Length);
            parola = linee[r];
            Alastor = true;
        }
        else if (risp == "d")
        {
            string filePath = "Parole_Difficili.txt";
            string[] linee = File.ReadAllLines(filePath);
            int r = g.Next(linee.Length);
            parola = linee[r];
            Alastor = true;
        }
        else if (risp == "a")
        {
            string filePath = "Animali.txt";
            string[] linee = File.ReadAllLines(filePath);
            int r = g.Next(linee.Length);
            parola = linee[r];
            Alastor = true;
        }
        else if (risp == "c")
        {
            string filePath = "Città.txt";
            string[] linee = File.ReadAllLines(filePath);
            int r = g.Next(linee.Length);
            parola = linee[r];
            Alastor = true;
        }
        else if (risp == "o")
        {
            string filePath = "Oggetto.txt";
            string[] linee = File.ReadAllLines(filePath);
            int r = g.Next(linee.Length);
            parola = linee[r];
            Alastor = true;
        }
        else
        {
            Console.WriteLine("Opzione non valida.");
            Console.WriteLine("Vuoi una difficoltà ( facile [f], medio [m] o difficile [d])? Oppure un tema (animali [a], città [c], oggetti [o])?");
            risp = Console.ReadLine();
        }
    }
    // Crea un array di caratteri dove ogni carattere è un underscore
    parolaI = new string('_', parola.Length).ToCharArray();
    int tentativi = 6;
    string lettereI = "";

    Console.WriteLine("Gioco dell'impiccato:");
    Console.WriteLine("La parola da indovinare ha " + parola.Length + " lettere.");

    while (tentativi > 0)
    {
        Console.WriteLine("Parola da indovinare: " + new string(parolaI));
        Console.WriteLine("Tentativi rimasti: " + tentativi);
        Console.WriteLine("Lettere già indovinate: " + lettereI);
        Console.Write("Inserisci una lettera: ");
        char let = Console.ReadKey().KeyChar;
        Console.WriteLine();

        lettereI += let;

        bool trovata = false;

        for (int j = 0; j < parola.Length; j++)
        {
            if (parola[j] == let)
            {
                parolaI[j] = let;
                trovata = true;
                Punteggio += 1;
            }
        }

        if (!trovata)
        {
            Console.WriteLine("Lettera sbagliata!");
            tentativi--;
        }
        // Converte l'array di caratteri 'parolaI' in una stringa
        if (new string(parolaI) == parola)
        {
            Console.WriteLine("Hai indovinato la parola: " + parola);
            Console.WriteLine("Il tuo punteggio è: " + Punteggio);
            tentativi = 0;
        }

        if (tentativi == 0)
        {
            if (new string(parolaI) != parola)
            {
                Console.WriteLine("Hai esaurito i tentativi. La parola era: " + parola);
            }
            Console.WriteLine("Il tuo punteggio è: " + Punteggio);
        }
    }

    Console.WriteLine("Vuoi fermare il gioco? si (s), no (n)");
    string fine = Console.ReadLine();

    if (fine == "s")
    {
        Fine = true;
    }
}
