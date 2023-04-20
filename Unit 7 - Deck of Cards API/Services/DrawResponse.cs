using Newtonsoft.Json;
using Unit_7___Deck_of_Cards_API.Models;

namespace Unit_7___Deck_of_Cards_API.Services
{
    public class DrawResponse
    {
        [JsonProperty("deck_id")]
        public string DeckId { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }

        [JsonProperty("cards")]
        public List<Card> Cards { get; set; }
    }
}
