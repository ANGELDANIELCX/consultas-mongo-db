using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/eq")]
public class EqController : Controller {
    [HttpGet("listar-transaccion")]
   public IActionResult ListarTransaccion() {
MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
var db = client.GetDatabase("Inmuebles");
var collection = db.GetCollection<Inmueble>("RentasVentas");

var filtro = Builders<Inmueble>.Filter.Eq(x => x.Operacion,"Venta");
var lista = collection.Find(filtro).ToList();
return Ok(lista);
}

[HttpGet("listar-transaccion")]
   public IActionResult ListarTransaccion() {
MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
var db = client.GetDatabase("Inmuebles");
var collection = db.GetCollection<Inmueble>("RentasVentas");

var filtro = Builders<Inmueble>.Filter.Eq(x => x.Operacion,"Venta");
var lista = collection.Find(filtro).ToList();
return Ok(lista);
}

}      