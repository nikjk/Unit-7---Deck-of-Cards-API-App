using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Unit_7___Deck_of_Cards_API.Models;

namespace Unit_7___Deck_of_Cards_API.Services
{
    public class DeckService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        //public async Task<string> CreateDeckAsync()
        //{
        //    var response = await _httpClient.GetAsync("https://deckofcardsapi.com/api/deck/new/");
        //    var content = await response.Content.ReadAsStringAsync();
        //    var deck = JsonConvert.DeserializeObject<Deck>(content);

        //    return deck.DeckId;
        //}

        //public async Task<List<Card>> DrawCardsAsync(string deckId, int count)
        //{
        //    var response = await _httpClient.GetAsync($"https://deckofcardsapi.com/api/deck/{deckId}/draw/?count={count}");
        //    var content = await response.Content.ReadAsStringAsync();
        //    var deck = JsonConvert.DeserializeObject<Deck>(content);

        //    return draw.Cards;
        //}
        //public async Task<DrawResult> DrawCardsAsync(string deckId, int count)
        //{
        //    var response = await _httpClient.GetAsync($"https://deckofcardsapi.com/api/deck/{deckId}/draw/?count={count}");
        //    var content = await response.Content.ReadAsStringAsync();
        //    var drawResult = JsonConvert.DeserializeObject<DrawResult>(content);

        //    return drawResult;
        //}

        public async Task<string> CreateDeckAsync()
        {
            var response = await _httpClient.GetAsync("https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1");
            var content = await response.Content.ReadAsStringAsync();
            var deckResponse = JsonConvert.DeserializeObject<DeckResponse>(content);

            return deckResponse.DeckId;
        }

        public async Task<Deck> DrawCardsAsync(string deckId, int count)
        {
            var response = await _httpClient.GetAsync($"https://deckofcardsapi.com/api/deck/{deckId}/draw/?count={count}");
            var content = await response.Content.ReadAsStringAsync();
            var drawResponse = JsonConvert.DeserializeObject<DrawResponse>(content);

            return new Deck
            {
                DeckId = drawResponse.DeckId,
                Remaining = drawResponse.Remaining,
                Cards = drawResponse.Cards
            };
        }
    }
}