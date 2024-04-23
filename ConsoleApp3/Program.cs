using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Vytvoření instance WordManageru
        WordManager wordManager = new WordManager();

        // Hlavní smyčka programu
        while (true)
        {
            Console.Write("Zadejte příkaz: ");
            string command = Console.ReadLine();

            // Zpracování příkazu "Pridat"
            if (command.StartsWith("Pridat:"))
            {
                // Získání slova z příkazu
                string word = command.Substring(7);
                // Přidání slova do WordManageru
                wordManager.AddWord(word);
            }
            // Zpracování příkazu "Zpet"
            else if (command == "Zpet")
            {
                // Přesun na předchozí slovo
                wordManager.GoBack();
            }
            // Zpracování příkazu "Vpred"
            else if (command == "Vpred")
            {
                // Přesun na následující slovo
                wordManager.GoForward();
            }
            // Zpracování neznámého příkazu
            else
            {
                Console.WriteLine("Neznámý příkaz.");
            }
        }
    }
}

class WordManager
{
    // Zásobník pro ukládání slov
    private Stack<string> wordStack = new Stack<string>();
    // Index aktuálního slova
    private int currentIndex = -1;

    // Metoda pro přidání slova do zásobníku
    public void AddWord(string word)
    {
        // Přidání slova na vrchol zásobníku
        wordStack.Push(word);
        // Inkrementace indexu aktuálního slova
        currentIndex++;
        // Vypsání přidaného slova do konzole
        Console.WriteLine(word);
    }

    // Metoda pro pohyb na předchozí slovo
    public void GoBack()
    {
        // Pokud je možné jít zpět v historii
        if (currentIndex > 0)
        {
            // Dekrementace indexu aktuálního slova
            currentIndex--;
            // Vypsání předchozího slova do konzole
            Console.WriteLine(wordStack.ToArray()[currentIndex]);
        }
        // Pokud nelze jít zpět v historii
        else
        {
            // Informace o nemožnosti pohybu zpět
            Console.WriteLine("Nelze se vrátit dále zpět.");
        }
    }

    // Metoda pro pohyb na následující slovo
    public void GoForward()
    {
        // Pokud je možné jít vpřed v historii
        if (currentIndex < wordStack.Count - 1)
        {
            // Inkrementace indexu aktuálního slova
            currentIndex++;
            // Vypsání následujícího slova do konzole
            Console.WriteLine(wordStack.ToArray()[currentIndex]);
        }
        // Pokud nelze jít vpřed v historii
        else
        {
            // Informace o nemožnosti pohybu vpřed
            Console.WriteLine("Nelze jít vpřed.");
        }
    }
}