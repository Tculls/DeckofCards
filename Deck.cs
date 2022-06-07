public class Deck
{
    public List<Card> cards = new List<Card>();
    public Deck()
    {
        Reset();
    }
    public List<Card> Reset()
    {
        cards.Clear();
        string[] suits = 
        {
            "Heart",
            "spades",
            "clubs",
            "Diamonds"
        };
        foreach(string suit in suits)
        {
            for (int i = 1; i <14; i ++)
            {
                cards.Add(new Card(suit, i));
            }
        }
        return cards;
    }
    public Card Deal()
    {
        Card cardDealt = cards[0];
        cards.RemoveAt(0);
        return cardDealt;
    }
    public void Shuffle()
    {
        List<Card> unshuffled = this.cards;
        List<Card> shuffled = new List<Card>();
        Random rand = new Random();
        while(unshuffled.Count > 0)
        {
            int index = rand.Next(0, unshuffled.Count);
            shuffled.Add(unshuffled[index]);
            unshuffled.RemoveAt(index);
        }
        this.cards = shuffled;
    }
}