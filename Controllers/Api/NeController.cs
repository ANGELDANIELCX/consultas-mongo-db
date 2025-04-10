using MongoDB.Driver;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/ne")]
public class NeeController : Controller {
[HttpGet("operacion-no-venta")]
public IActionResult InmueblesOperacionNoVenta()
{
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Ne(x => x.Operacion, "Venta");
    var inmuebles = collection.Find(filtro).Limit(5).ToList();
    return Ok(inmuebles);
}

[HttpGet("no-terrenos")]
public IActionResult InmueblesNoTerrenos()
{
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Ne(x => x.Tipo, "Terreno");
    var inmuebles = collection.Find(filtro).Limit(5).ToList();
    return Ok(inmuebles);
}

[HttpGet("agencia-no-perez")]
public IActionResult InmueblesAgenciaNoPerez()
{
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Ne(x => x.Agencia, "Inmobiliaria Pérez");
    var inmuebles = collection.Find(filtro).Limit(5).ToList();
    return Ok(inmuebles);
}

[HttpGet("agente-no-carlos-garcia")]
public IActionResult InmueblesAgenteNoCarlosGarcia()
{
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Ne(x => x.NombreAgente, "Carlos García");
    var inmuebles = collection.Find(filtro).Limit(5).ToList();
    return Ok(inmuebles);
}

[HttpGet("costo-no-500k")]
public IActionResult InmueblesCostoNo500k()
{
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Ne(x => x.Costo, 500000);
    var inmuebles = collection.Find(filtro).Limit(5).ToList();
    return Ok(inmuebles);
}



}