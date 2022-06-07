class Player
{
    private string name;
    private List<Card> hand;
    public Player(string name)
    {
        this.name = name; 
        hand = new List<Card>();
    }
    public string Name
    {
        get {return name;}
    }
    public Card Draw(Deck d)
    {
        Card theCard = d.Deal();
        hand.Add(theCard);
        return theCard;
    }
    public Card Discard(int index)
    {
        Card theCard;
        if(index < hand.Count)
        {
            theCard = hand[index];
            hand.RemoveAt(index);
            return theCard;
        }
        else {return null!;}
    }
}