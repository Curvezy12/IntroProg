using Microsoft.AspNetCore.Mvc;
using BeersLib;
using System.Collections.Generic;

namespace BeersApi.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class BeersController: ControllerBase {

        Beers beers = new Beers();

        [HttpGet]
        public List<Beer> Get() {
            return beers.BeersList;
        }
        
        [HttpGet("{name}")]
        public Beer GetBeer(string name) {
            return beers.GetBeerByName;
        }
    }
}