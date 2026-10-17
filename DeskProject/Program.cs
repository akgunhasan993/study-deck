using System;

namespace DeskProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            
            Console.WriteLine("Question? ");
            string question = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Answer? ");
            string answer = Console.ReadLine() ?? string.Empty;

            Card card = new Card(1, question, answer);
            
            cards.Add(card);
            Console.WriteLine("Card added list! ");

            Console.WriteLine(cards.Count);
            
        }
    }
}