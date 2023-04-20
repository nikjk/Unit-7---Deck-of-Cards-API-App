using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using Unit_7___Deck_of_Cards_API.Services;

namespace Unit_7___Deck_of_Cards_API.Controllers
{
    public class HomeController : Controller
    {
        private readonly DeckService _deckService;

        public HomeController()
        {
            _deckService = new DeckService();
        }

        //public async Task<IActionResult> Index()
        //{
        //    var deckId = await _deckService.CreateDeckAsync();
        //    var cards = await _deckService.DrawCardsAsync(deckId, 5);

        //    var deck = new Deck { DeckId = deckId, Cards = cards };

        //    return View(deck);
        //}

        //public async Task<IActionResult> Index()
        //{
        //    var deckId = await _deckService.CreateDeckAsync();
        //    var drawResult = await _deckService.DrawCardsAsync(deckId, 5);

        //    return View(drawResult);
        //}

        public async Task<IActionResult> Index()
        {
            var deckId = await _deckService.CreateDeckAsync();
            var deck = await _deckService.DrawCardsAsync(deckId, 5);

            return View(deck);
        }

    }
}