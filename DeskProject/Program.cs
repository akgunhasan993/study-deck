using System;

namespace DeskProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card(5, "hasan", "akgun");
            card.LastReviewedDate = DateTime.Now.AddDays(-2);
            
            card.Review(true);
            Console.WriteLine(card.BoxNumber);
            Console.WriteLine(card.IsDue());
            
        }
    }
}