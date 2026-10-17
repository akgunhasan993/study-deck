using System;

namespace DeskProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            
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
                    
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
            
        }

        public static string Choose()
        {
            Console.WriteLine("Choose a number: ");
            Console.WriteLine("1- Add card\n2-Cards list\n0-Exit");
            string choice = Console.ReadLine();
            return choice;
        }
    }
}