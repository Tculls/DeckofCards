public class Card
{
    public string Name;
    public string Suit;
    public int Value;

    public Card(string s, int val)
    {
        switch (val)
        {
            case 11:
                Name= "Jack";
                break;
            case 12:
                Name="queen";
                break;
            case 13:
                Name = "king";
                break;
            case 1:
                Name = "ace";
                break;
            default:
                Name = val.ToString();
                break;
        }
        Suit = s;
        Value = val;
    }
}