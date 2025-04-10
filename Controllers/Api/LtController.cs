using MongoDB.Driver;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/lt")]
public class LtController : Controller {

    [HttpGet("terreno-menos-500")]
    public IActionResult TerrenoMenosDe500(){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection =db.GetCollection<Inmueble>("RentasVentas");

           var filtro = Builders<Inmueble>.Filter.Lt(x => x.MetrosTerreno, 500);
    var inmuebles = collection.Find(filtro).Limit(5).ToList();
    return Ok(inmuebles);
    }

[HttpGet("costo-menos-100k")]
public IActionResult CostoMenorA100k()
    {
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection =db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lt(x => x.Costo, 100000);
    var inmuebles = collection.Find(filtro).Limit(5).ToList();
    return Ok(inmuebles);
    }

[HttpGet("pisos-menos-2")]
public IActionResult PisosMenosDe2()
    {
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection =db.GetCollection<Inmueble>("RentasVentas");

         var filtro = Builders<Inmueble>.Filter.Lt(x => x.Pisos, 2);
    var inmuebles = collection.Find(filtro).Limit(5).ToList();
    return Ok(inmuebles);

    }

[HttpGet("construccion-menos-200")]
public IActionResult ConstruccionMenosDe200()
    {
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection =db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lt(x => x.MetrosConstruccion, 200);
    var inmuebles = collection.Find(filtro).Limit(5).ToList();
    return Ok(inmuebles);
    }
[HttpGet("banos-menos-2")]
public IActionResult BanosMenosDe2()
    {
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection =db.GetCollection<Inmueble>("RentasVentas");

 var filtro = Builders<Inmueble>.Filter.Lt(x => x.Banios, 2);
    var inmuebles = collection.Find(filtro).Limit(5).ToList();
    return Ok(inmuebles);
    }
    
}
