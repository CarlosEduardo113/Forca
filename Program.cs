
        // Forca - Exercício 3 da Lista 2

        Console.WriteLine("\n\n\n-------------");
        Console.WriteLine("\n\n\n--- Forca ---");
        Console.WriteLine("\n\n\n-------------");


        Console.Write("\nQual a palavra secreta? ");
        string palavraSecreta = Console.ReadLine().ToLower(); 

        Console.Write("Qual a letra? ");
        char letra = Char.ToLower(Console.ReadLine()[0]); 


        bool existeNaPalavra = palavraSecreta.Contains(letra.ToString());


        Console.WriteLine($"A letra \"{letra}\" existe na palavra secreta => {existeNaPalavra}");