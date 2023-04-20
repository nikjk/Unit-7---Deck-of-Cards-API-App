using Newtonsoft.Json;

namespace Unit_7___Deck_of_Cards_API.Models
{
    public class DeckResponse
    {
        [JsonProperty("deck_id")]
        public string DeckId { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }
    }
}
