using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gte")]
public class GteController : Controller{

    [HttpGet("inmuebles-con-terreno-de-cien-metros-cuadrados")]
    public IActionResult InmublesConTerrenoDeCienMetrosCuadrados() {
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtroTerreno = Builders<Inmueble>.Filter.Gte(x => x.MetrosTerreno, 1000);
    var inmueblesTerreno = collection.Find(filtroTerreno).Limit(5).ToList();
    return Ok(inmueblesTerreno);

    }

 [HttpGet("inmuebles-con-costo-de-dos-millones-o-mas")]
    public IActionResult InmueblesConCostoDeDosMillonesOMas() {
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtroCosto = Builders<Inmueble>.Filter.Gte(x => x.Costo, 2000000);
var inmueblesCosto = collection.Find(filtroCosto).Limit(5).ToList();
return Ok(inmueblesCosto);

    }


     [HttpGet("inmuebles-con-tres-o-mas-pisos")]
    public IActionResult InmuebleConTresOMasPisos() {
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtroPisos = Builders<Inmueble>.Filter.Gte(x => x.Pisos, 3);
var inmueblesPisos = collection.Find(filtroPisos).Limit(5).ToList();
return Ok(inmueblesPisos);

    }


     [HttpGet("inmuebles-con-construccion-de-cuatro-cientos-metros-cuadrados")]
    public IActionResult InmublesConConstruccionDeCuatrosCientosMetrosCuadrados() {
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtroConstruccion = Builders<Inmueble>.Filter.Gte(x => x.MetrosConstruccion, 400);
var inmueblesConstruccion = collection.Find(filtroConstruccion).Limit(5).ToList();
return Ok(inmueblesConstruccion);

    }


     [HttpGet("inmuebles-con-tres-baños-o-mas")]
    public IActionResult InmueblesConTresBañosOMas() {
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtroBanos = Builders<Inmueble>.Filter.Gte(x => x.Banios, 3);
var inmueblesBanos = collection.Find(filtroBanos).Limit(5).ToList();
return Ok(inmueblesBanos);
    }

}