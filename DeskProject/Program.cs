using System;
using System.Globalization;
using System.Text.Json;

namespace DeskProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = LoadCards();
            
            bool running = true;
            
            while (running)
            {
                string choice = Choose();
                
                switch (choice)
                {
                    case "0":
                        running = false;
                        Console.WriteLine("Exiting...");
                        break;
                    
                    case "1":
                        Console.WriteLine("Question? ");
                        string question = Console.ReadLine() ?? string.Empty;

                        Console.WriteLine("Answer? ");
                        string answer = Console.ReadLine() ?? string.Empty;

                        Card card = new Card(1, question, answer);
            
                        cards.Add(card);
                        Console.WriteLine("Card added list! ");
                        
                        SaveCards(cards);
                        LoadCards();
                        break;
                    
                    case "2":
                        if (cards.Count < 1)
                        {
                            Console.WriteLine("You don't have any cards");
                        }
                        else
                        {
                            foreach (Card c in cards)
                            {
                                Console.WriteLine(c.Question + "  =>  " + c.Answer + " Box number  =>  " +  c.BoxNumber);
                            }
                        }
                        break;
                    
                    case "3":
                        var dueCards = cards.Where(c => c.IsDue()).ToList();
                        
                        if (dueCards.Count < 1)
                        {
                            Console.WriteLine("You don't have a card to work!");
                        }
                        else
                        {
                            int correctCount = 0;
                            foreach (Card c in dueCards)
                            {
                                Console.WriteLine(c.Question);
                                Console.Write("Answer? ");
                            
                                string idea =  Console.ReadLine() ?? string.Empty;

                                if (c.Answer.Trim().ToLower() == idea.Trim().ToLower())
                                {
                                    Console.WriteLine("Correct answer,congratulations!");
                                    c.Review(true);
                                    correctCount++;
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect answer; Answer => " + c.Answer);
                                    c.Review(false);
                                }
                            }
                            Console.WriteLine("----OF THE RESULT----");
                            Console.WriteLine($"You knew {correctCount} out of {dueCards.Count} cards");
                        }
                        SaveCards(cards);
                        LoadCards();
                        break;
                    
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
            
        }

        public static string Choose()
        {
            Console.WriteLine("Choose a number: ");
            Console.WriteLine("1- Add card\n2-Cards list\n3-Study\n0-Exit");
            string choice = Console.ReadLine();
            return choice;
        }

        private const string FilePath = "cards.json";

        public static void SaveCards(List<Card> cards)
        {
            string json = JsonSerializer.Serialize(cards, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        public static List<Card> LoadCards()
        {
            if (!File.Exists(FilePath))
            {
                return new List<Card>();
            }

            string json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<Card>>(json) ?? new List<Card>();
        }
    }
}