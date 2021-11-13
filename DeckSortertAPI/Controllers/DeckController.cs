using DeckSortertAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DeckSortertAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeckController : ControllerBase
    {
        private ICardSortService _cardSortService;
        public DeckController(ICardSortService cardSortService)
        {
            _cardSortService = cardSortService;
        }
        // GET 
        [Route("sort")]
        [HttpPost]
        public ActionResult<IEnumerable<string>> Get([FromBody]List<string> cards)
        {
            return Ok(_cardSortService.SortCards(cards));
        }
    }
}