using System;

namespace DeskProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card(3, "hasan", "akgun");
            card.LastReviewedDate = DateTime.Now.AddDays(-2);
            Console.WriteLine(card.IsDue());
        }
    }
}