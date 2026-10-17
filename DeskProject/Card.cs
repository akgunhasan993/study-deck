namespace DeskProject;

public class Card
{
    
    public int  BoxNumber { get; set; }  // kutu numarası
    
    public string Question { get; set; } // kart sorusu için
    
    public string Answer { get; set; } // kartın cevabı için
    
    public DateTime LastReviewedDate { get; set; } = DateTime.Now;
    
   

    public Card(int boxNumber, string question, string answer)
    {
        this.BoxNumber = boxNumber;
        this.Question = question;
        this.Answer = answer;
        
    }

    public int BoxDays(int boxNumber)
    {
        if (boxNumber == 1)
            return 1;
        else if (boxNumber == 2)
            return 2;
        else if (boxNumber == 3)
            return 4;
        else if (boxNumber == 4)
            return 7;
        else
            return 14;

    }

    
    public bool IsDue()
    {
        int passedDays = (DateTime.Now - LastReviewedDate).Days;

        if (BoxDays(BoxNumber) <= passedDays)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Review(bool knewIt)
    {
        if (knewIt)
        {
            if (BoxNumber < 5)
            {
                BoxNumber++;
            }
            
        }
        else
        {
            BoxNumber = 1;
        }
        
        LastReviewedDate = DateTime.Now;
    }
    
    
}