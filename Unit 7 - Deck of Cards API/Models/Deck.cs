namespace Unit_7___Deck_of_Cards_API.Models
{
    public class Deck
    {
        public string DeckId { get; set; }
        public int Remaining { get; set; }
        public List<Card> Cards { get; set; }

    }
}
