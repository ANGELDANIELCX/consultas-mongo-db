using MongoDB.Driver;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/lte")]
public class LteController : Controller {

    [HttpGet("costo-menor-o-igual-50k")]
public IActionResult CostoMenorOIgual50k()
{
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lte(x => x.Costo, 50000);
    var inmuebles = collection.Find(filtro).Limit(5).ToList();
    return Ok(inmuebles);
}

[HttpGet("pisos-menor-o-igual-1")]
public IActionResult PisosMenorOIgual1()
{
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lte(x => x.Pisos, 1);
    var inmuebles = collection.Find(filtro).Limit(5).ToList();
    return Ok(inmuebles);
}

[HttpGet("construccion-menor-o-igual-150")]
public IActionResult ConstruccionMenorOIgual150()
{
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lte(x => x.MetrosConstruccion, 150);
    var inmuebles = collection.Find(filtro).Limit(5).ToList();
    return Ok(inmuebles);
}

[HttpGet("banos-menor-o-igual-1")]
public IActionResult BanosMenorOIgual1()
{
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lte(x => x.Banios, 1);
    var inmuebles = collection.Find(filtro).Limit(5).ToList();
    return Ok(inmuebles);
}

[HttpGet("terreno-menor-o-igual-300")]
public IActionResult TerrenoMenorOIgual300()
{
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Lte(x => x.MetrosTerreno, 300);
    var inmuebles = collection.Find(filtro).Limit(5).ToList();
    return Ok(inmuebles);
}

}