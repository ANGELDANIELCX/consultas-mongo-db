using MongoDB.Driver;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/nin")]
public class NinController : Controller {

[HttpGet("costo-no-500k-1m-2m")]
public IActionResult InmueblesCostoNo500k1m2m()
{
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Nin(x => x.Costo, new[] { 500000, 1000000, 2000000 });
    var inmuebles = collection.Find(filtro).Limit(5).ToList();
    return Ok(inmuebles);
}

[HttpGet("renta-no-firmado-enproceso")]
public IActionResult InmueblesRentaNoFirmadoEnProceso()
{
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.And( Builders<Inmueble>.Filter.Eq(x => x.Operacion, "Renta"));
    var inmuebles = collection.Find(filtro).ToList();
    return Ok(inmuebles);
}

[HttpGet("no-casas-ni-departamentos")]
public IActionResult InmueblesNoCasasNiDepartamentos()
{
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Nin(x => x.Tipo, new[] { "Casa", "Terreno" });
    var inmuebles = collection.Find(filtro).Limit(5).ToList();
    return Ok(inmuebles);
}

[HttpGet("no-disponible-ni-reservado")]
public IActionResult InmueblesNoDisponibleNiReservado()
{
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Nin(x => x.Operacion, new[] { "Venta", "Renta" });
    var inmuebles = collection.Find(filtro).Limit(5).ToList();
    return Ok(inmuebles);
}

[HttpGet("no-cdmx-ni-monterrey")]
public IActionResult InmueblesNoCdmxNiMonterrey()
{
    MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
    var db = client.GetDatabase("Inmuebles");
    var collection = db.GetCollection<Inmueble>("RentasVentas");

    var filtro = Builders<Inmueble>.Filter.Nin(x => x.Costo, new[] { 500000, 1000000, 2000000});
    var inmuebles = collection.Find(filtro).Limit(5).ToList();
    return Ok(inmuebles);
}


}
